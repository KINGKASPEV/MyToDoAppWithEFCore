using MyToDoApp.Data.Repositories.Interfaces;
using MyToDoApp.Model;
using System.Windows.Forms;

namespace MyToDoApp
{
    public partial class Form1 : Form
    {
        private readonly IToDoRepository _repository;
        public Form1(IToDoRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadTodoItems();
            timer1.Start();
        }
        private async Task LoadTodoItems(List<MyToDoItems> todoItems = null)
        {
            try
            {
                dataGridView1.Rows.Clear();

                if (todoItems == null)
                {
                    todoItems = await _repository.GetAllTodoItemsAsync();
                }
                todoItems.Reverse();
                foreach (var item in todoItems)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Task });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Description });

                    string formattedDueDate = item.CreatedAt.ToString("MM/dd/yyyy HH:mm:ss");
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = formattedDueDate });

                    string formattedUpdatedAt = item.UpdatedAt.ToString("MM/dd/yyyy HH:mm:ss");
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = formattedUpdatedAt });

                    row.Tag = item.Id;
                    dataGridView1.Rows.Insert(0, row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading todo items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected task?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        var itemId = (int)dataGridView1.SelectedRows[0].Tag;
                        await _repository.DeleteTodoAsync(itemId);
                    }
                    await LoadTodoItems();
                    MessageBox.Show("Task deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting todo item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox2.Text))
                {
                    MessageBox.Show("Task and Description fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newTodo = new MyToDoItems
                {
                    Task = textBox1.Text,
                    Description = richTextBox2.Text,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    IsCompleted = false
                };
                var sortedTodoItems = await _repository.AddTodoAsync(newTodo);
                textBox1.Clear();
                richTextBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
                await LoadTodoItems(sortedTodoItems);
                MessageBox.Show("Task added successfully");
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = ex.InnerException != null ? ex.InnerException.Message : "";
                MessageBox.Show($"Error saving todo item: {ex.Message}\nInner Exception: {innerExceptionMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void DeleteAllbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete all selected task?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var todoItems = await _repository.GetAllTodoItemsAsync();
                    foreach (var item in todoItems)
                    {
                        await _repository.DeleteTodoAsync(item.Id);
                    }
                }
                await LoadTodoItems();
                MessageBox.Show("All selected Task deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting all todo items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox2.Text))
                {
                    MessageBox.Show("Task and Description fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var itemId = (int)dataGridView1.SelectedRows[0].Tag;
                    var todoToUpdate = await _repository.GetTodoItemByIdAsync(itemId);

                    if (todoToUpdate != null)
                    {
                        todoToUpdate.Task = textBox1.Text;
                        todoToUpdate.Description = richTextBox2.Text;
                        todoToUpdate.UpdatedAt = DateTime.Now;

                        await _repository.EditTodoAsync(todoToUpdate);

                        textBox1.Clear();
                        richTextBox2.Clear();
                        dateTimePicker1.Value = DateTime.Now;

                        await LoadTodoItems();
                        MessageBox.Show("Task updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("The selected ToDo item does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating todo item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Editbutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var itemId = (int)dataGridView1.SelectedRows[0].Tag;
                    var todoToEdit = await _repository.GetTodoItemByIdAsync(itemId);

                    textBox1.Text = todoToEdit.Task;
                    richTextBox2.Text = todoToEdit.Description;
                    dateTimePicker1.Value = todoToEdit.CreatedAt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing todo item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var searchQuery = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    var searchResults = await _repository.SearchTodoItemsAsync(searchQuery);
                    await LoadTodoItems(searchResults);
                }
                else
                {
                    await LoadTodoItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for todo items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                var searchQuery = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(searchQuery))
                {
                    await LoadTodoItems();
                }
                else
                {
                    var searchResults = await _repository.SearchTodoItemsAsync(searchQuery);
                    await LoadTodoItems(searchResults);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for todo items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Mytimer_Tick_1(object sender, EventArgs e)
        {
            int currentX = label1.Location.X;
            currentX -= 6;
            if (currentX + label1.Width < 0)
            {
                currentX = this.Width;
            }
            label1.Location = new Point(currentX, label1.Location.Y);
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IsCompleted.Index && e.RowIndex == 0)
            {
                var itemId = (int)dataGridView1.Rows[e.RowIndex].Tag;
                await _repository.MarkCompleteAsync(itemId);
                await LoadTodoItems();
            }
        }

    }
}

using GridPrintPreviewLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursach_1.ExtensionsMethods;

namespace kursach_1
{
    public partial class MainForm : Form
    {

        const string _path = @"C:\Users\igor_2\Desktop\уЧеба_3курс\бд\харош.gif";
        public MainForm()
        {
            InitializeComponent();
            this.Hide();

            AuthForm authForm = new AuthForm();
            bool successFill = false;
            while (!successFill)
            {

                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    successFill = true;
                }
                else if (authForm.DialogResult != DialogResult.Retry)
                {
                    
                    Environment.Exit(0);
                    break;  
                }
            }

            FillComboboxes();
            MakeDisabledGroupBoxes();
            toolStripButtonCancelEditingShopsName.Enabled = false;
            toolStripButtonCancelGenres.Enabled = false;
        }
        private void SetPermissions()
        {
            DBHelper.CheckPermissions();

            if (!DBHelper.IsCurrentUserAdmin)
            {
                MakeUsersRestriction();
            }
            else
            {
                MakeAdminPermission();
            }
            FillTables();
        }
        private void author_bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.author_bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.publishing_houseDataSet);
        }
        private void MakeDisabledGroupBoxes()
        {
            groupBoxEditAuthorBook.Enabled = false;
            groupBoxEditAuthor.Enabled = false;
            groupBoxEditBook.Enabled = false;
            groupBoxEditDesigner.Enabled = false;
            groupBoxEditEditors.Enabled = false;
            groupBoxEditShops.Enabled = false;
            groupBoxEditShops_Books.Enabled = false;
        }
        private void FillTables()
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.publishing_houseDataSet.genres);//

            this.shops_nameTableAdapter.Fill(this.publishing_houseDataSet.shops_name);//
            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.shops". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.editors". При необходимости она может быть перемещена или удалена.
            this.editorsTableAdapter.Fill(this.publishing_houseDataSet.editors);//

            this.designersTableAdapter.Fill(this.publishing_houseDataSet.designers);//
            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.shops_name". При необходимости она может быть перемещена или удалена.

            this.authorsTableAdapter.Fill(this.publishing_houseDataSet.authors);//

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.shops". При необходимости она может быть перемещена или удалена.
            this.shopsTableAdapter.Fill(this.publishing_houseDataSet.shops);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.shops_books". При необходимости она может быть перемещена или удалена.
            this.shops_booksTableAdapter.Fill(this.publishing_houseDataSet.shops_books);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.publishing_houseDataSet.books);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.author_book". При необходимости она может быть перемещена или удалена.
            this.author_bookTableAdapter.Fill(this.publishing_houseDataSet.author_book);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.ShopsBooksNamed". При необходимости она может быть перемещена или удалена.
            this.shopsBooksNamedTableAdapter.Fill(this.publishing_houseDataSet.ShopsBooksNamed);

            if (DBHelper.IsCurrentUserAdmin)
            {
                this.logTableTableAdapter.Fill(this.publishing_houseDataSet.LogTable);
                this.booksLogTableTableAdapter.Fill(this.publishing_houseDataSet.booksLogTable);
            }
            else
            {
                toolStripButtonEditAuthorBook.Enabled = false;
            }
        }

        private void FillComboboxes()
        {
            //1 таблица
            for (int i = 1; i < author_bookDataGridView.Columns.Count; i++)
            {
                comboBoxCriterionAuthorBook.Items.Add(author_bookDataGridView.Columns[i].HeaderText);
            }
            //2 таблица
            for (int i = 1; i < authorsDataGridView.Columns.Count; i++)
            {
                comboBoxCriterionAuthor.Items.Add(authorsDataGridView.Columns[i].HeaderText);
                DBHelper.ColumnsNameAuthorsDictionary.Add(i - 1, publishing_houseDataSet.authors.Columns[i].ColumnName);
            }
            for (int i = 1; i < booksDataGridView.Columns.Count; i++)
            {
                comboBoxCriterionBook.Items.Add(booksDataGridView.Columns[i].HeaderText);
                DBHelper.ColumnsNameBooksDictionary.Add(i - 1, publishing_houseDataSet.books.Columns[i].ColumnName);
            }

            for (int i = 1; i < designersDataGridView.Columns.Count; i++)
            {
                if (i == designersDataGridView.Columns.Count - 2)
                {
                    comboBoxCriterionDesigner.Items.Add(designersDataGridView.Columns[i + 1].HeaderText);
                    DBHelper.ColumnsNameDesignersDictionary.Add(i - 1, publishing_houseDataSet.designers.Columns[i + 1].ColumnName);
                    break;
                }
                comboBoxCriterionDesigner.Items.Add(designersDataGridView.Columns[i].HeaderText);
                DBHelper.ColumnsNameDesignersDictionary.Add(i - 1, publishing_houseDataSet.designers.Columns[i].ColumnName);
            }

            for (int i = 1; i < editorsDataGridView.Columns.Count; i++)
            {
                if (i == editorsDataGridView.Columns.Count - 2)
                {
                    comboBoxCriterionEditor.Items.Add(editorsDataGridView.Columns[i + 1].HeaderText);
                    DBHelper.ColumnsNameEditorsDictionary.Add(i - 1, publishing_houseDataSet.editors.Columns[i + 1].ColumnName);
                    break;
                }
                comboBoxCriterionEditor.Items.Add(editorsDataGridView.Columns[i].HeaderText);
                DBHelper.ColumnsNameEditorsDictionary.Add(i - 1, publishing_houseDataSet.editors.Columns[i].ColumnName);
            }

            toolStripComboBoxCriterionView.Items.AddRange(new string[]
            {
                shopsBooksNamedDataGridView.Columns[0].HeaderText,
                shopsBooksNamedDataGridView.Columns[1].HeaderText
            });
            DBHelper.ColumnsNameViewDictionary.Add(0, publishing_houseDataSet.ShopsBooksNamed.Columns[0].ColumnName);
            DBHelper.ColumnsNameViewDictionary.Add(1, publishing_houseDataSet.ShopsBooksNamed.Columns[1].ColumnName);
        }
        private void MakeUsersRestriction()
        {
            author_bookBindingNavigator.MakeDisabledDMLButtons(false);
            authorsBindingNavigator.MakeDisabledDMLButtons(false);
            booksBindingNavigator.MakeDisabledDMLButtons(false);
            designersBindingNavigator.MakeDisabledDMLButtons(false);
            editorsBindingNavigator.MakeDisabledDMLButtons(false);
            shopsBindingNavigator.MakeDisabledDMLButtons(false);
            genresBindingNavigator.MakeDisabledDMLButtons(false);
            shops_nameBindingNavigator.MakeDisabledDMLButtons(false);
            tabControlFacts.TabPages.RemoveByKey("tabPageShopsBooksForAdmin");
            tabControlMain.TabPages.RemoveByKey("tabPageLogs");
            genresDataGridView.ReadOnly = true;
            shops_nameDataGridView.ReadOnly = true;

        }
        private void MakeAdminPermission()
        {
            author_bookBindingNavigator.MakeDisabledDMLButtons(true);
            authorsBindingNavigator.MakeDisabledDMLButtons(true);
            booksBindingNavigator.MakeDisabledDMLButtons(true);
            designersBindingNavigator.MakeDisabledDMLButtons(true);
            editorsBindingNavigator.MakeDisabledDMLButtons(true);
            shopsBindingNavigator.MakeDisabledDMLButtons(true);
            genresBindingNavigator.MakeDisabledDMLButtons(true);
            shops_nameBindingNavigator.MakeDisabledDMLButtons(true);
            genresDataGridView.ReadOnly = false;
            shops_nameDataGridView.ReadOnly = false;
            if (!tabControlFacts.TabPages.Contains(tabPageShopsBooksForAdmin))
                tabControlFacts.TabPages.Add(tabPageShopsBooksForAdmin);
            if (!tabControlMain.TabPages.Contains(tabPageLogs))
                tabControlMain.TabPages.Add(tabPageLogs);

        }
        private void ChangeEnableAllButtons(BindingNavigator bindingNavigator, bool enable)
        {
            foreach (ToolStripItem item in bindingNavigator.Items)
            {
                item.Enabled = enable;
            }
        }
        private void PrintDataGridView(DataGridView dataGridView)
        {

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Пустой отчёт печати не подлежит", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GridPrintDocument doc = new GridPrintDocument(dataGridView, dataGridView.Font, true);
            doc.DocumentName = "Preview Test";
            doc.DrawCellBox = true;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(500, 200);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";

            printPreviewDialog.UseAntiAlias = true;

            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();
            doc.Dispose();
            doc = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "publishing_houseDataSet.booksLogTable". При необходимости она может быть перемещена или удалена.

            SetPermissions();
        }

        private void buttonQueryAuthorBooks_Click(object sender, EventArgs e)
        {
            int index = comboBoxCriterionAuthorBook.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(textBoxConditionAuthorBooks.Text))
            {
                MessageBox.Show("Нет условия выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string searchParam = textBoxConditionAuthorBooks.Text.Trim();

            object outputId = DBHelper.ExecuteSpForAuthor_booksTable(searchParam, comboBoxCriterionAuthorBook.SelectedIndex);
            int id = 0;
            if (outputId == null || outputId == Convert.DBNull)
            {
                MessageBox.Show("Не найдено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = -1;

            }
            else
            {
                id = Convert.ToInt32(outputId);
            }
            if (index == dataGridViewTextBoxColumnAuthorBooksAuthor.Index - 1)
                this.author_bookTableAdapter.FillByAuthor(this.publishing_houseDataSet.author_book, id);
            else if (index == dataGridViewTextBoxColumnAuthorBooksBook.Index - 1)
                this.author_bookTableAdapter.FillByBook(this.publishing_houseDataSet.author_book, id);

        }

         private void toolStripButtonUpdateBooksAuthors_Click(object sender, EventArgs e)
        {
            this.author_bookTableAdapter.Fill(this.publishing_houseDataSet.author_book);
            textBoxConditionAuthorBooks.Clear();
        }

        private void buttonPrintQueryAuthorBook_Click(object sender, EventArgs e)
        {

            if (comboBoxCriterionAuthorBook.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBoxConditionAuthorBooks.Text))
            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(author_bookDataGridView);
        }
        private void author_bookDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = author_bookBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var author_booksRow = dataRow.Row as publishing_houseDataSet.author_bookRow;

            if (author_booksRow == null || author_booksRow.RowState == DataRowState.Detached)
                return;

            try
            {
                DataRowView rowView = authorsBindingSource[authorsBindingSource.Find("authors_id", author_booksRow.author_books_author_id)] as DataRowView;
                comboBoxAuthorBooksAuthor.SelectedItem = rowView;
                rowView = booksBindingSource[booksBindingSource.Find("books_id", author_booksRow.author_books_books_id)] as DataRowView;
                comboBoxAuthorBooksBook.SelectedItem = rowView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            author_bookBindingNavigator.Enabled = false;
            author_bookDataGridView.Enabled = false;
            groupBoxSearchAuthorBooks.Enabled = false;
            groupBoxEditAuthorBook.Enabled = true;
        }

        private void buttonCancelAuthorBook_Click(object sender, EventArgs e)
        {

            if (author_bookDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
            {
                author_bookDataGridView.Rows.Remove(author_bookDataGridView.CurrentRow);
            }
            author_bookDataGridView.Invoke((Action<object, EventArgs>)author_bookDataGridView_SelectionChanged, author_bookDataGridView, null);

            author_bookBindingNavigator.Enabled = true;
            author_bookDataGridView.Enabled = true;
            groupBoxSearchAuthorBooks.Enabled = true;
            groupBoxEditAuthorBook.Enabled = false;
        }

        private void buttonSaveAuthorBook_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView dataRow = author_bookBindingSource.Current as DataRowView;
                publishing_houseDataSet.author_bookRow author_BookRow = dataRow.Row as publishing_houseDataSet.author_bookRow;

                author_BookRow.author_books_author_id = ((comboBoxAuthorBooksAuthor.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.authorsRow).authors_id;

                author_BookRow.author_books_books_id = ((comboBoxAuthorBooksBook.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.booksRow).books_id;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                author_bookBindingNavigator.Enabled = true;
                author_bookDataGridView.Enabled = true;
                groupBoxSearchAuthorBooks.Enabled = true;
                groupBoxEditAuthorBook.Enabled = false;
                author_bookBindingNavigator.Focus();
            }
        }

        private void toolStripButtonEditAuthorBook_Click(object sender, EventArgs e)
        {
            author_bookBindingNavigator.Enabled = false;
            author_bookDataGridView.Enabled = false;
            groupBoxSearchAuthorBooks.Enabled = false;
            groupBoxEditAuthorBook.Enabled = true;
            author_bookBindingSource.ResetCurrentItem();
        }
        //----------------------------------------------------------------//////////////
        private void textBoxAuthorLastName_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Строка не должна быть пустой!");
                errorProvider.SetIconAlignment(textBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetIconPadding(textBox, textBox.Width / 20);
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void toolStripButtonSaveAuthorItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.publishing_houseDataSet);
        }

        private void toolStripButtonUpdateAuthorItem_Click(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Fill(this.publishing_houseDataSet.authors);
        }

        private void toolStripButtonEditAuthorItem_Click(object sender, EventArgs e)
        {
            authorsBindingNavigator.Enabled = false;
            authorsDataGridView.Enabled = false;
            groupBoxSearchAuthor.Enabled = false;

            groupBoxEditAuthor.Enabled = true;
            authorsBindingSource.ResetCurrentItem();
        }

        private void buttonQueryAuthor_Click(object sender, EventArgs e)
        {

            int index = comboBoxCriterionAuthor.SelectedIndex;
            string text = textBoxConditionAuthor.Text.Trim();
            if (index < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(textBoxConditionAuthor.Text))
            {
                MessageBox.Show("Нет условия выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == 3)
            {
                int year;
                if (int.TryParse(text, out year))
                    authorsTableAdapter.FillBy(this.publishing_houseDataSet.authors, "dbo.authors", DBHelper.ColumnsNameAuthorsDictionary[index], null, text);
                else
                    MessageBox.Show("Неверно введён год", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                authorsTableAdapter.FillBy(this.publishing_houseDataSet.authors, "dbo.authors", DBHelper.ColumnsNameAuthorsDictionary[index], text, null);
            }
        }

        private void comboBoxCriterionAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCriterionAuthor.SelectedIndex == 3)
                textBoxConditionAuthor.MaxLength = 4;
            else
                textBoxConditionAuthor.MaxLength = 25;
        }

        private void tabPageAuthors_Leave(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Fill(this.publishing_houseDataSet.authors);
        }

        private void bindingNavigatorAddNewItem4_Click(object sender, EventArgs e)
        {
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            textBoxAuthorPatronymic.Clear();

            authorsBindingNavigator.Enabled = false;
            authorsDataGridView.Enabled = false;
            groupBoxSearchAuthor.Enabled = false;
            groupBoxEditAuthor.Enabled = true;
        }

        private void buttonCancelAuthorEditing_Click(object sender, EventArgs e)
        {
            if (authorsDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                authorsDataGridView.Rows.Remove(authorsDataGridView.CurrentRow);

            authorsDataGridView.Invoke((Action<object, EventArgs>)authorsDataGridView_SelectionChanged, author_bookDataGridView, null);

            textBoxAuthorLastName.Focus();
            textBoxAuthorFirstName.Focus();


            authorsBindingNavigator.Enabled = true;
            authorsDataGridView.Enabled = true;
            groupBoxSearchAuthor.Enabled = true;
            groupBoxEditAuthor.Enabled = false;
        }

        private void authorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = authorsBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var authorsRow = dataRow.Row as publishing_houseDataSet.authorsRow;

            if (authorsRow == null || authorsRow.RowState == DataRowState.Detached)
                return;

            try
            {
                textBoxAuthorLastName.Text = authorsRow.authors_last_name;
                textBoxAuthorFirstName.Text = authorsRow.authors_first_name;
                if (!authorsRow.Isautrhors_patronymicNull())
                    textBoxAuthorPatronymic.Text = authorsRow.autrhors_patronymic;
                else
                    textBoxAuthorPatronymic.Clear();
                dateTimePickerAuthorBirthDate.Value = authorsRow.authors_birthday;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool AtLeastOneEmptyTextBox(TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
                    return true;
            }
            return false;
        }
        private void buttonSaveAuthorEditing_Click(object sender, EventArgs e)
        {

            bool wasEmpty = AtLeastOneEmptyTextBox(new TextBox[]
            {
                textBoxAuthorFirstName,
                textBoxAuthorLastName
            });
            if (wasEmpty)
            {
                MessageBox.Show("Не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataRowView dataRow = authorsBindingSource.Current as DataRowView;
                var authorsRow = dataRow.Row as publishing_houseDataSet.authorsRow;

                authorsRow.authors_first_name = textBoxAuthorFirstName.Text.Trim();
                authorsRow.authors_last_name = textBoxAuthorLastName.Text.Trim();
                authorsRow.autrhors_patronymic = textBoxAuthorPatronymic.Text.Trim();
                authorsRow.authors_birthday = dateTimePickerAuthorBirthDate.Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                authorsBindingNavigator.Enabled = true;
                authorsDataGridView.Enabled = true;
                groupBoxSearchAuthor.Enabled = true;
                groupBoxEditAuthor.Enabled = false;
                authorsBindingNavigator.Focus();
            }
        }

        private void buttonPrintAuthor_Click(object sender, EventArgs e)
        {
            if (comboBoxCriterionAuthor.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBoxConditionAuthor.Text))
            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(authorsDataGridView);
        }

        private void buttonQueryBooks_Click(object sender, EventArgs e)
        {
            if (comboBoxCriterionBook.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(comboBoxConditionBooks.Text))
            {
                MessageBox.Show("Не выбрано условие выборки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = comboBoxCriterionBook.SelectedIndex;
            if (index == 0)
            {
                this.booksTableAdapter.FillBy(publishing_houseDataSet.books, DBHelper.ColumnsNameBooksDictionary[index], comboBoxConditionBooks.Text.Trim(), true);
            }
            else if (comboBoxCriterionBook.SelectedIndex < 3)
            {
                int number = 0;
                if (int.TryParse(comboBoxConditionBooks.Text.Trim(), out number))
                    this.booksTableAdapter.FillBy(publishing_houseDataSet.books, DBHelper.ColumnsNameBooksDictionary[index], number.ToString(), false);
                else
                    MessageBox.Show("Не верно введено числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.booksTableAdapter.FillBy(publishing_houseDataSet.books, DBHelper.ColumnsNameBooksDictionary[index], comboBoxConditionBooks.SelectedValue.ToString(), false);
            }

        }

        private void comboBoxCriterionBook_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = comboBoxCriterionBook.SelectedIndex;
            if (index < 0)
                return;

            switch (index)
            {
                case 0:
                    comboBoxConditionBooks.DropDownStyle = ComboBoxStyle.Simple;
                    comboBoxConditionBooks.DataBindings.Clear();
                    comboBoxConditionBooks.DataSource = null;
                    comboBoxConditionBooks.MaxLength = 40;
                    comboBoxConditionBooks.Text = "";
                    break;
                case 1:
                case 2:
                    comboBoxConditionBooks.DropDownStyle = ComboBoxStyle.Simple;
                    comboBoxConditionBooks.DataBindings.Clear();
                    comboBoxConditionBooks.DataSource = null;
                    comboBoxConditionBooks.MaxLength = 4;
                    comboBoxConditionBooks.Text = "";
                    break;
                case 3:
                    comboBoxConditionBooks.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionBooks.DataSource = genresBindingSource;
                    comboBoxConditionBooks.ValueMember = "genre_id";
                    comboBoxConditionBooks.DisplayMember = "genre_name";
                    break;
                case 4:
                    comboBoxConditionBooks.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionBooks.DataSource = editorsBindingSource;
                    comboBoxConditionBooks.ValueMember = "editors_id";
                    comboBoxConditionBooks.DisplayMember = "editors_last_name";
                    break;
                case 5:
                    comboBoxConditionBooks.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionBooks.DataSource = designersBindingSource;
                    comboBoxConditionBooks.ValueMember = "designers_id";
                    comboBoxConditionBooks.DisplayMember = "designer_last_name";
                    break;
                default:
                    break;
            }

        }

        private void tabPageBooks_Leave(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.publishing_houseDataSet.books);
        }

        private void buttonPrintQueryBook_Click(object sender, EventArgs e)
        {
            if (comboBoxCriterionBook.SelectedIndex == -1 ||
    string.IsNullOrEmpty(comboBoxConditionBooks.Text))
            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(booksDataGridView);
        }

        private void bindingNavigatorAddNewItem8_Click(object sender, EventArgs e)
        {
            textBoxBooksName.Clear();
            numericUpDownBooksPages.Value = 3;
            numericUpDownBooksPublishingYear.Value = 2020;
            comboBoxBooksGenre.SelectedIndex = 0;
            comboBoxBooksEditor.SelectedIndex = 0;
            comboBoxBooksDesigner.SelectedIndex = 0;

            booksBindingNavigator.Enabled = false;
            booksDataGridView.Enabled = false;
            groupBoxSearchBook.Enabled = false;
            groupBoxEditBook.Enabled = true;
        }

        private void toolStripButtonSaveBooksItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.publishing_houseDataSet);
        }

        private void toolStripButtonUpdateBooksItem_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.publishing_houseDataSet.books);
        }

        private void toolStripButtonEditBooksItem_Click(object sender, EventArgs e)
        {
            booksBindingNavigator.Enabled = false;
            booksDataGridView.Enabled = false;
            groupBoxSearchBook.Enabled = false;

            groupBoxEditBook.Enabled = true;
            booksBindingSource.ResetCurrentItem();
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBooksName.Text) || comboBoxBooksDesigner.SelectedIndex < 0
                || comboBoxBooksEditor.SelectedIndex < 0 || comboBoxBooksGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Одно из полей имело неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                DataRowView dataRow = booksBindingSource.Current as DataRowView;
                var booksRow = dataRow.Row as publishing_houseDataSet.booksRow;

                booksRow.books_name = textBoxBooksName.Text.Trim();
                booksRow.books_pages = (short)numericUpDownBooksPages.Value;
                booksRow.books_publishing_year = (short)numericUpDownBooksPublishingYear.Value;

                booksRow.books_genre_id = ((comboBoxBooksGenre.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.genresRow).genre_id;

                booksRow.books_editor_id = ((comboBoxBooksEditor.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.editorsRow).editors_id;

                booksRow.books_designer_id = ((comboBoxBooksDesigner.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.designersRow).designers_id;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                booksBindingNavigator.Enabled = true;
                booksDataGridView.Enabled = true;
                groupBoxSearchBook.Enabled = true;
                groupBoxEditBook.Enabled = false;
                booksBindingNavigator.Focus();
            }
        }

        private void buttonCancelEditBook_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                booksDataGridView.Rows.Remove(booksDataGridView.CurrentRow);


            groupBoxSearchBook.Enabled = true;

            booksDataGridView.Invoke((Action<object, EventArgs>)booksDataGridView_SelectionChanged, booksDataGridView, null);
            textBoxBooksName.Focus();

            comboBoxBooksEditor.Focus();

            booksBindingNavigator.Enabled = true;
            booksDataGridView.Enabled = true;
            groupBoxEditBook.Enabled = false;
        }

        private void booksDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = booksBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;
            
            var booksRow = dataRow.Row as publishing_houseDataSet.booksRow;
            
            if (booksRow == null || booksRow.RowState == DataRowState.Detached || !groupBoxSearchBook.Enabled)
                return;
            
            try
            {
                textBoxBooksName.Text = booksRow.books_name;
                numericUpDownBooksPages.Value = booksRow.books_pages;
                numericUpDownBooksPublishingYear.Value = booksRow.books_publishing_year;

                DataRowView rowView = genresBindingSource[genresBindingSource.Find("genre_id", booksRow.books_genre_id)] as DataRowView;
                comboBoxBooksGenre.SelectedItem = rowView;
                rowView = editorsBindingSource[editorsBindingSource.Find("editors_id", booksRow.books_editor_id)] as DataRowView;
                comboBoxBooksEditor.SelectedItem = rowView;
                rowView = designersBindingSource[designersBindingSource.Find("designers_id", booksRow.books_designer_id)] as DataRowView;
                comboBoxBooksDesigner.SelectedItem = rowView;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
        }

        //--------------------------------------------------------------------------------------------------
        private void buttonQueryDesigner_Click(object sender, EventArgs e)
        {
            int index = comboBoxCriterionDesigner.SelectedIndex;
            string text = textBoxConditionDesigner.Text.Trim();
            if (index < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(textBoxConditionDesigner.Text))
            {
                MessageBox.Show("Нет условия выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == 3)
            {
                int year;
                if (int.TryParse(text, out year))
                    designersTableAdapter.FillBy(this.publishing_houseDataSet.designers, "dbo.designers", DBHelper.ColumnsNameDesignersDictionary[index], null, text);
                else
                    MessageBox.Show("Неверно введён год", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                designersTableAdapter.FillBy(this.publishing_houseDataSet.designers, "dbo.designers", DBHelper.ColumnsNameDesignersDictionary[index], text, null);
            }
        }

        private void buttonPrintDesigner_Click(object sender, EventArgs e)
        {
            if (comboBoxCriterionDesigner.SelectedIndex < 0 ||
               string.IsNullOrEmpty(textBoxConditionDesigner.Text))
            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(designersDataGridView);
        }

        private void designersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = designersBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var designerRow = dataRow.Row as publishing_houseDataSet.designersRow;

            if (designerRow == null || designerRow.RowState == DataRowState.Detached)
                return;

            try
            {
                textBoxDesignerLastName.Text = designerRow.designer_last_name;
                textBoxDesignerFirstName.Text = designerRow.designers_first_name;

                if (!designerRow.Isdesigner_patronymicNull())
                    textBoxDesignerPatronymic.Text = designerRow.designer_patronymic;
                else
                    textBoxDesignerPatronymic.Clear();
                dateTimePickerDesignerBirthDate.Value = designerRow.designers_birthday;

                if (!designerRow.Isdesigners_number_phoneNull())
                    maskedTextBoxDesignerNumberPhone.Text = designerRow.designers_number_phone;
                else
                    maskedTextBoxDesignerNumberPhone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem5_Click(object sender, EventArgs e)
        {
            textBoxDesignerFirstName.Clear();
            textBoxDesignerLastName.Clear();
            textBoxDesignerPatronymic.Clear();

            designersBindingNavigator.Enabled = false;
            designersDataGridView.Enabled = false;
            groupBoxSearchDesigner.Enabled = false;
            groupBoxEditDesigner.Enabled = true;
        }

        private void toolStripButtonSaveDesignersItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.designersBindingSource.EndEdit();
            this.designersTableAdapter.Update(this.publishing_houseDataSet);
            this.tableAdapterManager.UpdateAll(publishing_houseDataSet);
        }

        private void toolStripButtonUpdateDesignersItem_Click(object sender, EventArgs e)
        {
            this.designersTableAdapter.Fill(this.publishing_houseDataSet.designers);
        }

        private void toolStripButtonEditDesignerItem_Click(object sender, EventArgs e)
        {
            designersBindingNavigator.Enabled = false;
            designersDataGridView.Enabled = false;
            groupBoxSearchDesigner.Enabled = false;

            groupBoxEditDesigner.Enabled = true;
            designersBindingSource.ResetCurrentItem();
        }

        private void buttonCancelEditingDesigner_Click(object sender, EventArgs e)
        {
            if (designersDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                designersDataGridView.Rows.Remove(designersDataGridView.CurrentRow);


            groupBoxSearchDesigner.Enabled = true;

            designersDataGridView.Invoke((Action<object, EventArgs>)designersDataGridView_SelectionChanged, designersDataGridView, null);

            textBoxDesignerFirstName.Focus();
            textBoxDesignerLastName.Focus();


            designersBindingNavigator.Enabled = true;
            designersDataGridView.Enabled = true;
            groupBoxEditDesigner.Enabled = false;
        }

        private void buttonSaveDesigner_Click(object sender, EventArgs e)
        {
            bool wasEmpty = AtLeastOneEmptyTextBox(new TextBox[]
           {
                textBoxDesignerFirstName,
                textBoxDesignerLastName,

           });
            if (wasEmpty)
            {
                MessageBox.Show("Не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string numberPhone = "";
            if (!maskedTextBoxDesignerNumberPhone.MaskCompleted)
            {
                if (maskedTextBoxDesignerNumberPhone.Text == " -   -   -  -")
                    numberPhone = "";
                else
                {
                    MessageBox.Show("Неверно введён номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                numberPhone = maskedTextBoxDesignerNumberPhone.Text;
            }

            try
            {

                DataRowView dataRow = designersBindingSource.Current as DataRowView;
                var designersRow = dataRow.Row as publishing_houseDataSet.designersRow;

                designersRow.designers_first_name = textBoxDesignerFirstName.Text.Trim();
                designersRow.designer_last_name = textBoxDesignerLastName.Text.Trim();
                designersRow.designer_patronymic = textBoxDesignerPatronymic.Text.Trim();
                designersRow.designers_birthday = dateTimePickerDesignerBirthDate.Value;

                designersRow.designers_number_phone = numberPhone;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                designersBindingNavigator.Enabled = true;
                designersDataGridView.Enabled = true;
                groupBoxSearchDesigner.Enabled = true;
                groupBoxEditDesigner.Enabled = false;
                designersBindingNavigator.Focus();
            }
        }

        //---------------------------------------------------------------------------------------
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.editorsBindingSource.EndEdit();
            this.editorsTableAdapter.Update(this.publishing_houseDataSet);
            this.tableAdapterManager.UpdateAll(publishing_houseDataSet);
        }

        private void editorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = editorsBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var editorsRow = dataRow.Row as publishing_houseDataSet.editorsRow;

            if (editorsRow == null || editorsRow.RowState == DataRowState.Detached)
                return;

            try
            {
                textBoxEditorsLastName.Text = editorsRow.editors_last_name;
                textBoxEditorsFirstName.Text = editorsRow.editors_first_name;

                if (!editorsRow.Iseditors_patronymicNull())
                    textBoxEditorsPatronymic.Text = editorsRow.editors_patronymic;

                else
                    textBoxEditorsPatronymic.Clear();
                dateTimePickerEdtirosBirthDate.Value = editorsRow.editors_birthday;

                if (!editorsRow.Iseditors_number_phoneNull())
                    maskedTextBoxEditorsNumberPhone.Text = editorsRow.editors_number_phone;
                else
                    maskedTextBoxEditorsNumberPhone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            textBoxEditorsFirstName.Clear();
            textBoxEditorsLastName.Clear();
            textBoxEditorsPatronymic.Clear();

            editorsBindingNavigator.Enabled = false;
            editorsDataGridView.Enabled = false;
            groupBoxSearchEditor.Enabled = false;
            groupBoxEditEditors.Enabled = true;
        }

        private void toolStripButtonUpdateEditorsItem_Click(object sender, EventArgs e)
        {
            this.editorsTableAdapter.Fill(this.publishing_houseDataSet.editors);
        }

        private void toolStripButtonEditEditorsItem_Click(object sender, EventArgs e)
        {
            editorsBindingNavigator.Enabled = false;
            editorsDataGridView.Enabled = false;
            groupBoxSearchEditor.Enabled = false;

            groupBoxEditEditors.Enabled = true;
            editorsBindingSource.ResetCurrentItem();
        }

        private void buttonSaveEditors_Click(object sender, EventArgs e)
        {
            bool wasEmpty = AtLeastOneEmptyTextBox(new TextBox[]
          {
                textBoxEditorsFirstName,
                textBoxEditorsLastName,
          });
            if (wasEmpty)
            {
                MessageBox.Show("Не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string numberPhone = "";
            if (!maskedTextBoxEditorsNumberPhone.MaskCompleted)
            {
                if (maskedTextBoxEditorsNumberPhone.Text == " -   -   -  -")
                    numberPhone = "";
                else
                {
                    MessageBox.Show("Неверно введён номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                numberPhone = maskedTextBoxEditorsNumberPhone.Text;
            }
            try
            {
                DataRowView dataRow = editorsBindingSource.Current as DataRowView;
                var editorsRow = dataRow.Row as publishing_houseDataSet.editorsRow;

                editorsRow.editors_first_name = textBoxEditorsFirstName.Text.Trim();
                editorsRow.editors_last_name = textBoxEditorsLastName.Text.Trim();
                editorsRow.editors_patronymic = textBoxEditorsPatronymic.Text.Trim();
                editorsRow.editors_birthday = dateTimePickerEdtirosBirthDate.Value;
                editorsRow.editors_number_phone = numberPhone;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                editorsBindingNavigator.Enabled = true;
                editorsDataGridView.Enabled = true;
                groupBoxSearchEditor.Enabled = true;
                groupBoxEditEditors.Enabled = false;
                editorsBindingNavigator.Focus();
            }
        }

        private void buttonCancelEditEditors_Click(object sender, EventArgs e)
        {
            if (editorsDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                editorsDataGridView.Rows.Remove(editorsDataGridView.CurrentRow);

            groupBoxSearchEditor.Enabled = true;
            editorsDataGridView.Invoke((Action<object, EventArgs>)editorsDataGridView_SelectionChanged, editorsDataGridView, null);
            textBoxEditorsFirstName.Focus();
            textBoxEditorsLastName.Focus();
            editorsBindingNavigator.Enabled = true;
            editorsDataGridView.Enabled = true;
            groupBoxEditEditors.Enabled = false;
        }

        private void buttonQueryEditor_Click(object sender, EventArgs e)
        {
            int index = comboBoxCriterionEditor.SelectedIndex;
            string text = textBoxConditionEditor.Text.Trim();
            if (index < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(textBoxConditionEditor.Text))
            {
                MessageBox.Show("Нет условия выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (index == 3)
            {
                int year;
                if (int.TryParse(text, out year))
                    editorsTableAdapter.FillBy(this.publishing_houseDataSet.editors, "dbo.editors", DBHelper.ColumnsNameEditorsDictionary[index], null, text);
                else
                    MessageBox.Show("Неверно введён год", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editorsTableAdapter.FillBy(this.publishing_houseDataSet.editors, "dbo.editors", DBHelper.ColumnsNameEditorsDictionary[index], text, null);
            }
        }

        private void buttonPrintQueryEditors_Click(object sender, EventArgs e)
        {
            if (comboBoxCriterionEditor.SelectedIndex < 0 ||
               string.IsNullOrEmpty(textBoxConditionEditor.Text))
            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(editorsDataGridView);
        }

        private void tabPageDesigners_Leave(object sender, EventArgs e)
        {
            this.designersTableAdapter.Fill(publishing_houseDataSet.designers);
        }

        private void tabPageEditors_Leave(object sender, EventArgs e)
        {
            this.editorsTableAdapter.Fill(publishing_houseDataSet.editors);
        }

        private void tabPageAuthorsBooks_Leave(object sender, EventArgs e)
        {
            this.author_bookTableAdapter.Fill(publishing_houseDataSet.author_book);
        }

        private void tabPageShops_Leave(object sender, EventArgs e)
        {
            this.shopsTableAdapter.Fill(publishing_houseDataSet.shops);
        }

        private void tabPageShopsBooks_Leave(object sender, EventArgs e)
        {
            this.shops_booksTableAdapter.Fill(publishing_houseDataSet.shops_books);
        }

        private void comboBoxCriterionDesigner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCriterionDesigner.SelectedIndex == 3)
                textBoxConditionDesigner.MaxLength = 4;
            else
                textBoxConditionDesigner.MaxLength = 25;
        }

        private void comboBoxCriterionEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCriterionEditor.SelectedIndex == 3)
                textBoxConditionEditor.MaxLength = 4;
            else
                textBoxConditionEditor.MaxLength = 25;
        }



        private void shopsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = shopsBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var shopsRow = dataRow.Row as publishing_houseDataSet.shopsRow;

            if (shopsRow == null || shopsRow.RowState == DataRowState.Detached)
                return;

            try
            {
                textBoxShopsAddress.Text = shopsRow.shops_address;

                if (!shopsRow.Isshops_number_phoneNull())
                    maskedTextBoxShopsNumberPhone.Text = shopsRow.shops_number_phone;
                else
                    maskedTextBoxShopsNumberPhone.Clear();

                DataRowView rowView = shopsnameBindingSource[shopsnameBindingSource.Find("shops_name_id", shopsRow.shops_name_id)] as DataRowView;
                comboBoxShopsName.SelectedItem = rowView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem6_Click(object sender, EventArgs e)
        {
            textBoxShopsAddress.Clear();
            maskedTextBoxShopsNumberPhone.Clear();
            comboBoxShopsName.SelectedIndex = 0;

            shopsBindingNavigator.Enabled = false;
            shopsDataGridView.Enabled = false;
            groupBoxSearchShops.Enabled = false;
            groupBoxEditShops.Enabled = true;
        }

        private void toolStripButtonSaveShopsItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shopsBindingSource.EndEdit();
            this.shopsTableAdapter.Update(this.publishing_houseDataSet);
            this.tableAdapterManager.UpdateAll(publishing_houseDataSet);
        }

        private void toolStripButtonUpdateShopsItem_Click(object sender, EventArgs e)
        {
            this.shopsTableAdapter.Fill(publishing_houseDataSet.shops);
        }

        private void toolStripButtonEditShopsItem_Click(object sender, EventArgs e)
        {
            shopsBindingNavigator.Enabled = false;
            shopsDataGridView.Enabled = false;
            groupBoxSearchShops.Enabled = false;

            groupBoxEditShops.Enabled = true;
            shopsBindingSource.ResetCurrentItem();
        }

        private void buttonQueryShops_Click(object sender, EventArgs e)
        {
            int index = comboBoxConditionShops.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Не выбран критерий выборки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (int.TryParse(comboBoxConditionShops.SelectedValue.ToString(), out id))
                shopsTableAdapter.FillBy(this.publishing_houseDataSet.shops, id);
            else
                shopsTableAdapter.FillBy(this.publishing_houseDataSet.shops, -1);
        }

        private void buttonPrintShops_Click(object sender, EventArgs e)
        {
            if (comboBoxConditionShops.SelectedIndex < 0)

            {
                MessageBox.Show("Нет запроса на печать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(shopsDataGridView);
        }

        private void buttonSaveShop_Click(object sender, EventArgs e)
        {
            bool wasEmpty = AtLeastOneEmptyTextBox(new TextBox[]
         {
                textBoxShopsAddress
         });
            if (wasEmpty)
            {
                MessageBox.Show("Не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string numberPhone = "";
            if (!maskedTextBoxShopsNumberPhone.MaskCompleted)
            {
                if (maskedTextBoxShopsNumberPhone.Text == " -   -   -  -")
                    numberPhone = "";
                else
                {
                    MessageBox.Show("Неверно введён номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                numberPhone = maskedTextBoxShopsNumberPhone.Text;
            }
            try
            {
                DataRowView dataRow = shopsBindingSource.Current as DataRowView;
                var shopsRow = dataRow.Row as publishing_houseDataSet.shopsRow;

                shopsRow.shops_address = textBoxShopsAddress.Text.Trim();
                shopsRow.shops_number_phone = numberPhone;

                int id;
                if (int.TryParse(comboBoxShopsName.SelectedValue.ToString(), out id))
                    shopsRow.shops_name_id = id;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                shopsBindingNavigator.Enabled = true;
                shopsDataGridView.Enabled = true;
                groupBoxSearchShops.Enabled = true;
                groupBoxEditShops.Enabled = false;
                shopsBindingNavigator.Focus();
            }
        }

        private void buttonCancelEditingShops_Click(object sender, EventArgs e)
        {
            if (shopsDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                shopsDataGridView.Rows.Remove(shopsDataGridView.CurrentRow);

            groupBoxSearchShops.Enabled = true;
            shopsDataGridView.Invoke((Action<object, EventArgs>)shopsDataGridView_SelectionChanged, shopsDataGridView, null);
            textBoxShopsAddress.Focus();
            shopsBindingNavigator.Enabled = true;
            shopsDataGridView.Enabled = true;
            groupBoxEditShops.Enabled = false;
        }


        private void bindingNavigatorAddNewItem7_Click(object sender, EventArgs e)
        {
            numericUpDownCostBook.Value = numericUpDownCostBook.Minimum;
            numericUpDownCostBook.Value = numericUpDownCostBook.Minimum;
            comboBoxShops_BooksBooksId.SelectedIndex = 0;
            comboBoxShops_BooksShopsId.SelectedIndex = 0;

            shops_booksBindingNavigator.Enabled = false;
            shops_booksDataGridView.Enabled = false;
            groupBoxSearchShops_Books.Enabled = false;
            groupBoxEditShops_Books.Enabled = true;
        }
        private void toolStripButtonSaveBooksInShopsItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shops_booksBindingSource.EndEdit();
            this.shops_booksTableAdapter.Update(this.publishing_houseDataSet);
            this.tableAdapterManager.UpdateAll(publishing_houseDataSet);
        }

        private void toolStripButtonUpdateShopsInBooks_Click(object sender, EventArgs e)
        {
            this.shops_booksTableAdapter.Fill(publishing_houseDataSet.shops_books);
        }

        private void toolStripButtonEditBooksInShopsItem_Click(object sender, EventArgs e)
        {
            shops_booksBindingNavigator.Enabled = false;
            shops_booksDataGridView.Enabled = false;
            groupBoxSearchShops_Books.Enabled = false;

            groupBoxEditShops_Books.Enabled = true;
            shops_booksBindingSource.ResetCurrentItem();
        }
        private void shops_booksDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = shops_booksBindingSource.Current as DataRowView;

            if (dataRow == null)
                return;

            var shops_booksRow = dataRow.Row as publishing_houseDataSet.shops_booksRow;

            if (shops_booksRow == null || shops_booksRow.RowState == DataRowState.Detached)
                return;

            try
            {
                numericUpDownCountBooks.Value = shops_booksRow.shops_books_books_in_shops_count;
                numericUpDownCostBook.Value = shops_booksRow.shops_books_cost;

                if (shops_booksRow.shopsRow == null || shops_booksRow.booksRow == null)
                    return;
                int index = booksBindingSource.Find("books_id", shops_booksRow.shops_books_books_id);
                DataRowView rowView = booksBindingSource[index] as DataRowView;

                comboBoxShops_BooksBooksId.SelectedItem = rowView;

                index = shopsBindingSource.Find("shops_id", shops_booksRow.shops_books_shops_id);
                rowView = shopsBindingSource[index] as DataRowView;
                comboBoxShops_BooksShopsId.SelectedItem = rowView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
        }

        private void buttonQueryBooksShops_Click(object sender, EventArgs e)
        {
            string booksName = textBoxCondtitionBooksName.Text.Trim();
            if (string.IsNullOrWhiteSpace(booksName))
            {
                MessageBox.Show("Название книги не введено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            shops_booksTableAdapter.FillBy(publishing_houseDataSet.shops_books, booksName);
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void buttonPrintQueryBooksShops_Click(object sender, EventArgs e)
        {
            string booksName = textBoxCondtitionBooksName.Text.Trim();
            if (string.IsNullOrWhiteSpace(booksName))
            {
                MessageBox.Show("Название книги не введено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(shops_booksDataGridView);
        }

        private void buttonSaveShops_Books_Click(object sender, EventArgs e)
        {
            if (comboBoxShops_BooksBooksId.SelectedIndex < 0 || comboBoxShops_BooksShopsId.SelectedIndex < 0)
            {
                MessageBox.Show("Одно из значений было введено неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataRowView dataRow = shops_booksBindingSource.Current as DataRowView;
                var shops_booksRow = dataRow.Row as publishing_houseDataSet.shops_booksRow;

                shops_booksRow.shops_books_books_id = ((comboBoxShops_BooksBooksId.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.booksRow).books_id;
                shops_booksRow.shops_books_shops_id = ((comboBoxShops_BooksShopsId.SelectedItem as DataRowView).Row
                    as publishing_houseDataSet.shopsRow).shops_id;

                shops_booksRow.shops_books_books_in_shops_count = (short)numericUpDownCountBooks.Value;
                shops_booksRow.shops_books_cost = (short)numericUpDownCostBook.Value;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /* var st = new System.Diagnostics.StackTrace(e, true);
                     var frame = st.GetFrame(0);
                     MessageBox.Show(frame.GetFileLineNumber().ToString());*/
                DBHelper.InsertErrorInLogTable(DateTime.Now, ex.Message);
            }
            finally
            {
                shops_booksBindingNavigator.Enabled = true;
                shops_booksDataGridView.Enabled = true;
                groupBoxSearchShops_Books.Enabled = true;
                groupBoxEditShops_Books.Enabled = false;
                shops_booksBindingNavigator.Focus();
            }
        }

        private void buttonCancelShops_Books_Click(object sender, EventArgs e)
        {
            if (shops_booksDataGridView.CurrentRow.Cells[1].Value == DBNull.Value)
                shops_booksDataGridView.Rows.Remove(shops_booksDataGridView.CurrentRow);

            groupBoxSearchShops_Books.Enabled = true;
            shops_booksDataGridView.Invoke((Action<object, EventArgs>)shops_booksDataGridView_SelectionChanged, shops_booksDataGridView, null);

            shops_booksBindingNavigator.Enabled = true;
            shops_booksDataGridView.Enabled = true;
            groupBoxEditShops_Books.Enabled = false;
        }

        private void comboBoxCriterionAuthorBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCriterionAuthorBook.SelectedIndex == 0)
                textBoxConditionAuthorBooks.MaxLength = 40;
            else if (comboBoxCriterionAuthorBook.SelectedIndex == 1)
                textBoxConditionAuthorBooks.MaxLength = 25;
        }

        private void fillTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlFacts.TabPages.Insert(tabControlFacts.TabPages.Count, tabPageShopsBooks);
        }

        private void toolStripComboBoxCriterionView_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxCriterionView.SelectedIndex == 0)
                toolStripTextBoxConditionView.MaxLength = 50;
            else if (toolStripComboBoxCriterionView.SelectedIndex == 1)
                toolStripTextBoxConditionView.MaxLength = 40;
        }

        private void shops_nameDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void genresDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var datagrid = genresDataGridView;
            MessageBox.Show(e.Exception.Message);
            datagrid.Rows.Remove(datagrid.Rows[e.RowIndex]);
        }


        private void toolStripButtonSearchByParam_Click(object sender, EventArgs e)
        {
            int index = toolStripComboBoxCriterionView.SelectedIndex;
            string condition = toolStripTextBoxConditionView.Text.Trim();
            if (index == -1)
            {
                MessageBox.Show("Не выбран критерий", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(condition))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.shopsBooksNamedTableAdapter.FillBy(publishing_houseDataSet.ShopsBooksNamed,
                DBHelper.ColumnsNameViewDictionary[index], condition);

        }

        private void toolStripButtonUpdateView_Click(object sender, EventArgs e)
        {
            this.shopsBooksNamedTableAdapter.Fill(publishing_houseDataSet.ShopsBooksNamed);
        }

        private void toolStripButtonPrintView_Click(object sender, EventArgs e)
        {
            int index = toolStripComboBoxCriterionView.SelectedIndex;
            string condition = toolStripTextBoxConditionView.Text.Trim();
            if (index == -1)
            {
                MessageBox.Show("Не выбран критерий", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(condition))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(shopsBooksNamedDataGridView);
        }
        //-------------------------------------------
        private void genresDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            toolStripButtonCancelGenres.Tag = genresDataGridView.CurrentCell.Value;
            ChangeEnableAllButtons(genresBindingNavigator, false);
            toolStripButtonCancelGenres.Enabled = true;
        }

        private void genresDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = genresDataGridView.CurrentCell.Value as string;
            string lastValue = toolStripButtonCancelGenres.Tag as string;
            if (!string.IsNullOrEmpty(cellValue))
                ChangeEnableAllButtons(genresBindingNavigator, true);

            else if (!string.IsNullOrEmpty(lastValue))
            {
                genresDataGridView.CurrentCell.Value = lastValue;
            }
            toolStripButtonCancelGenres.Enabled = false;
        }

        private void genresDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                errorProvider.SetError(genresDataGridView, "Пустая строка");
                genresDataGridView.Rows[e.RowIndex].ErrorText = errorProvider.GetError(genresDataGridView);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
                genresDataGridView.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void bindingNavigatorAddNewItem2_Click(object sender, EventArgs e)
        {

            genresDataGridView.CurrentCell = genresDataGridView.Rows[genresBindingSource.Count - 1].Cells[1];
            genresDataGridView.InvalidateCell(genresDataGridView.CurrentCell);
            ChangeEnableAllButtons(genresBindingNavigator, false);
            genresDataGridView.BeginEdit(false);
            genresDataGridView.CausesValidation = true;
        }

        private void toolStripButtonSaveGenre_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.genresBindingSource.EndEdit();
            this.genresTableAdapter.Update(publishing_houseDataSet.genres);
        }

        private void toolStripButtonUpdateGenres_Click(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.publishing_houseDataSet.genres);
        }

        private void toolStripButtonCancelGenres_Click(object sender, EventArgs e)
        {
            string oldCellValue = toolStripButtonCancelGenres.Tag as string;
            if (string.IsNullOrEmpty(oldCellValue))
            {
                genresDataGridView.Rows.Remove(genresDataGridView.CurrentRow);
            }
            else
            {
                string editing = genresDataGridView.CurrentCell.EditedFormattedValue as string;
                if (string.IsNullOrEmpty(editing))
                {
                    genresDataGridView.CurrentCell.Value = oldCellValue;
                    genresDataGridView.EndEdit();


                }
                else
                {
                    genresDataGridView.EndEdit();
                    genresDataGridView.CurrentCell.Value = oldCellValue;
                }
            }
            ChangeEnableAllButtons(genresBindingNavigator, true);
            toolStripButtonCancelGenres.Enabled = false;
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            string text = toolStripTextBoxConditionGenres.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.genresTableAdapter.FillBy(this.publishing_houseDataSet.genres, text);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {

            string condition = toolStripTextBoxConditionGenres.Text.Trim();

            if (string.IsNullOrWhiteSpace(condition))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(editorsDataGridView);
        }

        //--------------------------------------------------------------------------
        private void shops_nameDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            toolStripButtonCancelEditingShopsName.Tag = shops_nameDataGridView.CurrentCell.Value;
            
            ChangeEnableAllButtons(shops_nameBindingNavigator, false);
            toolStripButtonCancelEditingShopsName.Enabled = true;
        }

        private void shops_nameDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = shops_nameDataGridView.CurrentCell.Value as string;
            string lastValue = toolStripButtonCancelEditingShopsName.Tag as string;
           
            if (!string.IsNullOrEmpty(cellValue))
                ChangeEnableAllButtons(shops_nameBindingNavigator, true);

            else if (!string.IsNullOrEmpty(lastValue))
            {
                shops_nameDataGridView.CurrentCell.Value = lastValue;
            }
            toolStripButtonCancelEditingShopsName.Enabled = false;
        }

        private void shops_nameDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                errorProvider.SetError(shops_nameDataGridView, "Пустая строка");
                shops_nameDataGridView.Rows[e.RowIndex].ErrorText = errorProvider.GetError(shops_nameDataGridView);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
                shops_nameDataGridView.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void bindingNavigatorAddNewItem3_Click(object sender, EventArgs e)
        {
            shops_nameDataGridView.CurrentCell = shops_nameDataGridView.Rows[shops_nameBindingSource.Count - 1].Cells[1];
            shops_nameDataGridView.InvalidateCell(shops_nameDataGridView.CurrentCell);
            ChangeEnableAllButtons(shops_nameBindingNavigator, false);
            shops_nameDataGridView.BeginEdit(false);
            shops_nameDataGridView.CausesValidation = true;
        }

        private void toolStripButtonCancelEditingShopsName_Click(object sender, EventArgs e)
        {
            string oldCellValue = toolStripButtonCancelEditingShopsName.Tag as string;
            if (string.IsNullOrEmpty(oldCellValue))
            {
                shops_nameDataGridView.Rows.Remove(shops_nameDataGridView.CurrentRow);
            }
            else
            {
                string editing = shops_nameDataGridView.CurrentCell.EditedFormattedValue as string;
                if (string.IsNullOrEmpty(editing))
                {
                    shops_nameDataGridView.CurrentCell.Value = oldCellValue;
                    shops_nameDataGridView.EndEdit();
                }
                else
                {
                    shops_nameDataGridView.EndEdit();
                    shops_nameDataGridView.CurrentCell.Value = oldCellValue;
                }
            }
            ChangeEnableAllButtons(shops_nameBindingNavigator, true);
            toolStripButtonCancelEditingShopsName.Enabled = false;
        }

        private void toolStripButtonSaveShopsName_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shops_nameBindingSource.EndEdit();
            this.shops_nameTableAdapter.Update(publishing_houseDataSet.shops_name);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.shops_nameTableAdapter.Fill(this.publishing_houseDataSet.shops_name);
        }

        private void toolStripButtonSearchShopsName_Click(object sender, EventArgs e)
        {
            string text = toolStripTextBoxConditionShopsName.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.shops_nameTableAdapter.FillBy(this.publishing_houseDataSet.shops_name, text);


        }

        private void toolStripButtonPrintShopsNames_Click(object sender, EventArgs e)
        {
            string condition = toolStripTextBoxConditionShopsName.Text.Trim();

            if (string.IsNullOrWhiteSpace(condition))
            {
                MessageBox.Show("Не набрано условие", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDataGridView(shops_nameDataGridView);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            bool successFill = false;
            while (!successFill)
            {

                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    successFill = true;
                }
                else if (authForm.DialogResult != DialogResult.Retry)
                {
                    Environment.Exit(0);
                    break;
                }
            }
            MakeDisabledGroupBoxes();
            toolStripButtonCancelEditingShopsName.Enabled = false;
            toolStripButtonCancelGenres.Enabled = false;
            SetPermissions();
            this.Show();

        }

        private void booksLogTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Controls.Add(new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile(_path),
                SizeMode = PictureBoxSizeMode.StretchImage
        });


            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            
        }

        private void tabPageGenres_Leave(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.publishing_houseDataSet.genres);
        }

        private void tabPageHandbook_Leave(object sender, EventArgs e)
        {
            this.shops_nameTableAdapter.Fill(this.publishing_houseDataSet.shops_name);
        }
    }
}

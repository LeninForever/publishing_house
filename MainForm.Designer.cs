
namespace kursach_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageFacts = new System.Windows.Forms.TabPage();
            this.tabControlFacts = new System.Windows.Forms.TabControl();
            this.tabPageAuthorsBooks = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.author_bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnAuthorBooksId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAuthorBooksBook = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishing_houseDataSet = new kursach_1.publishing_houseDataSet();
            this.dataGridViewTextBoxColumnAuthorBooksAuthor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.author_bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.author_bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.author_bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditAuthorBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateBooksAuthors = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditAuthorBook = new System.Windows.Forms.GroupBox();
            this.labelAuthorBooksAuthors = new System.Windows.Forms.Label();
            this.comboBoxAuthorBooksAuthor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveAuthorBook = new System.Windows.Forms.Button();
            this.comboBoxAuthorBooksBook = new System.Windows.Forms.ComboBox();
            this.buttonCancelAuthorBook = new System.Windows.Forms.Button();
            this.groupBoxSearchAuthorBooks = new System.Windows.Forms.GroupBox();
            this.buttonPrintQueryAuthorBook = new System.Windows.Forms.Button();
            this.buttonQueryAuthorBooks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConditionAuthorBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCriterionAuthorBook = new System.Windows.Forms.ComboBox();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveAuthorItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditAuthorItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateAuthorItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditAuthor = new System.Windows.Forms.GroupBox();
            this.buttonSaveAuthorEditing = new System.Windows.Forms.Button();
            this.buttonCancelAuthorEditing = new System.Windows.Forms.Button();
            this.dateTimePickerAuthorBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAuthorPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.buttonPrintAuthor = new System.Windows.Forms.Button();
            this.buttonQueryAuthor = new System.Windows.Forms.Button();
            this.textBoxConditionAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCriterionAuthor = new System.Windows.Forms.ComboBox();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.designersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem8 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem8 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem8 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveBooksItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditBooksItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateBooksItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditBook = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonCancelEditBook = new System.Windows.Forms.Button();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.textBoxBooksName = new System.Windows.Forms.TextBox();
            this.numericUpDownBooksPublishingYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBooksPages = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBooksDesigner = new System.Windows.Forms.ComboBox();
            this.comboBoxBooksEditor = new System.Windows.Forms.ComboBox();
            this.comboBoxBooksGenre = new System.Windows.Forms.ComboBox();
            this.groupBoxSearchBook = new System.Windows.Forms.GroupBox();
            this.comboBoxConditionBooks = new System.Windows.Forms.ComboBox();
            this.buttonPrintQueryBook = new System.Windows.Forms.Button();
            this.buttonQueryBooks = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxCriterionBook = new System.Windows.Forms.ComboBox();
            this.tabPageDesigners = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.designersDataGridView = new System.Windows.Forms.DataGridView();
            this.designersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerpatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersnumberphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersbirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveDesignersItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditDesignerItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateDesignersItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditDesigner = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDesignerNumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.buttonSaveDesigner = new System.Windows.Forms.Button();
            this.buttonCancelEditingDesigner = new System.Windows.Forms.Button();
            this.dateTimePickerDesignerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesignerPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxDesignerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxDesignerLastName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBoxSearchDesigner = new System.Windows.Forms.GroupBox();
            this.buttonPrintDesigner = new System.Windows.Forms.Button();
            this.buttonQueryDesigner = new System.Windows.Forms.Button();
            this.textBoxConditionDesigner = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCriterionDesigner = new System.Windows.Forms.ComboBox();
            this.tabPageEditors = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.editorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveEditorsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditEditorsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateEditorsItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditEditors = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxEditorsNumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.buttonSaveEditors = new System.Windows.Forms.Button();
            this.buttonCancelEditEditors = new System.Windows.Forms.Button();
            this.dateTimePickerEdtirosBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditorsPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxEditorsFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEditorsLastName = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBoxSearchEditor = new System.Windows.Forms.GroupBox();
            this.buttonPrintQueryEditors = new System.Windows.Forms.Button();
            this.buttonQueryEditor = new System.Windows.Forms.Button();
            this.textBoxConditionEditor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxCriterionEditor = new System.Windows.Forms.ComboBox();
            this.tabPageShops = new System.Windows.Forms.TabPage();
            this.splitContainerShops = new System.Windows.Forms.SplitContainer();
            this.shopsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shops_nameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem6 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem6 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveShopsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditShopsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateShopsItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditShops = new System.Windows.Forms.GroupBox();
            this.buttonSaveShop = new System.Windows.Forms.Button();
            this.buttonCancelEditingShops = new System.Windows.Forms.Button();
            this.comboBoxShopsName = new System.Windows.Forms.ComboBox();
            this.shopsnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBoxShopsNumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxShopsAddress = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBoxSearchShops = new System.Windows.Forms.GroupBox();
            this.comboBoxConditionShops = new System.Windows.Forms.ComboBox();
            this.buttonPrintShops = new System.Windows.Forms.Button();
            this.buttonQueryShops = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageShopsBooksForAdmin = new System.Windows.Forms.TabPage();
            this.splitContainerBooksInShops = new System.Windows.Forms.SplitContainer();
            this.shops_booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shops_booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shops_booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem7 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem7 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveBooksInShopsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditBooksInShopsItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateShopsInBooks = new System.Windows.Forms.ToolStripButton();
            this.groupBoxEditShops_Books = new System.Windows.Forms.GroupBox();
            this.buttonCancelShops_Books = new System.Windows.Forms.Button();
            this.buttonSaveShops_Books = new System.Windows.Forms.Button();
            this.numericUpDownCostBook = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountBooks = new System.Windows.Forms.NumericUpDown();
            this.comboBoxShops_BooksBooksId = new System.Windows.Forms.ComboBox();
            this.comboBoxShops_BooksShopsId = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxSearchShops_Books = new System.Windows.Forms.GroupBox();
            this.textBoxCondtitionBooksName = new System.Windows.Forms.TextBox();
            this.buttonPrintQueryBooksShops = new System.Windows.Forms.Button();
            this.buttonQueryBooksShops = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPageShopsBooks = new System.Windows.Forms.TabPage();
            this.shopsBooksNamedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopsBooksNamedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorView = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem9 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem9 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem9 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem9 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem9 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem9 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdateView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxCriterionView = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxConditionView = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearchByParam = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageHandbook = new System.Windows.Forms.TabPage();
            this.tabControlHandBook = new System.Windows.Forms.TabControl();
            this.tabPageGenres = new System.Windows.Forms.TabPage();
            this.genresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnGenreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxConditionGenres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancelGenres = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveGenre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateGenres = new System.Windows.Forms.ToolStripButton();
            this.tabPageShopsNames = new System.Windows.Forms.TabPage();
            this.shops_nameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shops_nameBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxConditionShopsName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearchShopsName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintShopsNames = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancelEditingShopsName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveShopsName = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.logTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorLogs = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem10 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem9 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem10 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem10 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem10 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem10 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem10 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.author_bookTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.author_bookTableAdapter();
            this.tableAdapterManager = new kursach_1.publishing_houseDataSetTableAdapters.TableAdapterManager();
            this.authorsTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.authorsTableAdapter();
            this.booksTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.booksTableAdapter();
            this.genresTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.genresTableAdapter();
            this.publishinghouseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorsTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.editorsTableAdapter();
            this.shops_nameTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.shops_nameTableAdapter();
            this.designersTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.designersTableAdapter();
            this.shopsTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.shopsTableAdapter();
            this.shops_booksTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.shops_booksTableAdapter();
            this.fKbooksdesignerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKshopsbooksshopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addAuthorAndBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addAuthorAndBookTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.AddAuthorAndBookTableAdapter();
            this.logTableTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.LogTableTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.shopsBooksNamedTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.ShopsBooksNamedTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogsErrors = new System.Windows.Forms.TabPage();
            this.tabPageOperationsBooksTable = new System.Windows.Forms.TabPage();
            this.booksLogTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksLogTableTableAdapter = new kursach_1.publishing_houseDataSetTableAdapters.booksLogTableTableAdapter();
            this.booksLogTableDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem11 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem11 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem11 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem11 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem11 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem11 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem10 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPageFacts.SuspendLayout();
            this.tabControlFacts.SuspendLayout();
            this.tabPageAuthorsBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.author_bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishing_houseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_bookBindingNavigator)).BeginInit();
            this.author_bookBindingNavigator.SuspendLayout();
            this.groupBoxEditAuthorBook.SuspendLayout();
            this.groupBoxSearchAuthorBooks.SuspendLayout();
            this.tabPageAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).BeginInit();
            this.authorsBindingNavigator.SuspendLayout();
            this.groupBoxEditAuthor.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            this.groupBoxEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooksPublishingYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooksPages)).BeginInit();
            this.groupBoxSearchBook.SuspendLayout();
            this.tabPageDesigners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingNavigator)).BeginInit();
            this.designersBindingNavigator.SuspendLayout();
            this.groupBoxEditDesigner.SuspendLayout();
            this.groupBoxSearchDesigner.SuspendLayout();
            this.tabPageEditors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingNavigator)).BeginInit();
            this.editorsBindingNavigator.SuspendLayout();
            this.groupBoxEditEditors.SuspendLayout();
            this.groupBoxSearchEditor.SuspendLayout();
            this.tabPageShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShops)).BeginInit();
            this.splitContainerShops.Panel1.SuspendLayout();
            this.splitContainerShops.Panel2.SuspendLayout();
            this.splitContainerShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingNavigator)).BeginInit();
            this.shopsBindingNavigator.SuspendLayout();
            this.groupBoxEditShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsnameBindingSource)).BeginInit();
            this.groupBoxSearchShops.SuspendLayout();
            this.tabPageShopsBooksForAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksInShops)).BeginInit();
            this.splitContainerBooksInShops.Panel1.SuspendLayout();
            this.splitContainerBooksInShops.Panel2.SuspendLayout();
            this.splitContainerBooksInShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksBindingNavigator)).BeginInit();
            this.shops_booksBindingNavigator.SuspendLayout();
            this.groupBoxEditShops_Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBooks)).BeginInit();
            this.groupBoxSearchShops_Books.SuspendLayout();
            this.tabPageShopsBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBooksNamedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBooksNamedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorView)).BeginInit();
            this.bindingNavigatorView.SuspendLayout();
            this.tabPageHandbook.SuspendLayout();
            this.tabControlHandBook.SuspendLayout();
            this.tabPageGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).BeginInit();
            this.genresBindingNavigator.SuspendLayout();
            this.tabPageShopsNames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameBindingNavigator)).BeginInit();
            this.shops_nameBindingNavigator.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLogs)).BeginInit();
            this.bindingNavigatorLogs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbooksdesignerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKshopsbooksshopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAuthorAndBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLogsErrors.SuspendLayout();
            this.tabPageOperationsBooksTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksLogTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksLogTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageFacts);
            this.tabControlMain.Controls.Add(this.tabPageHandbook);
            this.tabControlMain.Controls.Add(this.tabPageLogs);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1246, 549);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageFacts
            // 
            this.tabPageFacts.Controls.Add(this.tabControlFacts);
            this.tabPageFacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageFacts.Name = "tabPageFacts";
            this.tabPageFacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFacts.Size = new System.Drawing.Size(1238, 523);
            this.tabPageFacts.TabIndex = 0;
            this.tabPageFacts.Text = "Таблицы фактов";
            this.tabPageFacts.UseVisualStyleBackColor = true;
            // 
            // tabControlFacts
            // 
            this.tabControlFacts.Controls.Add(this.tabPageAuthorsBooks);
            this.tabControlFacts.Controls.Add(this.tabPageAuthors);
            this.tabControlFacts.Controls.Add(this.tabPageBooks);
            this.tabControlFacts.Controls.Add(this.tabPageDesigners);
            this.tabControlFacts.Controls.Add(this.tabPageEditors);
            this.tabControlFacts.Controls.Add(this.tabPageShops);
            this.tabControlFacts.Controls.Add(this.tabPageShopsBooksForAdmin);
            this.tabControlFacts.Controls.Add(this.tabPageShopsBooks);
            this.tabControlFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFacts.Location = new System.Drawing.Point(3, 3);
            this.tabControlFacts.Name = "tabControlFacts";
            this.tabControlFacts.SelectedIndex = 0;
            this.tabControlFacts.Size = new System.Drawing.Size(1232, 517);
            this.tabControlFacts.TabIndex = 0;
            // 
            // tabPageAuthorsBooks
            // 
            this.tabPageAuthorsBooks.AutoScroll = true;
            this.tabPageAuthorsBooks.Controls.Add(this.splitContainer1);
            this.tabPageAuthorsBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuthorsBooks.Name = "tabPageAuthorsBooks";
            this.tabPageAuthorsBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthorsBooks.Size = new System.Drawing.Size(1224, 491);
            this.tabPageAuthorsBooks.TabIndex = 0;
            this.tabPageAuthorsBooks.Text = "Авторы и книги";
            this.tabPageAuthorsBooks.UseVisualStyleBackColor = true;
            this.tabPageAuthorsBooks.Leave += new System.EventHandler(this.tabPageAuthorsBooks_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.author_bookDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.author_bookBindingNavigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxEditAuthorBook);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSearchAuthorBooks);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(1218, 485);
            this.splitContainer1.SplitterDistance = 791;
            this.splitContainer1.TabIndex = 5;
            // 
            // author_bookDataGridView
            // 
            this.author_bookDataGridView.AllowUserToAddRows = false;
            this.author_bookDataGridView.AutoGenerateColumns = false;
            this.author_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.author_bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnAuthorBooksId,
            this.dataGridViewTextBoxColumnAuthorBooksBook,
            this.dataGridViewTextBoxColumnAuthorBooksAuthor});
            this.author_bookDataGridView.DataSource = this.author_bookBindingSource;
            this.author_bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.author_bookDataGridView.Location = new System.Drawing.Point(0, 25);
            this.author_bookDataGridView.MultiSelect = false;
            this.author_bookDataGridView.Name = "author_bookDataGridView";
            this.author_bookDataGridView.ReadOnly = true;
            this.author_bookDataGridView.Size = new System.Drawing.Size(791, 460);
            this.author_bookDataGridView.TabIndex = 0;
            this.author_bookDataGridView.SelectionChanged += new System.EventHandler(this.author_bookDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumnAuthorBooksId
            // 
            this.dataGridViewTextBoxColumnAuthorBooksId.DataPropertyName = "authror_books_id";
            this.dataGridViewTextBoxColumnAuthorBooksId.HeaderText = "id";
            this.dataGridViewTextBoxColumnAuthorBooksId.Name = "dataGridViewTextBoxColumnAuthorBooksId";
            this.dataGridViewTextBoxColumnAuthorBooksId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnAuthorBooksBook
            // 
            this.dataGridViewTextBoxColumnAuthorBooksBook.DataPropertyName = "author_books_books_id";
            this.dataGridViewTextBoxColumnAuthorBooksBook.DataSource = this.booksBindingSource;
            this.dataGridViewTextBoxColumnAuthorBooksBook.DisplayMember = "books_name";
            this.dataGridViewTextBoxColumnAuthorBooksBook.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumnAuthorBooksBook.HeaderText = "Книга";
            this.dataGridViewTextBoxColumnAuthorBooksBook.Name = "dataGridViewTextBoxColumnAuthorBooksBook";
            this.dataGridViewTextBoxColumnAuthorBooksBook.ReadOnly = true;
            this.dataGridViewTextBoxColumnAuthorBooksBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumnAuthorBooksBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumnAuthorBooksBook.ValueMember = "books_id";
            this.dataGridViewTextBoxColumnAuthorBooksBook.Width = 300;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // publishing_houseDataSet
            // 
            this.publishing_houseDataSet.DataSetName = "publishing_houseDataSet";
            this.publishing_houseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumnAuthorBooksAuthor
            // 
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.DataPropertyName = "author_books_author_id";
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.DataSource = this.authorsBindingSource;
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.DisplayMember = "authors_last_name";
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.HeaderText = "Автор";
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.Name = "dataGridViewTextBoxColumnAuthorBooksAuthor";
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.ReadOnly = true;
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.ValueMember = "authors_id";
            this.dataGridViewTextBoxColumnAuthorBooksAuthor.Width = 200;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // author_bookBindingSource
            // 
            this.author_bookBindingSource.DataMember = "author_book";
            this.author_bookBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // author_bookBindingNavigator
            // 
            this.author_bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.author_bookBindingNavigator.BindingSource = this.author_bookBindingSource;
            this.author_bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.author_bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.author_bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.author_bookBindingNavigatorSaveItem,
            this.toolStripButtonEditAuthorBook,
            this.toolStripButtonUpdateBooksAuthors});
            this.author_bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.author_bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.author_bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.author_bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.author_bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.author_bookBindingNavigator.Name = "author_bookBindingNavigator";
            this.author_bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.author_bookBindingNavigator.Size = new System.Drawing.Size(791, 25);
            this.author_bookBindingNavigator.TabIndex = 4;
            this.author_bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // author_bookBindingNavigatorSaveItem
            // 
            this.author_bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.author_bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("author_bookBindingNavigatorSaveItem.Image")));
            this.author_bookBindingNavigatorSaveItem.Name = "author_bookBindingNavigatorSaveItem";
            this.author_bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.author_bookBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.author_bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.author_bookBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonEditAuthorBook
            // 
            this.toolStripButtonEditAuthorBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditAuthorBook.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditAuthorBook.Image")));
            this.toolStripButtonEditAuthorBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditAuthorBook.Name = "toolStripButtonEditAuthorBook";
            this.toolStripButtonEditAuthorBook.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditAuthorBook.Text = "Редактировать";
            this.toolStripButtonEditAuthorBook.Click += new System.EventHandler(this.toolStripButtonEditAuthorBook_Click);
            // 
            // toolStripButtonUpdateBooksAuthors
            // 
            this.toolStripButtonUpdateBooksAuthors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateBooksAuthors.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateBooksAuthors.Image")));
            this.toolStripButtonUpdateBooksAuthors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateBooksAuthors.Name = "toolStripButtonUpdateBooksAuthors";
            this.toolStripButtonUpdateBooksAuthors.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateBooksAuthors.Text = "Обновить";
            this.toolStripButtonUpdateBooksAuthors.Click += new System.EventHandler(this.toolStripButtonUpdateBooksAuthors_Click);
            // 
            // groupBoxEditAuthorBook
            // 
            this.groupBoxEditAuthorBook.Controls.Add(this.labelAuthorBooksAuthors);
            this.groupBoxEditAuthorBook.Controls.Add(this.comboBoxAuthorBooksAuthor);
            this.groupBoxEditAuthorBook.Controls.Add(this.label2);
            this.groupBoxEditAuthorBook.Controls.Add(this.buttonSaveAuthorBook);
            this.groupBoxEditAuthorBook.Controls.Add(this.comboBoxAuthorBooksBook);
            this.groupBoxEditAuthorBook.Controls.Add(this.buttonCancelAuthorBook);
            this.groupBoxEditAuthorBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditAuthorBook.Location = new System.Drawing.Point(0, 278);
            this.groupBoxEditAuthorBook.Name = "groupBoxEditAuthorBook";
            this.groupBoxEditAuthorBook.Size = new System.Drawing.Size(423, 204);
            this.groupBoxEditAuthorBook.TabIndex = 7;
            this.groupBoxEditAuthorBook.TabStop = false;
            this.groupBoxEditAuthorBook.Text = "Редактирование";
            // 
            // labelAuthorBooksAuthors
            // 
            this.labelAuthorBooksAuthors.AutoSize = true;
            this.labelAuthorBooksAuthors.Location = new System.Drawing.Point(6, 36);
            this.labelAuthorBooksAuthors.Name = "labelAuthorBooksAuthors";
            this.labelAuthorBooksAuthors.Size = new System.Drawing.Size(53, 20);
            this.labelAuthorBooksAuthors.TabIndex = 0;
            this.labelAuthorBooksAuthors.Text = "Книга";
            // 
            // comboBoxAuthorBooksAuthor
            // 
            this.comboBoxAuthorBooksAuthor.DataSource = this.authorsBindingSource;
            this.comboBoxAuthorBooksAuthor.DisplayMember = "authors_last_name";
            this.comboBoxAuthorBooksAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthorBooksAuthor.FormattingEnabled = true;
            this.comboBoxAuthorBooksAuthor.Location = new System.Drawing.Point(88, 36);
            this.comboBoxAuthorBooksAuthor.Name = "comboBoxAuthorBooksAuthor";
            this.comboBoxAuthorBooksAuthor.Size = new System.Drawing.Size(309, 28);
            this.comboBoxAuthorBooksAuthor.TabIndex = 3;
            this.comboBoxAuthorBooksAuthor.ValueMember = "authors_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор";
            // 
            // buttonSaveAuthorBook
            // 
            this.buttonSaveAuthorBook.Location = new System.Drawing.Point(284, 164);
            this.buttonSaveAuthorBook.Name = "buttonSaveAuthorBook";
            this.buttonSaveAuthorBook.Size = new System.Drawing.Size(133, 34);
            this.buttonSaveAuthorBook.TabIndex = 4;
            this.buttonSaveAuthorBook.Text = "Сохранить";
            this.buttonSaveAuthorBook.UseVisualStyleBackColor = true;
            this.buttonSaveAuthorBook.Click += new System.EventHandler(this.buttonSaveAuthorBook_Click);
            // 
            // comboBoxAuthorBooksBook
            // 
            this.comboBoxAuthorBooksBook.DataSource = this.booksBindingSource;
            this.comboBoxAuthorBooksBook.DisplayMember = "books_name";
            this.comboBoxAuthorBooksBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthorBooksBook.FormattingEnabled = true;
            this.comboBoxAuthorBooksBook.Location = new System.Drawing.Point(88, 76);
            this.comboBoxAuthorBooksBook.Name = "comboBoxAuthorBooksBook";
            this.comboBoxAuthorBooksBook.Size = new System.Drawing.Size(309, 28);
            this.comboBoxAuthorBooksBook.TabIndex = 2;
            this.comboBoxAuthorBooksBook.ValueMember = "books_id";
            // 
            // buttonCancelAuthorBook
            // 
            this.buttonCancelAuthorBook.Location = new System.Drawing.Point(13, 164);
            this.buttonCancelAuthorBook.Name = "buttonCancelAuthorBook";
            this.buttonCancelAuthorBook.Size = new System.Drawing.Size(133, 34);
            this.buttonCancelAuthorBook.TabIndex = 5;
            this.buttonCancelAuthorBook.Text = "Отмена";
            this.buttonCancelAuthorBook.UseVisualStyleBackColor = true;
            this.buttonCancelAuthorBook.Click += new System.EventHandler(this.buttonCancelAuthorBook_Click);
            // 
            // groupBoxSearchAuthorBooks
            // 
            this.groupBoxSearchAuthorBooks.Controls.Add(this.buttonPrintQueryAuthorBook);
            this.groupBoxSearchAuthorBooks.Controls.Add(this.buttonQueryAuthorBooks);
            this.groupBoxSearchAuthorBooks.Controls.Add(this.label3);
            this.groupBoxSearchAuthorBooks.Controls.Add(this.textBoxConditionAuthorBooks);
            this.groupBoxSearchAuthorBooks.Controls.Add(this.label1);
            this.groupBoxSearchAuthorBooks.Controls.Add(this.comboBoxCriterionAuthorBook);
            this.groupBoxSearchAuthorBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchAuthorBooks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchAuthorBooks.Name = "groupBoxSearchAuthorBooks";
            this.groupBoxSearchAuthorBooks.Size = new System.Drawing.Size(423, 278);
            this.groupBoxSearchAuthorBooks.TabIndex = 6;
            this.groupBoxSearchAuthorBooks.TabStop = false;
            this.groupBoxSearchAuthorBooks.Text = "Поиск";
            // 
            // buttonPrintQueryAuthorBook
            // 
            this.buttonPrintQueryAuthorBook.Location = new System.Drawing.Point(88, 194);
            this.buttonPrintQueryAuthorBook.Name = "buttonPrintQueryAuthorBook";
            this.buttonPrintQueryAuthorBook.Size = new System.Drawing.Size(255, 31);
            this.buttonPrintQueryAuthorBook.TabIndex = 5;
            this.buttonPrintQueryAuthorBook.Text = "Печать запроса";
            this.buttonPrintQueryAuthorBook.UseVisualStyleBackColor = true;
            this.buttonPrintQueryAuthorBook.Click += new System.EventHandler(this.buttonPrintQueryAuthorBook_Click);
            // 
            // buttonQueryAuthorBooks
            // 
            this.buttonQueryAuthorBooks.Location = new System.Drawing.Point(88, 157);
            this.buttonQueryAuthorBooks.Name = "buttonQueryAuthorBooks";
            this.buttonQueryAuthorBooks.Size = new System.Drawing.Size(255, 31);
            this.buttonQueryAuthorBooks.TabIndex = 4;
            this.buttonQueryAuthorBooks.Text = "Выполнить запрос";
            this.buttonQueryAuthorBooks.UseVisualStyleBackColor = true;
            this.buttonQueryAuthorBooks.Click += new System.EventHandler(this.buttonQueryAuthorBooks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Критерий выборки";
            // 
            // textBoxConditionAuthorBooks
            // 
            this.textBoxConditionAuthorBooks.Location = new System.Drawing.Point(162, 79);
            this.textBoxConditionAuthorBooks.Name = "textBoxConditionAuthorBooks";
            this.textBoxConditionAuthorBooks.Size = new System.Drawing.Size(235, 26);
            this.textBoxConditionAuthorBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Условие выборки";
            // 
            // comboBoxCriterionAuthorBook
            // 
            this.comboBoxCriterionAuthorBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterionAuthorBook.FormattingEnabled = true;
            this.comboBoxCriterionAuthorBook.Location = new System.Drawing.Point(162, 25);
            this.comboBoxCriterionAuthorBook.Name = "comboBoxCriterionAuthorBook";
            this.comboBoxCriterionAuthorBook.Size = new System.Drawing.Size(235, 28);
            this.comboBoxCriterionAuthorBook.TabIndex = 0;
            this.comboBoxCriterionAuthorBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterionAuthorBook_SelectedIndexChanged);
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Controls.Add(this.splitContainer5);
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthors.Size = new System.Drawing.Size(1224, 491);
            this.tabPageAuthors.TabIndex = 1;
            this.tabPageAuthors.Text = "Авторы";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            this.tabPageAuthors.Leave += new System.EventHandler(this.tabPageAuthors_Leave);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.AutoScroll = true;
            this.splitContainer5.Panel1.Controls.Add(this.authorsDataGridView);
            this.splitContainer5.Panel1.Controls.Add(this.authorsBindingNavigator);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.groupBoxEditAuthor);
            this.splitContainer5.Panel2.Controls.Add(this.groupBoxSearchAuthor);
            this.splitContainer5.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer5.Size = new System.Drawing.Size(1218, 485);
            this.splitContainer5.SplitterDistance = 743;
            this.splitContainer5.TabIndex = 0;
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.AllowUserToAddRows = false;
            this.authorsDataGridView.AutoGenerateColumns = false;
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.authorsDataGridView.DataSource = this.authorsBindingSource;
            this.authorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.authorsDataGridView.MultiSelect = false;
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.ReadOnly = true;
            this.authorsDataGridView.Size = new System.Drawing.Size(743, 460);
            this.authorsDataGridView.TabIndex = 0;
            this.authorsDataGridView.SelectionChanged += new System.EventHandler(this.authorsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "authors_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 20;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "authors_last_name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "authors_first_name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "autrhors_patronymic";
            this.dataGridViewTextBoxColumn14.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "authors_birthday";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // authorsBindingNavigator
            // 
            this.authorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.authorsBindingNavigator.BindingSource = this.authorsBindingSource;
            this.authorsBindingNavigator.CountItem = this.bindingNavigatorCountItem4;
            this.authorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.authorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4,
            this.toolStripButtonSaveAuthorItem,
            this.toolStripButtonEditAuthorItem,
            this.toolStripButtonUpdateAuthorItem});
            this.authorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.authorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.authorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.authorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.authorsBindingNavigator.Name = "authorsBindingNavigator";
            this.authorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem4;
            this.authorsBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.authorsBindingNavigator.TabIndex = 1;
            this.authorsBindingNavigator.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "Добавить";
            this.bindingNavigatorAddNewItem4.Click += new System.EventHandler(this.bindingNavigatorAddNewItem4_Click);
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem4.Text = "для {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveAuthorItem
            // 
            this.toolStripButtonSaveAuthorItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAuthorItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAuthorItem.Image")));
            this.toolStripButtonSaveAuthorItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAuthorItem.Name = "toolStripButtonSaveAuthorItem";
            this.toolStripButtonSaveAuthorItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveAuthorItem.Text = "Сохранить изменения";
            this.toolStripButtonSaveAuthorItem.Click += new System.EventHandler(this.toolStripButtonSaveAuthorItem_Click);
            // 
            // toolStripButtonEditAuthorItem
            // 
            this.toolStripButtonEditAuthorItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditAuthorItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditAuthorItem.Image")));
            this.toolStripButtonEditAuthorItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditAuthorItem.Name = "toolStripButtonEditAuthorItem";
            this.toolStripButtonEditAuthorItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditAuthorItem.Text = "Редактировать";
            this.toolStripButtonEditAuthorItem.Click += new System.EventHandler(this.toolStripButtonEditAuthorItem_Click);
            // 
            // toolStripButtonUpdateAuthorItem
            // 
            this.toolStripButtonUpdateAuthorItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateAuthorItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateAuthorItem.Image")));
            this.toolStripButtonUpdateAuthorItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateAuthorItem.Name = "toolStripButtonUpdateAuthorItem";
            this.toolStripButtonUpdateAuthorItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateAuthorItem.Text = "Перезагрузить";
            this.toolStripButtonUpdateAuthorItem.Click += new System.EventHandler(this.toolStripButtonUpdateAuthorItem_Click);
            // 
            // groupBoxEditAuthor
            // 
            this.groupBoxEditAuthor.Controls.Add(this.buttonSaveAuthorEditing);
            this.groupBoxEditAuthor.Controls.Add(this.buttonCancelAuthorEditing);
            this.groupBoxEditAuthor.Controls.Add(this.dateTimePickerAuthorBirthDate);
            this.groupBoxEditAuthor.Controls.Add(this.textBoxAuthorPatronymic);
            this.groupBoxEditAuthor.Controls.Add(this.textBoxAuthorFirstName);
            this.groupBoxEditAuthor.Controls.Add(this.textBoxAuthorLastName);
            this.groupBoxEditAuthor.Controls.Add(this.label9);
            this.groupBoxEditAuthor.Controls.Add(this.label8);
            this.groupBoxEditAuthor.Controls.Add(this.label7);
            this.groupBoxEditAuthor.Controls.Add(this.label6);
            this.groupBoxEditAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditAuthor.Location = new System.Drawing.Point(0, 244);
            this.groupBoxEditAuthor.Name = "groupBoxEditAuthor";
            this.groupBoxEditAuthor.Size = new System.Drawing.Size(471, 233);
            this.groupBoxEditAuthor.TabIndex = 1;
            this.groupBoxEditAuthor.TabStop = false;
            this.groupBoxEditAuthor.Text = "Редактирование";
            // 
            // buttonSaveAuthorEditing
            // 
            this.buttonSaveAuthorEditing.Location = new System.Drawing.Point(326, 187);
            this.buttonSaveAuthorEditing.Name = "buttonSaveAuthorEditing";
            this.buttonSaveAuthorEditing.Size = new System.Drawing.Size(133, 35);
            this.buttonSaveAuthorEditing.TabIndex = 9;
            this.buttonSaveAuthorEditing.Text = "Сохранить";
            this.buttonSaveAuthorEditing.UseVisualStyleBackColor = true;
            this.buttonSaveAuthorEditing.Click += new System.EventHandler(this.buttonSaveAuthorEditing_Click);
            // 
            // buttonCancelAuthorEditing
            // 
            this.buttonCancelAuthorEditing.Location = new System.Drawing.Point(9, 187);
            this.buttonCancelAuthorEditing.Name = "buttonCancelAuthorEditing";
            this.buttonCancelAuthorEditing.Size = new System.Drawing.Size(133, 35);
            this.buttonCancelAuthorEditing.TabIndex = 8;
            this.buttonCancelAuthorEditing.Text = "Отмена";
            this.buttonCancelAuthorEditing.UseVisualStyleBackColor = true;
            this.buttonCancelAuthorEditing.Click += new System.EventHandler(this.buttonCancelAuthorEditing_Click);
            // 
            // dateTimePickerAuthorBirthDate
            // 
            this.dateTimePickerAuthorBirthDate.Location = new System.Drawing.Point(144, 135);
            this.dateTimePickerAuthorBirthDate.Name = "dateTimePickerAuthorBirthDate";
            this.dateTimePickerAuthorBirthDate.Size = new System.Drawing.Size(289, 26);
            this.dateTimePickerAuthorBirthDate.TabIndex = 7;
            // 
            // textBoxAuthorPatronymic
            // 
            this.textBoxAuthorPatronymic.Location = new System.Drawing.Point(144, 103);
            this.textBoxAuthorPatronymic.MaxLength = 25;
            this.textBoxAuthorPatronymic.Name = "textBoxAuthorPatronymic";
            this.textBoxAuthorPatronymic.Size = new System.Drawing.Size(289, 26);
            this.textBoxAuthorPatronymic.TabIndex = 6;
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(144, 69);
            this.textBoxAuthorFirstName.MaxLength = 25;
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(289, 26);
            this.textBoxAuthorFirstName.TabIndex = 5;
            this.textBoxAuthorFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(144, 35);
            this.textBoxAuthorLastName.MaxLength = 25;
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(289, 26);
            this.textBoxAuthorLastName.TabIndex = 4;
            this.textBoxAuthorLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Фамилия";
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Controls.Add(this.buttonPrintAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.buttonQueryAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.textBoxConditionAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.label5);
            this.groupBoxSearchAuthor.Controls.Add(this.label4);
            this.groupBoxSearchAuthor.Controls.Add(this.comboBoxCriterionAuthor);
            this.groupBoxSearchAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(471, 244);
            this.groupBoxSearchAuthor.TabIndex = 0;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Поиск";
            // 
            // buttonPrintAuthor
            // 
            this.buttonPrintAuthor.Location = new System.Drawing.Point(113, 192);
            this.buttonPrintAuthor.Name = "buttonPrintAuthor";
            this.buttonPrintAuthor.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintAuthor.TabIndex = 8;
            this.buttonPrintAuthor.Text = "Печать запроса";
            this.buttonPrintAuthor.UseVisualStyleBackColor = true;
            this.buttonPrintAuthor.Click += new System.EventHandler(this.buttonPrintAuthor_Click);
            // 
            // buttonQueryAuthor
            // 
            this.buttonQueryAuthor.Location = new System.Drawing.Point(113, 144);
            this.buttonQueryAuthor.Name = "buttonQueryAuthor";
            this.buttonQueryAuthor.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryAuthor.TabIndex = 7;
            this.buttonQueryAuthor.Text = "Выполнить запрос";
            this.buttonQueryAuthor.UseVisualStyleBackColor = true;
            this.buttonQueryAuthor.Click += new System.EventHandler(this.buttonQueryAuthor_Click);
            // 
            // textBoxConditionAuthor
            // 
            this.textBoxConditionAuthor.Location = new System.Drawing.Point(162, 88);
            this.textBoxConditionAuthor.Name = "textBoxConditionAuthor";
            this.textBoxConditionAuthor.Size = new System.Drawing.Size(297, 26);
            this.textBoxConditionAuthor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Условие выборки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Критерий выборки";
            // 
            // comboBoxCriterionAuthor
            // 
            this.comboBoxCriterionAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterionAuthor.FormattingEnabled = true;
            this.comboBoxCriterionAuthor.Location = new System.Drawing.Point(162, 36);
            this.comboBoxCriterionAuthor.Name = "comboBoxCriterionAuthor";
            this.comboBoxCriterionAuthor.Size = new System.Drawing.Size(297, 28);
            this.comboBoxCriterionAuthor.TabIndex = 0;
            this.comboBoxCriterionAuthor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterionAuthor_SelectedIndexChanged);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.splitContainer6);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1224, 491);
            this.tabPageBooks.TabIndex = 2;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            this.tabPageBooks.Leave += new System.EventHandler(this.tabPageBooks_Leave);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.booksDataGridView);
            this.splitContainer6.Panel1.Controls.Add(this.booksBindingNavigator);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.groupBoxEditBook);
            this.splitContainer6.Panel2.Controls.Add(this.groupBoxSearchBook);
            this.splitContainer6.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer6.Size = new System.Drawing.Size(1218, 485);
            this.splitContainer6.SplitterDistance = 820;
            this.splitContainer6.TabIndex = 0;
            this.splitContainer6.TabStop = false;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksDataGridView.Location = new System.Drawing.Point(0, 25);
            this.booksDataGridView.MultiSelect = false;
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.Size = new System.Drawing.Size(820, 460);
            this.booksDataGridView.TabIndex = 0;
            this.booksDataGridView.TabStop = false;
            this.booksDataGridView.SelectionChanged += new System.EventHandler(this.booksDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "books_id";
            this.dataGridViewTextBoxColumn32.HeaderText = "id";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 20;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "books_name";
            this.dataGridViewTextBoxColumn33.HeaderText = "Название";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 200;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "books_publishing_year";
            this.dataGridViewTextBoxColumn34.HeaderText = "Год";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 50;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "books_pages";
            this.dataGridViewTextBoxColumn35.HeaderText = "Страниц";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 70;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "books_genre_id";
            this.dataGridViewTextBoxColumn36.DataSource = this.genresBindingSource;
            this.dataGridViewTextBoxColumn36.DisplayMember = "genre_name";
            this.dataGridViewTextBoxColumn36.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn36.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn36.ValueMember = "genre_id";
            this.dataGridViewTextBoxColumn36.Width = 120;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "genres";
            this.genresBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "books_editor_id";
            this.dataGridViewTextBoxColumn37.DataSource = this.editorsBindingSource;
            this.dataGridViewTextBoxColumn37.DisplayMember = "editors_last_name";
            this.dataGridViewTextBoxColumn37.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn37.HeaderText = "Редактор";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn37.ValueMember = "editors_id";
            this.dataGridViewTextBoxColumn37.Width = 150;
            // 
            // editorsBindingSource
            // 
            this.editorsBindingSource.DataMember = "editors";
            this.editorsBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "books_designer_id";
            this.dataGridViewTextBoxColumn38.DataSource = this.designersBindingSource;
            this.dataGridViewTextBoxColumn38.DisplayMember = "designer_last_name";
            this.dataGridViewTextBoxColumn38.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn38.HeaderText = "Художник";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn38.ValueMember = "designers_id";
            this.dataGridViewTextBoxColumn38.Width = 150;
            // 
            // designersBindingSource
            // 
            this.designersBindingSource.DataMember = "designers";
            this.designersBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem8;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem8;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem8;
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem8,
            this.bindingNavigatorMovePreviousItem8,
            this.bindingNavigatorSeparator24,
            this.bindingNavigatorPositionItem8,
            this.bindingNavigatorCountItem8,
            this.bindingNavigatorSeparator25,
            this.bindingNavigatorMoveNextItem8,
            this.bindingNavigatorMoveLastItem8,
            this.bindingNavigatorSeparator26,
            this.bindingNavigatorAddNewItem8,
            this.bindingNavigatorDeleteItem8,
            this.toolStripButtonSaveBooksItem,
            this.toolStripButtonEditBooksItem,
            this.toolStripButtonUpdateBooksItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem8;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem8;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem8;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem8;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem8;
            this.booksBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.booksBindingNavigator.TabIndex = 1;
            this.booksBindingNavigator.Text = "bindingNavigator6";
            // 
            // bindingNavigatorAddNewItem8
            // 
            this.bindingNavigatorAddNewItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem8.Image")));
            this.bindingNavigatorAddNewItem8.Name = "bindingNavigatorAddNewItem8";
            this.bindingNavigatorAddNewItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem8.Text = "Добавить";
            this.bindingNavigatorAddNewItem8.Click += new System.EventHandler(this.bindingNavigatorAddNewItem8_Click);
            // 
            // bindingNavigatorCountItem8
            // 
            this.bindingNavigatorCountItem8.Name = "bindingNavigatorCountItem8";
            this.bindingNavigatorCountItem8.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem8.Text = "для {0}";
            this.bindingNavigatorCountItem8.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem8
            // 
            this.bindingNavigatorDeleteItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem8.Image")));
            this.bindingNavigatorDeleteItem8.Name = "bindingNavigatorDeleteItem8";
            this.bindingNavigatorDeleteItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem8.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem8
            // 
            this.bindingNavigatorMoveFirstItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem8.Image")));
            this.bindingNavigatorMoveFirstItem8.Name = "bindingNavigatorMoveFirstItem8";
            this.bindingNavigatorMoveFirstItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem8.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem8
            // 
            this.bindingNavigatorMovePreviousItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem8.Image")));
            this.bindingNavigatorMovePreviousItem8.Name = "bindingNavigatorMovePreviousItem8";
            this.bindingNavigatorMovePreviousItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem8.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator24
            // 
            this.bindingNavigatorSeparator24.Name = "bindingNavigatorSeparator24";
            this.bindingNavigatorSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem8
            // 
            this.bindingNavigatorPositionItem8.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem8.AutoSize = false;
            this.bindingNavigatorPositionItem8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem8.Name = "bindingNavigatorPositionItem8";
            this.bindingNavigatorPositionItem8.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem8.Text = "0";
            this.bindingNavigatorPositionItem8.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator25
            // 
            this.bindingNavigatorSeparator25.Name = "bindingNavigatorSeparator25";
            this.bindingNavigatorSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem8
            // 
            this.bindingNavigatorMoveNextItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem8.Image")));
            this.bindingNavigatorMoveNextItem8.Name = "bindingNavigatorMoveNextItem8";
            this.bindingNavigatorMoveNextItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem8.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem8
            // 
            this.bindingNavigatorMoveLastItem8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem8.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem8.Image")));
            this.bindingNavigatorMoveLastItem8.Name = "bindingNavigatorMoveLastItem8";
            this.bindingNavigatorMoveLastItem8.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem8.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem8.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator26
            // 
            this.bindingNavigatorSeparator26.Name = "bindingNavigatorSeparator26";
            this.bindingNavigatorSeparator26.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveBooksItem
            // 
            this.toolStripButtonSaveBooksItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveBooksItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveBooksItem.Image")));
            this.toolStripButtonSaveBooksItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveBooksItem.Name = "toolStripButtonSaveBooksItem";
            this.toolStripButtonSaveBooksItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveBooksItem.Text = "Сохранить";
            this.toolStripButtonSaveBooksItem.Click += new System.EventHandler(this.toolStripButtonSaveBooksItem_Click);
            // 
            // toolStripButtonEditBooksItem
            // 
            this.toolStripButtonEditBooksItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditBooksItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditBooksItem.Image")));
            this.toolStripButtonEditBooksItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditBooksItem.Name = "toolStripButtonEditBooksItem";
            this.toolStripButtonEditBooksItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditBooksItem.Text = "Редактировать";
            this.toolStripButtonEditBooksItem.Click += new System.EventHandler(this.toolStripButtonEditBooksItem_Click);
            // 
            // toolStripButtonUpdateBooksItem
            // 
            this.toolStripButtonUpdateBooksItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateBooksItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateBooksItem.Image")));
            this.toolStripButtonUpdateBooksItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateBooksItem.Name = "toolStripButtonUpdateBooksItem";
            this.toolStripButtonUpdateBooksItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateBooksItem.Text = "Обновить";
            this.toolStripButtonUpdateBooksItem.Click += new System.EventHandler(this.toolStripButtonUpdateBooksItem_Click);
            // 
            // groupBoxEditBook
            // 
            this.groupBoxEditBook.Controls.Add(this.label25);
            this.groupBoxEditBook.Controls.Add(this.label24);
            this.groupBoxEditBook.Controls.Add(this.label23);
            this.groupBoxEditBook.Controls.Add(this.label22);
            this.groupBoxEditBook.Controls.Add(this.label21);
            this.groupBoxEditBook.Controls.Add(this.label20);
            this.groupBoxEditBook.Controls.Add(this.buttonCancelEditBook);
            this.groupBoxEditBook.Controls.Add(this.buttonSaveBook);
            this.groupBoxEditBook.Controls.Add(this.textBoxBooksName);
            this.groupBoxEditBook.Controls.Add(this.numericUpDownBooksPublishingYear);
            this.groupBoxEditBook.Controls.Add(this.numericUpDownBooksPages);
            this.groupBoxEditBook.Controls.Add(this.comboBoxBooksDesigner);
            this.groupBoxEditBook.Controls.Add(this.comboBoxBooksEditor);
            this.groupBoxEditBook.Controls.Add(this.comboBoxBooksGenre);
            this.groupBoxEditBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditBook.Location = new System.Drawing.Point(0, 214);
            this.groupBoxEditBook.Name = "groupBoxEditBook";
            this.groupBoxEditBook.Size = new System.Drawing.Size(394, 263);
            this.groupBoxEditBook.TabIndex = 2;
            this.groupBoxEditBook.TabStop = false;
            this.groupBoxEditBook.Text = "Редактирование";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 170);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 16);
            this.label25.TabIndex = 13;
            this.label25.Text = "Художник";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(14, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 16);
            this.label24.TabIndex = 12;
            this.label24.Text = "Редактор";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 16);
            this.label23.TabIndex = 11;
            this.label23.Text = "Жанр";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 16);
            this.label22.TabIndex = 10;
            this.label22.Text = "Страниц";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "Год";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Название";
            // 
            // buttonCancelEditBook
            // 
            this.buttonCancelEditBook.Location = new System.Drawing.Point(9, 210);
            this.buttonCancelEditBook.Name = "buttonCancelEditBook";
            this.buttonCancelEditBook.Size = new System.Drawing.Size(120, 41);
            this.buttonCancelEditBook.TabIndex = 7;
            this.buttonCancelEditBook.Text = "Отменить";
            this.buttonCancelEditBook.UseVisualStyleBackColor = true;
            this.buttonCancelEditBook.Click += new System.EventHandler(this.buttonCancelEditBook_Click);
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Location = new System.Drawing.Point(263, 210);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(120, 41);
            this.buttonSaveBook.TabIndex = 6;
            this.buttonSaveBook.Text = "Сохрнаить";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // textBoxBooksName
            // 
            this.textBoxBooksName.Location = new System.Drawing.Point(157, 25);
            this.textBoxBooksName.MaxLength = 40;
            this.textBoxBooksName.Name = "textBoxBooksName";
            this.textBoxBooksName.Size = new System.Drawing.Size(211, 22);
            this.textBoxBooksName.TabIndex = 5;
            this.textBoxBooksName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // numericUpDownBooksPublishingYear
            // 
            this.numericUpDownBooksPublishingYear.Location = new System.Drawing.Point(157, 53);
            this.numericUpDownBooksPublishingYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDownBooksPublishingYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBooksPublishingYear.Name = "numericUpDownBooksPublishingYear";
            this.numericUpDownBooksPublishingYear.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownBooksPublishingYear.TabIndex = 4;
            this.numericUpDownBooksPublishingYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBooksPages
            // 
            this.numericUpDownBooksPages.Location = new System.Drawing.Point(156, 81);
            this.numericUpDownBooksPages.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownBooksPages.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownBooksPages.Name = "numericUpDownBooksPages";
            this.numericUpDownBooksPages.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownBooksPages.TabIndex = 3;
            this.numericUpDownBooksPages.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // comboBoxBooksDesigner
            // 
            this.comboBoxBooksDesigner.DataSource = this.designersBindingSource;
            this.comboBoxBooksDesigner.DisplayMember = "designer_last_name";
            this.comboBoxBooksDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooksDesigner.FormattingEnabled = true;
            this.comboBoxBooksDesigner.Location = new System.Drawing.Point(156, 167);
            this.comboBoxBooksDesigner.Name = "comboBoxBooksDesigner";
            this.comboBoxBooksDesigner.Size = new System.Drawing.Size(213, 24);
            this.comboBoxBooksDesigner.TabIndex = 2;
            this.comboBoxBooksDesigner.ValueMember = "designers_id";
            // 
            // comboBoxBooksEditor
            // 
            this.comboBoxBooksEditor.DataSource = this.editorsBindingSource;
            this.comboBoxBooksEditor.DisplayMember = "editors_last_name";
            this.comboBoxBooksEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooksEditor.FormattingEnabled = true;
            this.comboBoxBooksEditor.Location = new System.Drawing.Point(156, 137);
            this.comboBoxBooksEditor.Name = "comboBoxBooksEditor";
            this.comboBoxBooksEditor.Size = new System.Drawing.Size(213, 24);
            this.comboBoxBooksEditor.TabIndex = 1;
            this.comboBoxBooksEditor.ValueMember = "editors_id";
            // 
            // comboBoxBooksGenre
            // 
            this.comboBoxBooksGenre.DataSource = this.genresBindingSource;
            this.comboBoxBooksGenre.DisplayMember = "genre_name";
            this.comboBoxBooksGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooksGenre.FormattingEnabled = true;
            this.comboBoxBooksGenre.Location = new System.Drawing.Point(156, 107);
            this.comboBoxBooksGenre.Name = "comboBoxBooksGenre";
            this.comboBoxBooksGenre.Size = new System.Drawing.Size(213, 24);
            this.comboBoxBooksGenre.TabIndex = 0;
            this.comboBoxBooksGenre.ValueMember = "genre_id";
            // 
            // groupBoxSearchBook
            // 
            this.groupBoxSearchBook.Controls.Add(this.comboBoxConditionBooks);
            this.groupBoxSearchBook.Controls.Add(this.buttonPrintQueryBook);
            this.groupBoxSearchBook.Controls.Add(this.buttonQueryBooks);
            this.groupBoxSearchBook.Controls.Add(this.label10);
            this.groupBoxSearchBook.Controls.Add(this.label11);
            this.groupBoxSearchBook.Controls.Add(this.comboBoxCriterionBook);
            this.groupBoxSearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchBook.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchBook.Name = "groupBoxSearchBook";
            this.groupBoxSearchBook.Size = new System.Drawing.Size(394, 214);
            this.groupBoxSearchBook.TabIndex = 1;
            this.groupBoxSearchBook.TabStop = false;
            this.groupBoxSearchBook.Text = "Поиск";
            // 
            // comboBoxConditionBooks
            // 
            this.comboBoxConditionBooks.FormattingEnabled = true;
            this.comboBoxConditionBooks.Location = new System.Drawing.Point(162, 88);
            this.comboBoxConditionBooks.Name = "comboBoxConditionBooks";
            this.comboBoxConditionBooks.Size = new System.Drawing.Size(221, 24);
            this.comboBoxConditionBooks.TabIndex = 9;
            // 
            // buttonPrintQueryBook
            // 
            this.buttonPrintQueryBook.Location = new System.Drawing.Point(76, 168);
            this.buttonPrintQueryBook.Name = "buttonPrintQueryBook";
            this.buttonPrintQueryBook.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintQueryBook.TabIndex = 8;
            this.buttonPrintQueryBook.Text = "Печать запроса";
            this.buttonPrintQueryBook.UseVisualStyleBackColor = true;
            this.buttonPrintQueryBook.Click += new System.EventHandler(this.buttonPrintQueryBook_Click);
            // 
            // buttonQueryBooks
            // 
            this.buttonQueryBooks.Location = new System.Drawing.Point(76, 129);
            this.buttonQueryBooks.Name = "buttonQueryBooks";
            this.buttonQueryBooks.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryBooks.TabIndex = 7;
            this.buttonQueryBooks.Text = "Выполнить запрос";
            this.buttonQueryBooks.UseVisualStyleBackColor = true;
            this.buttonQueryBooks.Click += new System.EventHandler(this.buttonQueryBooks_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Условие выборки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Критерий выборки";
            // 
            // comboBoxCriterionBook
            // 
            this.comboBoxCriterionBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterionBook.FormattingEnabled = true;
            this.comboBoxCriterionBook.Location = new System.Drawing.Point(162, 36);
            this.comboBoxCriterionBook.Name = "comboBoxCriterionBook";
            this.comboBoxCriterionBook.Size = new System.Drawing.Size(221, 24);
            this.comboBoxCriterionBook.TabIndex = 0;
            this.comboBoxCriterionBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterionBook_SelectedIndexChanged);
            // 
            // tabPageDesigners
            // 
            this.tabPageDesigners.Controls.Add(this.splitContainer7);
            this.tabPageDesigners.Location = new System.Drawing.Point(4, 22);
            this.tabPageDesigners.Name = "tabPageDesigners";
            this.tabPageDesigners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesigners.Size = new System.Drawing.Size(1224, 491);
            this.tabPageDesigners.TabIndex = 3;
            this.tabPageDesigners.Text = "Художники";
            this.tabPageDesigners.UseVisualStyleBackColor = true;
            this.tabPageDesigners.Leave += new System.EventHandler(this.tabPageDesigners_Leave);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.designersDataGridView);
            this.splitContainer7.Panel1.Controls.Add(this.designersBindingNavigator);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.groupBoxEditDesigner);
            this.splitContainer7.Panel2.Controls.Add(this.groupBoxSearchDesigner);
            this.splitContainer7.Size = new System.Drawing.Size(1218, 485);
            this.splitContainer7.SplitterDistance = 796;
            this.splitContainer7.TabIndex = 0;
            // 
            // designersDataGridView
            // 
            this.designersDataGridView.AllowUserToAddRows = false;
            this.designersDataGridView.AutoGenerateColumns = false;
            this.designersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.designersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designersidDataGridViewTextBoxColumn,
            this.designerlastnameDataGridViewTextBoxColumn,
            this.designersfirstnameDataGridViewTextBoxColumn,
            this.designerpatronymicDataGridViewTextBoxColumn,
            this.designersnumberphoneDataGridViewTextBoxColumn,
            this.designersbirthdayDataGridViewTextBoxColumn});
            this.designersDataGridView.DataSource = this.designersBindingSource;
            this.designersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designersDataGridView.Location = new System.Drawing.Point(0, 25);
            this.designersDataGridView.Name = "designersDataGridView";
            this.designersDataGridView.ReadOnly = true;
            this.designersDataGridView.Size = new System.Drawing.Size(796, 460);
            this.designersDataGridView.TabIndex = 0;
            this.designersDataGridView.SelectionChanged += new System.EventHandler(this.designersDataGridView_SelectionChanged);
            // 
            // designersidDataGridViewTextBoxColumn
            // 
            this.designersidDataGridViewTextBoxColumn.DataPropertyName = "designers_id";
            this.designersidDataGridViewTextBoxColumn.HeaderText = "id";
            this.designersidDataGridViewTextBoxColumn.Name = "designersidDataGridViewTextBoxColumn";
            this.designersidDataGridViewTextBoxColumn.ReadOnly = true;
            this.designersidDataGridViewTextBoxColumn.Width = 50;
            // 
            // designerlastnameDataGridViewTextBoxColumn
            // 
            this.designerlastnameDataGridViewTextBoxColumn.DataPropertyName = "designer_last_name";
            this.designerlastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.designerlastnameDataGridViewTextBoxColumn.Name = "designerlastnameDataGridViewTextBoxColumn";
            this.designerlastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.designerlastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // designersfirstnameDataGridViewTextBoxColumn
            // 
            this.designersfirstnameDataGridViewTextBoxColumn.DataPropertyName = "designers_first_name";
            this.designersfirstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.designersfirstnameDataGridViewTextBoxColumn.Name = "designersfirstnameDataGridViewTextBoxColumn";
            this.designersfirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.designersfirstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // designerpatronymicDataGridViewTextBoxColumn
            // 
            this.designerpatronymicDataGridViewTextBoxColumn.DataPropertyName = "designer_patronymic";
            this.designerpatronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.designerpatronymicDataGridViewTextBoxColumn.Name = "designerpatronymicDataGridViewTextBoxColumn";
            this.designerpatronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designersnumberphoneDataGridViewTextBoxColumn
            // 
            this.designersnumberphoneDataGridViewTextBoxColumn.DataPropertyName = "designers_number_phone";
            this.designersnumberphoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.designersnumberphoneDataGridViewTextBoxColumn.Name = "designersnumberphoneDataGridViewTextBoxColumn";
            this.designersnumberphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.designersnumberphoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // designersbirthdayDataGridViewTextBoxColumn
            // 
            this.designersbirthdayDataGridViewTextBoxColumn.DataPropertyName = "designers_birthday";
            this.designersbirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.designersbirthdayDataGridViewTextBoxColumn.Name = "designersbirthdayDataGridViewTextBoxColumn";
            this.designersbirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.designersbirthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // designersBindingNavigator
            // 
            this.designersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem5;
            this.designersBindingNavigator.BindingSource = this.designersBindingSource;
            this.designersBindingNavigator.CountItem = this.bindingNavigatorCountItem5;
            this.designersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem5;
            this.designersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5,
            this.toolStripButtonSaveDesignersItem,
            this.toolStripButtonEditDesignerItem,
            this.toolStripButtonUpdateDesignersItem});
            this.designersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.designersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.designersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.designersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.designersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.designersBindingNavigator.Name = "designersBindingNavigator";
            this.designersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem5;
            this.designersBindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.designersBindingNavigator.TabIndex = 1;
            this.designersBindingNavigator.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem5
            // 
            this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
            this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
            this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem5.Text = "Добавить";
            this.bindingNavigatorAddNewItem5.Click += new System.EventHandler(this.bindingNavigatorAddNewItem5_Click);
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem5.Text = "для {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem5
            // 
            this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
            this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
            this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem5.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveDesignersItem
            // 
            this.toolStripButtonSaveDesignersItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveDesignersItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveDesignersItem.Image")));
            this.toolStripButtonSaveDesignersItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveDesignersItem.Name = "toolStripButtonSaveDesignersItem";
            this.toolStripButtonSaveDesignersItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveDesignersItem.Text = "Сохранить";
            this.toolStripButtonSaveDesignersItem.Click += new System.EventHandler(this.toolStripButtonSaveDesignersItem_Click);
            // 
            // toolStripButtonEditDesignerItem
            // 
            this.toolStripButtonEditDesignerItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditDesignerItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditDesignerItem.Image")));
            this.toolStripButtonEditDesignerItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditDesignerItem.Name = "toolStripButtonEditDesignerItem";
            this.toolStripButtonEditDesignerItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditDesignerItem.Text = "Редактировать";
            this.toolStripButtonEditDesignerItem.Click += new System.EventHandler(this.toolStripButtonEditDesignerItem_Click);
            // 
            // toolStripButtonUpdateDesignersItem
            // 
            this.toolStripButtonUpdateDesignersItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateDesignersItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateDesignersItem.Image")));
            this.toolStripButtonUpdateDesignersItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateDesignersItem.Name = "toolStripButtonUpdateDesignersItem";
            this.toolStripButtonUpdateDesignersItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateDesignersItem.Text = "Обновить";
            this.toolStripButtonUpdateDesignersItem.Click += new System.EventHandler(this.toolStripButtonUpdateDesignersItem_Click);
            // 
            // groupBoxEditDesigner
            // 
            this.groupBoxEditDesigner.Controls.Add(this.maskedTextBoxDesignerNumberPhone);
            this.groupBoxEditDesigner.Controls.Add(this.label30);
            this.groupBoxEditDesigner.Controls.Add(this.buttonSaveDesigner);
            this.groupBoxEditDesigner.Controls.Add(this.buttonCancelEditingDesigner);
            this.groupBoxEditDesigner.Controls.Add(this.dateTimePickerDesignerBirthDate);
            this.groupBoxEditDesigner.Controls.Add(this.textBoxDesignerPatronymic);
            this.groupBoxEditDesigner.Controls.Add(this.textBoxDesignerFirstName);
            this.groupBoxEditDesigner.Controls.Add(this.textBoxDesignerLastName);
            this.groupBoxEditDesigner.Controls.Add(this.label26);
            this.groupBoxEditDesigner.Controls.Add(this.label27);
            this.groupBoxEditDesigner.Controls.Add(this.label28);
            this.groupBoxEditDesigner.Controls.Add(this.label29);
            this.groupBoxEditDesigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditDesigner.Location = new System.Drawing.Point(0, 244);
            this.groupBoxEditDesigner.Name = "groupBoxEditDesigner";
            this.groupBoxEditDesigner.Size = new System.Drawing.Size(418, 233);
            this.groupBoxEditDesigner.TabIndex = 3;
            this.groupBoxEditDesigner.TabStop = false;
            this.groupBoxEditDesigner.Text = "Редактирование";
            // 
            // maskedTextBoxDesignerNumberPhone
            // 
            this.maskedTextBoxDesignerNumberPhone.Location = new System.Drawing.Point(144, 155);
            this.maskedTextBoxDesignerNumberPhone.Mask = "0-000-000-00-00";
            this.maskedTextBoxDesignerNumberPhone.Name = "maskedTextBoxDesignerNumberPhone";
            this.maskedTextBoxDesignerNumberPhone.Size = new System.Drawing.Size(239, 20);
            this.maskedTextBoxDesignerNumberPhone.TabIndex = 11;
            this.maskedTextBoxDesignerNumberPhone.ValidatingType = typeof(System.DateTime);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 155);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(93, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "Номер телефона";
            // 
            // buttonSaveDesigner
            // 
            this.buttonSaveDesigner.Location = new System.Drawing.Point(280, 187);
            this.buttonSaveDesigner.Name = "buttonSaveDesigner";
            this.buttonSaveDesigner.Size = new System.Drawing.Size(126, 35);
            this.buttonSaveDesigner.TabIndex = 9;
            this.buttonSaveDesigner.Text = "Сохранить";
            this.buttonSaveDesigner.UseVisualStyleBackColor = true;
            this.buttonSaveDesigner.Click += new System.EventHandler(this.buttonSaveDesigner_Click);
            // 
            // buttonCancelEditingDesigner
            // 
            this.buttonCancelEditingDesigner.Location = new System.Drawing.Point(9, 187);
            this.buttonCancelEditingDesigner.Name = "buttonCancelEditingDesigner";
            this.buttonCancelEditingDesigner.Size = new System.Drawing.Size(126, 35);
            this.buttonCancelEditingDesigner.TabIndex = 8;
            this.buttonCancelEditingDesigner.Text = "Отмена";
            this.buttonCancelEditingDesigner.UseVisualStyleBackColor = true;
            this.buttonCancelEditingDesigner.Click += new System.EventHandler(this.buttonCancelEditingDesigner_Click);
            // 
            // dateTimePickerDesignerBirthDate
            // 
            this.dateTimePickerDesignerBirthDate.Location = new System.Drawing.Point(144, 119);
            this.dateTimePickerDesignerBirthDate.Name = "dateTimePickerDesignerBirthDate";
            this.dateTimePickerDesignerBirthDate.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerDesignerBirthDate.TabIndex = 7;
            // 
            // textBoxDesignerPatronymic
            // 
            this.textBoxDesignerPatronymic.Location = new System.Drawing.Point(144, 87);
            this.textBoxDesignerPatronymic.MaxLength = 25;
            this.textBoxDesignerPatronymic.Name = "textBoxDesignerPatronymic";
            this.textBoxDesignerPatronymic.Size = new System.Drawing.Size(239, 20);
            this.textBoxDesignerPatronymic.TabIndex = 6;
            // 
            // textBoxDesignerFirstName
            // 
            this.textBoxDesignerFirstName.Location = new System.Drawing.Point(144, 53);
            this.textBoxDesignerFirstName.MaxLength = 25;
            this.textBoxDesignerFirstName.Name = "textBoxDesignerFirstName";
            this.textBoxDesignerFirstName.Size = new System.Drawing.Size(239, 20);
            this.textBoxDesignerFirstName.TabIndex = 5;
            this.textBoxDesignerFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // textBoxDesignerLastName
            // 
            this.textBoxDesignerLastName.Location = new System.Drawing.Point(144, 19);
            this.textBoxDesignerLastName.MaxLength = 25;
            this.textBoxDesignerLastName.Name = "textBoxDesignerLastName";
            this.textBoxDesignerLastName.Size = new System.Drawing.Size(239, 20);
            this.textBoxDesignerLastName.TabIndex = 4;
            this.textBoxDesignerLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Дата рождения";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 90);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Отчество";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Имя";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Фамилия";
            // 
            // groupBoxSearchDesigner
            // 
            this.groupBoxSearchDesigner.Controls.Add(this.buttonPrintDesigner);
            this.groupBoxSearchDesigner.Controls.Add(this.buttonQueryDesigner);
            this.groupBoxSearchDesigner.Controls.Add(this.textBoxConditionDesigner);
            this.groupBoxSearchDesigner.Controls.Add(this.label12);
            this.groupBoxSearchDesigner.Controls.Add(this.label13);
            this.groupBoxSearchDesigner.Controls.Add(this.comboBoxCriterionDesigner);
            this.groupBoxSearchDesigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchDesigner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchDesigner.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchDesigner.Name = "groupBoxSearchDesigner";
            this.groupBoxSearchDesigner.Size = new System.Drawing.Size(418, 244);
            this.groupBoxSearchDesigner.TabIndex = 2;
            this.groupBoxSearchDesigner.TabStop = false;
            this.groupBoxSearchDesigner.Text = "Поиск";
            // 
            // buttonPrintDesigner
            // 
            this.buttonPrintDesigner.Location = new System.Drawing.Point(76, 198);
            this.buttonPrintDesigner.Name = "buttonPrintDesigner";
            this.buttonPrintDesigner.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintDesigner.TabIndex = 8;
            this.buttonPrintDesigner.Text = "Печать запроса";
            this.buttonPrintDesigner.UseVisualStyleBackColor = true;
            this.buttonPrintDesigner.Click += new System.EventHandler(this.buttonPrintDesigner_Click);
            // 
            // buttonQueryDesigner
            // 
            this.buttonQueryDesigner.Location = new System.Drawing.Point(76, 150);
            this.buttonQueryDesigner.Name = "buttonQueryDesigner";
            this.buttonQueryDesigner.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryDesigner.TabIndex = 7;
            this.buttonQueryDesigner.Text = "Выполнить запрос";
            this.buttonQueryDesigner.UseVisualStyleBackColor = true;
            this.buttonQueryDesigner.Click += new System.EventHandler(this.buttonQueryDesigner_Click);
            // 
            // textBoxConditionDesigner
            // 
            this.textBoxConditionDesigner.Location = new System.Drawing.Point(162, 88);
            this.textBoxConditionDesigner.Name = "textBoxConditionDesigner";
            this.textBoxConditionDesigner.Size = new System.Drawing.Size(221, 22);
            this.textBoxConditionDesigner.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Условие выборки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Критерий выборки";
            // 
            // comboBoxCriterionDesigner
            // 
            this.comboBoxCriterionDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterionDesigner.FormattingEnabled = true;
            this.comboBoxCriterionDesigner.Location = new System.Drawing.Point(162, 36);
            this.comboBoxCriterionDesigner.Name = "comboBoxCriterionDesigner";
            this.comboBoxCriterionDesigner.Size = new System.Drawing.Size(221, 24);
            this.comboBoxCriterionDesigner.TabIndex = 0;
            this.comboBoxCriterionDesigner.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterionDesigner_SelectedIndexChanged);
            // 
            // tabPageEditors
            // 
            this.tabPageEditors.Controls.Add(this.splitContainer4);
            this.tabPageEditors.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditors.Name = "tabPageEditors";
            this.tabPageEditors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditors.Size = new System.Drawing.Size(1224, 491);
            this.tabPageEditors.TabIndex = 4;
            this.tabPageEditors.Text = "Редакторы";
            this.tabPageEditors.UseVisualStyleBackColor = true;
            this.tabPageEditors.Leave += new System.EventHandler(this.tabPageEditors_Leave);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.editorsDataGridView);
            this.splitContainer4.Panel1.Controls.Add(this.editorsBindingNavigator);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBoxEditEditors);
            this.splitContainer4.Panel2.Controls.Add(this.groupBoxSearchEditor);
            this.splitContainer4.Size = new System.Drawing.Size(1218, 485);
            this.splitContainer4.SplitterDistance = 779;
            this.splitContainer4.TabIndex = 0;
            // 
            // editorsDataGridView
            // 
            this.editorsDataGridView.AllowUserToAddRows = false;
            this.editorsDataGridView.AutoGenerateColumns = false;
            this.editorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.editorsDataGridView.DataSource = this.editorsBindingSource;
            this.editorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.editorsDataGridView.Name = "editorsDataGridView";
            this.editorsDataGridView.Size = new System.Drawing.Size(779, 460);
            this.editorsDataGridView.TabIndex = 2;
            this.editorsDataGridView.SelectionChanged += new System.EventHandler(this.editorsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "editors_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 20;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "editors_last_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "editors_first_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "editors_patronymic";
            this.dataGridViewTextBoxColumn7.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "editors_number_phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "editors_birthday";
            this.dataGridViewTextBoxColumn9.HeaderText = "Год рождения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // editorsBindingNavigator
            // 
            this.editorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.editorsBindingNavigator.BindingSource = this.editorsBindingSource;
            this.editorsBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.editorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.editorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButtonSaveEditorsItem,
            this.toolStripButtonEditEditorsItem,
            this.toolStripButtonUpdateEditorsItem});
            this.editorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.editorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.editorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.editorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.editorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.editorsBindingNavigator.Name = "editorsBindingNavigator";
            this.editorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.editorsBindingNavigator.Size = new System.Drawing.Size(779, 25);
            this.editorsBindingNavigator.TabIndex = 3;
            this.editorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveEditorsItem
            // 
            this.toolStripButtonSaveEditorsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveEditorsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveEditorsItem.Image")));
            this.toolStripButtonSaveEditorsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveEditorsItem.Name = "toolStripButtonSaveEditorsItem";
            this.toolStripButtonSaveEditorsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveEditorsItem.Text = "Сохранить";
            this.toolStripButtonSaveEditorsItem.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // toolStripButtonEditEditorsItem
            // 
            this.toolStripButtonEditEditorsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditEditorsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditEditorsItem.Image")));
            this.toolStripButtonEditEditorsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditEditorsItem.Name = "toolStripButtonEditEditorsItem";
            this.toolStripButtonEditEditorsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditEditorsItem.Text = "Редактировать";
            this.toolStripButtonEditEditorsItem.Click += new System.EventHandler(this.toolStripButtonEditEditorsItem_Click);
            // 
            // toolStripButtonUpdateEditorsItem
            // 
            this.toolStripButtonUpdateEditorsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateEditorsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateEditorsItem.Image")));
            this.toolStripButtonUpdateEditorsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateEditorsItem.Name = "toolStripButtonUpdateEditorsItem";
            this.toolStripButtonUpdateEditorsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateEditorsItem.Text = "Обновить";
            this.toolStripButtonUpdateEditorsItem.Click += new System.EventHandler(this.toolStripButtonUpdateEditorsItem_Click);
            // 
            // groupBoxEditEditors
            // 
            this.groupBoxEditEditors.Controls.Add(this.maskedTextBoxEditorsNumberPhone);
            this.groupBoxEditEditors.Controls.Add(this.label31);
            this.groupBoxEditEditors.Controls.Add(this.buttonSaveEditors);
            this.groupBoxEditEditors.Controls.Add(this.buttonCancelEditEditors);
            this.groupBoxEditEditors.Controls.Add(this.dateTimePickerEdtirosBirthDate);
            this.groupBoxEditEditors.Controls.Add(this.textBoxEditorsPatronymic);
            this.groupBoxEditEditors.Controls.Add(this.textBoxEditorsFirstName);
            this.groupBoxEditEditors.Controls.Add(this.textBoxEditorsLastName);
            this.groupBoxEditEditors.Controls.Add(this.label32);
            this.groupBoxEditEditors.Controls.Add(this.label33);
            this.groupBoxEditEditors.Controls.Add(this.label34);
            this.groupBoxEditEditors.Controls.Add(this.label35);
            this.groupBoxEditEditors.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditEditors.Location = new System.Drawing.Point(0, 244);
            this.groupBoxEditEditors.Name = "groupBoxEditEditors";
            this.groupBoxEditEditors.Size = new System.Drawing.Size(435, 233);
            this.groupBoxEditEditors.TabIndex = 4;
            this.groupBoxEditEditors.TabStop = false;
            this.groupBoxEditEditors.Text = "Редактирование";
            // 
            // maskedTextBoxEditorsNumberPhone
            // 
            this.maskedTextBoxEditorsNumberPhone.Location = new System.Drawing.Point(144, 155);
            this.maskedTextBoxEditorsNumberPhone.Mask = "0-000-000-00-00";
            this.maskedTextBoxEditorsNumberPhone.Name = "maskedTextBoxEditorsNumberPhone";
            this.maskedTextBoxEditorsNumberPhone.Size = new System.Drawing.Size(239, 20);
            this.maskedTextBoxEditorsNumberPhone.TabIndex = 11;
            this.maskedTextBoxEditorsNumberPhone.ValidatingType = typeof(System.DateTime);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 155);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 13);
            this.label31.TabIndex = 10;
            this.label31.Text = "Номер телефона";
            // 
            // buttonSaveEditors
            // 
            this.buttonSaveEditors.Location = new System.Drawing.Point(297, 187);
            this.buttonSaveEditors.Name = "buttonSaveEditors";
            this.buttonSaveEditors.Size = new System.Drawing.Size(126, 35);
            this.buttonSaveEditors.TabIndex = 9;
            this.buttonSaveEditors.Text = "Сохранить";
            this.buttonSaveEditors.UseVisualStyleBackColor = true;
            this.buttonSaveEditors.Click += new System.EventHandler(this.buttonSaveEditors_Click);
            // 
            // buttonCancelEditEditors
            // 
            this.buttonCancelEditEditors.Location = new System.Drawing.Point(9, 187);
            this.buttonCancelEditEditors.Name = "buttonCancelEditEditors";
            this.buttonCancelEditEditors.Size = new System.Drawing.Size(126, 35);
            this.buttonCancelEditEditors.TabIndex = 8;
            this.buttonCancelEditEditors.Text = "Отмена";
            this.buttonCancelEditEditors.UseVisualStyleBackColor = true;
            this.buttonCancelEditEditors.Click += new System.EventHandler(this.buttonCancelEditEditors_Click);
            // 
            // dateTimePickerEdtirosBirthDate
            // 
            this.dateTimePickerEdtirosBirthDate.Location = new System.Drawing.Point(144, 119);
            this.dateTimePickerEdtirosBirthDate.Name = "dateTimePickerEdtirosBirthDate";
            this.dateTimePickerEdtirosBirthDate.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerEdtirosBirthDate.TabIndex = 7;
            // 
            // textBoxEditorsPatronymic
            // 
            this.textBoxEditorsPatronymic.Location = new System.Drawing.Point(144, 87);
            this.textBoxEditorsPatronymic.MaxLength = 25;
            this.textBoxEditorsPatronymic.Name = "textBoxEditorsPatronymic";
            this.textBoxEditorsPatronymic.Size = new System.Drawing.Size(239, 20);
            this.textBoxEditorsPatronymic.TabIndex = 6;
            // 
            // textBoxEditorsFirstName
            // 
            this.textBoxEditorsFirstName.Location = new System.Drawing.Point(144, 53);
            this.textBoxEditorsFirstName.MaxLength = 25;
            this.textBoxEditorsFirstName.Name = "textBoxEditorsFirstName";
            this.textBoxEditorsFirstName.Size = new System.Drawing.Size(239, 20);
            this.textBoxEditorsFirstName.TabIndex = 5;
            this.textBoxEditorsFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // textBoxEditorsLastName
            // 
            this.textBoxEditorsLastName.Location = new System.Drawing.Point(144, 19);
            this.textBoxEditorsLastName.MaxLength = 25;
            this.textBoxEditorsLastName.Name = "textBoxEditorsLastName";
            this.textBoxEditorsLastName.Size = new System.Drawing.Size(239, 20);
            this.textBoxEditorsLastName.TabIndex = 4;
            this.textBoxEditorsLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 124);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(86, 13);
            this.label32.TabIndex = 3;
            this.label32.Text = "Дата рождения";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 90);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Отчество";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 56);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "Имя";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Фамилия";
            // 
            // groupBoxSearchEditor
            // 
            this.groupBoxSearchEditor.Controls.Add(this.buttonPrintQueryEditors);
            this.groupBoxSearchEditor.Controls.Add(this.buttonQueryEditor);
            this.groupBoxSearchEditor.Controls.Add(this.textBoxConditionEditor);
            this.groupBoxSearchEditor.Controls.Add(this.label14);
            this.groupBoxSearchEditor.Controls.Add(this.label15);
            this.groupBoxSearchEditor.Controls.Add(this.comboBoxCriterionEditor);
            this.groupBoxSearchEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchEditor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchEditor.Name = "groupBoxSearchEditor";
            this.groupBoxSearchEditor.Size = new System.Drawing.Size(435, 244);
            this.groupBoxSearchEditor.TabIndex = 2;
            this.groupBoxSearchEditor.TabStop = false;
            this.groupBoxSearchEditor.Text = "Поиск";
            // 
            // buttonPrintQueryEditors
            // 
            this.buttonPrintQueryEditors.Location = new System.Drawing.Point(76, 198);
            this.buttonPrintQueryEditors.Name = "buttonPrintQueryEditors";
            this.buttonPrintQueryEditors.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintQueryEditors.TabIndex = 8;
            this.buttonPrintQueryEditors.Text = "Печать запроса";
            this.buttonPrintQueryEditors.UseVisualStyleBackColor = true;
            this.buttonPrintQueryEditors.Click += new System.EventHandler(this.buttonPrintQueryEditors_Click);
            // 
            // buttonQueryEditor
            // 
            this.buttonQueryEditor.Location = new System.Drawing.Point(76, 150);
            this.buttonQueryEditor.Name = "buttonQueryEditor";
            this.buttonQueryEditor.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryEditor.TabIndex = 7;
            this.buttonQueryEditor.Text = "Выполнить запрос";
            this.buttonQueryEditor.UseVisualStyleBackColor = true;
            this.buttonQueryEditor.Click += new System.EventHandler(this.buttonQueryEditor_Click);
            // 
            // textBoxConditionEditor
            // 
            this.textBoxConditionEditor.Location = new System.Drawing.Point(162, 88);
            this.textBoxConditionEditor.Name = "textBoxConditionEditor";
            this.textBoxConditionEditor.Size = new System.Drawing.Size(221, 22);
            this.textBoxConditionEditor.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Условие выборки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Критерий выборки";
            // 
            // comboBoxCriterionEditor
            // 
            this.comboBoxCriterionEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterionEditor.FormattingEnabled = true;
            this.comboBoxCriterionEditor.Location = new System.Drawing.Point(162, 36);
            this.comboBoxCriterionEditor.Name = "comboBoxCriterionEditor";
            this.comboBoxCriterionEditor.Size = new System.Drawing.Size(221, 24);
            this.comboBoxCriterionEditor.TabIndex = 0;
            this.comboBoxCriterionEditor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterionEditor_SelectedIndexChanged);
            // 
            // tabPageShops
            // 
            this.tabPageShops.Controls.Add(this.splitContainerShops);
            this.tabPageShops.Location = new System.Drawing.Point(4, 22);
            this.tabPageShops.Name = "tabPageShops";
            this.tabPageShops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShops.Size = new System.Drawing.Size(1224, 491);
            this.tabPageShops.TabIndex = 5;
            this.tabPageShops.Text = "Магазины";
            this.tabPageShops.UseVisualStyleBackColor = true;
            this.tabPageShops.Leave += new System.EventHandler(this.tabPageShops_Leave);
            // 
            // splitContainerShops
            // 
            this.splitContainerShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerShops.Location = new System.Drawing.Point(3, 3);
            this.splitContainerShops.Name = "splitContainerShops";
            // 
            // splitContainerShops.Panel1
            // 
            this.splitContainerShops.Panel1.Controls.Add(this.shopsDataGridView);
            this.splitContainerShops.Panel1.Controls.Add(this.shopsBindingNavigator);
            // 
            // splitContainerShops.Panel2
            // 
            this.splitContainerShops.Panel2.Controls.Add(this.groupBoxEditShops);
            this.splitContainerShops.Panel2.Controls.Add(this.groupBoxSearchShops);
            this.splitContainerShops.Size = new System.Drawing.Size(1218, 485);
            this.splitContainerShops.SplitterDistance = 653;
            this.splitContainerShops.TabIndex = 1;
            // 
            // shopsDataGridView
            // 
            this.shopsDataGridView.AllowUserToAddRows = false;
            this.shopsDataGridView.AutoGenerateColumns = false;
            this.shopsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.shopsDataGridView.DataSource = this.shopsBindingSource;
            this.shopsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.shopsDataGridView.Name = "shopsDataGridView";
            this.shopsDataGridView.ReadOnly = true;
            this.shopsDataGridView.Size = new System.Drawing.Size(653, 460);
            this.shopsDataGridView.TabIndex = 0;
            this.shopsDataGridView.SelectionChanged += new System.EventHandler(this.shopsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "shops_id";
            this.dataGridViewTextBoxColumn22.HeaderText = "id";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 20;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "shops_address";
            this.dataGridViewTextBoxColumn23.HeaderText = "адрес";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 200;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "shops_number_phone";
            this.dataGridViewTextBoxColumn24.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "shops_name_id";
            this.dataGridViewTextBoxColumn25.DataSource = this.shops_nameBindingSource;
            this.dataGridViewTextBoxColumn25.DisplayMember = "shops_name";
            this.dataGridViewTextBoxColumn25.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn25.HeaderText = "название";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn25.ValueMember = "shops_name_id";
            this.dataGridViewTextBoxColumn25.Width = 200;
            // 
            // shops_nameBindingSource
            // 
            this.shops_nameBindingSource.DataMember = "shops_name";
            this.shops_nameBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataMember = "shops";
            this.shopsBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // shopsBindingNavigator
            // 
            this.shopsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem6;
            this.shopsBindingNavigator.BindingSource = this.shopsBindingSource;
            this.shopsBindingNavigator.CountItem = this.bindingNavigatorCountItem6;
            this.shopsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem6;
            this.shopsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem6,
            this.bindingNavigatorMovePreviousItem6,
            this.bindingNavigatorSeparator18,
            this.bindingNavigatorPositionItem6,
            this.bindingNavigatorCountItem6,
            this.bindingNavigatorSeparator19,
            this.bindingNavigatorMoveNextItem6,
            this.bindingNavigatorMoveLastItem6,
            this.bindingNavigatorSeparator20,
            this.bindingNavigatorAddNewItem6,
            this.bindingNavigatorDeleteItem6,
            this.toolStripButtonSaveShopsItem,
            this.toolStripButtonEditShopsItem,
            this.toolStripButtonUpdateShopsItem});
            this.shopsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shopsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem6;
            this.shopsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem6;
            this.shopsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem6;
            this.shopsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem6;
            this.shopsBindingNavigator.Name = "shopsBindingNavigator";
            this.shopsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem6;
            this.shopsBindingNavigator.Size = new System.Drawing.Size(653, 25);
            this.shopsBindingNavigator.TabIndex = 1;
            this.shopsBindingNavigator.Text = "Редактировать";
            // 
            // bindingNavigatorAddNewItem6
            // 
            this.bindingNavigatorAddNewItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem6.Image")));
            this.bindingNavigatorAddNewItem6.Name = "bindingNavigatorAddNewItem6";
            this.bindingNavigatorAddNewItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem6.Text = "Добавить";
            this.bindingNavigatorAddNewItem6.Click += new System.EventHandler(this.bindingNavigatorAddNewItem6_Click);
            // 
            // bindingNavigatorCountItem6
            // 
            this.bindingNavigatorCountItem6.Name = "bindingNavigatorCountItem6";
            this.bindingNavigatorCountItem6.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem6.Text = "для {0}";
            this.bindingNavigatorCountItem6.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem6
            // 
            this.bindingNavigatorDeleteItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem6.Image")));
            this.bindingNavigatorDeleteItem6.Name = "bindingNavigatorDeleteItem6";
            this.bindingNavigatorDeleteItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem6.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem6
            // 
            this.bindingNavigatorMoveFirstItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem6.Image")));
            this.bindingNavigatorMoveFirstItem6.Name = "bindingNavigatorMoveFirstItem6";
            this.bindingNavigatorMoveFirstItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem6.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem6
            // 
            this.bindingNavigatorMovePreviousItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem6.Image")));
            this.bindingNavigatorMovePreviousItem6.Name = "bindingNavigatorMovePreviousItem6";
            this.bindingNavigatorMovePreviousItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem6.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator18
            // 
            this.bindingNavigatorSeparator18.Name = "bindingNavigatorSeparator18";
            this.bindingNavigatorSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem6
            // 
            this.bindingNavigatorPositionItem6.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem6.AutoSize = false;
            this.bindingNavigatorPositionItem6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem6.Name = "bindingNavigatorPositionItem6";
            this.bindingNavigatorPositionItem6.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem6.Text = "0";
            this.bindingNavigatorPositionItem6.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator19
            // 
            this.bindingNavigatorSeparator19.Name = "bindingNavigatorSeparator19";
            this.bindingNavigatorSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem6
            // 
            this.bindingNavigatorMoveNextItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem6.Image")));
            this.bindingNavigatorMoveNextItem6.Name = "bindingNavigatorMoveNextItem6";
            this.bindingNavigatorMoveNextItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem6.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem6
            // 
            this.bindingNavigatorMoveLastItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem6.Image")));
            this.bindingNavigatorMoveLastItem6.Name = "bindingNavigatorMoveLastItem6";
            this.bindingNavigatorMoveLastItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem6.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator20
            // 
            this.bindingNavigatorSeparator20.Name = "bindingNavigatorSeparator20";
            this.bindingNavigatorSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveShopsItem
            // 
            this.toolStripButtonSaveShopsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveShopsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveShopsItem.Image")));
            this.toolStripButtonSaveShopsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveShopsItem.Name = "toolStripButtonSaveShopsItem";
            this.toolStripButtonSaveShopsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveShopsItem.Text = "Сохранить";
            this.toolStripButtonSaveShopsItem.Click += new System.EventHandler(this.toolStripButtonSaveShopsItem_Click);
            // 
            // toolStripButtonEditShopsItem
            // 
            this.toolStripButtonEditShopsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditShopsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditShopsItem.Image")));
            this.toolStripButtonEditShopsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditShopsItem.Name = "toolStripButtonEditShopsItem";
            this.toolStripButtonEditShopsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditShopsItem.Text = "Редактировать";
            this.toolStripButtonEditShopsItem.Click += new System.EventHandler(this.toolStripButtonEditShopsItem_Click);
            // 
            // toolStripButtonUpdateShopsItem
            // 
            this.toolStripButtonUpdateShopsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateShopsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateShopsItem.Image")));
            this.toolStripButtonUpdateShopsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateShopsItem.Name = "toolStripButtonUpdateShopsItem";
            this.toolStripButtonUpdateShopsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateShopsItem.Text = "Обновить";
            this.toolStripButtonUpdateShopsItem.Click += new System.EventHandler(this.toolStripButtonUpdateShopsItem_Click);
            // 
            // groupBoxEditShops
            // 
            this.groupBoxEditShops.Controls.Add(this.buttonSaveShop);
            this.groupBoxEditShops.Controls.Add(this.buttonCancelEditingShops);
            this.groupBoxEditShops.Controls.Add(this.comboBoxShopsName);
            this.groupBoxEditShops.Controls.Add(this.maskedTextBoxShopsNumberPhone);
            this.groupBoxEditShops.Controls.Add(this.textBoxShopsAddress);
            this.groupBoxEditShops.Controls.Add(this.label38);
            this.groupBoxEditShops.Controls.Add(this.label37);
            this.groupBoxEditShops.Controls.Add(this.label36);
            this.groupBoxEditShops.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEditShops.Location = new System.Drawing.Point(0, 244);
            this.groupBoxEditShops.Name = "groupBoxEditShops";
            this.groupBoxEditShops.Size = new System.Drawing.Size(561, 238);
            this.groupBoxEditShops.TabIndex = 3;
            this.groupBoxEditShops.TabStop = false;
            this.groupBoxEditShops.Text = "Редактирование";
            // 
            // buttonSaveShop
            // 
            this.buttonSaveShop.Location = new System.Drawing.Point(411, 193);
            this.buttonSaveShop.Name = "buttonSaveShop";
            this.buttonSaveShop.Size = new System.Drawing.Size(144, 39);
            this.buttonSaveShop.TabIndex = 15;
            this.buttonSaveShop.Text = "Сохранить";
            this.buttonSaveShop.UseVisualStyleBackColor = true;
            this.buttonSaveShop.Click += new System.EventHandler(this.buttonSaveShop_Click);
            // 
            // buttonCancelEditingShops
            // 
            this.buttonCancelEditingShops.Location = new System.Drawing.Point(6, 193);
            this.buttonCancelEditingShops.Name = "buttonCancelEditingShops";
            this.buttonCancelEditingShops.Size = new System.Drawing.Size(144, 39);
            this.buttonCancelEditingShops.TabIndex = 14;
            this.buttonCancelEditingShops.Text = "Отмена";
            this.buttonCancelEditingShops.UseVisualStyleBackColor = true;
            this.buttonCancelEditingShops.Click += new System.EventHandler(this.buttonCancelEditingShops_Click);
            // 
            // comboBoxShopsName
            // 
            this.comboBoxShopsName.DataSource = this.shopsnameBindingSource;
            this.comboBoxShopsName.DisplayMember = "shops_name";
            this.comboBoxShopsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShopsName.FormattingEnabled = true;
            this.comboBoxShopsName.Location = new System.Drawing.Point(158, 132);
            this.comboBoxShopsName.Name = "comboBoxShopsName";
            this.comboBoxShopsName.Size = new System.Drawing.Size(307, 28);
            this.comboBoxShopsName.TabIndex = 13;
            this.comboBoxShopsName.ValueMember = "shops_name_id";
            // 
            // shopsnameBindingSource
            // 
            this.shopsnameBindingSource.DataMember = "shops_name";
            this.shopsnameBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // maskedTextBoxShopsNumberPhone
            // 
            this.maskedTextBoxShopsNumberPhone.Location = new System.Drawing.Point(158, 90);
            this.maskedTextBoxShopsNumberPhone.Mask = "0-000-000-00-00";
            this.maskedTextBoxShopsNumberPhone.Name = "maskedTextBoxShopsNumberPhone";
            this.maskedTextBoxShopsNumberPhone.Size = new System.Drawing.Size(307, 26);
            this.maskedTextBoxShopsNumberPhone.TabIndex = 12;
            this.maskedTextBoxShopsNumberPhone.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxShopsAddress
            // 
            this.textBoxShopsAddress.Location = new System.Drawing.Point(158, 41);
            this.textBoxShopsAddress.MaxLength = 50;
            this.textBoxShopsAddress.Name = "textBoxShopsAddress";
            this.textBoxShopsAddress.Size = new System.Drawing.Size(307, 26);
            this.textBoxShopsAddress.TabIndex = 3;
            this.textBoxShopsAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAuthorLastName_Validating);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(44, 135);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(83, 20);
            this.label38.TabIndex = 2;
            this.label38.Text = "Название";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(48, 93);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 20);
            this.label37.TabIndex = 1;
            this.label37.Text = "Телефон";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(70, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 20);
            this.label36.TabIndex = 0;
            this.label36.Text = "Адрес";
            // 
            // groupBoxSearchShops
            // 
            this.groupBoxSearchShops.Controls.Add(this.comboBoxConditionShops);
            this.groupBoxSearchShops.Controls.Add(this.buttonPrintShops);
            this.groupBoxSearchShops.Controls.Add(this.buttonQueryShops);
            this.groupBoxSearchShops.Controls.Add(this.label16);
            this.groupBoxSearchShops.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchShops.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchShops.Name = "groupBoxSearchShops";
            this.groupBoxSearchShops.Size = new System.Drawing.Size(561, 244);
            this.groupBoxSearchShops.TabIndex = 2;
            this.groupBoxSearchShops.TabStop = false;
            this.groupBoxSearchShops.Text = "Поиск";
            // 
            // comboBoxConditionShops
            // 
            this.comboBoxConditionShops.DataSource = this.shops_nameBindingSource;
            this.comboBoxConditionShops.DisplayMember = "shops_name";
            this.comboBoxConditionShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConditionShops.FormattingEnabled = true;
            this.comboBoxConditionShops.Location = new System.Drawing.Point(158, 82);
            this.comboBoxConditionShops.Name = "comboBoxConditionShops";
            this.comboBoxConditionShops.Size = new System.Drawing.Size(245, 28);
            this.comboBoxConditionShops.TabIndex = 9;
            this.comboBoxConditionShops.ValueMember = "shops_name_id";
            // 
            // buttonPrintShops
            // 
            this.buttonPrintShops.Location = new System.Drawing.Point(158, 198);
            this.buttonPrintShops.Name = "buttonPrintShops";
            this.buttonPrintShops.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintShops.TabIndex = 8;
            this.buttonPrintShops.Text = "Печать запроса";
            this.buttonPrintShops.UseVisualStyleBackColor = true;
            this.buttonPrintShops.Click += new System.EventHandler(this.buttonPrintShops_Click);
            // 
            // buttonQueryShops
            // 
            this.buttonQueryShops.Location = new System.Drawing.Point(158, 150);
            this.buttonQueryShops.Name = "buttonQueryShops";
            this.buttonQueryShops.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryShops.TabIndex = 7;
            this.buttonQueryShops.Text = "Выполнить запрос";
            this.buttonQueryShops.UseVisualStyleBackColor = true;
            this.buttonQueryShops.Click += new System.EventHandler(this.buttonQueryShops_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Поиск по названию";
            // 
            // tabPageShopsBooksForAdmin
            // 
            this.tabPageShopsBooksForAdmin.Controls.Add(this.splitContainerBooksInShops);
            this.tabPageShopsBooksForAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageShopsBooksForAdmin.Name = "tabPageShopsBooksForAdmin";
            this.tabPageShopsBooksForAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShopsBooksForAdmin.Size = new System.Drawing.Size(1224, 491);
            this.tabPageShopsBooksForAdmin.TabIndex = 6;
            this.tabPageShopsBooksForAdmin.Text = "Книги в магазинах (для редактирования)";
            this.tabPageShopsBooksForAdmin.UseVisualStyleBackColor = true;
            this.tabPageShopsBooksForAdmin.Leave += new System.EventHandler(this.tabPageShopsBooks_Leave);
            // 
            // splitContainerBooksInShops
            // 
            this.splitContainerBooksInShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBooksInShops.Location = new System.Drawing.Point(3, 3);
            this.splitContainerBooksInShops.Name = "splitContainerBooksInShops";
            // 
            // splitContainerBooksInShops.Panel1
            // 
            this.splitContainerBooksInShops.Panel1.Controls.Add(this.shops_booksDataGridView);
            this.splitContainerBooksInShops.Panel1.Controls.Add(this.shops_booksBindingNavigator);
            // 
            // splitContainerBooksInShops.Panel2
            // 
            this.splitContainerBooksInShops.Panel2.Controls.Add(this.groupBoxEditShops_Books);
            this.splitContainerBooksInShops.Panel2.Controls.Add(this.groupBoxSearchShops_Books);
            this.splitContainerBooksInShops.Size = new System.Drawing.Size(1218, 485);
            this.splitContainerBooksInShops.SplitterDistance = 759;
            this.splitContainerBooksInShops.TabIndex = 1;
            // 
            // shops_booksDataGridView
            // 
            this.shops_booksDataGridView.AllowUserToAddRows = false;
            this.shops_booksDataGridView.AutoGenerateColumns = false;
            this.shops_booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shops_booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.shops_booksDataGridView.DataSource = this.shops_booksBindingSource;
            this.shops_booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shops_booksDataGridView.Location = new System.Drawing.Point(0, 25);
            this.shops_booksDataGridView.Name = "shops_booksDataGridView";
            this.shops_booksDataGridView.Size = new System.Drawing.Size(759, 460);
            this.shops_booksDataGridView.TabIndex = 0;
            this.shops_booksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.shops_booksDataGridView.SelectionChanged += new System.EventHandler(this.shops_booksDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "shops_books_id";
            this.dataGridViewTextBoxColumn26.FillWeight = 20F;
            this.dataGridViewTextBoxColumn26.HeaderText = "id";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 50;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "shops_books_shops_id";
            this.dataGridViewTextBoxColumn27.HeaderText = "id магазина";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn27.Width = 150;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "shops_books_books_id";
            this.dataGridViewTextBoxColumn28.DataSource = this.booksBindingSource;
            this.dataGridViewTextBoxColumn28.DisplayMember = "books_name";
            this.dataGridViewTextBoxColumn28.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn28.HeaderText = "Книга";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn28.ValueMember = "books_id";
            this.dataGridViewTextBoxColumn28.Width = 150;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "shops_books_books_in_shops_count";
            this.dataGridViewTextBoxColumn29.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "shops_books_cost";
            this.dataGridViewTextBoxColumn30.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "shops_books_summary_cost";
            this.dataGridViewTextBoxColumn31.HeaderText = "Общая стоимость";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 150;
            // 
            // shops_booksBindingSource
            // 
            this.shops_booksBindingSource.DataMember = "shops_books";
            this.shops_booksBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // shops_booksBindingNavigator
            // 
            this.shops_booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem7;
            this.shops_booksBindingNavigator.BindingSource = this.shops_booksBindingSource;
            this.shops_booksBindingNavigator.CountItem = this.bindingNavigatorCountItem7;
            this.shops_booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem7;
            this.shops_booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem7,
            this.bindingNavigatorMovePreviousItem7,
            this.bindingNavigatorSeparator21,
            this.bindingNavigatorPositionItem7,
            this.bindingNavigatorCountItem7,
            this.bindingNavigatorSeparator22,
            this.bindingNavigatorMoveNextItem7,
            this.bindingNavigatorMoveLastItem7,
            this.bindingNavigatorSeparator23,
            this.bindingNavigatorAddNewItem7,
            this.bindingNavigatorDeleteItem7,
            this.toolStripButtonSaveBooksInShopsItem,
            this.toolStripButtonEditBooksInShopsItem,
            this.toolStripButtonUpdateShopsInBooks});
            this.shops_booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shops_booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.shops_booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.shops_booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.shops_booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.shops_booksBindingNavigator.Name = "shops_booksBindingNavigator";
            this.shops_booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem7;
            this.shops_booksBindingNavigator.Size = new System.Drawing.Size(759, 25);
            this.shops_booksBindingNavigator.TabIndex = 1;
            this.shops_booksBindingNavigator.Text = "bindingNavigator5";
            // 
            // bindingNavigatorAddNewItem7
            // 
            this.bindingNavigatorAddNewItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem7.Image")));
            this.bindingNavigatorAddNewItem7.Name = "bindingNavigatorAddNewItem7";
            this.bindingNavigatorAddNewItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem7.Text = "Добавить";
            this.bindingNavigatorAddNewItem7.Click += new System.EventHandler(this.bindingNavigatorAddNewItem7_Click);
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem7.Text = "для {0}";
            this.bindingNavigatorCountItem7.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem7
            // 
            this.bindingNavigatorDeleteItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem7.Image")));
            this.bindingNavigatorDeleteItem7.Name = "bindingNavigatorDeleteItem7";
            this.bindingNavigatorDeleteItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem7.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem7
            // 
            this.bindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem7.Image")));
            this.bindingNavigatorMoveFirstItem7.Name = "bindingNavigatorMoveFirstItem7";
            this.bindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem7.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem7
            // 
            this.bindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem7.Image")));
            this.bindingNavigatorMovePreviousItem7.Name = "bindingNavigatorMovePreviousItem7";
            this.bindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem7.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator21
            // 
            this.bindingNavigatorSeparator21.Name = "bindingNavigatorSeparator21";
            this.bindingNavigatorSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem7
            // 
            this.bindingNavigatorPositionItem7.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem7.AutoSize = false;
            this.bindingNavigatorPositionItem7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem7.Name = "bindingNavigatorPositionItem7";
            this.bindingNavigatorPositionItem7.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem7.Text = "0";
            this.bindingNavigatorPositionItem7.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator22
            // 
            this.bindingNavigatorSeparator22.Name = "bindingNavigatorSeparator22";
            this.bindingNavigatorSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem7
            // 
            this.bindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem7.Image")));
            this.bindingNavigatorMoveNextItem7.Name = "bindingNavigatorMoveNextItem7";
            this.bindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem7.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem7
            // 
            this.bindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem7.Image")));
            this.bindingNavigatorMoveLastItem7.Name = "bindingNavigatorMoveLastItem7";
            this.bindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem7.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator23
            // 
            this.bindingNavigatorSeparator23.Name = "bindingNavigatorSeparator23";
            this.bindingNavigatorSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveBooksInShopsItem
            // 
            this.toolStripButtonSaveBooksInShopsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveBooksInShopsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveBooksInShopsItem.Image")));
            this.toolStripButtonSaveBooksInShopsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveBooksInShopsItem.Name = "toolStripButtonSaveBooksInShopsItem";
            this.toolStripButtonSaveBooksInShopsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveBooksInShopsItem.Text = "Сохранить";
            this.toolStripButtonSaveBooksInShopsItem.Click += new System.EventHandler(this.toolStripButtonSaveBooksInShopsItem_Click);
            // 
            // toolStripButtonEditBooksInShopsItem
            // 
            this.toolStripButtonEditBooksInShopsItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditBooksInShopsItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditBooksInShopsItem.Image")));
            this.toolStripButtonEditBooksInShopsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditBooksInShopsItem.Name = "toolStripButtonEditBooksInShopsItem";
            this.toolStripButtonEditBooksInShopsItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditBooksInShopsItem.Text = "Редактировать";
            this.toolStripButtonEditBooksInShopsItem.Click += new System.EventHandler(this.toolStripButtonEditBooksInShopsItem_Click);
            // 
            // toolStripButtonUpdateShopsInBooks
            // 
            this.toolStripButtonUpdateShopsInBooks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateShopsInBooks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateShopsInBooks.Image")));
            this.toolStripButtonUpdateShopsInBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateShopsInBooks.Name = "toolStripButtonUpdateShopsInBooks";
            this.toolStripButtonUpdateShopsInBooks.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateShopsInBooks.Text = "Обновить";
            this.toolStripButtonUpdateShopsInBooks.Click += new System.EventHandler(this.toolStripButtonUpdateShopsInBooks_Click);
            // 
            // groupBoxEditShops_Books
            // 
            this.groupBoxEditShops_Books.Controls.Add(this.buttonCancelShops_Books);
            this.groupBoxEditShops_Books.Controls.Add(this.buttonSaveShops_Books);
            this.groupBoxEditShops_Books.Controls.Add(this.numericUpDownCostBook);
            this.groupBoxEditShops_Books.Controls.Add(this.numericUpDownCountBooks);
            this.groupBoxEditShops_Books.Controls.Add(this.comboBoxShops_BooksBooksId);
            this.groupBoxEditShops_Books.Controls.Add(this.comboBoxShops_BooksShopsId);
            this.groupBoxEditShops_Books.Controls.Add(this.label41);
            this.groupBoxEditShops_Books.Controls.Add(this.label40);
            this.groupBoxEditShops_Books.Controls.Add(this.label39);
            this.groupBoxEditShops_Books.Controls.Add(this.label17);
            this.groupBoxEditShops_Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditShops_Books.Location = new System.Drawing.Point(0, 244);
            this.groupBoxEditShops_Books.Name = "groupBoxEditShops_Books";
            this.groupBoxEditShops_Books.Size = new System.Drawing.Size(455, 238);
            this.groupBoxEditShops_Books.TabIndex = 3;
            this.groupBoxEditShops_Books.TabStop = false;
            this.groupBoxEditShops_Books.Text = "Редактирование";
            // 
            // buttonCancelShops_Books
            // 
            this.buttonCancelShops_Books.Location = new System.Drawing.Point(6, 194);
            this.buttonCancelShops_Books.Name = "buttonCancelShops_Books";
            this.buttonCancelShops_Books.Size = new System.Drawing.Size(111, 38);
            this.buttonCancelShops_Books.TabIndex = 9;
            this.buttonCancelShops_Books.Text = "Отмена";
            this.buttonCancelShops_Books.UseVisualStyleBackColor = true;
            this.buttonCancelShops_Books.Click += new System.EventHandler(this.buttonCancelShops_Books_Click);
            // 
            // buttonSaveShops_Books
            // 
            this.buttonSaveShops_Books.Location = new System.Drawing.Point(338, 194);
            this.buttonSaveShops_Books.Name = "buttonSaveShops_Books";
            this.buttonSaveShops_Books.Size = new System.Drawing.Size(111, 38);
            this.buttonSaveShops_Books.TabIndex = 8;
            this.buttonSaveShops_Books.Text = "Сохранить";
            this.buttonSaveShops_Books.UseVisualStyleBackColor = true;
            this.buttonSaveShops_Books.Click += new System.EventHandler(this.buttonSaveShops_Books_Click);
            // 
            // numericUpDownCostBook
            // 
            this.numericUpDownCostBook.Location = new System.Drawing.Point(150, 148);
            this.numericUpDownCostBook.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCostBook.Name = "numericUpDownCostBook";
            this.numericUpDownCostBook.Size = new System.Drawing.Size(273, 20);
            this.numericUpDownCostBook.TabIndex = 7;
            // 
            // numericUpDownCountBooks
            // 
            this.numericUpDownCountBooks.Location = new System.Drawing.Point(150, 111);
            this.numericUpDownCountBooks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCountBooks.Name = "numericUpDownCountBooks";
            this.numericUpDownCountBooks.Size = new System.Drawing.Size(273, 20);
            this.numericUpDownCountBooks.TabIndex = 6;
            // 
            // comboBoxShops_BooksBooksId
            // 
            this.comboBoxShops_BooksBooksId.DataSource = this.booksBindingSource;
            this.comboBoxShops_BooksBooksId.DisplayMember = "books_name";
            this.comboBoxShops_BooksBooksId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShops_BooksBooksId.FormattingEnabled = true;
            this.comboBoxShops_BooksBooksId.Location = new System.Drawing.Point(150, 73);
            this.comboBoxShops_BooksBooksId.Name = "comboBoxShops_BooksBooksId";
            this.comboBoxShops_BooksBooksId.Size = new System.Drawing.Size(273, 21);
            this.comboBoxShops_BooksBooksId.TabIndex = 5;
            this.comboBoxShops_BooksBooksId.ValueMember = "books_id";
            // 
            // comboBoxShops_BooksShopsId
            // 
            this.comboBoxShops_BooksShopsId.DataSource = this.shopsBindingSource;
            this.comboBoxShops_BooksShopsId.DisplayMember = "shops_id";
            this.comboBoxShops_BooksShopsId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShops_BooksShopsId.FormattingEnabled = true;
            this.comboBoxShops_BooksShopsId.Location = new System.Drawing.Point(150, 36);
            this.comboBoxShops_BooksShopsId.Name = "comboBoxShops_BooksShopsId";
            this.comboBoxShops_BooksShopsId.Size = new System.Drawing.Size(273, 21);
            this.comboBoxShops_BooksShopsId.TabIndex = 4;
            this.comboBoxShops_BooksShopsId.ValueMember = "shops_books_shops_id";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(32, 150);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Стоимость";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(32, 113);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Количество";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(32, 76);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(37, 13);
            this.label39.TabIndex = 1;
            this.label39.Text = "Книга";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "id Магазин";
            // 
            // groupBoxSearchShops_Books
            // 
            this.groupBoxSearchShops_Books.Controls.Add(this.textBoxCondtitionBooksName);
            this.groupBoxSearchShops_Books.Controls.Add(this.buttonPrintQueryBooksShops);
            this.groupBoxSearchShops_Books.Controls.Add(this.buttonQueryBooksShops);
            this.groupBoxSearchShops_Books.Controls.Add(this.label18);
            this.groupBoxSearchShops_Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchShops_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearchShops_Books.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchShops_Books.Name = "groupBoxSearchShops_Books";
            this.groupBoxSearchShops_Books.Size = new System.Drawing.Size(455, 244);
            this.groupBoxSearchShops_Books.TabIndex = 2;
            this.groupBoxSearchShops_Books.TabStop = false;
            this.groupBoxSearchShops_Books.Text = "Поиск";
            // 
            // textBoxCondtitionBooksName
            // 
            this.textBoxCondtitionBooksName.Location = new System.Drawing.Point(161, 76);
            this.textBoxCondtitionBooksName.MaxLength = 40;
            this.textBoxCondtitionBooksName.Name = "textBoxCondtitionBooksName";
            this.textBoxCondtitionBooksName.Size = new System.Drawing.Size(262, 22);
            this.textBoxCondtitionBooksName.TabIndex = 9;
            // 
            // buttonPrintQueryBooksShops
            // 
            this.buttonPrintQueryBooksShops.Location = new System.Drawing.Point(100, 178);
            this.buttonPrintQueryBooksShops.Name = "buttonPrintQueryBooksShops";
            this.buttonPrintQueryBooksShops.Size = new System.Drawing.Size(245, 33);
            this.buttonPrintQueryBooksShops.TabIndex = 8;
            this.buttonPrintQueryBooksShops.Text = "Печать запроса";
            this.buttonPrintQueryBooksShops.UseVisualStyleBackColor = true;
            this.buttonPrintQueryBooksShops.Click += new System.EventHandler(this.buttonPrintQueryBooksShops_Click);
            // 
            // buttonQueryBooksShops
            // 
            this.buttonQueryBooksShops.Location = new System.Drawing.Point(100, 130);
            this.buttonQueryBooksShops.Name = "buttonQueryBooksShops";
            this.buttonQueryBooksShops.Size = new System.Drawing.Size(245, 33);
            this.buttonQueryBooksShops.TabIndex = 7;
            this.buttonQueryBooksShops.Text = "Выполнить запрос";
            this.buttonQueryBooksShops.UseVisualStyleBackColor = true;
            this.buttonQueryBooksShops.Click += new System.EventHandler(this.buttonQueryBooksShops_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Название книги";
            // 
            // tabPageShopsBooks
            // 
            this.tabPageShopsBooks.Controls.Add(this.shopsBooksNamedDataGridView);
            this.tabPageShopsBooks.Controls.Add(this.bindingNavigatorView);
            this.tabPageShopsBooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageShopsBooks.Name = "tabPageShopsBooks";
            this.tabPageShopsBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShopsBooks.Size = new System.Drawing.Size(1224, 491);
            this.tabPageShopsBooks.TabIndex = 7;
            this.tabPageShopsBooks.Text = "Книги в магазинах";
            this.tabPageShopsBooks.UseVisualStyleBackColor = true;
            // 
            // shopsBooksNamedDataGridView
            // 
            this.shopsBooksNamedDataGridView.AllowUserToAddRows = false;
            this.shopsBooksNamedDataGridView.AutoGenerateColumns = false;
            this.shopsBooksNamedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsBooksNamedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn41});
            this.shopsBooksNamedDataGridView.DataSource = this.shopsBooksNamedBindingSource;
            this.shopsBooksNamedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopsBooksNamedDataGridView.Location = new System.Drawing.Point(3, 28);
            this.shopsBooksNamedDataGridView.Name = "shopsBooksNamedDataGridView";
            this.shopsBooksNamedDataGridView.ReadOnly = true;
            this.shopsBooksNamedDataGridView.Size = new System.Drawing.Size(1218, 460);
            this.shopsBooksNamedDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "shops_name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Название";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "books_name";
            this.dataGridViewTextBoxColumn21.HeaderText = "Название книги";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "shops_books_books_in_shops_count";
            this.dataGridViewTextBoxColumn17.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "shops_books_cost";
            this.dataGridViewTextBoxColumn18.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "shops_address";
            this.dataGridViewTextBoxColumn20.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 200;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "shops_books_summary_cost";
            this.dataGridViewTextBoxColumn19.HeaderText = "Общая цена";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "shops_number_phone";
            this.dataGridViewTextBoxColumn41.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 150;
            // 
            // shopsBooksNamedBindingSource
            // 
            this.shopsBooksNamedBindingSource.DataMember = "ShopsBooksNamed";
            this.shopsBooksNamedBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // bindingNavigatorView
            // 
            this.bindingNavigatorView.AddNewItem = null;
            this.bindingNavigatorView.BindingSource = this.shopsBooksNamedBindingSource;
            this.bindingNavigatorView.CountItem = this.bindingNavigatorCountItem9;
            this.bindingNavigatorView.DeleteItem = null;
            this.bindingNavigatorView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem9,
            this.bindingNavigatorMovePreviousItem9,
            this.bindingNavigatorSeparator27,
            this.bindingNavigatorPositionItem9,
            this.bindingNavigatorCountItem9,
            this.bindingNavigatorSeparator28,
            this.bindingNavigatorMoveNextItem9,
            this.bindingNavigatorMoveLastItem9,
            this.bindingNavigatorSeparator29,
            this.toolStripButtonUpdateView,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxCriterionView,
            this.toolStripLabel2,
            this.toolStripTextBoxConditionView,
            this.toolStripButtonSearchByParam,
            this.toolStripButtonPrintView,
            this.toolStripSeparator});
            this.bindingNavigatorView.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorView.MoveFirstItem = this.bindingNavigatorMoveFirstItem9;
            this.bindingNavigatorView.MoveLastItem = this.bindingNavigatorMoveLastItem9;
            this.bindingNavigatorView.MoveNextItem = this.bindingNavigatorMoveNextItem9;
            this.bindingNavigatorView.MovePreviousItem = this.bindingNavigatorMovePreviousItem9;
            this.bindingNavigatorView.Name = "bindingNavigatorView";
            this.bindingNavigatorView.PositionItem = this.bindingNavigatorPositionItem9;
            this.bindingNavigatorView.Size = new System.Drawing.Size(1218, 25);
            this.bindingNavigatorView.TabIndex = 1;
            this.bindingNavigatorView.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem9
            // 
            this.bindingNavigatorCountItem9.Name = "bindingNavigatorCountItem9";
            this.bindingNavigatorCountItem9.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem9.Text = "для {0}";
            this.bindingNavigatorCountItem9.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem9
            // 
            this.bindingNavigatorMoveFirstItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem9.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem9.Image")));
            this.bindingNavigatorMoveFirstItem9.Name = "bindingNavigatorMoveFirstItem9";
            this.bindingNavigatorMoveFirstItem9.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem9.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem9.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem9
            // 
            this.bindingNavigatorMovePreviousItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem9.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem9.Image")));
            this.bindingNavigatorMovePreviousItem9.Name = "bindingNavigatorMovePreviousItem9";
            this.bindingNavigatorMovePreviousItem9.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem9.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem9.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator27
            // 
            this.bindingNavigatorSeparator27.Name = "bindingNavigatorSeparator27";
            this.bindingNavigatorSeparator27.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem9
            // 
            this.bindingNavigatorPositionItem9.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem9.AutoSize = false;
            this.bindingNavigatorPositionItem9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem9.Name = "bindingNavigatorPositionItem9";
            this.bindingNavigatorPositionItem9.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem9.Text = "0";
            this.bindingNavigatorPositionItem9.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator28
            // 
            this.bindingNavigatorSeparator28.Name = "bindingNavigatorSeparator28";
            this.bindingNavigatorSeparator28.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem9
            // 
            this.bindingNavigatorMoveNextItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem9.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem9.Image")));
            this.bindingNavigatorMoveNextItem9.Name = "bindingNavigatorMoveNextItem9";
            this.bindingNavigatorMoveNextItem9.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem9.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem9.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem9
            // 
            this.bindingNavigatorMoveLastItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem9.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem9.Image")));
            this.bindingNavigatorMoveLastItem9.Name = "bindingNavigatorMoveLastItem9";
            this.bindingNavigatorMoveLastItem9.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem9.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem9.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator29
            // 
            this.bindingNavigatorSeparator29.Name = "bindingNavigatorSeparator29";
            this.bindingNavigatorSeparator29.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdateView
            // 
            this.toolStripButtonUpdateView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateView.Image")));
            this.toolStripButtonUpdateView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateView.Name = "toolStripButtonUpdateView";
            this.toolStripButtonUpdateView.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateView.Text = "toolStripButton2";
            this.toolStripButtonUpdateView.Click += new System.EventHandler(this.toolStripButtonUpdateView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Критерий";
            // 
            // toolStripComboBoxCriterionView
            // 
            this.toolStripComboBoxCriterionView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCriterionView.Name = "toolStripComboBoxCriterionView";
            this.toolStripComboBoxCriterionView.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxCriterionView.Click += new System.EventHandler(this.toolStripComboBoxCriterionView_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "Условие";
            // 
            // toolStripTextBoxConditionView
            // 
            this.toolStripTextBoxConditionView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxConditionView.Name = "toolStripTextBoxConditionView";
            this.toolStripTextBoxConditionView.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonSearchByParam
            // 
            this.toolStripButtonSearchByParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchByParam.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchByParam.Image")));
            this.toolStripButtonSearchByParam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchByParam.Name = "toolStripButtonSearchByParam";
            this.toolStripButtonSearchByParam.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearchByParam.Text = "toolStripButton3";
            this.toolStripButtonSearchByParam.Click += new System.EventHandler(this.toolStripButtonSearchByParam_Click);
            // 
            // toolStripButtonPrintView
            // 
            this.toolStripButtonPrintView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrintView.Image")));
            this.toolStripButtonPrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrintView.Name = "toolStripButtonPrintView";
            this.toolStripButtonPrintView.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrintView.Text = "&Печать";
            this.toolStripButtonPrintView.Click += new System.EventHandler(this.toolStripButtonPrintView_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageHandbook
            // 
            this.tabPageHandbook.Controls.Add(this.tabControlHandBook);
            this.tabPageHandbook.Location = new System.Drawing.Point(4, 22);
            this.tabPageHandbook.Name = "tabPageHandbook";
            this.tabPageHandbook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHandbook.Size = new System.Drawing.Size(1238, 523);
            this.tabPageHandbook.TabIndex = 1;
            this.tabPageHandbook.Text = "Справочники";
            this.tabPageHandbook.UseVisualStyleBackColor = true;
            this.tabPageHandbook.Leave += new System.EventHandler(this.tabPageHandbook_Leave);
            // 
            // tabControlHandBook
            // 
            this.tabControlHandBook.Controls.Add(this.tabPageGenres);
            this.tabControlHandBook.Controls.Add(this.tabPageShopsNames);
            this.tabControlHandBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHandBook.Location = new System.Drawing.Point(3, 3);
            this.tabControlHandBook.Name = "tabControlHandBook";
            this.tabControlHandBook.SelectedIndex = 0;
            this.tabControlHandBook.Size = new System.Drawing.Size(1232, 517);
            this.tabControlHandBook.TabIndex = 0;
            // 
            // tabPageGenres
            // 
            this.tabPageGenres.Controls.Add(this.genresDataGridView);
            this.tabPageGenres.Controls.Add(this.genresBindingNavigator);
            this.tabPageGenres.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenres.Name = "tabPageGenres";
            this.tabPageGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenres.Size = new System.Drawing.Size(1224, 491);
            this.tabPageGenres.TabIndex = 0;
            this.tabPageGenres.Text = "Жанры";
            this.tabPageGenres.UseVisualStyleBackColor = true;
            this.tabPageGenres.Leave += new System.EventHandler(this.tabPageGenres_Leave);
            // 
            // genresDataGridView
            // 
            this.genresDataGridView.AllowUserToAddRows = false;
            this.genresDataGridView.AutoGenerateColumns = false;
            this.genresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnGenreId,
            this.dataGridViewTextBoxColumn3});
            this.genresDataGridView.DataSource = this.genresBindingSource;
            this.genresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genresDataGridView.Location = new System.Drawing.Point(3, 28);
            this.genresDataGridView.Name = "genresDataGridView";
            this.genresDataGridView.Size = new System.Drawing.Size(1218, 460);
            this.genresDataGridView.TabIndex = 0;
            this.genresDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.genresDataGridView_CellBeginEdit);
            this.genresDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.genresDataGridView_CellEndEdit);
            this.genresDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.genresDataGridView_CellValidating);
            this.genresDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.genresDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumnGenreId
            // 
            this.dataGridViewTextBoxColumnGenreId.DataPropertyName = "genre_id";
            this.dataGridViewTextBoxColumnGenreId.HeaderText = "id";
            this.dataGridViewTextBoxColumnGenreId.Name = "dataGridViewTextBoxColumnGenreId";
            this.dataGridViewTextBoxColumnGenreId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "genre_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // genresBindingNavigator
            // 
            this.genresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.genresBindingNavigator.BindingSource = this.genresBindingSource;
            this.genresBindingNavigator.CountItem = this.bindingNavigatorCountItem2;
            this.genresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.genresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.toolStripLabel4,
            this.toolStripTextBoxConditionGenres,
            this.toolStripSeparator2,
            this.toolStripButtonSearch,
            this.печатьToolStripButton,
            this.toolStripSeparator3,
            this.bindingNavigatorAddNewItem2,
            this.toolStripButtonCancelGenres,
            this.bindingNavigatorDeleteItem2,
            this.toolStripButtonSaveGenre,
            this.toolStripButtonUpdateGenres});
            this.genresBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.genresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.genresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.genresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.genresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.genresBindingNavigator.Name = "genresBindingNavigator";
            this.genresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem2;
            this.genresBindingNavigator.Size = new System.Drawing.Size(1218, 25);
            this.genresBindingNavigator.TabIndex = 1;
            this.genresBindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            this.bindingNavigatorAddNewItem2.Click += new System.EventHandler(this.bindingNavigatorAddNewItem2_Click);
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "Условие";
            // 
            // toolStripTextBoxConditionGenres
            // 
            this.toolStripTextBoxConditionGenres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxConditionGenres.Name = "toolStripTextBoxConditionGenres";
            this.toolStripTextBoxConditionGenres.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "toolStripButton4";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.печатьToolStripButton.Text = "&Печать";
            this.печатьToolStripButton.Click += new System.EventHandler(this.печатьToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCancelGenres
            // 
            this.toolStripButtonCancelGenres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancelGenres.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelGenres.Image")));
            this.toolStripButtonCancelGenres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelGenres.Name = "toolStripButtonCancelGenres";
            this.toolStripButtonCancelGenres.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCancelGenres.Text = "toolStripButton1";
            this.toolStripButtonCancelGenres.Click += new System.EventHandler(this.toolStripButtonCancelGenres_Click);
            // 
            // toolStripButtonSaveGenre
            // 
            this.toolStripButtonSaveGenre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveGenre.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveGenre.Image")));
            this.toolStripButtonSaveGenre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveGenre.Name = "toolStripButtonSaveGenre";
            this.toolStripButtonSaveGenre.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveGenre.Text = "toolStripButton3";
            this.toolStripButtonSaveGenre.Click += new System.EventHandler(this.toolStripButtonSaveGenre_Click);
            // 
            // toolStripButtonUpdateGenres
            // 
            this.toolStripButtonUpdateGenres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdateGenres.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateGenres.Image")));
            this.toolStripButtonUpdateGenres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateGenres.Name = "toolStripButtonUpdateGenres";
            this.toolStripButtonUpdateGenres.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdateGenres.Text = "toolStripButton2";
            this.toolStripButtonUpdateGenres.Click += new System.EventHandler(this.toolStripButtonUpdateGenres_Click);
            // 
            // tabPageShopsNames
            // 
            this.tabPageShopsNames.Controls.Add(this.shops_nameDataGridView);
            this.tabPageShopsNames.Controls.Add(this.shops_nameBindingNavigator);
            this.tabPageShopsNames.Location = new System.Drawing.Point(4, 22);
            this.tabPageShopsNames.Name = "tabPageShopsNames";
            this.tabPageShopsNames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShopsNames.Size = new System.Drawing.Size(1224, 491);
            this.tabPageShopsNames.TabIndex = 1;
            this.tabPageShopsNames.Text = "Магазины (сети)";
            this.tabPageShopsNames.UseVisualStyleBackColor = true;
            // 
            // shops_nameDataGridView
            // 
            this.shops_nameDataGridView.AllowUserToAddRows = false;
            this.shops_nameDataGridView.AutoGenerateColumns = false;
            this.shops_nameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shops_nameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn10});
            this.shops_nameDataGridView.DataSource = this.shops_nameBindingSource;
            this.shops_nameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shops_nameDataGridView.Location = new System.Drawing.Point(3, 28);
            this.shops_nameDataGridView.Name = "shops_nameDataGridView";
            this.shops_nameDataGridView.Size = new System.Drawing.Size(1218, 460);
            this.shops_nameDataGridView.TabIndex = 0;
            this.shops_nameDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.shops_nameDataGridView_CellBeginEdit);
            this.shops_nameDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.shops_nameDataGridView_CellEndEdit);
            this.shops_nameDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.shops_nameDataGridView_CellValidating);
            this.shops_nameDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.shops_nameDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "shops_name_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "shops_name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Название сети";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 250;
            // 
            // shops_nameBindingNavigator
            // 
            this.shops_nameBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.shops_nameBindingNavigator.BindingSource = this.shops_nameBindingSource;
            this.shops_nameBindingNavigator.CountItem = this.bindingNavigatorCountItem3;
            this.shops_nameBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.shops_nameBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.toolStripLabel3,
            this.toolStripTextBoxConditionShopsName,
            this.toolStripSeparator4,
            this.toolStripButtonSearchShopsName,
            this.toolStripButtonPrintShopsNames,
            this.toolStripSeparator5,
            this.bindingNavigatorAddNewItem3,
            this.toolStripButtonCancelEditingShopsName,
            this.bindingNavigatorDeleteItem3,
            this.toolStripButtonSaveShopsName,
            this.toolStripButton3});
            this.shops_nameBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.shops_nameBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.shops_nameBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.shops_nameBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.shops_nameBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.shops_nameBindingNavigator.Name = "shops_nameBindingNavigator";
            this.shops_nameBindingNavigator.PositionItem = this.bindingNavigatorPositionItem3;
            this.shops_nameBindingNavigator.Size = new System.Drawing.Size(1218, 25);
            this.shops_nameBindingNavigator.TabIndex = 1;
            this.shops_nameBindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Добавить";
            this.bindingNavigatorAddNewItem3.Click += new System.EventHandler(this.bindingNavigatorAddNewItem3_Click);
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem3.Text = "для {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel3.Text = "Условие";
            // 
            // toolStripTextBoxConditionShopsName
            // 
            this.toolStripTextBoxConditionShopsName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxConditionShopsName.Name = "toolStripTextBoxConditionShopsName";
            this.toolStripTextBoxConditionShopsName.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSearchShopsName
            // 
            this.toolStripButtonSearchShopsName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchShopsName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchShopsName.Image")));
            this.toolStripButtonSearchShopsName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchShopsName.Name = "toolStripButtonSearchShopsName";
            this.toolStripButtonSearchShopsName.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearchShopsName.Text = "toolStripButton4";
            this.toolStripButtonSearchShopsName.Click += new System.EventHandler(this.toolStripButtonSearchShopsName_Click);
            // 
            // toolStripButtonPrintShopsNames
            // 
            this.toolStripButtonPrintShopsNames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintShopsNames.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrintShopsNames.Image")));
            this.toolStripButtonPrintShopsNames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrintShopsNames.Name = "toolStripButtonPrintShopsNames";
            this.toolStripButtonPrintShopsNames.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrintShopsNames.Text = "&Печать";
            this.toolStripButtonPrintShopsNames.Click += new System.EventHandler(this.toolStripButtonPrintShopsNames_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCancelEditingShopsName
            // 
            this.toolStripButtonCancelEditingShopsName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancelEditingShopsName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelEditingShopsName.Image")));
            this.toolStripButtonCancelEditingShopsName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelEditingShopsName.Name = "toolStripButtonCancelEditingShopsName";
            this.toolStripButtonCancelEditingShopsName.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCancelEditingShopsName.Text = "Отмена";
            this.toolStripButtonCancelEditingShopsName.Click += new System.EventHandler(this.toolStripButtonCancelEditingShopsName_Click);
            // 
            // toolStripButtonSaveShopsName
            // 
            this.toolStripButtonSaveShopsName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveShopsName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveShopsName.Image")));
            this.toolStripButtonSaveShopsName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveShopsName.Name = "toolStripButtonSaveShopsName";
            this.toolStripButtonSaveShopsName.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveShopsName.Text = "Сохранить";
            this.toolStripButtonSaveShopsName.Click += new System.EventHandler(this.toolStripButtonSaveShopsName_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Обновить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.tabControl1);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(1238, 523);
            this.tabPageLogs.TabIndex = 2;
            this.tabPageLogs.Text = "Журнал ошибок";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // logTableDataGridView
            // 
            this.logTableDataGridView.AllowUserToAddRows = false;
            this.logTableDataGridView.AutoGenerateColumns = false;
            this.logTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40});
            this.logTableDataGridView.DataSource = this.logTableBindingSource;
            this.logTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTableDataGridView.Location = new System.Drawing.Point(3, 28);
            this.logTableDataGridView.Name = "logTableDataGridView";
            this.logTableDataGridView.Size = new System.Drawing.Size(1218, 460);
            this.logTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "log_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "log_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "log_date";
            this.dataGridViewTextBoxColumn39.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 250;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "log_msg";
            this.dataGridViewTextBoxColumn40.HeaderText = "Сообщение";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 500;
            // 
            // logTableBindingSource
            // 
            this.logTableBindingSource.DataMember = "LogTable";
            this.logTableBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // bindingNavigatorLogs
            // 
            this.bindingNavigatorLogs.AddNewItem = null;
            this.bindingNavigatorLogs.BindingSource = this.logTableBindingSource;
            this.bindingNavigatorLogs.CountItem = this.bindingNavigatorCountItem10;
            this.bindingNavigatorLogs.DeleteItem = this.bindingNavigatorDeleteItem9;
            this.bindingNavigatorLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem10,
            this.bindingNavigatorMovePreviousItem10,
            this.bindingNavigatorSeparator30,
            this.bindingNavigatorPositionItem10,
            this.bindingNavigatorCountItem10,
            this.bindingNavigatorSeparator31,
            this.bindingNavigatorMoveNextItem10,
            this.bindingNavigatorMoveLastItem10,
            this.bindingNavigatorSeparator32,
            this.bindingNavigatorDeleteItem9});
            this.bindingNavigatorLogs.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorLogs.MoveFirstItem = this.bindingNavigatorMoveFirstItem10;
            this.bindingNavigatorLogs.MoveLastItem = this.bindingNavigatorMoveLastItem10;
            this.bindingNavigatorLogs.MoveNextItem = this.bindingNavigatorMoveNextItem10;
            this.bindingNavigatorLogs.MovePreviousItem = this.bindingNavigatorMovePreviousItem10;
            this.bindingNavigatorLogs.Name = "bindingNavigatorLogs";
            this.bindingNavigatorLogs.PositionItem = this.bindingNavigatorPositionItem10;
            this.bindingNavigatorLogs.Size = new System.Drawing.Size(1218, 25);
            this.bindingNavigatorLogs.TabIndex = 1;
            this.bindingNavigatorLogs.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem10
            // 
            this.bindingNavigatorCountItem10.Name = "bindingNavigatorCountItem10";
            this.bindingNavigatorCountItem10.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem10.Text = "для {0}";
            this.bindingNavigatorCountItem10.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem9
            // 
            this.bindingNavigatorDeleteItem9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem9.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem9.Image")));
            this.bindingNavigatorDeleteItem9.Name = "bindingNavigatorDeleteItem9";
            this.bindingNavigatorDeleteItem9.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem9.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem9.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem10
            // 
            this.bindingNavigatorMoveFirstItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem10.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem10.Image")));
            this.bindingNavigatorMoveFirstItem10.Name = "bindingNavigatorMoveFirstItem10";
            this.bindingNavigatorMoveFirstItem10.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem10.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem10.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem10
            // 
            this.bindingNavigatorMovePreviousItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem10.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem10.Image")));
            this.bindingNavigatorMovePreviousItem10.Name = "bindingNavigatorMovePreviousItem10";
            this.bindingNavigatorMovePreviousItem10.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem10.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem10.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator30
            // 
            this.bindingNavigatorSeparator30.Name = "bindingNavigatorSeparator30";
            this.bindingNavigatorSeparator30.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem10
            // 
            this.bindingNavigatorPositionItem10.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem10.AutoSize = false;
            this.bindingNavigatorPositionItem10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem10.Name = "bindingNavigatorPositionItem10";
            this.bindingNavigatorPositionItem10.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem10.Text = "0";
            this.bindingNavigatorPositionItem10.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator31
            // 
            this.bindingNavigatorSeparator31.Name = "bindingNavigatorSeparator31";
            this.bindingNavigatorSeparator31.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem10
            // 
            this.bindingNavigatorMoveNextItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem10.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem10.Image")));
            this.bindingNavigatorMoveNextItem10.Name = "bindingNavigatorMoveNextItem10";
            this.bindingNavigatorMoveNextItem10.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem10.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem10.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem10
            // 
            this.bindingNavigatorMoveLastItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem10.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem10.Image")));
            this.bindingNavigatorMoveLastItem10.Name = "bindingNavigatorMoveLastItem10";
            this.bindingNavigatorMoveLastItem10.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem10.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem10.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator32
            // 
            this.bindingNavigatorSeparator32.Name = "bindingNavigatorSeparator32";
            this.bindingNavigatorSeparator32.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutAuthorToolStripMenuItem.Text = "Об авторе";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // author_bookTableAdapter
            // 
            this.author_bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.author_bookTableAdapter = this.author_bookTableAdapter;
            this.tableAdapterManager.authorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksLogTableTableAdapter = null;
            this.tableAdapterManager.booksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.designersTableAdapter = null;
            this.tableAdapterManager.editorsTableAdapter = null;
            this.tableAdapterManager.genresTableAdapter = this.genresTableAdapter;
            this.tableAdapterManager.LogTableTableAdapter = null;
            this.tableAdapterManager.shops_booksTableAdapter = null;
            this.tableAdapterManager.shops_nameTableAdapter = null;
            this.tableAdapterManager.shopsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kursach_1.publishing_houseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // publishinghouseDataSetBindingSource
            // 
            this.publishinghouseDataSetBindingSource.DataSource = this.publishing_houseDataSet;
            this.publishinghouseDataSetBindingSource.Position = 0;
            // 
            // editorsTableAdapter
            // 
            this.editorsTableAdapter.ClearBeforeFill = true;
            // 
            // shops_nameTableAdapter
            // 
            this.shops_nameTableAdapter.ClearBeforeFill = true;
            // 
            // designersTableAdapter
            // 
            this.designersTableAdapter.ClearBeforeFill = true;
            // 
            // shopsTableAdapter
            // 
            this.shopsTableAdapter.ClearBeforeFill = true;
            // 
            // shops_booksTableAdapter
            // 
            this.shops_booksTableAdapter.ClearBeforeFill = true;
            // 
            // fKbooksdesignerBindingSource
            // 
            this.fKbooksdesignerBindingSource.DataMember = "FK_books_designer";
            this.fKbooksdesignerBindingSource.DataSource = this.designersBindingSource;
            // 
            // fKshopsbooksshopsBindingSource
            // 
            this.fKshopsbooksshopsBindingSource.DataMember = "FK_shops_books_shops";
            this.fKshopsbooksshopsBindingSource.DataSource = this.shopsBindingSource;
            // 
            // addAuthorAndBookBindingSource
            // 
            this.addAuthorAndBookBindingSource.DataMember = "AddAuthorAndBook";
            this.addAuthorAndBookBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // addAuthorAndBookTableAdapter
            // 
            this.addAuthorAndBookTableAdapter.ClearBeforeFill = true;
            // 
            // logTableTableAdapter
            // 
            this.logTableTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // shopsBooksNamedTableAdapter
            // 
            this.shopsBooksNamedTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogsErrors);
            this.tabControl1.Controls.Add(this.tabPageOperationsBooksTable);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 517);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLogsErrors
            // 
            this.tabPageLogsErrors.Controls.Add(this.logTableDataGridView);
            this.tabPageLogsErrors.Controls.Add(this.bindingNavigatorLogs);
            this.tabPageLogsErrors.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogsErrors.Name = "tabPageLogsErrors";
            this.tabPageLogsErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogsErrors.Size = new System.Drawing.Size(1224, 491);
            this.tabPageLogsErrors.TabIndex = 0;
            this.tabPageLogsErrors.Text = "Журнал";
            this.tabPageLogsErrors.UseVisualStyleBackColor = true;
            // 
            // tabPageOperationsBooksTable
            // 
            this.tabPageOperationsBooksTable.Controls.Add(this.booksLogTableDataGridView);
            this.tabPageOperationsBooksTable.Controls.Add(this.bindingNavigator1);
            this.tabPageOperationsBooksTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperationsBooksTable.Name = "tabPageOperationsBooksTable";
            this.tabPageOperationsBooksTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperationsBooksTable.Size = new System.Drawing.Size(1224, 491);
            this.tabPageOperationsBooksTable.TabIndex = 1;
            this.tabPageOperationsBooksTable.Text = "Журнал (таблица книг)";
            this.tabPageOperationsBooksTable.UseVisualStyleBackColor = true;
            // 
            // booksLogTableBindingSource
            // 
            this.booksLogTableBindingSource.DataMember = "booksLogTable";
            this.booksLogTableBindingSource.DataSource = this.publishing_houseDataSet;
            // 
            // booksLogTableTableAdapter
            // 
            this.booksLogTableTableAdapter.ClearBeforeFill = true;
            // 
            // booksLogTableDataGridView
            // 
            this.booksLogTableDataGridView.AllowUserToAddRows = false;
            this.booksLogTableDataGridView.AutoGenerateColumns = false;
            this.booksLogTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksLogTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46});
            this.booksLogTableDataGridView.DataSource = this.booksLogTableBindingSource;
            this.booksLogTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksLogTableDataGridView.Location = new System.Drawing.Point(3, 28);
            this.booksLogTableDataGridView.Name = "booksLogTableDataGridView";
            this.booksLogTableDataGridView.ReadOnly = true;
            this.booksLogTableDataGridView.Size = new System.Drawing.Size(1218, 460);
            this.booksLogTableDataGridView.TabIndex = 0;
            this.booksLogTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksLogTableDataGridView_CellContentClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.booksLogTableBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem11;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem10;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem11,
            this.bindingNavigatorMovePreviousItem11,
            this.bindingNavigatorSeparator33,
            this.bindingNavigatorPositionItem11,
            this.bindingNavigatorCountItem11,
            this.bindingNavigatorSeparator34,
            this.bindingNavigatorMoveNextItem11,
            this.bindingNavigatorMoveLastItem11,
            this.bindingNavigatorSeparator35,
            this.bindingNavigatorDeleteItem10});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem11;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem11;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem11;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem11;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem11;
            this.bindingNavigator1.Size = new System.Drawing.Size(1218, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem11
            // 
            this.bindingNavigatorMoveFirstItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem11.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem11.Image")));
            this.bindingNavigatorMoveFirstItem11.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem11.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem11.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem11.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem11
            // 
            this.bindingNavigatorMovePreviousItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem11.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem11.Image")));
            this.bindingNavigatorMovePreviousItem11.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem11.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem11.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem11.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator33
            // 
            this.bindingNavigatorSeparator33.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator33.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem11
            // 
            this.bindingNavigatorPositionItem11.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem11.AutoSize = false;
            this.bindingNavigatorPositionItem11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem11.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem11.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem11.Text = "0";
            this.bindingNavigatorPositionItem11.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem11
            // 
            this.bindingNavigatorCountItem11.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem11.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem11.Text = "для {0}";
            this.bindingNavigatorCountItem11.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator34
            // 
            this.bindingNavigatorSeparator34.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator34.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem11
            // 
            this.bindingNavigatorMoveNextItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem11.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem11.Image")));
            this.bindingNavigatorMoveNextItem11.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem11.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem11.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem11.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem11
            // 
            this.bindingNavigatorMoveLastItem11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem11.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem11.Image")));
            this.bindingNavigatorMoveLastItem11.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem11.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem11.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem11.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator35
            // 
            this.bindingNavigatorSeparator35.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator35.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem10
            // 
            this.bindingNavigatorDeleteItem10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem10.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem10.Image")));
            this.bindingNavigatorDeleteItem10.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem10.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem10.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem10.Text = "Удалить";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "booksLogTable_id";
            this.dataGridViewTextBoxColumn42.HeaderText = "id";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "booksLogTable_books_id";
            this.dataGridViewTextBoxColumn43.HeaderText = "id книги";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "booksLogTable_books_name";
            this.dataGridViewTextBoxColumn44.HeaderText = "Название";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 250;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "booksLogTable_Operation";
            this.dataGridViewTextBoxColumn45.HeaderText = "Операция";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "booksLogTable_CreateAt";
            this.dataGridViewTextBoxColumn46.HeaderText = "Время";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 573);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Литературное издательство";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageFacts.ResumeLayout(false);
            this.tabControlFacts.ResumeLayout(false);
            this.tabPageAuthorsBooks.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.author_bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishing_houseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_bookBindingNavigator)).EndInit();
            this.author_bookBindingNavigator.ResumeLayout(false);
            this.author_bookBindingNavigator.PerformLayout();
            this.groupBoxEditAuthorBook.ResumeLayout(false);
            this.groupBoxEditAuthorBook.PerformLayout();
            this.groupBoxSearchAuthorBooks.ResumeLayout(false);
            this.groupBoxSearchAuthorBooks.PerformLayout();
            this.tabPageAuthors.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).EndInit();
            this.authorsBindingNavigator.ResumeLayout(false);
            this.authorsBindingNavigator.PerformLayout();
            this.groupBoxEditAuthor.ResumeLayout(false);
            this.groupBoxEditAuthor.PerformLayout();
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.tabPageBooks.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            this.groupBoxEditBook.ResumeLayout(false);
            this.groupBoxEditBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooksPublishingYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBooksPages)).EndInit();
            this.groupBoxSearchBook.ResumeLayout(false);
            this.groupBoxSearchBook.PerformLayout();
            this.tabPageDesigners.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingNavigator)).EndInit();
            this.designersBindingNavigator.ResumeLayout(false);
            this.designersBindingNavigator.PerformLayout();
            this.groupBoxEditDesigner.ResumeLayout(false);
            this.groupBoxEditDesigner.PerformLayout();
            this.groupBoxSearchDesigner.ResumeLayout(false);
            this.groupBoxSearchDesigner.PerformLayout();
            this.tabPageEditors.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingNavigator)).EndInit();
            this.editorsBindingNavigator.ResumeLayout(false);
            this.editorsBindingNavigator.PerformLayout();
            this.groupBoxEditEditors.ResumeLayout(false);
            this.groupBoxEditEditors.PerformLayout();
            this.groupBoxSearchEditor.ResumeLayout(false);
            this.groupBoxSearchEditor.PerformLayout();
            this.tabPageShops.ResumeLayout(false);
            this.splitContainerShops.Panel1.ResumeLayout(false);
            this.splitContainerShops.Panel1.PerformLayout();
            this.splitContainerShops.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShops)).EndInit();
            this.splitContainerShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingNavigator)).EndInit();
            this.shopsBindingNavigator.ResumeLayout(false);
            this.shopsBindingNavigator.PerformLayout();
            this.groupBoxEditShops.ResumeLayout(false);
            this.groupBoxEditShops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsnameBindingSource)).EndInit();
            this.groupBoxSearchShops.ResumeLayout(false);
            this.groupBoxSearchShops.PerformLayout();
            this.tabPageShopsBooksForAdmin.ResumeLayout(false);
            this.splitContainerBooksInShops.Panel1.ResumeLayout(false);
            this.splitContainerBooksInShops.Panel1.PerformLayout();
            this.splitContainerBooksInShops.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksInShops)).EndInit();
            this.splitContainerBooksInShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_booksBindingNavigator)).EndInit();
            this.shops_booksBindingNavigator.ResumeLayout(false);
            this.shops_booksBindingNavigator.PerformLayout();
            this.groupBoxEditShops_Books.ResumeLayout(false);
            this.groupBoxEditShops_Books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountBooks)).EndInit();
            this.groupBoxSearchShops_Books.ResumeLayout(false);
            this.groupBoxSearchShops_Books.PerformLayout();
            this.tabPageShopsBooks.ResumeLayout(false);
            this.tabPageShopsBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBooksNamedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBooksNamedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorView)).EndInit();
            this.bindingNavigatorView.ResumeLayout(false);
            this.bindingNavigatorView.PerformLayout();
            this.tabPageHandbook.ResumeLayout(false);
            this.tabControlHandBook.ResumeLayout(false);
            this.tabPageGenres.ResumeLayout(false);
            this.tabPageGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingNavigator)).EndInit();
            this.genresBindingNavigator.ResumeLayout(false);
            this.genresBindingNavigator.PerformLayout();
            this.tabPageShopsNames.ResumeLayout(false);
            this.tabPageShopsNames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_nameBindingNavigator)).EndInit();
            this.shops_nameBindingNavigator.ResumeLayout(false);
            this.shops_nameBindingNavigator.PerformLayout();
            this.tabPageLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLogs)).EndInit();
            this.bindingNavigatorLogs.ResumeLayout(false);
            this.bindingNavigatorLogs.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKbooksdesignerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKshopsbooksshopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAuthorAndBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogsErrors.ResumeLayout(false);
            this.tabPageLogsErrors.PerformLayout();
            this.tabPageOperationsBooksTable.ResumeLayout(false);
            this.tabPageOperationsBooksTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksLogTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksLogTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageFacts;
        private System.Windows.Forms.TabControl tabControlFacts;
        private System.Windows.Forms.TabPage tabPageAuthorsBooks;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageDesigners;
        private System.Windows.Forms.TabPage tabPageEditors;
        private System.Windows.Forms.TabPage tabPageShops;
        private System.Windows.Forms.TabPage tabPageShopsBooksForAdmin;
        private System.Windows.Forms.TabPage tabPageHandbook;
        private System.Windows.Forms.TabControl tabControlHandBook;
        private System.Windows.Forms.TabPage tabPageGenres;
        private System.Windows.Forms.TabPage tabPageShopsNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private publishing_houseDataSet publishing_houseDataSet;
        private System.Windows.Forms.BindingSource author_bookBindingSource;
        private publishing_houseDataSetTableAdapters.author_bookTableAdapter author_bookTableAdapter;
        private publishing_houseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator author_bookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton author_bookBindingNavigatorSaveItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView author_bookDataGridView;
        private publishing_houseDataSetTableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private publishing_houseDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.ComboBox comboBoxAuthorBooksAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthorBooksBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAuthorBooksAuthors;
        private System.Windows.Forms.BindingSource publishinghouseDataSetBindingSource;
        private System.Windows.Forms.Button buttonCancelAuthorBook;
        private System.Windows.Forms.Button buttonSaveAuthorBook;
        private publishing_houseDataSetTableAdapters.genresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private System.Windows.Forms.DataGridView genresDataGridView;
        private System.Windows.Forms.BindingSource editorsBindingSource;
        private publishing_houseDataSetTableAdapters.editorsTableAdapter editorsTableAdapter;
        private System.Windows.Forms.BindingNavigator genresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnGenreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource shops_nameBindingSource;
        private publishing_houseDataSetTableAdapters.shops_nameTableAdapter shops_nameTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView editorsDataGridView;
        private System.Windows.Forms.BindingNavigator editorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveEditorsItem;
        private System.Windows.Forms.DataGridView shops_nameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingNavigator shops_nameBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveShopsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingNavigator authorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAuthorItem;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.BindingSource designersBindingSource;
        private publishing_houseDataSetTableAdapters.designersTableAdapter designersTableAdapter;
        private System.Windows.Forms.DataGridView designersDataGridView;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private publishing_houseDataSetTableAdapters.shopsTableAdapter shopsTableAdapter;
        private System.Windows.Forms.DataGridView shopsDataGridView;
        private System.Windows.Forms.BindingSource shops_booksBindingSource;
        private publishing_houseDataSetTableAdapters.shops_booksTableAdapter shops_booksTableAdapter;
        private System.Windows.Forms.BindingNavigator designersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveDesignersItem;
        private System.Windows.Forms.SplitContainer splitContainerShops;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.BindingNavigator shopsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem6;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator18;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator19;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator20;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveShopsItem;
        private System.Windows.Forms.SplitContainer splitContainerBooksInShops;
        private System.Windows.Forms.DataGridView shops_booksDataGridView;
        private System.Windows.Forms.BindingNavigator shops_booksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem7;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveBooksInShopsItem;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem8;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator24;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator25;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem8;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator26;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveBooksItem;
        private System.Windows.Forms.GroupBox groupBoxSearchAuthorBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCriterionAuthorBook;
        private System.Windows.Forms.Button buttonPrintQueryAuthorBook;
        private System.Windows.Forms.Button buttonQueryAuthorBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConditionAuthorBooks;
        private System.Windows.Forms.BindingSource fKbooksdesignerBindingSource;
        private System.Windows.Forms.BindingSource fKshopsbooksshopsBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateBooksAuthors;
        private System.Windows.Forms.GroupBox groupBoxEditAuthorBook;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditAuthorBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAuthorBooksId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumnAuthorBooksBook;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumnAuthorBooksAuthor;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.BindingSource addAuthorAndBookBindingSource;
        private publishing_houseDataSetTableAdapters.AddAuthorAndBookTableAdapter addAuthorAndBookTableAdapter;
        private System.Windows.Forms.BindingSource logTableBindingSource;
        private publishing_houseDataSetTableAdapters.LogTableTableAdapter logTableTableAdapter;
        private System.Windows.Forms.DataGridView logTableDataGridView;
        private System.Windows.Forms.GroupBox groupBoxEditAuthor;
        private System.Windows.Forms.GroupBox groupBoxSearchAuthor;
        private System.Windows.Forms.ComboBox comboBoxCriterionAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConditionAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrintAuthor;
        private System.Windows.Forms.Button buttonQueryAuthor;
        private System.Windows.Forms.Button buttonSaveAuthorEditing;
        private System.Windows.Forms.Button buttonCancelAuthorEditing;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuthorBirthDate;
        private System.Windows.Forms.TextBox textBoxAuthorPatronymic;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxSearchBook;
        private System.Windows.Forms.Button buttonPrintQueryBook;
        private System.Windows.Forms.Button buttonQueryBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCriterionBook;
        private System.Windows.Forms.GroupBox groupBoxSearchDesigner;
        private System.Windows.Forms.Button buttonPrintDesigner;
        private System.Windows.Forms.Button buttonQueryDesigner;
        private System.Windows.Forms.TextBox textBoxConditionDesigner;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCriterionDesigner;
        private System.Windows.Forms.GroupBox groupBoxSearchEditor;
        private System.Windows.Forms.Button buttonPrintQueryEditors;
        private System.Windows.Forms.Button buttonQueryEditor;
        private System.Windows.Forms.TextBox textBoxConditionEditor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxCriterionEditor;
        private System.Windows.Forms.GroupBox groupBoxSearchShops;
        private System.Windows.Forms.Button buttonPrintShops;
        private System.Windows.Forms.Button buttonQueryShops;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxSearchShops_Books;
        private System.Windows.Forms.Button buttonPrintQueryBooksShops;
        private System.Windows.Forms.Button buttonQueryBooksShops;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateAuthorItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditAuthorItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateBooksItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditBooksItem;
        private System.Windows.Forms.GroupBox groupBoxEditBook;
        private System.Windows.Forms.ComboBox comboBoxConditionBooks;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonCancelEditBook;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.TextBox textBoxBooksName;
        private System.Windows.Forms.NumericUpDown numericUpDownBooksPublishingYear;
        private System.Windows.Forms.NumericUpDown numericUpDownBooksPages;
        private System.Windows.Forms.ComboBox comboBoxBooksDesigner;
        private System.Windows.Forms.ComboBox comboBoxBooksEditor;
        private System.Windows.Forms.ComboBox comboBoxBooksGenre;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateDesignersItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditDesignerItem;
        private System.Windows.Forms.GroupBox groupBoxEditDesigner;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDesignerNumberPhone;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button buttonSaveDesigner;
        private System.Windows.Forms.Button buttonCancelEditingDesigner;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesignerBirthDate;
        private System.Windows.Forms.TextBox textBoxDesignerPatronymic;
        private System.Windows.Forms.TextBox textBoxDesignerFirstName;
        private System.Windows.Forms.TextBox textBoxDesignerLastName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateEditorsItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditEditorsItem;
        private System.Windows.Forms.GroupBox groupBoxEditEditors;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEditorsNumberPhone;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button buttonSaveEditors;
        private System.Windows.Forms.Button buttonCancelEditEditors;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdtirosBirthDate;
        private System.Windows.Forms.TextBox textBoxEditorsPatronymic;
        private System.Windows.Forms.TextBox textBoxEditorsFirstName;
        private System.Windows.Forms.TextBox textBoxEditorsLastName;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerpatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersnumberphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designersbirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxConditionShops;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateShopsItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditShopsItem;
        private System.Windows.Forms.GroupBox groupBoxEditShops;
        private System.Windows.Forms.ComboBox comboBoxShopsName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxShopsNumberPhone;
        private System.Windows.Forms.TextBox textBoxShopsAddress;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBoxEditShops_Books;
        private System.Windows.Forms.BindingSource shopsBooksNamedBindingSource;
        private publishing_houseDataSetTableAdapters.ShopsBooksNamedTableAdapter shopsBooksNamedTableAdapter;
        private System.Windows.Forms.Button buttonSaveShop;
        private System.Windows.Forms.Button buttonCancelEditingShops;
        private System.Windows.Forms.BindingSource shopsnameBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateShopsInBooks;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditBooksInShopsItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonCancelShops_Books;
        private System.Windows.Forms.Button buttonSaveShops_Books;
        private System.Windows.Forms.NumericUpDown numericUpDownCostBook;
        private System.Windows.Forms.NumericUpDown numericUpDownCountBooks;
        private System.Windows.Forms.ComboBox comboBoxShops_BooksBooksId;
        private System.Windows.Forms.ComboBox comboBoxShops_BooksShopsId;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPageShopsBooks;
        private System.Windows.Forms.TextBox textBoxCondtitionBooksName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.BindingNavigator bindingNavigatorView;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem9;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem9;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem9;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator27;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem9;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator28;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem9;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem9;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator29;
        private System.Windows.Forms.DataGridView shopsBooksNamedDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCriterionView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxConditionView;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchByParam;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateGenres;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveGenre;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxConditionGenres;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton печатьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxConditionShopsName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchShopsName;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelEditingShopsName;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintShopsNames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLogs;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem9;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem10;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator30;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem10;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator31;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem10;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator32;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogsErrors;
        private System.Windows.Forms.TabPage tabPageOperationsBooksTable;
        private System.Windows.Forms.BindingSource booksLogTableBindingSource;
        private publishing_houseDataSetTableAdapters.booksLogTableTableAdapter booksLogTableTableAdapter;
        private System.Windows.Forms.DataGridView booksLogTableDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem11;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem11;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem11;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator33;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem11;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator34;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem11;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem11;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
    }
}


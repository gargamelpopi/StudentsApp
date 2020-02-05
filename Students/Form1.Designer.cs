namespace Students
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label код_студентаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label родителиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label номер_зачёткиLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label код_специальностиLabel;
            System.Windows.Forms.Label очная_форма_обученияLabel;
            this.studentsDataSet = new Students.StudentsDataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new Students.StudentsDataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new Students.StudentsDataSetTableAdapters.TableAdapterManager();
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_студентаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.родителиTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.номер_зачёткиTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.курсTextBox = new System.Windows.Forms.TextBox();
            this.код_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.очная_форма_обученияCheckBox = new System.Windows.Forms.CheckBox();
            код_студентаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            родителиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            номер_зачёткиLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            очная_форма_обученияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.studentsDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Students.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(382, 25);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.студентыBindingNavigatorSaveItem.Text = "Save Data";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // код_студентаLabel
            // 
            код_студентаLabel.AutoSize = true;
            код_студентаLabel.Location = new System.Drawing.Point(11, 40);
            код_студентаLabel.Name = "код_студентаLabel";
            код_студентаLabel.Size = new System.Drawing.Size(77, 13);
            код_студентаLabel.TabIndex = 1;
            код_студентаLabel.Text = "Код студента:";
            // 
            // код_студентаTextBox
            // 
            this.код_студентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код студента", true));
            this.код_студентаTextBox.Location = new System.Drawing.Point(144, 37);
            this.код_студентаTextBox.Name = "код_студентаTextBox";
            this.код_студентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_студентаTextBox.TabIndex = 2;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(11, 66);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(144, 63);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(11, 92);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(144, 89);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 20);
            this.полTextBox.TabIndex = 6;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(11, 119);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 7;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(144, 115);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 8;
            // 
            // родителиLabel
            // 
            родителиLabel.AutoSize = true;
            родителиLabel.Location = new System.Drawing.Point(11, 144);
            родителиLabel.Name = "родителиLabel";
            родителиLabel.Size = new System.Drawing.Size(58, 13);
            родителиLabel.TabIndex = 9;
            родителиLabel.Text = "Родители:";
            // 
            // родителиTextBox
            // 
            this.родителиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Родители", true));
            this.родителиTextBox.Location = new System.Drawing.Point(144, 141);
            this.родителиTextBox.Name = "родителиTextBox";
            this.родителиTextBox.Size = new System.Drawing.Size(200, 20);
            this.родителиTextBox.TabIndex = 10;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(11, 170);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(144, 167);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 20);
            this.адресTextBox.TabIndex = 12;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(11, 196);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(144, 193);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 20);
            this.телефонTextBox.TabIndex = 14;
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(11, 222);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(114, 13);
            паспортные_данныеLabel.TabIndex = 15;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(144, 219);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(200, 20);
            this.паспортные_данныеTextBox.TabIndex = 16;
            // 
            // номер_зачёткиLabel
            // 
            номер_зачёткиLabel.AutoSize = true;
            номер_зачёткиLabel.Location = new System.Drawing.Point(11, 248);
            номер_зачёткиLabel.Name = "номер_зачёткиLabel";
            номер_зачёткиLabel.Size = new System.Drawing.Size(87, 13);
            номер_зачёткиLabel.TabIndex = 17;
            номер_зачёткиLabel.Text = "Номер зачётки:";
            // 
            // номер_зачёткиTextBox
            // 
            this.номер_зачёткиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер зачётки", true));
            this.номер_зачёткиTextBox.Location = new System.Drawing.Point(144, 245);
            this.номер_зачёткиTextBox.Name = "номер_зачёткиTextBox";
            this.номер_зачёткиTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_зачёткиTextBox.TabIndex = 18;
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(11, 275);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(103, 13);
            дата_поступленияLabel.TabIndex = 19;
            дата_поступленияLabel.Text = "Дата поступления:";
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(144, 271);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 20;
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(11, 300);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 21;
            группаLabel.Text = "Группа:";
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(144, 297);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(200, 20);
            this.группаTextBox.TabIndex = 22;
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Location = new System.Drawing.Point(11, 326);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(34, 13);
            курсLabel.TabIndex = 23;
            курсLabel.Text = "Курс:";
            // 
            // курсTextBox
            // 
            this.курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Курс", true));
            this.курсTextBox.Location = new System.Drawing.Point(144, 323);
            this.курсTextBox.Name = "курсTextBox";
            this.курсTextBox.Size = new System.Drawing.Size(200, 20);
            this.курсTextBox.TabIndex = 24;
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Location = new System.Drawing.Point(11, 352);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(109, 13);
            код_специальностиLabel.TabIndex = 25;
            код_специальностиLabel.Text = "Код специальности:";
            // 
            // код_специальностиTextBox
            // 
            this.код_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код специальности", true));
            this.код_специальностиTextBox.Location = new System.Drawing.Point(144, 349);
            this.код_специальностиTextBox.Name = "код_специальностиTextBox";
            this.код_специальностиTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_специальностиTextBox.TabIndex = 26;
            // 
            // очная_форма_обученияLabel
            // 
            очная_форма_обученияLabel.AutoSize = true;
            очная_форма_обученияLabel.Location = new System.Drawing.Point(11, 380);
            очная_форма_обученияLabel.Name = "очная_форма_обученияLabel";
            очная_форма_обученияLabel.Size = new System.Drawing.Size(127, 13);
            очная_форма_обученияLabel.TabIndex = 27;
            очная_форма_обученияLabel.Text = "Очная форма обучения:";
            // 
            // очная_форма_обученияCheckBox
            // 
            this.очная_форма_обученияCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.студентыBindingSource, "Очная форма обучения", true));
            this.очная_форма_обученияCheckBox.Location = new System.Drawing.Point(144, 375);
            this.очная_форма_обученияCheckBox.Name = "очная_форма_обученияCheckBox";
            this.очная_форма_обученияCheckBox.Size = new System.Drawing.Size(200, 24);
            this.очная_форма_обученияCheckBox.TabIndex = 28;
            this.очная_форма_обученияCheckBox.Text = "checkBox1";
            this.очная_форма_обученияCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 508);
            this.Controls.Add(код_студентаLabel);
            this.Controls.Add(this.код_студентаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(родителиLabel);
            this.Controls.Add(this.родителиTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(номер_зачёткиLabel);
            this.Controls.Add(this.номер_зачёткиTextBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсTextBox);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиTextBox);
            this.Controls.Add(очная_форма_обученияLabel);
            this.Controls.Add(this.очная_форма_обученияCheckBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "Form1";
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private StudentsDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private StudentsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_студентаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox родителиTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox номер_зачёткиTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox курсTextBox;
        private System.Windows.Forms.TextBox код_специальностиTextBox;
        private System.Windows.Forms.CheckBox очная_форма_обученияCheckBox;
    }
}


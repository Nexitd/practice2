
namespace Sandbox
{
    partial class Form7
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
            System.Windows.Forms.Label кодСамолетаLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label вместимостьLabel;
            System.Windows.Forms.Label грузоподъемностьLabel;
            System.Windows.Forms.Label кодТипаLabel;
            System.Windows.Forms.Label техническиеХарактеристикиLabel;
            System.Windows.Forms.Label датаВыпускаLabel;
            System.Windows.Forms.Label налетаноЧасовLabel;
            System.Windows.Forms.Label датаПоследнегоРемонтаLabel;
            System.Windows.Forms.Label кодСотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.airportDataSet = new Airoport.AirportDataSet();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.самолетыTableAdapter = new Airoport.AirportDataSetTableAdapters.СамолетыTableAdapter();
            this.tableAdapterManager = new Airoport.AirportDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиTableAdapter = new Airoport.AirportDataSetTableAdapters.СотрудникиTableAdapter();
            this.типыСамолетовTableAdapter = new Airoport.AirportDataSetTableAdapters.ТипыСамолетовTableAdapter();
            this.самолетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.самолетыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодСамолетаTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.вместимостьTextBox = new System.Windows.Forms.TextBox();
            this.грузоподъемностьTextBox = new System.Windows.Forms.TextBox();
            this.кодТипаComboBox = new System.Windows.Forms.ComboBox();
            this.типыСамолетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.техническиеХарактеристикиTextBox = new System.Windows.Forms.TextBox();
            this.датаВыпускаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.налетаноЧасовTextBox = new System.Windows.Forms.TextBox();
            this.датаПоследнегоРемонтаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодСотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            кодСамолетаLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            грузоподъемностьLabel = new System.Windows.Forms.Label();
            кодТипаLabel = new System.Windows.Forms.Label();
            техническиеХарактеристикиLabel = new System.Windows.Forms.Label();
            датаВыпускаLabel = new System.Windows.Forms.Label();
            налетаноЧасовLabel = new System.Windows.Forms.Label();
            датаПоследнегоРемонтаLabel = new System.Windows.Forms.Label();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingNavigator)).BeginInit();
            this.самолетыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыСамолетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодСамолетаLabel
            // 
            кодСамолетаLabel.AutoSize = true;
            кодСамолетаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСамолетаLabel.Location = new System.Drawing.Point(227, 91);
            кодСамолетаLabel.Name = "кодСамолетаLabel";
            кодСамолетаLabel.Size = new System.Drawing.Size(124, 20);
            кодСамолетаLabel.TabIndex = 1;
            кодСамолетаLabel.Text = "Код Самолета:";
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            маркаLabel.Location = new System.Drawing.Point(227, 128);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(61, 20);
            маркаLabel.TabIndex = 3;
            маркаLabel.Text = "Марка:";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            вместимостьLabel.Location = new System.Drawing.Point(227, 164);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(116, 20);
            вместимостьLabel.TabIndex = 5;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // грузоподъемностьLabel
            // 
            грузоподъемностьLabel.AutoSize = true;
            грузоподъемностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            грузоподъемностьLabel.Location = new System.Drawing.Point(227, 202);
            грузоподъемностьLabel.Name = "грузоподъемностьLabel";
            грузоподъемностьLabel.Size = new System.Drawing.Size(159, 20);
            грузоподъемностьLabel.TabIndex = 7;
            грузоподъемностьLabel.Text = "Грузоподъемность:";
            // 
            // кодТипаLabel
            // 
            кодТипаLabel.AutoSize = true;
            кодТипаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодТипаLabel.Location = new System.Drawing.Point(227, 243);
            кодТипаLabel.Name = "кодТипаLabel";
            кодТипаLabel.Size = new System.Drawing.Size(83, 20);
            кодТипаLabel.TabIndex = 9;
            кодТипаLabel.Text = "Код Типа:";
            // 
            // техническиеХарактеристикиLabel
            // 
            техническиеХарактеристикиLabel.AutoSize = true;
            техническиеХарактеристикиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            техническиеХарактеристикиLabel.Location = new System.Drawing.Point(227, 284);
            техническиеХарактеристикиLabel.Name = "техническиеХарактеристикиLabel";
            техническиеХарактеристикиLabel.Size = new System.Drawing.Size(237, 20);
            техническиеХарактеристикиLabel.TabIndex = 11;
            техническиеХарактеристикиLabel.Text = "Технические Характеристики:";
            // 
            // датаВыпускаLabel
            // 
            датаВыпускаLabel.AutoSize = true;
            датаВыпускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            датаВыпускаLabel.Location = new System.Drawing.Point(227, 364);
            датаВыпускаLabel.Name = "датаВыпускаLabel";
            датаВыпускаLabel.Size = new System.Drawing.Size(119, 20);
            датаВыпускаLabel.TabIndex = 13;
            датаВыпускаLabel.Text = "Дата Выпуска:";
            // 
            // налетаноЧасовLabel
            // 
            налетаноЧасовLabel.AutoSize = true;
            налетаноЧасовLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            налетаноЧасовLabel.Location = new System.Drawing.Point(227, 403);
            налетаноЧасовLabel.Name = "налетаноЧасовLabel";
            налетаноЧасовLabel.Size = new System.Drawing.Size(140, 20);
            налетаноЧасовLabel.TabIndex = 15;
            налетаноЧасовLabel.Text = "Налетано Часов:";
            // 
            // датаПоследнегоРемонтаLabel
            // 
            датаПоследнегоРемонтаLabel.AutoSize = true;
            датаПоследнегоРемонтаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            датаПоследнегоРемонтаLabel.Location = new System.Drawing.Point(227, 439);
            датаПоследнегоРемонтаLabel.Name = "датаПоследнегоРемонтаLabel";
            датаПоследнегоРемонтаLabel.Size = new System.Drawing.Size(219, 20);
            датаПоследнегоРемонтаLabel.TabIndex = 17;
            датаПоследнегоРемонтаLabel.Text = "Дата Последнего Ремонта:";
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСотрудникаLabel.Location = new System.Drawing.Point(227, 481);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(138, 20);
            кодСотрудникаLabel.TabIndex = 19;
            кодСотрудникаLabel.Text = "Код Сотрудника:";
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.airportDataSet;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airoport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СамолетыTableAdapter = this.самолетыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.ТипыСамолетовTableAdapter = this.типыСамолетовTableAdapter;
            this.tableAdapterManager.ЭкипажиTableAdapter = null;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // типыСамолетовTableAdapter
            // 
            this.типыСамолетовTableAdapter.ClearBeforeFill = true;
            // 
            // самолетыBindingNavigator
            // 
            this.самолетыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.самолетыBindingNavigator.BindingSource = this.самолетыBindingSource;
            this.самолетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.самолетыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.самолетыBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.самолетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.самолетыBindingNavigatorSaveItem});
            this.самолетыBindingNavigator.Location = new System.Drawing.Point(0, 664);
            this.самолетыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.самолетыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.самолетыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.самолетыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.самолетыBindingNavigator.Name = "самолетыBindingNavigator";
            this.самолетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.самолетыBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.самолетыBindingNavigator.TabIndex = 0;
            this.самолетыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // самолетыBindingNavigatorSaveItem
            // 
            this.самолетыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.самолетыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("самолетыBindingNavigatorSaveItem.Image")));
            this.самолетыBindingNavigatorSaveItem.Name = "самолетыBindingNavigatorSaveItem";
            this.самолетыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.самолетыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.самолетыBindingNavigatorSaveItem.Click += new System.EventHandler(this.самолетыBindingNavigatorSaveItem_Click);
            // 
            // кодСамолетаTextBox
            // 
            this.кодСамолетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "КодСамолета", true));
            this.кодСамолетаTextBox.Location = new System.Drawing.Point(509, 91);
            this.кодСамолетаTextBox.Name = "кодСамолетаTextBox";
            this.кодСамолетаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодСамолетаTextBox.TabIndex = 2;
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(509, 128);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(200, 20);
            this.маркаTextBox.TabIndex = 4;
            // 
            // вместимостьTextBox
            // 
            this.вместимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Вместимость", true));
            this.вместимостьTextBox.Location = new System.Drawing.Point(509, 164);
            this.вместимостьTextBox.Name = "вместимостьTextBox";
            this.вместимостьTextBox.Size = new System.Drawing.Size(200, 20);
            this.вместимостьTextBox.TabIndex = 6;
            // 
            // грузоподъемностьTextBox
            // 
            this.грузоподъемностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "Грузоподъемность", true));
            this.грузоподъемностьTextBox.Location = new System.Drawing.Point(509, 202);
            this.грузоподъемностьTextBox.Name = "грузоподъемностьTextBox";
            this.грузоподъемностьTextBox.Size = new System.Drawing.Size(200, 20);
            this.грузоподъемностьTextBox.TabIndex = 8;
            // 
            // кодТипаComboBox
            // 
            this.кодТипаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "КодТипа", true));
            this.кодТипаComboBox.DataSource = this.типыСамолетовBindingSource;
            this.кодТипаComboBox.DisplayMember = "КодТипа";
            this.кодТипаComboBox.FormattingEnabled = true;
            this.кодТипаComboBox.Location = new System.Drawing.Point(509, 242);
            this.кодТипаComboBox.Name = "кодТипаComboBox";
            this.кодТипаComboBox.Size = new System.Drawing.Size(200, 21);
            this.кодТипаComboBox.TabIndex = 10;
            this.кодТипаComboBox.ValueMember = "КодТипа";
            // 
            // типыСамолетовBindingSource
            // 
            this.типыСамолетовBindingSource.DataMember = "ТипыСамолетов";
            this.типыСамолетовBindingSource.DataSource = this.airportDataSet;
            // 
            // техническиеХарактеристикиTextBox
            // 
            this.техническиеХарактеристикиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "ТехническиеХарактеристики", true));
            this.техническиеХарактеристикиTextBox.Location = new System.Drawing.Point(509, 269);
            this.техническиеХарактеристикиTextBox.Multiline = true;
            this.техническиеХарактеристикиTextBox.Name = "техническиеХарактеристикиTextBox";
            this.техническиеХарактеристикиTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.техническиеХарактеристикиTextBox.Size = new System.Drawing.Size(348, 89);
            this.техническиеХарактеристикиTextBox.TabIndex = 12;
            // 
            // датаВыпускаDateTimePicker
            // 
            this.датаВыпускаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.самолетыBindingSource, "ДатаВыпуска", true));
            this.датаВыпускаDateTimePicker.Location = new System.Drawing.Point(509, 364);
            this.датаВыпускаDateTimePicker.Name = "датаВыпускаDateTimePicker";
            this.датаВыпускаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаВыпускаDateTimePicker.TabIndex = 14;
            // 
            // налетаноЧасовTextBox
            // 
            this.налетаноЧасовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "НалетаноЧасов", true));
            this.налетаноЧасовTextBox.Location = new System.Drawing.Point(509, 403);
            this.налетаноЧасовTextBox.Name = "налетаноЧасовTextBox";
            this.налетаноЧасовTextBox.Size = new System.Drawing.Size(200, 20);
            this.налетаноЧасовTextBox.TabIndex = 16;
            // 
            // датаПоследнегоРемонтаDateTimePicker
            // 
            this.датаПоследнегоРемонтаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.самолетыBindingSource, "ДатаПоследнегоРемонта", true));
            this.датаПоследнегоРемонтаDateTimePicker.Location = new System.Drawing.Point(509, 439);
            this.датаПоследнегоРемонтаDateTimePicker.Name = "датаПоследнегоРемонтаDateTimePicker";
            this.датаПоследнегоРемонтаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаПоследнегоРемонтаDateTimePicker.TabIndex = 18;
            // 
            // кодСотрудникаComboBox
            // 
            this.кодСотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.самолетыBindingSource, "КодСотрудника", true));
            this.кодСотрудникаComboBox.DataSource = this.сотрудникиBindingSource;
            this.кодСотрудникаComboBox.DisplayMember = "КодСотрудника";
            this.кодСотрудникаComboBox.FormattingEnabled = true;
            this.кодСотрудникаComboBox.Location = new System.Drawing.Point(509, 480);
            this.кодСотрудникаComboBox.Name = "кодСотрудникаComboBox";
            this.кодСотрудникаComboBox.Size = new System.Drawing.Size(200, 21);
            this.кодСотрудникаComboBox.TabIndex = 20;
            this.кодСотрудникаComboBox.ValueMember = "КодСотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.airportDataSet;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(420, 526);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton8.TabIndex = 66;
            this.materialFlatButton8.Text = "Выход";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click_1);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(321, 574);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton6.TabIndex = 65;
            this.materialFlatButton6.Text = "Удалить";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click_1);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(410, 574);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton5.TabIndex = 64;
            this.materialFlatButton5.Text = "Сохранить";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click_1);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(601, 526);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton4.TabIndex = 63;
            this.materialFlatButton4.Text = "Вперед";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click_1);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(332, 622);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(219, 36);
            this.materialFlatButton3.TabIndex = 62;
            this.materialFlatButton3.Text = "Открыть табличную форму";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(521, 574);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton2.TabIndex = 61;
            this.materialFlatButton2.Text = "Добавить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(254, 526);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 60;
            this.materialFlatButton1.Text = "Назад";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 689);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(кодСотрудникаLabel);
            this.Controls.Add(this.кодСотрудникаComboBox);
            this.Controls.Add(датаПоследнегоРемонтаLabel);
            this.Controls.Add(this.датаПоследнегоРемонтаDateTimePicker);
            this.Controls.Add(налетаноЧасовLabel);
            this.Controls.Add(this.налетаноЧасовTextBox);
            this.Controls.Add(датаВыпускаLabel);
            this.Controls.Add(this.датаВыпускаDateTimePicker);
            this.Controls.Add(техническиеХарактеристикиLabel);
            this.Controls.Add(this.техническиеХарактеристикиTextBox);
            this.Controls.Add(кодТипаLabel);
            this.Controls.Add(this.кодТипаComboBox);
            this.Controls.Add(грузоподъемностьLabel);
            this.Controls.Add(this.грузоподъемностьTextBox);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.вместимостьTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(кодСамолетаLabel);
            this.Controls.Add(this.кодСамолетаTextBox);
            this.Controls.Add(this.самолетыBindingNavigator);
            this.Name = "Form7";
            this.Text = "Самолеты";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingNavigator)).EndInit();
            this.самолетыBindingNavigator.ResumeLayout(false);
            this.самолетыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыСамолетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Airoport.AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
        private Airoport.AirportDataSetTableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private Airoport.AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator самолетыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton самолетыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодСамолетаTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox вместимостьTextBox;
        private System.Windows.Forms.TextBox грузоподъемностьTextBox;
        private System.Windows.Forms.ComboBox кодТипаComboBox;
        private System.Windows.Forms.TextBox техническиеХарактеристикиTextBox;
        private System.Windows.Forms.DateTimePicker датаВыпускаDateTimePicker;
        private System.Windows.Forms.TextBox налетаноЧасовTextBox;
        private System.Windows.Forms.DateTimePicker датаПоследнегоРемонтаDateTimePicker;
        private System.Windows.Forms.ComboBox кодСотрудникаComboBox;
        private Airoport.AirportDataSetTableAdapters.ТипыСамолетовTableAdapter типыСамолетовTableAdapter;
        private System.Windows.Forms.BindingSource типыСамолетовBindingSource;
        private Airoport.AirportDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
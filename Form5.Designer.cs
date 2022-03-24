
namespace Sandbox
{
    partial class Form5
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
            System.Windows.Forms.Label кодРейсаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label откудаLabel;
            System.Windows.Forms.Label кудаLabel;
            System.Windows.Forms.Label кодЭкипажаLabel;
            System.Windows.Forms.Label кодСамолетаLabel;
            System.Windows.Forms.Label времяПолетаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.airportDataSet = new Airoport.AirportDataSet();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсыTableAdapter = new Airoport.AirportDataSetTableAdapters.РейсыTableAdapter();
            this.tableAdapterManager = new Airoport.AirportDataSetTableAdapters.TableAdapterManager();
            this.самолетыTableAdapter = new Airoport.AirportDataSetTableAdapters.СамолетыTableAdapter();
            this.экипажиTableAdapter = new Airoport.AirportDataSetTableAdapters.ЭкипажиTableAdapter();
            this.рейсыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.рейсыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодРейсаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.откудаTextBox = new System.Windows.Forms.TextBox();
            this.кудаTextBox = new System.Windows.Forms.TextBox();
            this.кодЭкипажаComboBox = new System.Windows.Forms.ComboBox();
            this.экипажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодСамолетаComboBox = new System.Windows.Forms.ComboBox();
            this.самолетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.времяПолетаTextBox = new System.Windows.Forms.TextBox();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            кодРейсаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            времяLabel = new System.Windows.Forms.Label();
            откудаLabel = new System.Windows.Forms.Label();
            кудаLabel = new System.Windows.Forms.Label();
            кодЭкипажаLabel = new System.Windows.Forms.Label();
            кодСамолетаLabel = new System.Windows.Forms.Label();
            времяПолетаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).BeginInit();
            this.рейсыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодРейсаLabel
            // 
            кодРейсаLabel.AutoSize = true;
            кодРейсаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодРейсаLabel.Location = new System.Drawing.Point(262, 80);
            кодРейсаLabel.Name = "кодРейсаLabel";
            кодРейсаLabel.Size = new System.Drawing.Size(92, 20);
            кодРейсаLabel.TabIndex = 1;
            кодРейсаLabel.Text = "Код Рейса:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            датаLabel.Location = new System.Drawing.Point(291, 127);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            времяLabel.Location = new System.Drawing.Point(284, 167);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(62, 20);
            времяLabel.TabIndex = 5;
            времяLabel.Text = "Время:";
            // 
            // откудаLabel
            // 
            откудаLabel.AutoSize = true;
            откудаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            откудаLabel.Location = new System.Drawing.Point(279, 205);
            откудаLabel.Name = "откудаLabel";
            откудаLabel.Size = new System.Drawing.Size(69, 20);
            откудаLabel.TabIndex = 7;
            откудаLabel.Text = "Откуда:";
            // 
            // кудаLabel
            // 
            кудаLabel.AutoSize = true;
            кудаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кудаLabel.Location = new System.Drawing.Point(291, 241);
            кудаLabel.Name = "кудаLabel";
            кудаLabel.Size = new System.Drawing.Size(50, 20);
            кудаLabel.TabIndex = 9;
            кудаLabel.Text = "Куда:";
            // 
            // кодЭкипажаLabel
            // 
            кодЭкипажаLabel.AutoSize = true;
            кодЭкипажаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодЭкипажаLabel.Location = new System.Drawing.Point(248, 278);
            кодЭкипажаLabel.Name = "кодЭкипажаLabel";
            кодЭкипажаLabel.Size = new System.Drawing.Size(114, 20);
            кодЭкипажаLabel.TabIndex = 11;
            кодЭкипажаLabel.Text = "Код Экипажа:";
            // 
            // кодСамолетаLabel
            // 
            кодСамолетаLabel.AutoSize = true;
            кодСамолетаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСамолетаLabel.Location = new System.Drawing.Point(243, 314);
            кодСамолетаLabel.Name = "кодСамолетаLabel";
            кодСамолетаLabel.Size = new System.Drawing.Size(124, 20);
            кодСамолетаLabel.TabIndex = 13;
            кодСамолетаLabel.Text = "Код Самолета:";
            // 
            // времяПолетаLabel
            // 
            времяПолетаLabel.AutoSize = true;
            времяПолетаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            времяПолетаLabel.Location = new System.Drawing.Point(244, 343);
            времяПолетаLabel.Name = "времяПолетаLabel";
            времяПолетаLabel.Size = new System.Drawing.Size(124, 20);
            времяПолетаLabel.TabIndex = 15;
            времяПолетаLabel.Text = "Время Полета:";
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.airportDataSet;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airoport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = this.рейсыTableAdapter;
            this.tableAdapterManager.СамолетыTableAdapter = this.самолетыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТипыСамолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = this.экипажиTableAdapter;
            // 
            // самолетыTableAdapter
            // 
            this.самолетыTableAdapter.ClearBeforeFill = true;
            // 
            // экипажиTableAdapter
            // 
            this.экипажиTableAdapter.ClearBeforeFill = true;
            // 
            // рейсыBindingNavigator
            // 
            this.рейсыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рейсыBindingNavigator.BindingSource = this.рейсыBindingSource;
            this.рейсыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рейсыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рейсыBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.рейсыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рейсыBindingNavigatorSaveItem});
            this.рейсыBindingNavigator.Location = new System.Drawing.Point(0, 581);
            this.рейсыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рейсыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рейсыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рейсыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рейсыBindingNavigator.Name = "рейсыBindingNavigator";
            this.рейсыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рейсыBindingNavigator.Size = new System.Drawing.Size(817, 25);
            this.рейсыBindingNavigator.TabIndex = 0;
            this.рейсыBindingNavigator.Text = "bindingNavigator1";
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
            // рейсыBindingNavigatorSaveItem
            // 
            this.рейсыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рейсыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рейсыBindingNavigatorSaveItem.Image")));
            this.рейсыBindingNavigatorSaveItem.Name = "рейсыBindingNavigatorSaveItem";
            this.рейсыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.рейсыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.рейсыBindingNavigatorSaveItem.Click += new System.EventHandler(this.рейсыBindingNavigatorSaveItem_Click);
            // 
            // кодРейсаTextBox
            // 
            this.кодРейсаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "КодРейса", true));
            this.кодРейсаTextBox.Location = new System.Drawing.Point(386, 82);
            this.кодРейсаTextBox.Name = "кодРейсаTextBox";
            this.кодРейсаTextBox.Size = new System.Drawing.Size(164, 20);
            this.кодРейсаTextBox.TabIndex = 2;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рейсыBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(386, 118);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // времяDateTimePicker
            // 
            this.времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.рейсыBindingSource, "Время", true));
            this.времяDateTimePicker.Location = new System.Drawing.Point(387, 157);
            this.времяDateTimePicker.Name = "времяDateTimePicker";
            this.времяDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.времяDateTimePicker.TabIndex = 6;
            // 
            // откудаTextBox
            // 
            this.откудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Откуда", true));
            this.откудаTextBox.Location = new System.Drawing.Point(387, 194);
            this.откудаTextBox.Name = "откудаTextBox";
            this.откудаTextBox.Size = new System.Drawing.Size(164, 20);
            this.откудаTextBox.TabIndex = 8;
            // 
            // кудаTextBox
            // 
            this.кудаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "Куда", true));
            this.кудаTextBox.Location = new System.Drawing.Point(387, 232);
            this.кудаTextBox.Name = "кудаTextBox";
            this.кудаTextBox.Size = new System.Drawing.Size(164, 20);
            this.кудаTextBox.TabIndex = 10;
            // 
            // кодЭкипажаComboBox
            // 
            this.кодЭкипажаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "КодЭкипажа", true));
            this.кодЭкипажаComboBox.DataSource = this.экипажиBindingSource;
            this.кодЭкипажаComboBox.DisplayMember = "КодЭкипажа";
            this.кодЭкипажаComboBox.FormattingEnabled = true;
            this.кодЭкипажаComboBox.Location = new System.Drawing.Point(387, 269);
            this.кодЭкипажаComboBox.Name = "кодЭкипажаComboBox";
            this.кодЭкипажаComboBox.Size = new System.Drawing.Size(164, 21);
            this.кодЭкипажаComboBox.TabIndex = 12;
            this.кодЭкипажаComboBox.ValueMember = "КодЭкипажа";
            // 
            // экипажиBindingSource
            // 
            this.экипажиBindingSource.DataMember = "Экипажи";
            this.экипажиBindingSource.DataSource = this.airportDataSet;
            // 
            // кодСамолетаComboBox
            // 
            this.кодСамолетаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "КодСамолета", true));
            this.кодСамолетаComboBox.DataSource = this.самолетыBindingSource;
            this.кодСамолетаComboBox.DisplayMember = "КодСамолета";
            this.кодСамолетаComboBox.FormattingEnabled = true;
            this.кодСамолетаComboBox.Location = new System.Drawing.Point(387, 306);
            this.кодСамолетаComboBox.Name = "кодСамолетаComboBox";
            this.кодСамолетаComboBox.Size = new System.Drawing.Size(164, 21);
            this.кодСамолетаComboBox.TabIndex = 14;
            this.кодСамолетаComboBox.ValueMember = "КодСамолета";
            // 
            // самолетыBindingSource
            // 
            this.самолетыBindingSource.DataMember = "Самолеты";
            this.самолетыBindingSource.DataSource = this.airportDataSet;
            // 
            // времяПолетаTextBox
            // 
            this.времяПолетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рейсыBindingSource, "ВремяПолета", true));
            this.времяПолетаTextBox.Location = new System.Drawing.Point(387, 345);
            this.времяПолетаTextBox.Name = "времяПолетаTextBox";
            this.времяПолетаTextBox.Size = new System.Drawing.Size(164, 20);
            this.времяПолетаTextBox.TabIndex = 16;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(365, 413);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton8.TabIndex = 52;
            this.materialFlatButton8.Text = "Выход";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click_1);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(266, 461);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton6.TabIndex = 51;
            this.materialFlatButton6.Text = "Удалить";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click_1);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(355, 461);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton5.TabIndex = 50;
            this.materialFlatButton5.Text = "Сохранить";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click_1);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(546, 413);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton4.TabIndex = 49;
            this.materialFlatButton4.Text = "Вперед";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(277, 509);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(219, 36);
            this.materialFlatButton3.TabIndex = 48;
            this.materialFlatButton3.Text = "Открыть табличную форму";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(466, 461);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton2.TabIndex = 47;
            this.materialFlatButton2.Text = "Добавить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(199, 413);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 46;
            this.materialFlatButton1.Text = "Назад";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 606);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(времяПолетаLabel);
            this.Controls.Add(this.времяПолетаTextBox);
            this.Controls.Add(кодСамолетаLabel);
            this.Controls.Add(this.кодСамолетаComboBox);
            this.Controls.Add(кодЭкипажаLabel);
            this.Controls.Add(this.кодЭкипажаComboBox);
            this.Controls.Add(кудаLabel);
            this.Controls.Add(this.кудаTextBox);
            this.Controls.Add(откудаLabel);
            this.Controls.Add(this.откудаTextBox);
            this.Controls.Add(времяLabel);
            this.Controls.Add(this.времяDateTimePicker);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(кодРейсаLabel);
            this.Controls.Add(this.кодРейсаTextBox);
            this.Controls.Add(this.рейсыBindingNavigator);
            this.Name = "Form5";
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingNavigator)).EndInit();
            this.рейсыBindingNavigator.ResumeLayout(false);
            this.рейсыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.самолетыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Airoport.AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private Airoport.AirportDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private Airoport.AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рейсыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рейсыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодРейсаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.DateTimePicker времяDateTimePicker;
        private System.Windows.Forms.TextBox откудаTextBox;
        private System.Windows.Forms.TextBox кудаTextBox;
        private System.Windows.Forms.ComboBox кодЭкипажаComboBox;
        private System.Windows.Forms.ComboBox кодСамолетаComboBox;
        private System.Windows.Forms.TextBox времяПолетаTextBox;
        private Airoport.AirportDataSetTableAdapters.ЭкипажиTableAdapter экипажиTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.BindingSource экипажиBindingSource;
        private Airoport.AirportDataSetTableAdapters.СамолетыTableAdapter самолетыTableAdapter;
        private System.Windows.Forms.BindingSource самолетыBindingSource;
    }
}
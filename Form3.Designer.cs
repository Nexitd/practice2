
namespace Sandbox
{
    partial class Form3
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
            System.Windows.Forms.Label кодЭкипажаLabel;
            System.Windows.Forms.Label налетаноЧасовLabel;
            System.Windows.Forms.Label кодСотрудника1Label;
            System.Windows.Forms.Label кодСотрудника2Label;
            System.Windows.Forms.Label кодСотрудника3Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.airportDataSet = new Airoport.AirportDataSet();
            this.экипажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экипажиTableAdapter = new Airoport.AirportDataSetTableAdapters.ЭкипажиTableAdapter();
            this.tableAdapterManager = new Airoport.AirportDataSetTableAdapters.TableAdapterManager();
            this.экипажиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.экипажиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодЭкипажаTextBox = new System.Windows.Forms.TextBox();
            this.налетаноЧасовTextBox = new System.Windows.Forms.TextBox();
            this.кодСотрудника1TextBox = new System.Windows.Forms.TextBox();
            this.кодСотрудника2TextBox = new System.Windows.Forms.TextBox();
            this.кодСотрудника3TextBox = new System.Windows.Forms.TextBox();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            кодЭкипажаLabel = new System.Windows.Forms.Label();
            налетаноЧасовLabel = new System.Windows.Forms.Label();
            кодСотрудника1Label = new System.Windows.Forms.Label();
            кодСотрудника2Label = new System.Windows.Forms.Label();
            кодСотрудника3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingNavigator)).BeginInit();
            this.экипажиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодЭкипажаLabel
            // 
            кодЭкипажаLabel.AutoSize = true;
            кодЭкипажаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодЭкипажаLabel.Location = new System.Drawing.Point(282, 90);
            кодЭкипажаLabel.Name = "кодЭкипажаLabel";
            кодЭкипажаLabel.Size = new System.Drawing.Size(114, 20);
            кодЭкипажаLabel.TabIndex = 1;
            кодЭкипажаLabel.Text = "Код Экипажа:";
            // 
            // налетаноЧасовLabel
            // 
            налетаноЧасовLabel.AutoSize = true;
            налетаноЧасовLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            налетаноЧасовLabel.Location = new System.Drawing.Point(265, 138);
            налетаноЧасовLabel.Name = "налетаноЧасовLabel";
            налетаноЧасовLabel.Size = new System.Drawing.Size(140, 20);
            налетаноЧасовLabel.TabIndex = 3;
            налетаноЧасовLabel.Text = "Налетано Часов:";
            // 
            // кодСотрудника1Label
            // 
            кодСотрудника1Label.AutoSize = true;
            кодСотрудника1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСотрудника1Label.Location = new System.Drawing.Point(262, 179);
            кодСотрудника1Label.Name = "кодСотрудника1Label";
            кодСотрудника1Label.Size = new System.Drawing.Size(147, 20);
            кодСотрудника1Label.TabIndex = 5;
            кодСотрудника1Label.Text = "Код Сотрудника1:";
            // 
            // кодСотрудника2Label
            // 
            кодСотрудника2Label.AutoSize = true;
            кодСотрудника2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСотрудника2Label.Location = new System.Drawing.Point(262, 223);
            кодСотрудника2Label.Name = "кодСотрудника2Label";
            кодСотрудника2Label.Size = new System.Drawing.Size(147, 20);
            кодСотрудника2Label.TabIndex = 7;
            кодСотрудника2Label.Text = "Код Сотрудника2:";
            // 
            // кодСотрудника3Label
            // 
            кодСотрудника3Label.AutoSize = true;
            кодСотрудника3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодСотрудника3Label.Location = new System.Drawing.Point(262, 262);
            кодСотрудника3Label.Name = "кодСотрудника3Label";
            кодСотрудника3Label.Size = new System.Drawing.Size(147, 20);
            кодСотрудника3Label.TabIndex = 9;
            кодСотрудника3Label.Text = "Код Сотрудника3:";
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экипажиBindingSource
            // 
            this.экипажиBindingSource.DataMember = "Экипажи";
            this.экипажиBindingSource.DataSource = this.airportDataSet;
            // 
            // экипажиTableAdapter
            // 
            this.экипажиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airoport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СамолетыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТипыСамолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = this.экипажиTableAdapter;
            // 
            // экипажиBindingNavigator
            // 
            this.экипажиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.экипажиBindingNavigator.BindingSource = this.экипажиBindingSource;
            this.экипажиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.экипажиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.экипажиBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.экипажиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.экипажиBindingNavigatorSaveItem});
            this.экипажиBindingNavigator.Location = new System.Drawing.Point(0, 569);
            this.экипажиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.экипажиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.экипажиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.экипажиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.экипажиBindingNavigator.Name = "экипажиBindingNavigator";
            this.экипажиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.экипажиBindingNavigator.Size = new System.Drawing.Size(838, 25);
            this.экипажиBindingNavigator.TabIndex = 0;
            this.экипажиBindingNavigator.Text = "bindingNavigator1";
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
            // экипажиBindingNavigatorSaveItem
            // 
            this.экипажиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.экипажиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("экипажиBindingNavigatorSaveItem.Image")));
            this.экипажиBindingNavigatorSaveItem.Name = "экипажиBindingNavigatorSaveItem";
            this.экипажиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.экипажиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.экипажиBindingNavigatorSaveItem.Click += new System.EventHandler(this.экипажиBindingNavigatorSaveItem_Click);
            // 
            // кодЭкипажаTextBox
            // 
            this.кодЭкипажаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экипажиBindingSource, "КодЭкипажа", true));
            this.кодЭкипажаTextBox.Location = new System.Drawing.Point(441, 89);
            this.кодЭкипажаTextBox.Name = "кодЭкипажаTextBox";
            this.кодЭкипажаTextBox.Size = new System.Drawing.Size(238, 20);
            this.кодЭкипажаTextBox.TabIndex = 2;
            // 
            // налетаноЧасовTextBox
            // 
            this.налетаноЧасовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экипажиBindingSource, "НалетаноЧасов", true));
            this.налетаноЧасовTextBox.Location = new System.Drawing.Point(441, 140);
            this.налетаноЧасовTextBox.Name = "налетаноЧасовTextBox";
            this.налетаноЧасовTextBox.Size = new System.Drawing.Size(238, 20);
            this.налетаноЧасовTextBox.TabIndex = 4;
            // 
            // кодСотрудника1TextBox
            // 
            this.кодСотрудника1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экипажиBindingSource, "КодСотрудника1", true));
            this.кодСотрудника1TextBox.Location = new System.Drawing.Point(441, 181);
            this.кодСотрудника1TextBox.Name = "кодСотрудника1TextBox";
            this.кодСотрудника1TextBox.Size = new System.Drawing.Size(238, 20);
            this.кодСотрудника1TextBox.TabIndex = 6;
            // 
            // кодСотрудника2TextBox
            // 
            this.кодСотрудника2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экипажиBindingSource, "КодСотрудника2", true));
            this.кодСотрудника2TextBox.Location = new System.Drawing.Point(441, 222);
            this.кодСотрудника2TextBox.Name = "кодСотрудника2TextBox";
            this.кодСотрудника2TextBox.Size = new System.Drawing.Size(238, 20);
            this.кодСотрудника2TextBox.TabIndex = 8;
            // 
            // кодСотрудника3TextBox
            // 
            this.кодСотрудника3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экипажиBindingSource, "КодСотрудника3", true));
            this.кодСотрудника3TextBox.Location = new System.Drawing.Point(441, 264);
            this.кодСотрудника3TextBox.Name = "кодСотрудника3TextBox";
            this.кодСотрудника3TextBox.Size = new System.Drawing.Size(238, 20);
            this.кодСотрудника3TextBox.TabIndex = 10;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(425, 392);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton8.TabIndex = 45;
            this.materialFlatButton8.Text = "Выход";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(326, 440);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton6.TabIndex = 44;
            this.materialFlatButton6.Text = "Удалить";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(415, 440);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton5.TabIndex = 43;
            this.materialFlatButton5.Text = "Сохранить";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(606, 392);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton4.TabIndex = 42;
            this.materialFlatButton4.Text = "Вперед";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click_1);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(337, 488);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(219, 36);
            this.materialFlatButton3.TabIndex = 41;
            this.materialFlatButton3.Text = "Открыть табличную форму";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(526, 440);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton2.TabIndex = 40;
            this.materialFlatButton2.Text = "Добавить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click_1);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(259, 392);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 39;
            this.materialFlatButton1.Text = "Назад";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 594);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(кодСотрудника3Label);
            this.Controls.Add(this.кодСотрудника3TextBox);
            this.Controls.Add(кодСотрудника2Label);
            this.Controls.Add(this.кодСотрудника2TextBox);
            this.Controls.Add(кодСотрудника1Label);
            this.Controls.Add(this.кодСотрудника1TextBox);
            this.Controls.Add(налетаноЧасовLabel);
            this.Controls.Add(this.налетаноЧасовTextBox);
            this.Controls.Add(кодЭкипажаLabel);
            this.Controls.Add(this.кодЭкипажаTextBox);
            this.Controls.Add(this.экипажиBindingNavigator);
            this.Name = "Form3";
            this.Text = "Экипаж";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экипажиBindingNavigator)).EndInit();
            this.экипажиBindingNavigator.ResumeLayout(false);
            this.экипажиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Airoport.AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource экипажиBindingSource;
        private Airoport.AirportDataSetTableAdapters.ЭкипажиTableAdapter экипажиTableAdapter;
        private Airoport.AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator экипажиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton экипажиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодЭкипажаTextBox;
        private System.Windows.Forms.TextBox налетаноЧасовTextBox;
        private System.Windows.Forms.TextBox кодСотрудника1TextBox;
        private System.Windows.Forms.TextBox кодСотрудника2TextBox;
        private System.Windows.Forms.TextBox кодСотрудника3TextBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
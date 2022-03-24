
namespace Sandbox
{
    partial class Form6
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
            System.Windows.Forms.Label фИОпассажираLabel;
            System.Windows.Forms.Label паспортныеДанныеLabel;
            System.Windows.Forms.Label местоLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label кодРейсаLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.airportDataSet = new Airoport.AirportDataSet();
            this.билетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.билетыTableAdapter = new Airoport.AirportDataSetTableAdapters.БилетыTableAdapter();
            this.tableAdapterManager = new Airoport.AirportDataSetTableAdapters.TableAdapterManager();
            this.рейсыTableAdapter = new Airoport.AirportDataSetTableAdapters.РейсыTableAdapter();
            this.билетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.билетыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОпассажираTextBox = new System.Windows.Forms.TextBox();
            this.паспортныеДанныеTextBox = new System.Windows.Forms.TextBox();
            this.местоTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.кодРейсаComboBox = new System.Windows.Forms.ComboBox();
            фИОпассажираLabel = new System.Windows.Forms.Label();
            паспортныеДанныеLabel = new System.Windows.Forms.Label();
            местоLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            кодРейсаLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingNavigator)).BeginInit();
            this.билетыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОпассажираLabel
            // 
            фИОпассажираLabel.AutoSize = true;
            фИОпассажираLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            фИОпассажираLabel.Location = new System.Drawing.Point(207, 77);
            фИОпассажираLabel.Name = "фИОпассажираLabel";
            фИОпассажираLabel.Size = new System.Drawing.Size(132, 20);
            фИОпассажираLabel.TabIndex = 1;
            фИОпассажираLabel.Text = "ФИОпассажира:";
            // 
            // паспортныеДанныеLabel
            // 
            паспортныеДанныеLabel.AutoSize = true;
            паспортныеДанныеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            паспортныеДанныеLabel.Location = new System.Drawing.Point(183, 130);
            паспортныеДанныеLabel.Name = "паспортныеДанныеLabel";
            паспортныеДанныеLabel.Size = new System.Drawing.Size(170, 20);
            паспортныеДанныеLabel.TabIndex = 3;
            паспортныеДанныеLabel.Text = "Паспортные Данные:";
            // 
            // местоLabel
            // 
            местоLabel.AutoSize = true;
            местоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            местоLabel.Location = new System.Drawing.Point(258, 177);
            местоLabel.Name = "местоLabel";
            местоLabel.Size = new System.Drawing.Size(61, 20);
            местоLabel.TabIndex = 5;
            местоLabel.Text = "Место:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            ценаLabel.Location = new System.Drawing.Point(264, 262);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(52, 20);
            ценаLabel.TabIndex = 9;
            ценаLabel.Text = "Цена:";
            // 
            // кодРейсаLabel1
            // 
            кодРейсаLabel1.AutoSize = true;
            кодРейсаLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            кодРейсаLabel1.Location = new System.Drawing.Point(237, 225);
            кодРейсаLabel1.Name = "кодРейсаLabel1";
            кодРейсаLabel1.Size = new System.Drawing.Size(92, 20);
            кодРейсаLabel1.TabIndex = 10;
            кодРейсаLabel1.Text = "Код Рейса:";
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // билетыBindingSource
            // 
            this.билетыBindingSource.DataMember = "Билеты";
            this.билетыBindingSource.DataSource = this.airportDataSet;
            // 
            // билетыTableAdapter
            // 
            this.билетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Airoport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БилетыTableAdapter = this.билетыTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = this.рейсыTableAdapter;
            this.tableAdapterManager.СамолетыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТипыСамолетовTableAdapter = null;
            this.tableAdapterManager.ЭкипажиTableAdapter = null;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // билетыBindingNavigator
            // 
            this.билетыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.билетыBindingNavigator.BindingSource = this.билетыBindingSource;
            this.билетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.билетыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.билетыBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.билетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.билетыBindingNavigatorSaveItem});
            this.билетыBindingNavigator.Location = new System.Drawing.Point(0, 583);
            this.билетыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.билетыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.билетыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.билетыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.билетыBindingNavigator.Name = "билетыBindingNavigator";
            this.билетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.билетыBindingNavigator.Size = new System.Drawing.Size(873, 25);
            this.билетыBindingNavigator.TabIndex = 0;
            this.билетыBindingNavigator.Text = "bindingNavigator1";
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
            // билетыBindingNavigatorSaveItem
            // 
            this.билетыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.билетыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("билетыBindingNavigatorSaveItem.Image")));
            this.билетыBindingNavigatorSaveItem.Name = "билетыBindingNavigatorSaveItem";
            this.билетыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.билетыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.билетыBindingNavigatorSaveItem.Click += new System.EventHandler(this.билетыBindingNavigatorSaveItem_Click);
            // 
            // фИОпассажираTextBox
            // 
            this.фИОпассажираTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "ФИОпассажира", true));
            this.фИОпассажираTextBox.Location = new System.Drawing.Point(383, 81);
            this.фИОпассажираTextBox.Name = "фИОпассажираTextBox";
            this.фИОпассажираTextBox.Size = new System.Drawing.Size(249, 20);
            this.фИОпассажираTextBox.TabIndex = 2;
            // 
            // паспортныеДанныеTextBox
            // 
            this.паспортныеДанныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "ПаспортныеДанные", true));
            this.паспортныеДанныеTextBox.Location = new System.Drawing.Point(383, 130);
            this.паспортныеДанныеTextBox.Name = "паспортныеДанныеTextBox";
            this.паспортныеДанныеTextBox.Size = new System.Drawing.Size(249, 20);
            this.паспортныеДанныеTextBox.TabIndex = 4;
            // 
            // местоTextBox
            // 
            this.местоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Место", true));
            this.местоTextBox.Location = new System.Drawing.Point(383, 181);
            this.местоTextBox.Name = "местоTextBox";
            this.местоTextBox.Size = new System.Drawing.Size(249, 20);
            this.местоTextBox.TabIndex = 6;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(383, 269);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(249, 20);
            this.ценаTextBox.TabIndex = 10;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.airportDataSet;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Location = new System.Drawing.Point(369, 385);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(61, 36);
            this.materialFlatButton8.TabIndex = 59;
            this.materialFlatButton8.Text = "Выход";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            this.materialFlatButton8.Click += new System.EventHandler(this.materialFlatButton8_Click_1);
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(270, 433);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton6.TabIndex = 58;
            this.materialFlatButton6.Text = "Удалить";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            this.materialFlatButton6.Click += new System.EventHandler(this.materialFlatButton6_Click_1);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(359, 433);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton5.TabIndex = 57;
            this.materialFlatButton5.Text = "Сохранить";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click_1);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(550, 385);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton4.TabIndex = 56;
            this.materialFlatButton4.Text = "Вперед";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(281, 481);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(219, 36);
            this.materialFlatButton3.TabIndex = 55;
            this.materialFlatButton3.Text = "Открыть табличную форму";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(470, 433);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton2.TabIndex = 54;
            this.materialFlatButton2.Text = "Добавить";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(203, 385);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 53;
            this.materialFlatButton1.Text = "Назад";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // кодРейсаComboBox
            // 
            this.кодРейсаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.билетыBindingSource, "КодРейса", true));
            this.кодРейсаComboBox.DataSource = this.рейсыBindingSource;
            this.кодРейсаComboBox.DisplayMember = "КодРейса";
            this.кодРейсаComboBox.FormattingEnabled = true;
            this.кодРейсаComboBox.Location = new System.Drawing.Point(383, 229);
            this.кодРейсаComboBox.Name = "кодРейсаComboBox";
            this.кодРейсаComboBox.Size = new System.Drawing.Size(249, 21);
            this.кодРейсаComboBox.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 608);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(кодРейсаLabel1);
            this.Controls.Add(this.кодРейсаComboBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(местоLabel);
            this.Controls.Add(this.местоTextBox);
            this.Controls.Add(паспортныеДанныеLabel);
            this.Controls.Add(this.паспортныеДанныеTextBox);
            this.Controls.Add(фИОпассажираLabel);
            this.Controls.Add(this.фИОпассажираTextBox);
            this.Controls.Add(this.билетыBindingNavigator);
            this.Name = "Form6";
            this.Text = "Билеты";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетыBindingNavigator)).EndInit();
            this.билетыBindingNavigator.ResumeLayout(false);
            this.билетыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Airoport.AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource билетыBindingSource;
        private Airoport.AirportDataSetTableAdapters.БилетыTableAdapter билетыTableAdapter;
        private Airoport.AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator билетыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton билетыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОпассажираTextBox;
        private System.Windows.Forms.TextBox паспортныеДанныеTextBox;
        private System.Windows.Forms.TextBox местоTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Airoport.AirportDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private System.Windows.Forms.ComboBox кодРейсаComboBox;
    }
}
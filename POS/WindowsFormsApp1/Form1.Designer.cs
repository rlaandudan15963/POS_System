namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sale = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.CancelSale = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.ACbutton = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saletextBox = new System.Windows.Forms.TextBox();
            this.addpricetextBox = new System.Windows.Forms.TextBox();
            this.DeletePrice = new System.Windows.Forms.Button();
            this.stuffcount = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Button();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.pricelistBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(608, 361);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(157, 28);
            this.Sale.TabIndex = 88;
            this.Sale.Text = "매출";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(608, 308);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(157, 28);
            this.Stock.TabIndex = 87;
            this.Stock.Text = "재고 관리";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // CancelSale
            // 
            this.CancelSale.Location = new System.Drawing.Point(639, 251);
            this.CancelSale.Name = "CancelSale";
            this.CancelSale.Size = new System.Drawing.Size(98, 28);
            this.CancelSale.TabIndex = 86;
            this.CancelSale.Text = "취소";
            this.CancelSale.UseVisualStyleBackColor = true;
            this.CancelSale.Click += new System.EventHandler(this.CancelSale_Click);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(638, 183);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(99, 28);
            this.Payment.TabIndex = 85;
            this.Payment.Text = "결재";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Addbutton.Location = new System.Drawing.Point(516, 382);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(49, 45);
            this.Addbutton.TabIndex = 84;
            this.Addbutton.Text = "등록";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // ACbutton
            // 
            this.ACbutton.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ACbutton.Location = new System.Drawing.Point(406, 381);
            this.ACbutton.Name = "ACbutton";
            this.ACbutton.Size = new System.Drawing.Size(49, 45);
            this.ACbutton.TabIndex = 83;
            this.ACbutton.Text = "AC";
            this.ACbutton.UseVisualStyleBackColor = true;
            this.ACbutton.Click += new System.EventHandler(this.ACbutton_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num0.Location = new System.Drawing.Point(461, 382);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(49, 45);
            this.Num0.TabIndex = 82;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num9.Location = new System.Drawing.Point(516, 330);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(49, 45);
            this.Num9.TabIndex = 81;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num8.Location = new System.Drawing.Point(461, 330);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(49, 45);
            this.Num8.TabIndex = 80;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num7.Location = new System.Drawing.Point(406, 330);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(49, 45);
            this.Num7.TabIndex = 79;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num6.Location = new System.Drawing.Point(516, 279);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(49, 45);
            this.Num6.TabIndex = 78;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num5.Location = new System.Drawing.Point(461, 279);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(49, 45);
            this.Num5.TabIndex = 77;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num4.Location = new System.Drawing.Point(406, 279);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(49, 45);
            this.Num4.TabIndex = 76;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num3.Location = new System.Drawing.Point(516, 228);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(49, 45);
            this.Num3.TabIndex = 75;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num2.Location = new System.Drawing.Point(461, 228);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(49, 45);
            this.Num2.TabIndex = 74;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Num1.Location = new System.Drawing.Point(406, 228);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(49, 45);
            this.Num1.TabIndex = 72;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(320, 361);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(71, 66);
            this.button15.TabIndex = 64;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(243, 361);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 66);
            this.button14.TabIndex = 63;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(166, 361);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(71, 66);
            this.button13.TabIndex = 62;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(89, 361);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(71, 66);
            this.button12.TabIndex = 61;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 361);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 66);
            this.button11.TabIndex = 60;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(320, 289);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 66);
            this.button10.TabIndex = 59;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(243, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 66);
            this.button9.TabIndex = 58;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 289);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 66);
            this.button8.TabIndex = 57;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 289);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 66);
            this.button7.TabIndex = 56;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 66);
            this.button6.TabIndex = 55;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SaleStuff);
            // 
            // saletextBox
            // 
            this.saletextBox.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saletextBox.Location = new System.Drawing.Point(12, 20);
            this.saletextBox.Name = "saletextBox";
            this.saletextBox.Size = new System.Drawing.Size(379, 81);
            this.saletextBox.TabIndex = 89;
            this.saletextBox.Text = "0";
            this.saletextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addpricetextBox
            // 
            this.addpricetextBox.Font = new System.Drawing.Font("굴림", 16F);
            this.addpricetextBox.Location = new System.Drawing.Point(406, 183);
            this.addpricetextBox.Name = "addpricetextBox";
            this.addpricetextBox.Size = new System.Drawing.Size(159, 32);
            this.addpricetextBox.TabIndex = 90;
            this.addpricetextBox.Text = "0";
            this.addpricetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DeletePrice
            // 
            this.DeletePrice.Location = new System.Drawing.Point(638, 217);
            this.DeletePrice.Name = "DeletePrice";
            this.DeletePrice.Size = new System.Drawing.Size(99, 28);
            this.DeletePrice.TabIndex = 91;
            this.DeletePrice.Text = "제거";
            this.DeletePrice.UseVisualStyleBackColor = true;
            this.DeletePrice.Click += new System.EventHandler(this.DeletePrice_Click);
            // 
            // stuffcount
            // 
            this.stuffcount.Enabled = false;
            this.stuffcount.Font = new System.Drawing.Font("굴림", 16F);
            this.stuffcount.Location = new System.Drawing.Point(12, 179);
            this.stuffcount.Name = "stuffcount";
            this.stuffcount.Size = new System.Drawing.Size(159, 32);
            this.stuffcount.TabIndex = 95;
            this.stuffcount.Text = "0";
            this.stuffcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(186, 179);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 28);
            this.add.TabIndex = 96;
            this.add.Text = "등록";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancle
            // 
            this.cancle.Enabled = false;
            this.cancle.Location = new System.Drawing.Point(291, 179);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(100, 28);
            this.cancle.TabIndex = 97;
            this.cancle.Text = "취소";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 66);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 66);
            this.button2.TabIndex = 51;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 66);
            this.button3.TabIndex = 52;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 66);
            this.button4.TabIndex = 53;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SaleStuff);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 66);
            this.button5.TabIndex = 54;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SaleStuff);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(281, 117);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(110, 42);
            this.input.TabIndex = 103;
            this.input.Text = "입력";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // Barcode
            // 
            this.Barcode.Font = new System.Drawing.Font("굴림", 20F);
            this.Barcode.Location = new System.Drawing.Point(12, 117);
            this.Barcode.Multiline = true;
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(263, 42);
            this.Barcode.TabIndex = 102;
            this.Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pricelistBox
            // 
            this.pricelistBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.pricelistBox.FullRowSelect = true;
            this.pricelistBox.HideSelection = false;
            this.pricelistBox.Location = new System.Drawing.Point(412, 20);
            this.pricelistBox.Name = "pricelistBox";
            this.pricelistBox.Size = new System.Drawing.Size(403, 139);
            this.pricelistBox.TabIndex = 104;
            this.pricelistBox.UseCompatibleStateImageBehavior = false;
            this.pricelistBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "상품명";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "가격";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "개수";
            this.columnHeader4.Width = 40;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.pricelistBox);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stuffcount);
            this.Controls.Add(this.DeletePrice);
            this.Controls.Add(this.addpricetextBox);
            this.Controls.Add(this.saletextBox);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.CancelSale);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.ACbutton);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "POS_Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button CancelSale;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button ACbutton;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox saletextBox;
        private System.Windows.Forms.TextBox addpricetextBox;
        private System.Windows.Forms.Button DeletePrice;
        private System.Windows.Forms.TextBox stuffcount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.ListView pricelistBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


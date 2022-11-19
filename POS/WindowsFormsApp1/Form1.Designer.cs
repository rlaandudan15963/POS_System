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
            this.pricelistBox = new System.Windows.Forms.ListBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saletextBox = new System.Windows.Forms.TextBox();
            this.addpricetextBox = new System.Windows.Forms.TextBox();
            this.DeletePrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // pricelistBox
            // 
            this.pricelistBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pricelistBox.FormattingEnabled = true;
            this.pricelistBox.ItemHeight = 16;
            this.pricelistBox.Location = new System.Drawing.Point(406, 36);
            this.pricelistBox.Name = "pricelistBox";
            this.pricelistBox.Size = new System.Drawing.Size(405, 132);
            this.pricelistBox.TabIndex = 71;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(320, 361);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(71, 66);
            this.button20.TabIndex = 69;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(243, 361);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(71, 66);
            this.button19.TabIndex = 68;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(166, 361);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(71, 66);
            this.button18.TabIndex = 67;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(89, 361);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(71, 66);
            this.button17.TabIndex = 66;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 361);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(71, 66);
            this.button16.TabIndex = 65;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(320, 289);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(71, 66);
            this.button15.TabIndex = 64;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(243, 289);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 66);
            this.button14.TabIndex = 63;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(166, 289);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(71, 66);
            this.button13.TabIndex = 62;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(89, 289);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(71, 66);
            this.button12.TabIndex = 61;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 289);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 66);
            this.button11.TabIndex = 60;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(320, 217);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 66);
            this.button10.TabIndex = 59;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(243, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 66);
            this.button9.TabIndex = 58;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 66);
            this.button8.TabIndex = 57;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 66);
            this.button7.TabIndex = 56;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 66);
            this.button6.TabIndex = 55;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 66);
            this.button5.TabIndex = 54;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 66);
            this.button4.TabIndex = 53;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 66);
            this.button3.TabIndex = 52;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 66);
            this.button2.TabIndex = 51;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 66);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saletextBox
            // 
            this.saletextBox.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saletextBox.Location = new System.Drawing.Point(12, 46);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(619, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(764, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "개수";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.pricelistBox);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
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
        private System.Windows.Forms.ListBox pricelistBox;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox saletextBox;
        private System.Windows.Forms.TextBox addpricetextBox;
        private System.Windows.Forms.Button DeletePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


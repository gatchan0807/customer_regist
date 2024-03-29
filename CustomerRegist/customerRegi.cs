﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRegist
{
    public partial class CustomerRegi : Form
    {
        private MenuList menuList;
        private string[] prefectures = {
                                           "北海道", "青森県", "岩手県", "宮城県", "秋田県", 
                                           "山形県", "福島県", "茨城県", "栃木県", "群馬県", 
                                           "埼玉県", "千葉県", "東京都", "神奈川県", "新潟県", 
                                           "富山県", "石川県", "福井県", "山梨県", "長野県", 
                                           "岐阜県", "静岡県", "愛知県", "三重県", "滋賀県", 
                                           "京都府", "大阪府", "兵庫県", "奈良県", "和歌山県", 
                                           "鳥取県", "島根県", "岡山県", "広島県", "山口県", 
                                           "徳島県", "香川県", "愛媛県", "高知県", "福岡県", 
                                           "佐賀県", "長崎県", "熊本県", "大分県", "宮崎県", 
                                           "鹿児島県", "沖縄県"
                                       };
        private string[] city = {
                                    "市", "区", "町", "村"
                                };
        private Login login;
        public CustomerRegi()
        {
            InitializeComponent();
        }

        public CustomerRegi(MenuList menuList)
        {
            InitializeComponent();
            this.menuList = menuList;
        }

        public CustomerRegi(MenuList menuList, Login login)
        {
            InitializeComponent();
            this.menuList = menuList;
            this.login = login;
        }

        private void CustomerRegi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < prefectures.Length; i++ )   //都道府県コンボボックス初期化
            {
                customerData6.Items.Add(prefectures[i]);    
            }
            for (int i = 0; i < city.Length; i++)           //市区町村コンボボックス初期化
            {
                customerData8.Items.Add(city[i]);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            menuList.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (null_check())   //空文字チェックメソッド使用
            {
                string[] datas = { customerData1.Text, customerData2.Text, customerData3.Text,
                                    customerData4.Text, customerData5.Text, customerData6.Text,
                                    customerData7.Text, customerData8.Text, customerData9.Text,
                                    customerData10.Text, customerData11.Text
                                 };
                this.Hide();
                Confirmation cf = new Confirmation(this, datas, login, menuList);
                cf.Show();
            }
        }

        private bool null_check()   //入力フォームのから文字チェックメソッド
        {
            //どれかが空文字だと、入力欄の色が変わり、falseが返る
            //すべて埋まっていれば入力欄は白色に代わり、trueが返る

            Boolean flag = false;

            if (customerData1.Text == "" || customerData2.Text == "" || customerData3.Text == "" ||
                customerData4.Text == "" || customerData5.Text == "" || customerData6.Text == "" ||
                customerData7.Text == "" || customerData8.Text == "" || customerData9.Text == "" ||
                customerData10.Text == "")  
            {
                flag = false;
                if (customerData1.Text == "")
                {
                    customerData1.BackColor = Color.Orange;
                }
                else
                {
                    customerData1.BackColor = Color.White;
                }
                if (customerData2.Text == "")
                {
                    customerData2.BackColor = Color.Orange;
                }
                else
                {
                    customerData2.BackColor = Color.White;
                }
                if (customerData3.Text == "")
                {
                    customerData3.BackColor = Color.Orange;
                }
                else
                {
                    customerData3.BackColor = Color.White;
                }
                if (customerData4.Text == "")
                {
                    customerData4.BackColor = Color.Orange;
                }
                else
                {
                    customerData4.BackColor = Color.White;
                }
                if (customerData5.Text == "")
                {
                    customerData5.BackColor = Color.Orange;
                }
                else
                {
                    customerData5.BackColor = Color.White;
                }
                if (customerData6.Text == "")
                {
                    customerData6.BackColor = Color.Orange;
                }
                else
                {
                    customerData6.BackColor = Color.White;
                }
                if (customerData7.Text == "")
                {
                    customerData7.BackColor = Color.Orange;
                }
                else
                {
                    customerData7.BackColor = Color.White;
                }
                if (customerData8.Text == "")
                {
                    customerData8.BackColor = Color.Orange;
                }
                else
                {
                    customerData8.BackColor = Color.White;
                }
                if (customerData9.Text == "")
                {
                    customerData9.BackColor = Color.Orange;
                }
                else
                {
                    customerData9.BackColor = Color.White;
                }
                if (customerData10.Text == "")
                {
                    customerData10.BackColor = Color.Orange;
                }
                else
                {
                    customerData10.BackColor = Color.White;
                }
            }
            else
            {
               
                flag = true;
            }
            return flag;
        }
    }
}

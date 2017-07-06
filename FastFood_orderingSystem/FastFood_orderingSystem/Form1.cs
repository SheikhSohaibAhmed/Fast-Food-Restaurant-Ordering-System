using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FastFood_orderingSystem
{
    public partial class Form1 : Form
    {
        const double price_fries = 1.0;
        const double price_salad = 1.1;
        const double price_hamburger = 1.2;
        const double price_onionrings = 1.3;
        const double price_chikensalad = 1.4;
        const double price_fishsandwich = 1.5;
        const double price_cheesesandwich = 1.6;
        const double price_chikensandwich = 1.7;
        const double price_hashbrown = 1.8;
        const double price_toastedbagel = 1.9;
        const double price_pineapplestick = 2.0;
        const double price_chocolatemuffin = 2.1;
        const double price_pancakesyrup = 2.2;
        const double price_tea = 2.3;
        const double price_cola = 2.4;
        const double price_coffee = 2.5;
        const double price_orangejuice = 2.6;
        const double price_bottlewater = 2.7;
        const double price_vanillacone = 2.8;
        const double price_vanillashake = 2.9;
        const double price_strawberryshake = 3.0;
        const double price_chocolateshake = 3.1;
        const double Taxrate = 1.0;
        double itax, isubtotal, itotal;
        public Form1()
        {
            InitializeComponent();
        }
        //Exit_button
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit","Fast Food",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void resettextboxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "0";
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }
        private void disabletextboxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Enabled = false;
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }
        private void resetcheckboxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }
        //Reset_button
        private void button2_Click(object sender, EventArgs e)
        {
            resettextboxes();
            resetcheckboxes();
            cbpaymentmethod.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbpaymentmethod.Items.Add("");
            cbpaymentmethod.Items.Add("Cash");
            cbpaymentmethod.Items.Add("Master Card");
            cbpaymentmethod.Items.Add("Visa Card");
            cbpaymentmethod.Items.Add("Debit Card");
            disabletextboxes();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkfries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfries.Checked == true)
            {
                txtfries.Enabled = true;
                txtfries.Focus();
                txtfries.Text = "";
            }
            else
            {
                txtfries.Enabled = false;
                txtfries.Text = "0";
            }
        }

        private void chksalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chksalad.Checked == true)
            {
                txtsalad.Enabled = true;
                txtsalad.Focus();
                txtsalad.Text = "";
            }
            else
            {
                txtsalad.Enabled = false;
                txtsalad.Text = "0";
            }
        }

        private void chkhamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhamburger.Checked == true)
            {
                txthamburger.Enabled = true;
                txthamburger.Focus();
                txthamburger.Text = "";
            }
            else
            {
                txthamburger.Enabled = false;
                txthamburger.Text = "0";
            }
        }

        private void chkonionrings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkonionrings.Checked == true)
            {
                txtonionrings.Enabled = true;
                txtonionrings.Focus();
                txtonionrings.Text = "";
            }
            else
            {
                txtonionrings.Enabled = false;
                txtonionrings.Text = "0";
            }
        }

        private void chkchikensalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchikensalad.Checked == true)
            {
                txtchikensalad.Enabled = true;
                txtchikensalad.Focus();
                txtchikensalad.Text = "";
            }
            else
            {
                txtchikensalad.Enabled = false;
                txtchikensalad.Text = "0";
            }
        }

        private void chkfishsandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfishsandwich.Checked == true)
            {
                txtfishsandwich.Enabled = true;
                txtfishsandwich.Focus();
                txtfishsandwich.Text = "";
            }
            else
            {
                txtfishsandwich.Enabled = false;
                txtfishsandwich.Text = "0";
            }
        }

        private void chkcheesesandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcheesesandwich.Checked == true)
            {
                txtcheesesandwich.Enabled = true;
                txtcheesesandwich.Focus();
                txtcheesesandwich.Text = "";
            }
            else
            {
                txtcheesesandwich.Enabled = false;
                txtcheesesandwich.Text = "0";
            }
        }

        private void chkchikensandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchikensandwich.Checked == true)
            {
                txtchikensandwich.Enabled = true;
                txtchikensandwich.Focus();
                txtchikensandwich.Text = "";
            }
            else
            {
                txtchikensandwich.Enabled = false;
                txtchikensandwich.Text = "0";
            }
        }

        private void chkhashbrown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhashbrown.Checked == true)
            {
                txthashbrown.Enabled = true;
                txthashbrown.Focus();
                txthashbrown.Text = "";
            }
            else
            {
                txthashbrown.Enabled = false;
                txthashbrown.Text = "0";
            }
        }

        private void chktoastedbagel_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoastedbagel.Checked == true)
            {
                txttoastedbagel.Enabled = true;
                txttoastedbagel.Focus();
                txttoastedbagel.Text = "";
            }
            else
            {
                txttoastedbagel.Enabled = false;
                txttoastedbagel.Text = "0";
            }
        }

        private void chkpineapplestick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpineapplestick.Checked == true)
            {
                txtpineapplestick.Enabled = true;
                txtpineapplestick.Focus();
                txtpineapplestick.Text = "";
            }
            else
            {
                txtpineapplestick.Enabled = false;
                txtpineapplestick.Text = "0";
            }
        }

        private void chlchocolatemuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (chlchocolatemuffin.Checked == true)
            {
                txtchocolatemuffin.Enabled = true;
                txtchocolatemuffin.Focus();
                txtchocolatemuffin.Text = "";
            }
            else
            {
                txtchocolatemuffin.Enabled = false;
                txtchocolatemuffin.Text = "0";
            }
        }

        private void chkpanecakesyrup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpanecakesyrup.Checked == true)
            {
                txtpanecakesyrup.Enabled = true;
                txtpanecakesyrup.Focus();
                txtpanecakesyrup.Text = "";
            }
            else
            {
                txtpanecakesyrup.Enabled = false;
                txtpanecakesyrup.Text = "0";
            }
        }

        private void chktea_CheckedChanged(object sender, EventArgs e)
        {
            if (chktea.Checked == true)
            {
                txttea.Enabled = true;
                txttea.Focus();
                txttea.Text = "";
            }
            else
            {
                txttea.Enabled = false;
                txttea.Text = "0";
            }
        }

        private void chkcola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcola.Checked == true)
            {
                txtcola.Enabled = true;
                txtcola.Focus();
                txtcola.Text = "";
            }
            else
            {
                txtcola.Enabled = false;
                txtcola.Text = "0";
            }
        }

        private void chkcoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcoffee.Checked == true)
            {
                txtcoffee.Enabled = true;
                txtcoffee.Focus();
                txtcoffee.Text = "";
            }
            else
            {
                txtcoffee.Enabled = false;
                txtcoffee.Text = "0";
            }
        }

        private void chkorangejuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkorangejuice.Checked == true)
            {
                txtorangejuice.Enabled = true;
                txtorangejuice.Focus();
                txtorangejuice.Text = "";
            }
            else
            {
                txtorangejuice.Enabled = false;
                txtorangejuice.Text = "0";
            }
        }

        private void chkbottlewater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbottlewater.Checked == true)
            {
                txtbottlewater.Enabled = true;
                txtbottlewater.Focus();
                txtbottlewater.Text = "";
            }
            else
            {
                txtbottlewater.Enabled = false;
                txtbottlewater.Text = "0";
            }
        }

        private void chkvanillacone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvanillacone.Checked == true)
            {
                txtvanillacone.Enabled = true;
                txtvanillacone.Focus();
                txtvanillacone.Text = "";
            }
            else
            {
                txtvanillacone.Enabled = false;
                txtvanillacone.Text = "0";
            }
        }

        private void chkvanillashake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvanillashake.Checked == true)
            {
                txtvanillashake.Enabled = true;
                txtvanillashake.Focus();
                txtvanillashake.Text = "";
            }
            else
            {
                txtvanillashake.Enabled = false;
                txtvanillashake.Text = "0";
            }
        }

        private void cbpaymentmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpaymentmethod.Text == "Cash")
            {
                txtpaymentmethod.Enabled = true;
                txtpaymentmethod.Text = "";
                txtpaymentmethod.Focus();
            }
            else
            {
                txtpaymentmethod.Enabled = false;
                txtpaymentmethod.Text = "0";
            }
        }
        //total_button
        private void button1_Click(object sender, EventArgs e)
        {
            txtchange.Enabled = true;
            txttax.Enabled = true;
            txtsubtotal.Enabled = true;
            txttotal.Enabled = true;
            double[] itemcost = new double [22];
            itemcost[0] = Convert.ToDouble (txtfries.Text) * price_fries;
            itemcost[1] = Convert.ToDouble(txtsalad.Text) * price_salad;
            itemcost[2] = Convert.ToDouble(txthamburger.Text) * price_hamburger;
            itemcost[3] = Convert.ToDouble(txtonionrings.Text) * price_onionrings;
            itemcost[4] = Convert.ToDouble(txtchikensalad.Text) * price_chikensalad;
            itemcost[5] = Convert.ToDouble(txtfishsandwich.Text) * price_fishsandwich;
            itemcost[6] = Convert.ToDouble(txtcheesesandwich.Text) * price_cheesesandwich;
            itemcost[7] = Convert.ToDouble(txtchikensandwich.Text) * price_chikensandwich;
            itemcost[8] = Convert.ToDouble(txthashbrown.Text) * price_hashbrown;
            itemcost[9] = Convert.ToDouble(txttoastedbagel.Text) * price_toastedbagel;
            itemcost[10] = Convert.ToDouble(txtpineapplestick.Text) * price_pineapplestick;
            itemcost[11] = Convert.ToDouble(txtchocolatemuffin.Text) * price_chocolatemuffin;
            itemcost[12] = Convert.ToDouble(txtpanecakesyrup.Text) * price_pancakesyrup;
            itemcost[13] = Convert.ToDouble(txttea.Text) * price_tea;
            itemcost[14] = Convert.ToDouble(txtcola.Text) * price_cola;
            itemcost[15] = Convert.ToDouble(txtcoffee.Text) * price_coffee;
            itemcost[16] = Convert.ToDouble(txtorangejuice.Text) * price_orangejuice;
            itemcost[17] = Convert.ToDouble(txtbottlewater.Text) * price_bottlewater;
            itemcost[18] = Convert.ToDouble(txtvanillacone.Text) * price_vanillacone;
            itemcost[19] = Convert.ToDouble(txtvanillashake.Text) * price_vanillashake;
            itemcost[20] = Convert.ToDouble(txtstrawberryshake.Text) * price_strawberryshake;
            itemcost[21] = Convert.ToDouble(txtchocolateshake.Text) * price_chocolateshake;
            double cost;
            if (cbpaymentmethod.Text == "Cash")
            {
                isubtotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                    itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];
                txtsubtotal.Text = Convert.ToString(isubtotal);
                itax = (isubtotal * Taxrate) / 100;
                txttax.Text = Convert.ToString(itax);
                itotal = isubtotal + itax;
                txttotal.Text = Convert.ToString(itotal);
                double bill;
                bill = Convert.ToDouble(txtpaymentmethod.Text);
                txtchange.Text = Convert.ToString(bill - itotal);
                //txtchange.Text = 
            }
            else
            {
                isubtotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                    itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];
                txtsubtotal.Text = Convert.ToString(isubtotal);
                itax = (isubtotal * Taxrate) / 100;
                txttax.Text = Convert.ToString(itax);
                itotal = isubtotal + itax;
                txttotal.Text = Convert.ToString(itotal);
            }
        }

        private void chkstrawberryshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkstrawberryshake.Checked == true)
            {
                txtstrawberryshake.Enabled = true;
                txtstrawberryshake.Focus();
                txtstrawberryshake.Text = "";
            }
            else
            {
                txtstrawberryshake.Enabled = false;
                txtstrawberryshake.Text = "0";
            }
        }

        private void chkchocolateshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchocolateshake.Checked == true)
            {
                txtchocolateshake.Enabled = true;
                txtchocolateshake.Focus();
                txtchocolateshake.Text = "";
            }
            else
            {
                txtchocolateshake.Enabled = false;
                txtchocolateshake.Text = "0";
            }
        }
    }
}

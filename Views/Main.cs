using Calculadora.Interfaces;
using Calculadora.Models;
using Calculadora.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Views
{
    public partial class Main : Form, IMain
    {
        public string Visor { get => RtVisor.Text; set => _ = CleanVisor ? "0" : RtVisor.Text = value; }
        public string Subtotal { get => LbSubtotal.Text; set => _ = CleanSubtotal ? "0" : LbSubtotal.Text = value; }
        public bool CleanVisor
        {
            get => _cleanVisor;
            set
            {
                _cleanVisor = value;
                if (value)
                {
                    RtVisor.Text = "0";
                }
            }
        }
        private bool _cleanVisor = false;
        public bool CleanSubtotal
        {
            get => _cleanSubtotal;
            set
            {
                _cleanSubtotal = value;
                if (value)
                {
                    LbSubtotal.Text = "";
                }
            }
        }

        private bool _cleanSubtotal = false;
        public OperationType Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                CountOp++;
            }
        }
        private OperationType _operation;
        public string ValueA
        {
            get
            {
                _ = _valueA.Length > 0 && _valueA != "0" ? EnableOperation(true) : EnableOperation(false);
                return _valueA;
            }
            set
            {
                _valueA = value;
                _ = value.Length > 0 && value != "0" ? EnableOperation(true) : EnableOperation(false);
            }
        }
        private string _valueA = "0";
        public string ValueB
        {
            get
            {
                _ = _valueB.Length > 0 && _valueB != "0" ? EnableEqualsOp(true) : EnableEqualsOp(false);
                return _valueB;
            }
            set
            {
                _ = value.Length > 0 && value != "0" ? EnableEqualsOp(true) : EnableEqualsOp(false);
                _valueB = value;
            }
        }

        private string _valueB = "0";
        public int Index { get => _index; set => _index = value; }
        private int _index = 1;
        public int CountOp { get => _countOp; set => _countOp = value; }
        private int _countOp = 0;
        

        protected MainPresenter presenter;

        public Main()
        {
            InitializeComponent();
            presenter = new(this);
            EnableOperation(false);
           EnableEqualsOp(false);
        }
        public bool EnableEqualsOp(bool value)
        {
            BtEquals.Enabled = value;
            BtPercent.Enabled = value;
            return value;
        }
        public bool EnableOperation(bool value)
        {
            BtPlus.Enabled = value;
            BtMinus.Enabled = value;
            BtTimes.Enabled = value;
            BtDivide.Enabled = value;
            BtPercent.Enabled = value;
            return value;
        }
        private void BtOne_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("1");
            RtVisor.Focus();
        }

        private void BtTwo_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("2");
            RtVisor.Focus();
        }

        private void BtThree_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("3");
            RtVisor.Focus();
        }

        private void BtFour_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("4");
            RtVisor.Focus();
        }

        private void BtFive_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("5");
            RtVisor.Focus();
        }

        private void BtSix_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("6");
            RtVisor.Focus();
        }

        private void BtSeven_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("7");
            RtVisor.Focus();
        }

        private void BtEight_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("8");
            RtVisor.Focus();
        }

        private void BtNine_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("9");
            RtVisor.Focus();
        }

        private void BtZero_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("0");
            RtVisor.Focus();
        }

        private void BtComma_Click(object sender, EventArgs e)
        {
            CleanVisor = false;
            CleanSubtotal = false;
            if (!(Visor.Last() == ','))
            {
                presenter.AddDig(",");
            }
            RtVisor.Focus();

        }

        private void BtPlus_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Plus;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("+");
            RtVisor.Focus();
        }

        private void BtMinus_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Minus;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("-");
            RtVisor.Focus();
        }
        private void BtTimes_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Times;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("*");
            RtVisor.Focus();
        }

        private void BtDivide_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Divide;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("/");
            RtVisor.Focus();
        }
        private void BtPercent_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Percent;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("%");
            RtVisor.Focus();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            if (Visor.Length > 0)
            {
                Visor = Visor.Remove(Visor.Length - 1);
            }
            RtVisor.Focus();
        }

        private void BtEquals_Click(object sender, EventArgs e)
        {
            Operation = OperationType.Equals;
            CleanVisor = false;
            CleanSubtotal = false;
            presenter.AddDig("=");
        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            presenter.CleanCalc();
            RtVisor.Focus();
        }

    
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
            base.OnKeyPress(e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           
            switch (keyData)
            {
                case Keys.Enter:
                    if (BtEquals.Enabled) BtEquals_Click(new(), new());

                    break;
                case Keys.OemMinus:
                    if (BtMinus.Enabled) BtMinus_Click(new(), new());
                    break;
                case Keys.Subtract:
                    if (BtMinus.Enabled) BtMinus_Click(new(), new());
                    break;
                case Keys.Oemplus:
                    if (BtPlus.Enabled) BtPlus_Click(new(), new());
                    break;
                case Keys.Add:
                    if (BtPlus.Enabled) BtPlus_Click(new(), new());
                    break;
                case Keys.Multiply:
                    if (BtTimes.Enabled) BtTimes_Click(new(), new());
                    break;
                case Keys.X:
                    if (BtTimes.Enabled) BtTimes_Click(new(), new());
                    break;
                case Keys.Divide:
                    if (BtDivide.Enabled) BtDivide_Click(new(), new());
                    break;
                case Keys.P:
                    if (BtDivide.Enabled) BtDivide_Click(new(), new());
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Oem8)
            {
                if (BtTimes.Enabled) BtTimes_Click(new(), new());
            }
        }

        
    }
}

using Calculadora.Interfaces;
using Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Presenters
{
    public class MainPresenter
    {
        protected IMain View;
        private readonly char[] Op = { '+', '-', '/', '*', '=','%'};
        private decimal ValueA
        {
            get => decimal.Parse(View.ValueA); set => View.ValueA = value.ToString();
        }
        private decimal ValueB
        {
            get => decimal.Parse(View.ValueB); set => View.ValueB = value.ToString();
        }
        private OperationType FirstOperation;
        private string VisorAux;


        public MainPresenter(IMain view)
        {
            this.View = view;
            this.VisorAux = "";
        }
        public void AddDig(string value)
        {
            if (!Op.Contains(value.LastOrDefault()) && View.CountOp == 0)
            {
                View.Index = 1;
            }
            //verifica se o digito passado é uma operação
            bool isOp = Op.Contains(value.LastOrDefault());
            if (isOp)
            {
                //se foi relaizado a primeira op armazena o tipo dela para o calculo
                if (View.CountOp == 1)
                {
                    FirstOperation = View.Operation;
                }
                //Muda pro indice 2
                View.Index = 2;
                //verifica se o ultimo digito do visor é um operador, caso seja ele é substitui pelo recebido e altera a primeira operação para o novo operador recebido e atribui ao contador de operação 1 novamente.
                if (Op.Contains(View.Visor.LastOrDefault()))
                {
                    View.Visor = View.Visor.Replace(View.Visor.LastOrDefault(), value.LastOrDefault());
                    FirstOperation = View.Operation;
                    View.CountOp = 1;
                }
                // Se não adiciona o operador recebido no visor da calculadora.
                else
                {
                    View.Visor += value;
                    VisorAux += value;
                }
                // View.Visor = Op.Contains(View.Visor.LastOrDefault()) ? View.Visor.Replace(View.Visor.LastOrDefault(), value.LastOrDefault()) : View.Visor += value;
                //Se é o segundo operador encadeado a conta é processada 
                if (View.CountOp >= 2)
                {
                    //se o operador encadeado é igual zera o subtotal e resultado fica no visor, zerando o contador de operações e deixando no indice 2
                    if (View.Operation == OperationType.Equals)
                    {
                       
                        if (ValueB == 0 && FirstOperation == OperationType.Divide)
                        {
                            Exception("Não divísivel por zero");
                            return;
                        }
                        View.Visor = SwitchOp();
                        VisorAux = View.Visor;
                        ValueB = 0;
                        View.Index = 2;
                        ValueA = decimal.Parse(View.Visor);
                        View.CountOp = 0;
                        View.CleanSubtotal = true;
                    }
                    
                    //Se não mantem o mesmo valor no subtotal e passa para o visor, zerando o contador de operações deixando no indice 1
                    else
                    {
                       
                        if (ValueB == 0 && FirstOperation == OperationType.Divide)
                        {
                            Exception("Não divísivel por zero");
                            return;
                        }
                        View.Subtotal = SwitchOp();
                        View.Visor = View.Subtotal;
                        VisorAux = View.Visor;
                        ValueA = decimal.Parse(View.Subtotal);
                        ValueB = 0;
                        View.Index = 2;
                        View.CountOp = 0;
                    }

                }
            }
            else
            {
                if (View.Index == 1)
                {
                    _ = View.ValueA == "0" && value != ","? View.ValueA = value : View.ValueA = $@"{View.ValueA}{value}";
                    View.Visor = View.ValueA;
                    VisorAux = View.Visor;
                }
                if (View.Index == 2)
                {
                    _ = View.ValueB == "0" && value != "," ? View.ValueB = value : View.ValueB = $@"{View.ValueB}{value}";
                    View.Visor = $@"{VisorAux}{View.ValueB}";
                }
            }

        }
        public void Exception(string message)
        {
            View.Visor = message;
            ValueA = 0;
            ValueB = 0;
            View.CleanSubtotal = true;
            View.CountOp = 0;
            View.Index = 1;
        }
        public void CleanCalc()
        {
            ValueA = 0;
            ValueB = 0;
            View.CleanVisor = true;
            View.CleanSubtotal = true;
            View.CountOp = 0;
            View.Index = 1;
        }
        public string SwitchOp()
        {
            string result;
            if (FirstOperation == OperationType.Minus && View.Operation == OperationType.Percent)
                return Calc.Percent(FirstOperation, ValueA, ValueB).ToString();
            if (FirstOperation == OperationType.Plus && View.Operation == OperationType.Percent)
                return Calc.Percent(FirstOperation, ValueA, ValueB).ToString();
            if (FirstOperation == OperationType.Times && View.Operation == OperationType.Percent)
                return Calc.Percent(FirstOperation, ValueA, ValueB).ToString();
            if (FirstOperation == OperationType.Divide && View.Operation == OperationType.Percent)
                return Calc.Percent(FirstOperation, ValueA, ValueB).ToString();

            switch (FirstOperation)
            {
                case OperationType.Plus:
                    result = Calc.Plus(ValueA, ValueB).ToString();
                    break;
                case OperationType.Minus:
                    result = Calc.Minus(ValueA, ValueB).ToString();
                    break;
                case OperationType.Times:
                    result = Calc.Times(ValueA, ValueB).ToString();
                    break;
                case OperationType.Divide:
                    result = Calc.Divide(ValueA, ValueB).ToString();
                    break;
                default:
                    result = "0";
                    break;
            }
            return result;
        }

    }
}




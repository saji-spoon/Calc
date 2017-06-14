using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc002
{


    enum Operator 
    {
        Plus,
        Minus,
        Multi,
        Divide,
        Equal
    }    

    class Expression 
    {
        public string L { get; set; }
        public Operator? Op { get; set; }
        public string R { get; set; }      

        public Expression() 
        {
            L = "0";
        }

        //式を計算して左項に代入し、演算子と右項は空に
        public bool eval() 
        {
            if (Op == null || R == null) 
            {
                return false;
            }

            decimal dl = decimal.Parse(L);
            decimal dr = decimal.Parse(R);

            switch (Op)
            {
                case Operator.Plus:
                    dl = dl + dr;
                    break;
                case Operator.Minus:
                    dl = dl - dr;
                    break;
                case Operator.Multi:
                    dl = dl * dr;
                    break;
                case Operator.Divide:
                    dl = dl / dr;
                    break;
                default:
                    break;
            }

            L = dl.ToString();
            Op = null;
            R = null;

            return true;
        }

  

    }

    class Calc
    {
        private Expression Exp { get; set; }

        private bool IsError { get; set; }

        public string ExpText { get; set; }

        public string OpText { get; set; }


        public Calc() 
        {
            init();
        }

        public void init()
        {
            this.Exp = new Expression();
            this.IsError = false;
            this.ExpText = Exp.L.ToString();
            this.OpText = "";
        }

        private void setError() 
        {
            setError("");
        }

        private void setError(string errorMessage)
        {
            ExpText = errorMessage;
            OpText = "E";
            IsError = true;
        }

        //数字キーのどれか押された時の処理
        public void pushNum(int num) 
        {
            if(!(num <= 9))
            {
                return;
            }

            if (IsError) init();

            string temp;

            if(Exp.Op==null)
            {
                temp = Exp.L;
            }
            else
            {
                if (Exp.R == null) Exp.R = "0";
                temp = Exp.R;
            }
             
            temp = (temp == "0") ? num.ToString() : temp + num.ToString();

            //戻すかのチェック
            decimal result;
            if (decimal.TryParse(temp, out result)) 
            {                
                ExpText = temp;

                if (Exp.Op == null)
                    Exp.L = temp;
                else
                    Exp.R = temp;
            }

        }

        //演算子キーのどれかが押されたときの処理
        public void pushOp(Operator op) 
        {
            //右項を入力せずに連続して記号を入力→無効
            if(Exp.Op != null && Exp.R == null)
            {
                return;
            }

            //右項入力済みで記号を入力→計算して左辺へ代入した上で演算子を受付
            if (Exp.R != null) 
            {
                try
                {
                    Exp.eval();
                }
                catch (OverflowException ofe) 
                {
                    setError();
                    return;
                }
                catch (DivideByZeroException dze) 
                {
                    setError();
                    return;
                }
                ExpText = Exp.L.ToString();

                //「=」は結果の表示だけ　続けて計算はしない
                if (op == Operator.Equal)
                {
                    OpText = "";
                    return;
                }
            }

            //演算子を受付
            Exp.Op = op;            

            switch (op)
            {
                case Operator.Plus:
                    OpText = "+";
                    break;
                case Operator.Minus:
                    OpText = "-";
                    break;
                case Operator.Multi:
                    OpText = "×";
                    break;
                case Operator.Divide:
                    OpText = "÷";
                    break;
                default:
                    OpText = "E";
                    break;
            }
        }

        //.キーが押されたときの処理
        public void pushDot() 
        {
            string temp;

            if (Exp.Op == null) 
            {
                temp = Exp.L;                
            }
            else 
            {
                if (Exp.R == null) return;
                temp = Exp.R;
            }

            temp += ".";

            decimal result;

            if (decimal.TryParse(temp, out result))
            {
                ExpText = temp;

                if (Exp.Op == null)
                    Exp.L = temp;
                else
                    Exp.R = temp;
            }


        }

        public void pushBS()
        {
            if (Exp.Op == null) 
            {
                if(Exp.L != "0") Exp.L = Exp.L.Remove(Exp.L.Length-1);
                if (Exp.L == "") Exp.L = "0";
                ExpText = Exp.L;
            }
            else if (Exp.R == null) 
            {
                return;
            }
            else 
            {
                if (Exp.R != "0") Exp.R = Exp.R.Remove(Exp.R.Length - 1);
                if (Exp.R == "") Exp.R = "0";
                ExpText = Exp.R;
            }

        }

        public void pushCE() 
        {
            if (Exp.Op == null)
            {
                Exp.L = "0";
                ExpText = Exp.L;
            }
            else if (Exp.R == null)
            {
                return;
            }
            else
            {
                Exp.R = "0";
                ExpText = Exp.R;
            }
        }



    }
}

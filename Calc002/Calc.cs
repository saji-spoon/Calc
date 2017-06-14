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

    class Term 
    {
        public Term(string v) 
        {
            this.Value = v;
        }
        public string Value { get; set; }
    }

    class Expression 
    {
        
        //Op, Rはnullで未入力を表す
        public Term L { get; set; }
        public Operator? Op { get; set; }
        public Term R{ get; set; }      

        public Expression() 
        {
            //左項のみ値ありでスタート
            L = new Term("0");
        }

        //式を計算して左項に代入し、演算子と右項は空に
        public bool eval() 
        {
            if (Op == null || R == null) 
            {
                return false;
            }

            decimal dl = decimal.Parse(L.Value);
            decimal dr = decimal.Parse(R.Value);

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

            L.Value = dl.ToString();
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

        //電卓の計算状態を元に戻す Cキーを押したとき・初期化用
        public void init()
        {
            this.Exp = new Expression();
            this.IsError = false;
            this.ExpText = Exp.L.Value.ToString();
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

        //右項か左項、編集対象の方を返す
        //基本的に演算子が入力済みなら左項を、未入力なら右項を編集する
        //右項が編集対象かつ右項がnullのとき、isMakeRightTermがTrueなら右項に0を入力、falseならnullを返す
        private Term getTerm(bool isMakeRightTerm) 
        {
            if (Exp.Op == null)
            {
                return Exp.L;
            }
            else
            {
                if (Exp.R == null) 
                {
                    return isMakeRightTerm ? (Exp.R = new Term("0")) : null;
                }

                return Exp.R;
            }
        }

        //数字キーのいずれかが押されたとき→push()
        public void pushNum(int num) 
        {
            push(num.ToString());

            /*
            if (IsError) init();

            Term target = getTerm(true);

            string temp = target.Value;
             
            temp = (temp == "0") ? num.ToString() : temp + num.ToString();

            //入力した結果がParseできるかチェックしてからターゲットの項とテキストに反映する
            decimal result;
            if (decimal.TryParse(temp, out result)) 
            {
                target.Value = result.ToString();
                ExpText = target.Value;
            }
             * */
        }

        //.キーが押されたとき→push()
        public void pushDot()
        {
            push(".");
            /*
            Term target;

            target = getTerm(true);

            string temp = target.Value;

            temp += ".";

            decimal result;
            if (decimal.TryParse(temp, out result))
            {
                target.Value = temp;

                ExpText = target.Value;
            }*/


        }

        //数式スタックの編集対象の項に、strを入力する
        //追加した結果がdecimal.TryParseに失敗するなら反映しない
        public void push(string str) 
        {
            if (IsError) init();

            Term target = getTerm(true);

            string targetV = target.Value;

            switch (str) 
            {
                case ".":
                    targetV += str;
                    break;
                case "00":
                    targetV = (targetV == "0") ? targetV : targetV + str;
                    break;
                default: //単一の数字入力
                    targetV = (targetV == "0") ? str : targetV + str;
                    break;
            }

            decimal result;
            if (decimal.TryParse(targetV, out result))
            {
                target.Value = targetV;
                ExpText = target.Value;
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

            if (IsError) return;

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
                ExpText = Exp.L.Value;

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

        public void pushBS()
        {
            if (IsError) return;

            Term target;

            target = getTerm(false);

            if (target == null) return;

            if (target.Value != "0") target.Value = target.Value.Remove(target.Value.Length - 1);
            if (target.Value == "") target.Value = "0";
            ExpText = target.Value;

        }

        public void pushCE() 
        {
            if (IsError) return;

            Term target;

            target = getTerm(false);

            if (target == null) return;

            target.Value = "0";
            ExpText = target.Value;
        }



    }
}

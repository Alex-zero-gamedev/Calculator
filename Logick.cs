using DynamicExpresso;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Controls;
namespace Calculator
{
    class Logick
    {
        private TextBox t;
        public Logick(ref TextBox t)
        {
            this.t = t;
        }
        public void add(ref Button btn) { this.t.Text += btn.Content.ToString(); }
        public void addStr(string str) { this.t.Text += str; }

        public void updateSizeText()
        {
            if (t.Text.Length >= 36) { t.FontSize = 32; }
            else if (t.Text.Length >= 64) { t.FontSize = 12; }
            else t.FontSize = 72;
        }

        public void Calculate()
        {
            string text = this.t.Text;
            text = text.Replace("pi", Math.PI.ToString());
            text = text.Replace(",", ".");
            this.t.Text += $"={new DataTable().Compute(text, "")}";
        }
    }
}

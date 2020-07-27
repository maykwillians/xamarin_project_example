using System;
using System.Collections.Generic;
using System.Text;

namespace AppExample.Util
{
    public static class Validators
    {
        public static string ValidarCampoVazio(string text)
        {
            if(text.Equals("") || text == null)
            {
                return "Preencha este campo";
            }
            return "";
        }
    }
}
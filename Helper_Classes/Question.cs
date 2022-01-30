using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Classes
{
    public class Question
    {
        public Question(string content = "", bool response = false, string reasoning = "")
        {
            Content = content;
            Response = response;
            Reasoning = reasoning;
        }

        public void Clear_Response()
        {
            this.Reasoning = "";
            this.Response = false;
        }

        public string Content { get; set; }
        public bool Response { get; set; }
        public string Reasoning { get; set; } //Only to be filled in case Response is false



    }
}

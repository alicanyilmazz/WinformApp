using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARGASUPPLYAPP
{
    public class RichTextStatus
    {
        public RichTextStatus(RichTextBox textBox, bool textAdded, bool error, string errorMessage, bool secondTextAdded = false, bool secondError = false, string secondErrorMessage = "")
        {
            this.textBox = textBox;
            this.textAdded = textAdded;
            this.error = error;
            this.errorMessage = errorMessage;
            this.secondErrorMessage = secondErrorMessage;
            this.secondError = secondError;
        }

        public RichTextBox textBox { get; set; }
        public bool textAdded { get; set; }
        public bool secondTextAdded { get; set; }
        public bool error { get; set; }
        public bool secondError { get; set; }
        public string errorMessage { get; set; }
        public string secondErrorMessage { get; set; }

    }
}


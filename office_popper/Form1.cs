using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Word.ApplicationClass WordApp = new Word.ApplicationClass();
        private Excel.ApplicationClass ExcelApp = new Excel.ApplicationClass();

        private void button1_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
	        object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark*/
 
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            //Excel.Range oRng;

            //Start Excel and get Application object.
            oXL = new Excel.Application();
            oXL.Visible = true;

            //Get a new workbook.
            oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Outlook.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

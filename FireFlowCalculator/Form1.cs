using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFlowCalculator
{
    public partial class frmHydrantFlowCalc : Form
    {
        public frmHydrantFlowCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
    int staticValue = 75;
	int residual = 40;
	double diameter = 2.5;
	double pitot;
	int gpm;
	double availableFlow;
	double coefficient = .9;
    double mp;
	
	if (diameter > 2.5){
        coefficient = .75;
    }

      if (staticValue >= 40){
          mp = 20;
      }

      if (staticValue < 40){
          mp = staticValue/2;
      }
	
	double a = 29.83;

	double b = Math.Pow(diameter,2);

	double c = Math.Sqrt(pitot);

	var f = Math.Round((a * coefficient * b * c));

	
	
	{
		pitot = Math.Pow((staticValue-mp),.54);
		var x = Math.Pow((staticValue-residual),.54);
		availableFlow = ((pitot / x) * f);
		};

	//document.calc.at20.value = Math.round(fe);

	//{
		//var tt = Math.pow((ss-20),.54);
		//var bb = Math.pow((ss-rr),.54);
		//var mf = ((tt / bb) * f);
		//};
	//document.calc.mcap.value = Math.round(mf);
      //  }


	


        }
    }
}

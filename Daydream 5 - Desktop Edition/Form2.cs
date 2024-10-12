using Daydream_5___Desktop_Edition.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daydream_5___Desktop_Edition
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            LoadHelpPage();
        }

        public async void LoadHelpPage()
        {

            string html = @"
                <!DOCTYPE html>
                    <html>
	                    <body>
		                    <div>
			                    <h2>Daydream 5 - Desktop Edition: Help</h2>
								<h3>Requirements</h3>
			                    <ul>
									<li>Download Adobe Acrobat Reader if you want the .pdf to open automatically to print settings.</li>
								</ul>
								
								<h3>Introduction</h3>
								<p>The application starts and runs automatically, selecting 252 unique picks from the 5/36 lotterycodex. This results in each pick being used 35 times.
								   Think of it as a sort of net being cast into the ocean of possible picks in the hopes of catching that elusive prize.
								   The numbers 1-36 are divided into four groups based on two criteria: whether the number is low or high and whether it is even or odd.
								   Within these groups, the numbers are randomly shuffled. They are then divided into seven equal groupings of 5 with one remainder.
								   Each 5 number pick is stored, then the each group is rotated. The first group rotates the top number to the bottom while moving the rest up.
								   The second group does that twice. The third group does three times and the fourth group five. After nine wheels, the fourth group becomes the first,
								   the first becomes the second and so on. This goes on until each group has been in each role, resulting in 252 unique picks that are partially wheeled
								   in a stratified way. I love the symmetry of Florida's Fantasy 5 game for this reason.</p><br>
		                    </div>
							
							<div>
								<h2>Get picks</h2>
								
								<h3>Pick limit</h3>
								<p>While Daydream 5 does the work for you automatically, customization is available. You can choose how many picks you would like rather than relying
								   on the default of 252. Use *Pick limit* to change then number to anything between 1 and 252 inclusive.</p><br>
								   
								<h3>Sort picks in numerical order</h3>
								<p>It is easier to determine whether the picks are truly unique when they are sorted. That is why it is the default behavior.
								   However, if you would like to generate a random pick list, then you can with the help of unchecking the *Sort picks in numerical order* checkbox.
								   The rationale for this was to randomly spread the picks over playslips so that if you preferred to play only a portion of the set, then you may. </p><br>
								   
								<h3>Get picks button</h3>
								<p>After you have the desired *Pick limit* and *Sort picks in numerical order* settings, press the *Get picks* button to receive a new pick list.
								   You will only notice a change in the number count when you change the pick limit to something other than 252.</p><br>
							</div>
							
							<div>
								<h2>Print picks</h2>
								
								<h3>Draw time</h3>
								<ul>
									<li>*Nearest draw time* leaves the draw time portion of the playslip blank.</li>
									<li>*Midday* selects the midday drawing.</li>
									<li>*Evening* selects the evening drawing.</li>
									<li>*Both* selects the next two drawings.</li>
								</ul><br>
								
								<h3>EZmatch</h3>
								<p>If you would like to play EZmatch, selecting this checkbox will pick an EZmatch for <b>every</b> pick in the pick list.</p><br>
								
								<h3>Picks per playslip</h3>
								<p>Making this less than 10 will place a limit on the number of picks to put on each playslip. This, of course requires more playslips.</p><br>
								
								<h3>Select a folder to save files</h3>
								<p>Press the *Select Folder* button to change the location for saving the .pdf and .txt files generated when you *Print picks*.</p><br>
								
								<h3>Print picks</h3>
								<p>Press the *Print picks* button to generate the .pdf and accompanying .txt files. If you have Adobe Acrobat installed, it will launch the print dialog.
								   You must print the playslips *Actual Size* in order to align the picks correctly. You may need to make this selection.
								   The .txt file uses the same filename to associate it with the .pdf. It contains information about what variables were used to generate the .pdf file.</p><br>
							</div>
	                    </body>
                    </html>";

                await webView2.EnsureCoreWebView2Async();
                this.webView2.NavigateToString(html); 
        }
    }
}

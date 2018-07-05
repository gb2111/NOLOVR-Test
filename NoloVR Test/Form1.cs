using NOLO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoloVR_Test
{
	public partial class Form1 : Form
	{
		private static bool statusConnected = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			funcCallback connectCallback = (context) => { connect_Nolo(context); };
			funcCallback disconnectCallback = (context) => { disconnect_Nolo(context); };
			noloDataNotifyFunc dataCallback = (noloData, context) => { noloDataNotify(noloData, context); };

			NOLO.NOLOClient_V2_API.registerDisConnectCallBack(disconnectCallback, IntPtr.Zero);
			NOLO.NOLOClient_V2_API.registerConnectSuccessCallBack(connectCallback, IntPtr.Zero);
			NOLO.NOLOClient_V2_API.registerNoloDataNotifyCallBack(dataCallback, IntPtr.Zero);

			NOLO.NOLOClient_V2_API.search_Nolo_Device();
		}

		private static void connect_Nolo(IntPtr context)
		{
			statusConnected = true;
		}

		private static void disconnect_Nolo(IntPtr context)
		{
			statusConnected = false;
		}

		private static void noloDataNotify(NOLO.NoloData noloData, IntPtr context)
		{
			//updateFPS.Update();
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			string text = statusConnected ? "Connected" : "Not connected";

			if (statusConnected)
			{
				NOLO.Controller leftController = NOLOClient_V2_API.get_Nolo_LeftControllerData();
				NOLO.Controller rightController = NOLOClient_V2_API.get_Nolo_RightControllerData();

				text += string.Format("\nLeft touchpad: {0:N2},{1:N2}", leftController.ControllerTouchAxis.x, leftController.ControllerTouchAxis.y);
				text += string.Format("\nRight touchpad: {0:N2},{1:N2}", rightController.ControllerTouchAxis.x, rightController.ControllerTouchAxis.y);
			}

			labelStatus.Text = text;
		}
	}
}

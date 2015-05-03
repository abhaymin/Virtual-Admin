using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class RServer
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			TcpServerChannel ch=new TcpServerChannel(9090);
			ChannelServices.RegisterChannel(ch,false);

			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(RemoteObject.RemoteProcesses),"RemoteObject.RemoteProcesses",
				WellKnownObjectMode.SingleCall);
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(RemoteObject.RemoteServices),"RemoteObject.RemoteServices",
				WellKnownObjectMode.SingleCall);

			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(RemoteObject.Eves),"RemoteObject.Eves",
				WellKnownObjectMode.SingleCall);
			
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof(RemoteObject.RemoteDesktop),"RemoteObject.RemoteDesktop",
				WellKnownObjectMode.SingleCall);

			Console.WriteLine("Server Initialized.");
			Console.ReadLine();
		}
	}
}

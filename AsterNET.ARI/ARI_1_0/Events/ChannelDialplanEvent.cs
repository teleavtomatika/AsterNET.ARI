﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 22/04/2015 09:45:42
*/

namespace AsterNET.ARI.Models
{
	/// <summary>
	///     Channel changed location in the dialplan.
	/// </summary>
	public class ChannelDialplanEvent : Event
	{
		/// <summary>
		/// </summary>
		/// <summary>
		///     The channel that changed dialplan location.
		/// </summary>
		public Channel Channel { get; set; }

		/// <summary>
		///     The application about to be executed.
		/// </summary>
		public string Dialplan_app { get; set; }

		/// <summary>
		///     The data to be passed to the application.
		/// </summary>
		public string Dialplan_app_data { get; set; }
	}
}
﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 22/04/2015 09:45:42
*/

using System.Collections.Generic;
using AsterNET.ARI.Models;

namespace AsterNET.ARI.Actions
{
	public interface IEventsActions
	{
		/// <summary>
		///     WebSocket connection for events..
		/// </summary>
		/// <param name="app">Applications to subscribe to.</param>
		Message EventWebsocket(string app);

		/// <summary>
		///     Generate a user event..
		/// </summary>
		/// <param name="eventName">Event name</param>
		/// <param name="application">The name of the application that will receive this event</param>
		/// <param name="source">
		///     URI for event source (channel:{channelId}, bridge:{bridgeId}, endpoint:{tech}/{resource},
		///     deviceState:{deviceName}
		/// </param>
		/// <param name="variables">
		///     The "variables" key in the body object holds custom key/value pairs to add to the user event.
		///     Ex. { "variables": { "key": "value" } }
		/// </param>
		void UserEvent(string eventName, string application, string source = null,
			List<KeyValuePair<string, string>> variables = null);
	}
}
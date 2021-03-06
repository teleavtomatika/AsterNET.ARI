﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 22/04/2015 09:45:42
*/

using System.Collections.Generic;
using AsterNET.ARI.Middleware;
using AsterNET.ARI.Models;

namespace AsterNET.ARI.Actions
{
	public class DeviceStatesActions : ARIBaseAction, IDeviceStatesActions
	{
		public DeviceStatesActions(IActionConsumer consumer)
			: base(consumer)
		{
		}

		/// <summary>
		///     List all ARI controlled device states..
		/// </summary>
		public List<DeviceState> List()
		{
			var path = "/deviceStates";
			var request = GetNewRequest(path, HttpMethod.GET);

			var response = Execute<List<DeviceState>>(request);

			if ((int) response.StatusCode >= 200 && (int) response.StatusCode < 300)
				return response.Data;

			switch ((int) response.StatusCode)
			{
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code {0} from ARI.", response.StatusCode));
			}
		}

		/// <summary>
		///     Retrieve the current state of a device..
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		public DeviceState Get(string deviceName)
		{
			var path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.GET);
			if (deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);

			var response = Execute<DeviceState>(request);

			if ((int) response.StatusCode >= 200 && (int) response.StatusCode < 300)
				return response.Data;

			switch ((int) response.StatusCode)
			{
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code {0} from ARI.", response.StatusCode));
			}
		}

		/// <summary>
		///     Change the state of a device controlled by ARI. (Note - implicitly creates the device state)..
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		/// <param name="deviceState">Device state value</param>
		public void Update(string deviceName, string deviceState)
		{
			var path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.PUT);
			if (deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);
			if (deviceState != null)
				request.AddParameter("deviceState", deviceState, ParameterType.QueryString);
			var response = Execute(request);
		}

		/// <summary>
		///     Destroy a device-state controlled by ARI..
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		public void Delete(string deviceName)
		{
			var path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.DELETE);
			if (deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);
			var response = Execute(request);
		}
	}
}
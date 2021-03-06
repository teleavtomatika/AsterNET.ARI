﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 22/04/2015 09:45:42
*/

using AsterNET.ARI.Middleware;
using AsterNET.ARI.Models;

namespace AsterNET.ARI.Actions
{
	public class AsteriskActions : ARIBaseAction, IAsteriskActions
	{
		public AsteriskActions(IActionConsumer consumer)
			: base(consumer)
		{
		}

		/// <summary>
		///     Gets Asterisk system information..
		/// </summary>
		/// <param name="only">Filter information returned</param>
		public AsteriskInfo GetInfo(string only = null)
		{
			var path = "/asterisk/info";
			var request = GetNewRequest(path, HttpMethod.GET);
			if (only != null)
				request.AddParameter("only", only, ParameterType.QueryString);

			var response = Execute<AsteriskInfo>(request);

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
		///     Get the value of a global variable..
		/// </summary>
		/// <param name="variable">The variable to get</param>
		public Variable GetGlobalVar(string variable)
		{
			var path = "/asterisk/variable";
			var request = GetNewRequest(path, HttpMethod.GET);
			if (variable != null)
				request.AddParameter("variable", variable, ParameterType.QueryString);

			var response = Execute<Variable>(request);

			if ((int) response.StatusCode >= 200 && (int) response.StatusCode < 300)
				return response.Data;

			switch ((int) response.StatusCode)
			{
				case 400:
					throw new AriException("Missing variable parameter.");
					break;
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code {0} from ARI.", response.StatusCode));
			}
		}

		/// <summary>
		///     Set the value of a global variable..
		/// </summary>
		/// <param name="variable">The variable to set</param>
		/// <param name="value">The value to set the variable to</param>
		public void SetGlobalVar(string variable, string value = null)
		{
			var path = "/asterisk/variable";
			var request = GetNewRequest(path, HttpMethod.POST);
			if (variable != null)
				request.AddParameter("variable", variable, ParameterType.QueryString);
			if (value != null)
				request.AddParameter("value", value, ParameterType.QueryString);
			var response = Execute(request);
		}
	}
}
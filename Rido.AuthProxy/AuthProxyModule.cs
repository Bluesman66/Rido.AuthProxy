using System;
using System.Net;

namespace Rido.AuthProxy
{
	public class AuthProxyModule : IWebProxy
	{
		private ICredentials _crendential = new NetworkCredential("user", "password");

		public ICredentials Credentials
		{
			get
			{
				return _crendential;
			}
			set
			{
				_crendential = value;
			}
		}

		public Uri GetProxy(Uri destination)
		{
			return new Uri("http://addr:port", UriKind.Absolute);
		}

		public bool IsBypassed(Uri host)
		{
			return host.IsLoopback;
		}

	}
}
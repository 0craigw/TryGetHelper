using System;

namespace LIC.Services.Reproduction.WebApi.IntegrationTests.Helpers
{
	/// <summary>
	/// Implements TryGet method for any delegate
	/// </summary>
	public static class TryGetHelper
	{
		public static bool TryGet<T>(Func<T> function, out T result) 
		{
			try
			{
				result = function();
			}
			catch (Exception)
			{
				result = default(T);
				return false;
			}
			return true;
		}
	}
}
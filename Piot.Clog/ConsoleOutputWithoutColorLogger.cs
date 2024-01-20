/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Linq;

namespace Piot.Clog
{
	public sealed class ConsoleOutputWithoutColorLogger : ILogTarget
	{
		public void Log(LogLevel level, string prefix, string message, object[] args)
		{
			var strings = args.Select(Utils.ArgumentValueToString);
			var values = args.Length > 0 ? $"({string.Join(", ", strings)})" : "";

			var line = $"{level,8} : [{prefix}] {message} {values}";
			Console.WriteLine(line);
		}
	}
}
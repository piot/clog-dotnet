/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace Piot.Clog
{
    public interface ILog
    {
        public void DebugLowLevel(string s);
        public void DebugLowLevel<T>(string s, T arg) where T : notnull;
        public void DebugLowLevel<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void DebugLowLevel<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void DebugLowLevel(string s, params object[] args);


        public void Debug(string s);
        public void Debug<T>(string s, T arg) where T : notnull;
        public void Debug<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void Debug<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void Debug(string s, params object[] args);


        public void Info(string s);
        public void Info<T>(string s, T arg) where T : notnull;
        public void Info<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void Info<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void Info(string s, params object[] args);


        public void Notice(string s);
        public void Notice<T>(string s, T arg) where T : notnull;
        public void Notice<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void Notice<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void Notice(string s, params object[] args);


        public void Warn(string s);
        public void Warn<T>(string s, T arg) where T : notnull;
        public void Warn<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void Warn<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void Warn(string s, params object[] args);

        public void Error(string s);
        public void Error<T>(string s, T arg) where T : notnull;
        public void Error<T0, T1>(string s, T0 arg0, T1 arg1) where T0 : notnull where T1 : notnull;

        public void Error<T0, T1, T2>(string s, T0 arg0, T1 arg1, T2 arg2)
            where T0 : notnull where T1 : notnull where T2 : notnull;

        public void Error(string s, params object[] args);

        public ILog SubLog(string debugPrefix);
    }
}
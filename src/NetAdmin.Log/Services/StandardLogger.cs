﻿namespace NetAdmin.Log
{
    internal class StandardLogger : LoggerBase, ILogger
    {
        public void Log(string message)
        {
            var log = new Log();

            throw new System.NotImplementedException();
        }

        public void Info(string message)
        {
            var info = new Info();

            throw new System.NotImplementedException();
        }

        public void Warning(string message)
        {
            var warning = new Warning();

            throw new System.NotImplementedException();
        }

        public void Error(string message)
        {
            var error = new Error();

            throw new System.NotImplementedException();
        }
    }
}
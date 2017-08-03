using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace log4net
{
    /// <summary>
    ///     Log(based on log4net)
    /// </summary>
    public static class Log
    {
        #region Cache
        /// <summary>
        ///     the logger cache.
        /// </summary>
        private static Dictionary<Type, ILog> Cache = new Dictionary<Type, ILog>();

        /// <summary>
        ///     get logger from the cache.
        /// </summary>
        public static ILog GetLog(Type type = null)
        {
            if (type == null) type = GetCaller(3);

            if (Cache.ContainsKey(type)) return Cache[type];
            return Cache[type] = LogManager.GetLogger(type);
        }

        /// <summary>
        ///     get caller.
        /// </summary>
        private static Type GetCaller(int n = 2)
        {
            var frame = new StackTrace().GetFrame(n);
            var method = frame.GetMethod();
            return method.ReflectedType;
        }
        #endregion

        #region ILog
        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Debug(object message)
        {
            var log = GetLog();
            log.Debug(message);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Debug(object message, Exception exception)
        {
            var log = GetLog();
            log.Debug(message, exception);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            var log = GetLog();
            log.DebugFormat(provider, format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void DebugFormat(string format, params object[] args)
        {
            var log = GetLog();
            log.DebugFormat(format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void DebugFormat(string format, object arg0)
        {
            var log = GetLog();
            log.DebugFormat(format, arg0);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void DebugFormat(string format, object arg0, object arg1)
        {
            var log = GetLog();
            log.DebugFormat(format, arg0, arg1);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            var log = GetLog();
            log.DebugFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Error(object message)
        {
            var log = GetLog();
            log.Error(message);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Error(object message, Exception exception)
        {
            var log = GetLog();
            log.Error(message, exception);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            var log = GetLog();
            log.ErrorFormat(provider, format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void ErrorFormat(string format, params object[] args)
        {
            var log = GetLog();
            log.ErrorFormat(format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void ErrorFormat(string format, object arg0)
        {
            var log = GetLog();
            log.ErrorFormat(format, arg0);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void ErrorFormat(string format, object arg0, object arg1)
        {
            var log = GetLog();
            log.ErrorFormat(format, arg0, arg1);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            var log = GetLog();
            log.ErrorFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Fatal(object message)
        {
            var log = GetLog();
            log.Fatal(message);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Fatal(object message, Exception exception)
        {
            var log = GetLog();
            log.Fatal(message, exception);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            var log = GetLog();
            log.FatalFormat(provider, format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void FatalFormat(string format, params object[] args)
        {
            var log = GetLog();
            log.FatalFormat(format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void FatalFormat(string format, object arg0)
        {
            var log = GetLog();
            log.FatalFormat(format, arg0);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void FatalFormat(string format, object arg0, object arg1)
        {
            var log = GetLog();
            log.FatalFormat(format, arg0, arg1);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            var log = GetLog();
            log.FatalFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Info(object message)
        {
            var log = GetLog();
            log.Info(message);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Info(object message, Exception exception)
        {
            var log = GetLog();
            log.Info(message, exception);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            var log = GetLog();
            log.InfoFormat(provider, format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void InfoFormat(string format, params object[] args)
        {
            var log = GetLog();
            log.InfoFormat(format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void InfoFormat(string format, object arg0)
        {
            var log = GetLog();
            log.InfoFormat(format, arg0);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void InfoFormat(string format, object arg0, object arg1)
        {
            var log = GetLog();
            log.InfoFormat(format, arg0, arg1);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            var log = GetLog();
            log.InfoFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Warn(object message)
        {
            var log = GetLog();
            log.Warn(message);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void Warn(object message, Exception exception)
        {
            var log = GetLog();
            log.Warn(message, exception);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            var log = GetLog();
            log.WarnFormat(provider, format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void WarnFormat(string format, params object[] args)
        {
            var log = GetLog();
            log.WarnFormat(format, args);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void WarnFormat(string format, object arg0)
        {
            var log = GetLog();
            log.WarnFormat(format, arg0);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void WarnFormat(string format, object arg0, object arg1)
        {
            var log = GetLog();
            log.WarnFormat(format, arg0, arg1);
        }

        /// <summary>
        ///     the wrapper of log4net.
        /// </summary>
        public static void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            var log = GetLog();
            log.WarnFormat(format, arg0, arg1, arg2);
        }
        #endregion
    }
}

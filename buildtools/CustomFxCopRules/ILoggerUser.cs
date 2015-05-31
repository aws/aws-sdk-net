using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    public interface ILogger
    {

    }

    public class LoggerInstance : ILogger
    {
 
    }

    public class LoggerInstanceInstance : LoggerInstance
    {

    }
}

namespace CustomFxCopRules
{
    public class ILoggerUser
    {
        public static ILogger Logger1;
        public static ILogger Logger2 { get; set; }
        public static LoggerInstance Logger3;
        public static LoggerInstance Logger4;
        public static LoggerInstanceInstance Logger5 { get; set; }
        public static LoggerInstanceInstance Logger6 { get; set; }

        private static ILogger Logger7;
        private static ILogger Logger8 { get; set; }
        private static LoggerInstance Logger9;
        private static LoggerInstance Logger10;
        private static LoggerInstanceInstance Logger11 { get; set; }
        private static LoggerInstanceInstance Logger12 { get; set; }

        public static ILogger Logger13
        {
            get
            {
                return null;
            }
        }
        public static ILogger Logger14
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        private static ILogger Logger15
        {
            get
            {
                return null;
            }
        }
        private static ILogger Logger16
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

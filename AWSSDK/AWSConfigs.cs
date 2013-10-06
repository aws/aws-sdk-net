/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;

namespace Amazon
{
    /// <summary>
    /// Configuration options that apply to the entire SDK.
    /// </summary>
    public static class AWSConfigs
    {
        internal static event PropertyChangedEventHandler PropertyChanged;

        #region Logging

        /// <summary>
        /// Key for the Logging property.
        /// <seealso cref="Amazon.AWSConfigs.Logging"/>
        /// </summary>
        public const string LoggingKey = "AWSLogging";

        /// <summary>
        /// Configures how the SDK should log events, if at all.
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWSLogging" value="log4net"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static LoggingOptions Logging
        {
            get { return _logging; }
            set
            {
                _logging = value;
                OnPropertyChanged("Logging");
            }
        }

        private static char[] validSeparators = new char[] { ' ', ',' };
        private static LoggingOptions _logging = GetLoggingSetting();
        private static LoggingOptions GetLoggingSetting()
        {
            string value = GetConfig(LoggingKey);
            if (string.IsNullOrEmpty(value))
                return LoggingOptions.None;

            string[] settings = value.Split(validSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (settings == null || settings.Length == 0)
                return LoggingOptions.None;

            LoggingOptions totalSetting = LoggingOptions.None;
            foreach (string setting in settings)
            {
                LoggingOptions l = ParseEnum<LoggingOptions>(setting);
                totalSetting |= l;
            }
            return totalSetting;
        }

        #endregion

        #region Response Logging

        /// <summary>
        /// Key for the ResponseLogging property.
        /// 
        /// <seealso cref="Amazon.AWSConfigs.ResponseLogging"/>
        /// </summary>
        public const string ResponseLoggingKey = "AWSResponseLogging";

        /// <summary>
        /// Configures when the SDK should log service responses.
        /// Changes to this setting will take effect immediately.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWSResponseLogging" value="OnError"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static ResponseLoggingOption ResponseLogging
        {
            get { return _responseLogging; }
            set { _responseLogging = value; }
        }

        private static ResponseLoggingOption _responseLogging = GetConfigEnum<ResponseLoggingOption>(ResponseLoggingKey);

        #endregion

        #region Log Metrics

        /// <summary>
        /// Key for the LogMetrics property.
        /// <seealso cref="Amazon.AWSConfigs.LogMetrics"/>
        /// </summary>
        public const string LogMetricsKey = "AWSLogMetrics";

        /// <summary>
        /// Configures if the SDK should log performance metrics.
        /// This setting configures the default LogMetrics property for all clients/configs.
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWSLogMetrics" value="true"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static bool LogMetrics
        {
            get { return _logMetrics; }
            set { _logMetrics = value; }
        }

        private static bool _logMetrics = GetConfigBool(LogMetricsKey);

        #endregion

        #region Private general methods

        private static void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(null, new PropertyChangedEventArgs(name));
            }
        }
        private static string GetConfig(string name)
        {
            NameValueCollection appConfig = ConfigurationManager.AppSettings;
            if (appConfig == null)
                return null;
            string value = appConfig[name];
            return value;
        }
        private static bool GetConfigBool(string name)
        {
            string value = GetConfig(name);
            bool result;
            if (bool.TryParse(value, out result))
                return result;
            return default(bool);
        }
        private static T GetConfigEnum<T>(string name)
        {
            Type type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException(string.Format("Type {0} must be enum", type.FullName));

            string value = GetConfig(name);
            if (string.IsNullOrEmpty(value))
                return default(T);
            T result = ParseEnum<T>(value);
            return result;
        }
        private static T ParseEnum<T>(string value)
        {
            T t;
            if (TryParseEnum<T>(value, out t))
                return t;
            Type type = typeof(T);
            string messageFormat = "Unable to parse value {0} as enum of type {1}. Valid values are: {2}";
            string enumNames = string.Join(", ", Enum.GetNames(type));
            throw new InvalidEnumArgumentException(string.Format(messageFormat, value, type.FullName, enumNames));
        }
        private static bool TryParseEnum<T>(string value, out T result)
        {
            result = default(T);

            if (string.IsNullOrEmpty(value))
                return false;

            try
            {
                T t = (T)Enum.Parse(typeof(T), value, true);
                result = t;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }

    /// <summary>
    /// Logging options.
    /// Can be combined to enable multiple loggers.
    /// </summary>
    [Flags]
    public enum LoggingOptions
    {
        /// <summary>
        /// No logging
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Log using log4net
        /// </summary>
        Log4Net = 1,
        
        /// <summary>
        /// Log using System.Diagnostics
        /// </summary>
        SystemDiagnostics = 2
    }

    /// <summary>
    /// Response logging option.
    /// </summary>
    public enum ResponseLoggingOption
    {
        /// <summary>
        /// Never log service response
        /// </summary>
        Never = 0,

        /// <summary>
        /// Only log service response when there's an error
        /// </summary>
        OnError = 1,

        /// <summary>
        /// Always log service response
        /// </summary>
        Always = 2
    }
}

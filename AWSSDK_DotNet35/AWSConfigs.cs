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


#if !WIN_RT
using System.Configuration;
#endif

using Amazon.Util;
using System.Globalization;

namespace Amazon
{
    /// <summary>
    /// Configuration options that apply to the entire SDK.
    /// </summary>
    public static partial class AWSConfigs
    {
        internal static event PropertyChangedEventHandler PropertyChanged;

        #region Region

        /// <summary>
        /// Key for the AWSRegion property.
        /// <seealso cref="Amazon.AWSConfigs.AWSRegion"/>
        /// </summary>
        public const string AWSRegionKey = "AWSRegion";

        /// <summary>
        /// Configures the default AWS region for clients which have not explicitly specified a region.
        /// Changes to this setting will only take effect for newly constructed instances of AWS clients.
        /// 
        /// This setting can be configured through the App.config. For example:
        /// <code>
        /// &lt;appSettings>
        ///   &lt;add key="AWSRegion" value="us-west-2"/>
        /// &lt;appSettings>
        /// </code>
        /// </summary>
        public static string AWSRegion
        {
            get { return _awsRegion; }
            set { _awsRegion = value; }
        }

        private static string _awsRegion = GetConfig(AWSRegionKey);

        #endregion

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

        #region Endpoint Configuration

        /// <summary>
        /// Key for the EndpointDefinition property.
        /// <seealso cref="Amazon.AWSConfigs.LogMetrics"/>
        /// </summary>
        public const string EndpointDefinitionKey = "AWSEndpointDefinition";

        /// <summary>
        /// Configures if the SDK should use a custom configuration file that defines the regions and endpoints.
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWSEndpointDefinition" value="c:\config\endpoints.xml"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static string EndpointDefinition
        {
            get { return _endpointDefinition; }
            set { _endpointDefinition = value; }
        }

        private static string _endpointDefinition = GetConfig(EndpointDefinitionKey);

        #endregion

        #region DynamoDBContext TableNamePrefix

        /// <summary>
        /// Key for the DynamoDBContextTableNamePrefix property.
        /// <seealso cref="Amazon.AWSConfigs.DynamoDBContextTableNamePrefix"/>
        /// </summary>
        public const string DynamoDBContextTableNamePrefixKey = "AWS.DynamoDBContext.TableNamePrefix";
        
        /// <summary>
        /// Configures the default TableNamePrefix that the DynamoDBContext will use if
        /// not manually configured.
        /// Changes to this setting will only take effect in newly-constructed instances of
        /// DynamoDBContextConfig and DynamoDBContext.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWS.DynamoDBContext.TableNamePrefix" value="Test-"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static string DynamoDBContextTableNamePrefix
        {
            get { return _dynamoDBContextTableNamePrefix; }
            set { _dynamoDBContextTableNamePrefix = value; }
        }

        private static string _dynamoDBContextTableNamePrefix = GetConfig(DynamoDBContextTableNamePrefixKey);

        #endregion

        #region S3 SignatureV4

        /// <summary>
        /// Key for the S3UseSignatureVersion4 property.
        /// <seealso cref="Amazon.AWSConfigs.S3UseSignatureVersion4"/>
        /// </summary>
        public const string S3UseSignatureVersion4Key = "AWS.S3.UseSignatureVersion4";

        /// <summary>
        /// Configures if the S3 client should use Signature Version 4 signing with requests.
        /// By default, this setting is false, though Signature Version 4 may be used by default
        /// in some cases or with some regions. When the setting is true, Signature Version 4
        /// will be used for all requests.
        /// 
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWS.S3.UseSignatureVersion4" value="true"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static bool S3UseSignatureVersion4
        {
            get { return _s3UseSignatureVersion4; }
            set { _s3UseSignatureVersion4 = value; }
        }

        private static bool _s3UseSignatureVersion4 = GetConfigBool(S3UseSignatureVersion4Key);

        #endregion

        #region EC2 SignatureV4

        /// <summary>
        /// Key for the EC2UseSignatureVersion4 property.
        /// <seealso cref="Amazon.AWSConfigs.EC2UseSignatureVersion4"/>
        /// </summary>
        public const string EC2UseSignatureVersion4Key = "AWS.EC2.UseSignatureVersion4";

        /// <summary>
        /// Configures if the EC2 client should use Signature Version 4 signing with requests.
        /// By default, this setting is false, though Signature Version 4 may be used by default
        /// in some cases or with some regions. When the setting is true, Signature Version 4
        /// will be used for all requests.
        /// 
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// 
        /// The setting can be configured through App.config, for example:
        /// <code>
        /// &lt;appSettings&gt;
        ///   &lt;add key="AWS.EC2.UseSignatureVersion4" value="true"/&gt;
        /// &lt;/appSettings&gt;
        /// </code>
        /// </summary>
        public static bool EC2UseSignatureVersion4
        {
            get { return _ec2UseSignatureVersion4; }
            set { _ec2UseSignatureVersion4 = value; }
        }

        private static bool _ec2UseSignatureVersion4 = GetConfigBool(EC2UseSignatureVersion4Key);

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
            var type = TypeFactory.GetTypeInfo(typeof(T));
            if (!type.IsEnum) throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Type {0} must be enum", type.FullName));

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
            throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, messageFormat, value, type.FullName, enumNames));
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
            catch (ArgumentException)
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

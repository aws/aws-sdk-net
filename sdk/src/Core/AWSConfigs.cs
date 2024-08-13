/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.ComponentModel;
using System.Globalization;

using Amazon.Util;
using Amazon.Util.Internal;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Telemetry;

namespace Amazon
{
    /// <summary>
    /// Configuration options that apply to the entire SDK.
    /// 
    /// These settings can be configured through app.config or web.config.
    /// Below is a full sample configuration that illustrates all the possible options.
    /// <code>
    /// &lt;configSections&gt;
    ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
    /// &lt;/configSections&gt;
    /// &lt;aws region="us-west-2"&gt;
    ///   &lt;logging logTo="Log4Net, SystemDiagnostics" logResponses="Always" logMetrics="true" /&gt;
    ///   &lt;s3 useSignatureVersion4="true" /&gt;
    ///   &lt;proxy host="localhost" port="8888" username="1" password="1" /&gt;
    ///   
    ///   &lt;dynamoDB&gt;
    ///     &lt;dynamoDBContext tableNamePrefix="Prod-" metadataCachingMode="Default" disableFetchingTableMetadata="false" retrieveDateTimeInUtc="false"&gt;
    /// 
    ///       &lt;tableAliases&gt;
    ///         &lt;alias fromTable="FakeTable" toTable="People" /&gt;
    ///         &lt;alias fromTable="Persons" toTable="People" /&gt;
    ///       &lt;/tableAliases&gt;
    /// 
    ///       &lt;mappings&gt;
    ///         &lt;map type="Sample.Tests.Author, SampleDLL" targetTable="People" /&gt;
    ///         &lt;map type="Sample.Tests.Editor, SampleDLL" targetTable="People"&gt;
    ///           &lt;property name="FullName" attribute="Name" /&gt;
    ///           &lt;property name="EmployeeId" attribute="Id" /&gt;
    ///           &lt;property name="ComplexData" converter="Sample.Tests.ComplexDataConverter, SampleDLL" /&gt;
    ///           &lt;property name="Version" version="true" /&gt;
    ///           &lt;property name="Password" ignore="true" /&gt;
    ///         &lt;/map&gt;
    ///       &lt;/mappings&gt;
    /// 
    ///     &lt;/dynamoDBContext&gt;
    ///   &lt;/dynamoDB&gt;
    /// &lt;/aws&gt;
    /// </code>
    /// </summary>
    public static partial class AWSConfigs
    {
        #region Private static members

        private static char[] validSeparators = new char[] { ' ', ',' };

        // Tests can override this DateTime source.
        internal static Func<DateTime> utcNowSource = GetUtcNow;

        // Deprecated configs
        internal static string _awsRegion = GetConfig(AWSRegionKey);
        internal static string _awsProfileName = GetConfig(AWSProfileNameKey);
        internal static string _awsAccountsLocation = GetConfig(AWSProfilesLocationKey);
        internal static bool _useSdkCache = GetConfigBool(UseSdkCacheKey, defaultValue: true);
        internal static bool _initializeCollections = GetConfigBool(InitializeCollectionsKey, defaultValue: false);
        // for reading from awsconfigs.xml
        private static object _lock = new object();
        private static List<string> standardConfigs = new List<string>() { "region", "logging", "correctForClockSkew" };
        private static TelemetryProvider _telemetryProvider = new DefaultTelemetryProvider();

#pragma warning disable 414
        private static bool configPresent = true;
#pragma warning restore 414

        // New config section
        private static RootConfig _rootConfig = new RootConfig();
        #endregion

        #region Clock Skew

        /// <summary>
        /// Manual offset to apply to client clock.  This is a global setting that overrides 
        /// ClockOffset value calculated for all service endpoints.
        /// </summary>
        public static TimeSpan? ManualClockCorrection
        {
            get
            {
                return Runtime.CorrectClockSkew.GlobalClockCorrection;
            }
            set
            {
                Runtime.CorrectClockSkew.GlobalClockCorrection = value;
            }
        }

        /// <summary>
        /// Determines if the SDK should correct for client clock skew
        /// by determining the correct server time and reissuing the
        /// request with the correct time.
        /// Default value of this field is True.
        /// Ignored if <seealso cref="ManualClockCorrection"/> is set.
        /// </summary>
        public static bool CorrectForClockSkew
        {
            get { return _rootConfig.CorrectForClockSkew; }
            set { _rootConfig.CorrectForClockSkew = value; }
        }
        #endregion

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
        /// &lt;configSections&gt;
        ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
        /// &lt;/configSections&gt;
        /// &lt;aws region="us-west-2" /&gt;
        /// </code>
        /// </summary>
        public static string AWSRegion
        {
            get { return _rootConfig.Region; }
            set { _rootConfig.Region = value; }
        }

        #endregion

        #region Account Name

        /// <summary>
        /// Key for the AWSProfileName property.
        /// <seealso cref="Amazon.AWSConfigs.AWSProfileName"/>
        /// </summary>
        public const string AWSProfileNameKey = "AWSProfileName";

        /// <summary>
        /// Profile name for stored AWS credentials that will be used to make service calls.
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// <para>
        /// To reference the account from an application's App.config or Web.config use the AWSProfileName setting.
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="development"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </para>
        /// </summary>
        public static string AWSProfileName
        {
            get { return _rootConfig.ProfileName; }
            set { _rootConfig.ProfileName = value; }
        }

        #endregion

        #region Accounts Location

        /// <summary>
        /// Key for the AWSProfilesLocation property.
        /// </summary>
        public const string AWSProfilesLocationKey = "AWSProfilesLocation";

        /// <summary>
        /// Location of the credentials file shared with other AWS SDKs.
        /// By default, the credentials file is stored in the .aws directory in the current user's home directory.
        /// 
        /// Changes to this setting will only take effect in newly-constructed clients.
        /// <para>
        /// To reference the profile from an application's App.config or Web.config use the AWSProfileName setting.
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfilesLocation" value="c:\config"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </para>
        /// </summary>
        public static string AWSProfilesLocation
        {
            get { return _rootConfig.ProfilesLocation; }
            set { _rootConfig.ProfilesLocation = value; }
        }

        #endregion


        #region SDK Cache

        /// <summary>
        /// Key for the UseSdkCache property.
        /// <seealso cref="Amazon.AWSConfigs.UseSdkCache"/>
        /// </summary>
        public const string UseSdkCacheKey = "AWSCache";

        /// <summary>
        /// Configures if the SDK Cache should be used, the default value is true.
        /// <code>
        /// &lt;configSections&gt;
        ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
        /// &lt;/configSections&gt;
        /// &lt;aws useSdkCache="true" /&gt;
        /// </code>
        /// </summary>
        public static bool UseSdkCache
        {
            get { return _rootConfig.UseSdkCache; }
            set { _rootConfig.UseSdkCache = value; }
        }

        #endregion

        #region Initialize Collections
        /// <summary>
        /// Key for the InitializeCollections property.
        /// <seealso cref="Amazon.AWSConfigs.InitializeCollections"/>
        /// </summary>
        public const string InitializeCollectionsKey = "AWSInitializeCollections";

        /// <summary>
        /// When true the collections used on the service API request and response objects are initialized
        /// to an empty collection. The collections are sent as part of requests when a collection is non-empty.
        /// 
        /// Setting InitializeCollections to false means all collections used on the service API request and 
        /// response objects are initialized to null. The collections are sent as part of requests when
        /// the collection non-null including an empty collection.
        /// 
        /// The default value is true. In the next major version of the SDK the default will change to false.
        /// This will improve performance not creating unnecessary collection instances and provide more
        /// control when the collection is sent to the service.
        /// 
        /// Setting this property is not thread safe and should only be set at application startup.
        /// </summary>
        public static bool InitializeCollections
        {
            get { return _rootConfig.InitializeCollections; }
            set { _rootConfig.InitializeCollections = value; }
        }
        #endregion

        #region AWS Config Sections

        /// <summary>
        /// Configuration for the Logging section of AWS configuration.
        /// Changes to some settings may not take effect until a new client is constructed.
        /// 
        /// Example section:
        /// <code>
        /// &lt;configSections&gt;
        ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
        /// &lt;/configSections&gt;
        /// &lt;aws&gt;
        ///   &lt;logging logTo="Log4Net, SystemDiagnostics" logResponses="Always" logMetrics="true" /&gt;
        /// &lt;/aws&gt;
        /// </code>
        /// </summary>
        public static LoggingConfig LoggingConfig { get { return _rootConfig.Logging; } }

        /// <summary>
        /// Configuration for the Proxy section of AWS configuration.
        /// Changes to some settings may not take effect until a new client is constructed.
        /// 
        /// Example section:
        /// <code>
        /// &lt;configSections&gt;
        ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
        /// &lt;/configSections&gt;
        /// &lt;aws&gt;
        ///   &lt;proxy host="localhost" port="8888" username="1" password="1" bypassList="addressexpr1;addressexpr2;..." bypassOnLocal="true" /&gt;
        /// &lt;/aws&gt;
        /// </code>
        /// </summary>
        public static ProxyConfig ProxyConfig { get { return _rootConfig.Proxy; } }

        /// <summary>
        /// When set to true, the service client will use the  x-amz-user-agent
        /// header instead of the User-Agent header to report version and
        /// environment information to the AWS service.
        ///
        /// Note: This is especially useful when using a platform like WebAssembly
        /// which doesn't allow to specify the User-Agent header.
        /// </summary>
        public static bool UseAlternateUserAgentHeader
        {
            get { return _rootConfig.UseAlternateUserAgentHeader; }
            set { _rootConfig.UseAlternateUserAgentHeader = value; }
        }

        /// <summary>
        /// Gets or sets the global <see cref="TelemetryProvider"/> instance.
        /// <para>
        /// This global telemetry provider is used to collect and report telemetry data 
        /// (such as traces and metrics) for all AWS SDK operations.
        /// </para>
        /// </summary>
        public static TelemetryProvider TelemetryProvider
        {
            get { return _telemetryProvider; }
            set { _telemetryProvider = value; }
        }

        /// <summary>
        /// Configuration for the region endpoint section of AWS configuration.
        /// Changes may not take effect until a new client is constructed.
        /// 
        /// Example section:
        /// <code>
        /// &lt;configSections&gt;
        ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
        /// &lt;/configSections&gt;
        /// &lt;aws region="us-west-2" /&gt;
        /// </code>
        /// </summary>
        public static RegionEndpoint RegionEndpoint
        {
            get { return _rootConfig.RegionEndpoint; }
            set { _rootConfig.RegionEndpoint = value; }
        }

        public static CSMConfig CSMConfig
        {
            get { return _rootConfig.CSMConfig; }
            set { _rootConfig.CSMConfig = value; }
        }
        #endregion

        #region Internal members

        internal const string LoggingDestinationProperty = "LogTo";

        internal static PropertyChangedEventHandler mPropertyChanged;
        /// <summary>
        /// Lock for SomeEvent delegate access.
        /// </summary>
        internal static readonly object propertyChangedLock = new object();

        internal static event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                lock (propertyChangedLock)
                {
                    mPropertyChanged += value;
                }
            }
            remove
            {
                lock (propertyChangedLock)
                {
                    mPropertyChanged -= value;
                }
            }
        }

        internal static void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = mPropertyChanged;
            if (handler != null)
            {
                handler(null, new PropertyChangedEventArgs(name));
            }
        }

        #endregion

        #region Private general methods

        private static bool GetConfigBool(string name, bool defaultValue = false)
        {
            string value = GetConfig(name);
            bool result;
            if (bool.TryParse(value, out result))
                return result;
            return defaultValue;
        }

        private static T GetConfigEnum<T>(string name)
        {
            var type = typeof(T);
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

        /// <summary>
        /// This method should never be called directly.
        /// Call AWSSDKUtils.CorrectedUtcNow instead.
        /// </summary>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("AwsSdkRules", "CR1003:PreventDateTimeNowUseRule")]
        private static DateTime GetUtcNow()
        {
            return DateTime.UtcNow;
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
        SystemDiagnostics = 2,

        /// <summary>
        /// Log to the console
        /// </summary>
        Console = 16
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

    /// <summary>
    /// Format for metrics data in the logs
    /// </summary>
    public enum LogMetricsFormatOption
    {
        /// <summary>
        /// Emit metrics in human-readable format
        /// </summary>
        Standard = 0,
        /// <summary>
        /// Emit metrics as JSON data
        /// </summary>
        JSON = 1
    }
}

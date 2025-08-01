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
using Amazon.Runtime.Credentials;
using Amazon.Runtime.CredentialManagement;

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

        // Tests can override this DateTime source.
        internal static Func<DateTime> utcNowSource = GetUtcNow;

        internal static string _awsRegion = GetConfig(AWSRegionKey);
        internal static string _awsProfileName = GetConfig(AWSProfileNameKey);
        internal static string _awsAccountsLocation = GetConfig(AWSProfilesLocationKey);
        internal static bool _useSdkCache = GetConfigBool(UseSdkCacheKey, defaultValue: true);
        internal static int _cborReaderInitialBufferSize = GetConfigInt(CborReaderInitialBufferSizeKey, defaultValue: 1024 * 4); //4KB
        internal static bool _initializeCollections = GetConfigBool(InitializeCollectionsKey, defaultValue: false);
        internal static bool _disableLegacyPersistenceStore = GetConfigBool(DisableLegacyPersistenceStoreKey, defaultValue: false);
        private static TelemetryProvider _telemetryProvider = new DefaultTelemetryProvider();

#if NET8_0_OR_GREATER
        internal static bool _disableDangerousDisablePathAndQueryCanonicalization = GetConfigBool(DisableDangerousDisablePathAndQueryCanonicalizationKey, defaultValue: false);
#endif

        // New config section
        private static readonly RootConfig _rootConfig = new();
        
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
        
        #region StreamingUtf8JsonReaderBufferSize

        /// <summary>
        /// Key for the StreamingUtf8JsonReaderBufferSize property.
        /// <seealso cref="StreamingUtf8JsonReaderBufferSize"/>
        /// </summary>
        public const string StreamingUtf8JsonReaderBufferSizeKey = "StreamingUtf8JsonReaderBufferSize";

        /// <summary>
        /// Configures the default buffer size for the the StreamingUtf8JsonReader
        /// used for buffering data from the stream passed into its constructor. If this isn't set, the SDK will default to 4096 bytes.
        /// 
        /// Setting this property is not thread safe and should only be set at application startup.
        /// </summary>
        public static int? StreamingUtf8JsonReaderBufferSize
        {
            get { return _rootConfig.StreamingUtf8JsonReaderBufferSize; }
            set { _rootConfig.StreamingUtf8JsonReaderBufferSize = value; }
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

        #region CborReader Initial Buffer Size

        /// <summary>
        /// Key for the CborReaderInitialBufferSize property.
        /// <seealso cref="Amazon.AWSConfigs.CborReaderInitialBufferSize"/>
        /// </summary>
        public const string CborReaderInitialBufferSizeKey = "CborReaderInitialBufferSize";

        /// <summary>
        /// Configures the initial buffer size in bytes for the streaming CBOR reader.
        /// If this value isn't set, a default size of 4,096 bytes (4 KB) will be used.
        /// <para />
        /// Setting this property is not thread safe and should only be set at application startup.
        /// <para />
        /// <remarks>
        /// Note that the buffer will automatically resize if it encounters a single data item larger
        /// than this initial size.
        /// </remarks>
        /// </summary>
        public static int CborReaderInitialBufferSize
        {
            get { return _rootConfig.CborReaderInitialBufferSize; }
            set { _rootConfig.CborReaderInitialBufferSize = value; }
        }

        #endregion

        #region Initialize Collections
        /// <summary>
        /// Key for the InitializeCollections property.
        /// <seealso cref="Amazon.AWSConfigs.InitializeCollections"/>
        /// </summary>
        public const string InitializeCollectionsKey = "AWSInitializeCollections";

        /// <summary>
        /// When <c>true</c> the collections used on the service API request and response objects are initialized
        /// to an empty collection. The collections are sent as part of requests when a collection is non-empty.
        /// <para />
        /// Setting InitializeCollections to <c>false</c> means all collections used on the service API request and 
        /// response objects are initialized to null. The collections are sent as part of requests when
        /// the collection non-null including an empty collection.
        /// <para />
        /// The default value is <c>false</c>. 
        /// 
        /// This was changed in V4 of the SDK to improve performance by not creating unnecessary 
        /// collection instances and provide more control when the collection is sent to the service.
        /// 
        /// You can set this value to <c>true</c> to revert to the collection initialization behavior of V3.
        /// <para />
        /// Setting this property is not thread safe and should only be set at application startup.
        /// </summary>
        public static bool InitializeCollections
        {
            get { return _rootConfig.InitializeCollections; }
            set { _rootConfig.InitializeCollections = value; }
        }
        #endregion

        #region Disable DangerousDisablePathAndQueryCanonicalization
#if NET8_0_OR_GREATER
        /// <summary>
        /// Key for the DisableDangerousDisablePathAndQueryCanonicalization property.
        /// <seealso cref="Amazon.AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization"/>
        /// </summary>
        public const string DisableDangerousDisablePathAndQueryCanonicalizationKey = "AWSDisableDangerousDisablePathAndQueryCanonicalization";

        /// <summary>
        /// Starting with .NET 8 the AWS SDK for .NET uses the DangerousDisablePathAndQueryCanonicalization setting when creating Uri instances.
        /// This prevents the .NET Uri class from altering the resource path of the URI for paths like S3 object keys. For 
        /// example if an S3 object key was "foo/../bar.txt" without enabling DangerousDisablePathAndQueryCanonicalization the
        /// .NET Uri class would change the resource path to "bar.txt".
        /// 
        /// Using Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactory for mock testing throws an exception when the 
        /// DangerousDisablePathAndQueryCanonicalization is enabled. To continue using WebApplicationFactory with the SDK
        /// this property can be set to true to prevent the SDK from using the DangerousDisablePathAndQueryCanonicalization flag.
        /// </summary>
        public static bool DisableDangerousDisablePathAndQueryCanonicalization
        {
            get { return _rootConfig.DisableDangerousDisablePathAndQueryCanonicalization; }
            set { _rootConfig.DisableDangerousDisablePathAndQueryCanonicalization = value; }
        }
#endif
        #endregion

        #region CredentialsGenerators

        /// <summary>
        /// Global configuration option to override the search order for credentials when creating SDK service clients without credentials.
        /// <para />
        /// This option is equivalent to the <see cref="FallbackCredentialsFactory.CredentialsGenerators"/>, but it should only be used 
        /// if the <a href="https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/creds-assign.html">default order</a> does not meet your application needs.
        /// <para />
        /// When set, all service clients will use the specified providers so you must guarantee they return valid
        /// credentials for the operations to succeed.
        /// <para />
        /// Setting this property is not thread safe and should only be set at application startup.
        /// </summary>
        /// <remarks>
        /// This option is only used in the <see cref="DefaultAWSCredentialsIdentityResolver"/>, it's not considered by the 
        /// deprecated <see cref="FallbackCredentialsFactory"/> when resolving credentials.
        /// </remarks>
        public static List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator> AWSCredentialsGenerators
        {
            get { return _rootConfig.AWSCredentialsGenerators; }
            set { _rootConfig.AWSCredentialsGenerators = value; }
        }

        #endregion

        #region DisableLegacyPersistenceStore

        /// <summary>
        /// Key for the <seealso cref="Amazon.AWSConfigs.DisableLegacyPersistenceStore"/> property.
        /// </summary>
        public const string DisableLegacyPersistenceStoreKey = "AWSDisableLegacyPersistenceStore";

        /// <summary>
        /// When attempting to retrieve configuration options for a given profile, the AWS SDK for .NET will look at both 
        /// the shared config file and the SDK Store by default - via the <see cref="CredentialProfileStoreChain"/>.
        /// <para />
        /// The SDK Store has a few limitations, such as only being available on Windows and being specific to a particular user on a particular host. 
        /// <para />
        /// Setting this property to <c>true</c> will instruct the SDK not to check the legacy persistence store when interacting with
        /// profiles (this setting is only applicable to the <see cref="CredentialProfileStoreChain"/> and it's not considered when 
        /// interacting with the <see cref="NetSDKCredentialsFile"/> class directly).
        /// </summary>
        /// <remarks>
        /// The default value is <c>false</c>.
        /// </remarks>
        public static bool DisableLegacyPersistenceStore
        {
            get { return _rootConfig.DisableLegacyPersistenceStore; }
            set { _rootConfig.DisableLegacyPersistenceStore = value; }
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

        private static int GetConfigInt(string name, int defaultValue = 0)
        {
            string value = GetConfig(name);
            int result;
            if (int.TryParse(value, out result))
                return result;
            return defaultValue;
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

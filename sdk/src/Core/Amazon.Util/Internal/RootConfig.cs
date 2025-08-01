using Amazon.Runtime.Credentials;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Root AWS config
    /// </summary>
    public partial class RootConfig
    {
        public CSMConfig CSMConfig { get; set; }
        public LoggingConfig Logging { get; private set; }
        public ProxyConfig Proxy { get; private set; }
        public string Region { get; set; }
        public string ProfileName { get; set; }
        public string ProfilesLocation { get; set; }
        public RegionEndpoint RegionEndpoint
        {
            get
            {
                if (string.IsNullOrEmpty(Region))
                    return null;
                return RegionEndpoint.GetBySystemName(Region);
            }
            set
            {
                if (value == null)
                    Region = null;
                else
                    Region = value.SystemName;
            }
        }
        public bool UseSdkCache { get; set; }

        public bool InitializeCollections { get; set; }
        public int CborReaderInitialBufferSize { get; set; }

        public bool CorrectForClockSkew { get; set; }

        public bool UseAlternateUserAgentHeader { get; set; }

        public string ApplicationName { get; set; }

        public bool? CSMEnabled { get; set; }
        public string CSMClientId { get; set; }
        public int? CSMPort { get; set; }
        public int? StreamingUtf8JsonReaderBufferSize { get; set; }

#if NET8_0_OR_GREATER
        public bool DisableDangerousDisablePathAndQueryCanonicalization { get; set; }
#endif

        public List<DefaultAWSCredentialsIdentityResolver.CredentialsGenerator> AWSCredentialsGenerators { get; set; }

        public bool DisableLegacyPersistenceStore { get; set; }

        private const string _rootAwsSectionName = "aws";
        public RootConfig()
        {
            CSMConfig = new CSMConfig();
            Logging = new LoggingConfig();
            Proxy = new ProxyConfig();

            Region = AWSConfigs._awsRegion;
            ProfileName = AWSConfigs._awsProfileName;
            ProfilesLocation = AWSConfigs._awsAccountsLocation;
            UseSdkCache = AWSConfigs._useSdkCache;
            InitializeCollections = AWSConfigs._initializeCollections;
            CborReaderInitialBufferSize = AWSConfigs._cborReaderInitialBufferSize;
            CorrectForClockSkew = true;
            DisableLegacyPersistenceStore = AWSConfigs._disableLegacyPersistenceStore;

#if NET8_0_OR_GREATER
            DisableDangerousDisablePathAndQueryCanonicalization = AWSConfigs._disableDangerousDisablePathAndQueryCanonicalization;
#endif

#if !NETSTANDARD
            var root = AWSConfigs.GetSection<AWSSection>(_rootAwsSectionName);

            Logging.Configure(root.Logging);
            Proxy.Configure(root.Proxy);
            CSMConfig.Configure(root.CSMConfig);
            ServiceSections = root.ServiceSections;
            if (root.UseSdkCache.HasValue)
                UseSdkCache = root.UseSdkCache.Value;

            Region = Choose(Region, root.Region);
            ProfileName = Choose(ProfileName, root.ProfileName);
            ProfilesLocation = Choose(ProfilesLocation, root.ProfilesLocation);
            ApplicationName = Choose(ApplicationName, root.ApplicationName);
            if (root.CorrectForClockSkew.HasValue)
                CorrectForClockSkew = root.CorrectForClockSkew.Value;
#endif
        }

        // If a is not null-or-empty, returns a; otherwise, returns b.
        private static string Choose(string a, string b)
        {
            return (string.IsNullOrEmpty(a) ? b : a);
        }

        IDictionary<string, XElement> ServiceSections { get; set; }
        public XElement GetServiceSection(string service)
        {
            XElement section;
            if (ServiceSections.TryGetValue(service, out section))
                return section;

            return null;
        }
    }
}

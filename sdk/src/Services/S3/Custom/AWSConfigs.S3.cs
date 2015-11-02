using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

#if BCL
using System.Configuration;
#endif

using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon
{
    /// <summary>
    /// Configuration for the S3 section of AWS configuration.
    /// Changes to some settings may not take effect until a new client is constructed.
    /// 
    /// Example section:
    /// <code>
    /// &lt;configSections&gt;
    ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK"/&gt;
    /// &lt;/configSections&gt;
    /// &lt;aws&gt;
    ///   &lt;s3 useSignatureVersion4="true" /&gt;
    /// &lt;/aws&gt;
    /// </code>
    /// </summary>
    public static class AWSConfigsS3
    {
        private const string s3Key = "s3";

        /// <summary>
        /// Key for the S3UseSignatureVersion4Key property.
        /// <seealso cref="Amazon.AWSConfigsS3.UseSignatureVersion4"/>
        /// </summary>
        public const string S3UseSignatureVersion4Key = "AWS.S3.UseSignatureVersion4";

        static AWSConfigsS3()
        {
#if BCL||UNITY
            var appSettingValue = AWSConfigs.GetConfig(S3UseSignatureVersion4Key);
            if (!string.IsNullOrEmpty(appSettingValue))
                UseSignatureVersion4 = bool.Parse(appSettingValue);

            var root = new RootConfig();
            var section = root.GetServiceSection(s3Key);
            if (section == null)
            {
                return;
            }

            var rootSection = new V4ClientSectionRoot(section);
            if (rootSection.S3 != null)
                AWSConfigsS3.Configure(rootSection.S3);
#endif
        }

        /// <summary>
        /// Configures if the S3 client should use Signature Version 4 signing with requests.
        /// By default, this setting is false, though Signature Version 4 may be used by default
        /// in some cases or with some regions. When the setting is true, Signature Version 4
        /// will be used for all requests.
        /// </summary>
        public static bool UseSignatureVersion4 { get; set; }

#if BCL || UNITY
        internal static void Configure(V4ClientSection section)
        {
            if (section.ElementInformation.IsPresent)
            {
                UseSignatureVersion4 = section.UseSignatureVersion4.GetValueOrDefault();
            }
        }
#endif

    }

#if UNITY
    internal class V4ClientSectionRoot
    {
        private const string s3Key = "s3";

        public V4ClientSectionRoot(XElement section)
        {
            if (section == null)
                return;

            this.S3 = AWSConfigs.GetObject<V4ClientSection>(section, s3Key);
        }

        public V4ClientSection S3 { get; set; }
    }

    internal class V4ClientSection : ConfigurationElement
    {
        public bool? UseSignatureVersion4 { get; set; }
    }

#endif


#if BCL

    internal class V4ClientSectionRoot : WritableConfigurationElement
    {
        private const string s3Key = "s3";

        public V4ClientSectionRoot(XElement section)
        {
            if (section != null)
            {
                XmlTextReader reader = new XmlTextReader(new StringReader(section.ToString()))
                {
                    WhitespaceHandling = WhitespaceHandling.None
                };
                this.DeserializeElement(reader, false);
            }
        }

        [ConfigurationProperty(s3Key)]
        public V4ClientSection S3
        {
            get { return (V4ClientSection)this[s3Key]; }
            set { this[s3Key] = value; }
        }
    }

    /// <summary>
    /// V4-enabling section
    /// </summary>
    internal class V4ClientSection : WritableConfigurationElement
    {
        private const string useSignatureVersion4Key = "useSignatureVersion4";

        public V4ClientSection(XElement section)
        {
            if (section != null)
            {
                this.DeserializeElement(section.CreateReader(), false);
            }
        }

        [ConfigurationProperty(useSignatureVersion4Key)]
        public bool? UseSignatureVersion4
        {
            get { return (bool?)this[useSignatureVersion4Key]; }
            set { this[useSignatureVersion4Key] = value; }
        }
    }
#endif
}

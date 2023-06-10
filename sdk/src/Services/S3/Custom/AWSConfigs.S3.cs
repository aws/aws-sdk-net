/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.IO;
using System.Xml;
using System.Xml.Linq;

#if BCL
using System.Configuration;
#endif

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
    ///   &lt;section name="aws" type="Amazon.AWSSection, AWSSDK.Core"/&gt;
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

        private static bool _useSignatureVersion4;

        static AWSConfigsS3()
        {
            _useSignatureVersion4 = true;
            UseSigV4SetExplicitly = false;

#if BCL

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
            {
                var s3Section = rootSection.S3;
                if (s3Section.ElementInformation.IsPresent)
                {
                    if (s3Section.UseSignatureVersion4.HasValue)
                    {
                        UseSignatureVersion4 = s3Section.UseSignatureVersion4.Value;
                    }
                }
            }

#endif

        }

        /// <summary>
        /// Configures if the S3 client should use Signature Version 4 signing with requests.
        /// By default, this setting is set to true which will use Signature Version 4 for all
        /// requests except presigned URL requests when the region is set to us-east-1. When 
        /// UseSignatureVersion4 is explicitly set to true by directly setting this property or
        /// directly setting this property through configuration, Signature Version 4 will be 
        /// used for all requests when able to do so.
        /// When this setting is false, Signature Version 2 will be used. Note that when the 
        /// setting is false, Signature Version 4 may still be used by default in some cases 
        /// or with some regions.
        /// </summary>
        public static bool UseSignatureVersion4 {
            get
            {
                return _useSignatureVersion4;
            }
            set
            {
                UseSigV4SetExplicitly = true;
                _useSignatureVersion4 = value;
            }
        }

        /// <summary>
        /// <para><b>WARNING: Setting DisableMD5Stream to true disables the MD5 data integrity check 
        /// on upload requests.</b></para>
        /// <para>When true, MD5Stream will not be used in upload requests. This may increase upload 
        /// performance under high CPU loads. The default value is false. Set this value to true to 
        /// disable MD5Stream use in all S3 upload requests or override this value per request by 
        /// setting the DisableMD5Stream property on PutObjectRequest, UploadPartRequest, or 
        /// TransferUtilityUploadRequest.</para>
        /// <para>MD5Stream, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableMD5Stream is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependant on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        public static bool DisableMD5Stream { get; set; }

        /// <summary>
        /// Escape and unescape S3 metadata for S3 Put/Get object requests.
        /// Escape only escapes non-ascii values in metadata
        /// Any "%" values in metadata could interfere with this option.
        /// Default value is false.
        /// </summary>
        public static bool EnableUnicodeEncodingForObjectMetadata { get; set; } = false;

        /// <summary>
        /// Was the value of the UseSignatureVersion4 property set explicitly?
        /// This can be done via configuration or by directly setting the property.
        ///
        /// This is used to determine if the user set UseSignatureVersion4 to true,
        /// or if it's true because the default was changed to true in the SDK.
        /// </summary>
        internal static bool UseSigV4SetExplicitly { get; private set; }
    }


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

        // Zero-parameter constructor required to retrieve object from configuration
        public V4ClientSection() { }

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

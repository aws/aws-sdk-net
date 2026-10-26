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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an Amazon Lightsail content delivery network (CDN) distribution.
    /// </summary>
    public partial class LightsailDistribution
    {
        /// <summary>
        /// Gets and sets the property AbleToUpdateBundle. 
        /// <para>
        /// Indicates whether the bundle that is currently applied to your distribution, specified
        /// using the <c>distributionName</c> parameter, can be changed to another bundle.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>UpdateDistributionBundle</c> action to change your distribution's bundle.
        /// </para>
        /// </summary>
        public bool? AbleToUpdateBundle { get; set; }

        /// <summary>
        /// Checks to see if the AbleToUpdateBundle property is set.
        /// </summary>
        internal bool IsSetAbleToUpdateBundle() => this.AbleToUpdateBundle.HasValue;

        /// <summary>
        /// Gets and sets the property AlternativeDomainNames. 
        /// <para>
        /// The alternate domain names of the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlternativeDomainNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlternativeDomainNames property is set.
        /// </summary>
        internal bool IsSetAlternativeDomainNames() => this.AlternativeDomainNames != null && (this.AlternativeDomainNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle currently applied to the distribution.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviorSettings. 
        /// <para>
        /// An object that describes the cache behavior settings of the distribution.
        /// </para>
        /// </summary>
        public CacheSettings CacheBehaviorSettings { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehaviorSettings property is set.
        /// </summary>
        internal bool IsSetCacheBehaviorSettings() => this.CacheBehaviorSettings != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// An array of objects that describe the per-path cache behavior of the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheBehaviorPerPath> CacheBehaviors { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheBehaviorPerPath>() : null;

        /// <summary>
        /// Checks to see if the CacheBehaviors property is set.
        /// </summary>
        internal bool IsSetCacheBehaviors() => this.CacheBehaviors != null && (this.CacheBehaviors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the SSL/TLS certificate attached to the distribution, if any.
        /// </para>
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the distribution was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// An array of objects that describe the custom error responses configured for the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DistributionCustomErrorResponse> CustomErrorResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<DistributionCustomErrorResponse>() : null;

        /// <summary>
        /// Checks to see if the CustomErrorResponses property is set.
        /// </summary>
        internal bool IsSetCustomErrorResponses() => this.CustomErrorResponses != null && (this.CustomErrorResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// An object that describes the default cache behavior of the distribution.
        /// </para>
        /// </summary>
        public CacheBehavior DefaultCacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCacheBehavior property is set.
        /// </summary>
        internal bool IsSetDefaultCacheBehavior() => this.DefaultCacheBehavior != null;

        /// <summary>
        /// Gets and sets the property DefaultRootObject. 
        /// <para>
        /// The object (for example, <c>index.html</c>) that the distribution returns when a viewer
        /// requests the root URL of the distribution (<c>/</c>) instead of a specific object.
        /// </para>
        /// </summary>
        public string DefaultRootObject { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRootObject property is set.
        /// </summary>
        internal bool IsSetDefaultRootObject() => this.DefaultRootObject != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the distribution.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the distribution.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, and <c>dualstack</c> for IPv4 and
        /// IPv6.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether the distribution is enabled.
        /// </para>
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the distribution, such as the Amazon Web
        /// Services Region and Availability Zone.
        /// </para>
        ///  <note> 
        /// <para>
        /// Lightsail distributions are global resources that can reference an origin in any Amazon
        /// Web Services Region, and distribute its content globally. However, all distributions
        /// are located in the <c>us-east-1</c> Region.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// An object that describes the origin resource of the distribution, such as a Lightsail
        /// instance, bucket, or load balancer.
        /// </para>
        ///  
        /// <para>
        /// The distribution pulls, caches, and serves content from the origin.
        /// </para>
        /// </summary>
        public Origin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property OriginPublicDNS. 
        /// <para>
        /// The public DNS of the origin.
        /// </para>
        /// </summary>
        public string OriginPublicDNS { get; set; }

        /// <summary>
        /// Checks to see if the OriginPublicDNS property is set.
        /// </summary>
        internal bool IsSetOriginPublicDNS() => this.OriginPublicDNS != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (<c>Distribution</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the distribution.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail distribution. This code enables our support team to look up your
        /// Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViewerMinimumTlsProtocolVersion. 
        /// <para>
        /// The minimum TLS protocol version that the distribution can use to communicate with
        /// viewers.
        /// </para>
        /// </summary>
        public string ViewerMinimumTlsProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ViewerMinimumTlsProtocolVersion property is set.
        /// </summary>
        internal bool IsSetViewerMinimumTlsProtocolVersion() => this.ViewerMinimumTlsProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property Waf. 
        /// <para>
        /// An object that describes the Web Application Firewall (WAF) configuration of the distribution.
        /// </para>
        /// </summary>
        public WafConfig Waf { get; set; }

        /// <summary>
        /// Checks to see if the Waf property is set.
        /// </summary>
        internal bool IsSetWaf() => this.Waf != null;
    }
}

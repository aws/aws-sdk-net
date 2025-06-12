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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Container for the parameters to the CreateDistribution operation.
    /// Creates an Amazon Lightsail content delivery network (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// A distribution is a globally distributed network of caching servers that improve the
    /// performance of your website or web application hosted on a Lightsail instance. For
    /// more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-content-delivery-network-distributions">Content
    /// delivery networks in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class CreateDistributionRequest : AmazonLightsailRequest
    {
        private string _bundleId;
        private List<CacheBehaviorPerPath> _cacheBehaviors = AWSConfigs.InitializeCollections ? new List<CacheBehaviorPerPath>() : null;
        private CacheSettings _cacheBehaviorSettings;
        private string _certificateName;
        private CacheBehavior _defaultCacheBehavior;
        private string _distributionName;
        private IpAddressType _ipAddressType;
        private InputOrigin _origin;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ViewerMinimumTlsProtocolVersionEnum _viewerMinimumTlsProtocolVersion;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle ID to use for the distribution.
        /// </para>
        ///  
        /// <para>
        /// A distribution bundle describes the specifications of your distribution, such as the
        /// monthly cost and monthly network transfer quota.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributionBundles</c> action to get a list of distribution bundle
        /// IDs that you can specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// An array of objects that describe the per-path cache behavior for the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheBehaviorPerPath> CacheBehaviors
        {
            get { return this._cacheBehaviors; }
            set { this._cacheBehaviors = value; }
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this._cacheBehaviors != null && (this._cacheBehaviors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CacheBehaviorSettings. 
        /// <para>
        /// An object that describes the cache behavior settings for the distribution.
        /// </para>
        /// </summary>
        public CacheSettings CacheBehaviorSettings
        {
            get { return this._cacheBehaviorSettings; }
            set { this._cacheBehaviorSettings = value; }
        }

        // Check to see if CacheBehaviorSettings property is set
        internal bool IsSetCacheBehaviorSettings()
        {
            return this._cacheBehaviorSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the SSL/TLS certificate that you want to attach to the distribution.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetCertificates.html">GetCertificates</a>
        /// action to get a list of certificate names that you can specify.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// An object that describes the default cache behavior for the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CacheBehavior DefaultCacheBehavior
        {
            get { return this._defaultCacheBehavior; }
            set { this._defaultCacheBehavior = value; }
        }

        // Check to see if DefaultCacheBehavior property is set
        internal bool IsSetDefaultCacheBehavior()
        {
            return this._defaultCacheBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionName. 
        /// <para>
        /// The name for the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionName
        {
            get { return this._distributionName; }
            set { this._distributionName = value; }
        }

        // Check to see if DistributionName property is set
        internal bool IsSetDistributionName()
        {
            return this._distributionName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the distribution.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, and <c>dualstack</c> for IPv4 and
        /// IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>dualstack</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// An object that describes the origin resource for the distribution, such as a Lightsail
        /// instance, bucket, or load balancer.
        /// </para>
        ///  
        /// <para>
        /// The distribution pulls, caches, and serves content from the origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputOrigin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the distribution during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ViewerMinimumTlsProtocolVersion. 
        /// <para>
        /// The minimum TLS protocol version for the SSL/TLS certificate.
        /// </para>
        /// </summary>
        public ViewerMinimumTlsProtocolVersionEnum ViewerMinimumTlsProtocolVersion
        {
            get { return this._viewerMinimumTlsProtocolVersion; }
            set { this._viewerMinimumTlsProtocolVersion = value; }
        }

        // Check to see if ViewerMinimumTlsProtocolVersion property is set
        internal bool IsSetViewerMinimumTlsProtocolVersion()
        {
            return this._viewerMinimumTlsProtocolVersion != null;
        }

    }
}
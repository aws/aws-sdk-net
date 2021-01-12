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
    /// more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-content-delivery-network-distributions">Content
    /// delivery networks in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class CreateDistributionRequest : AmazonLightsailRequest
    {
        private string _bundleId;
        private List<CacheBehaviorPerPath> _cacheBehaviors = new List<CacheBehaviorPerPath>();
        private CacheSettings _cacheBehaviorSettings;
        private CacheBehavior _defaultCacheBehavior;
        private string _distributionName;
        private IpAddressType _ipAddressType;
        private InputOrigin _origin;
        private List<Tag> _tags = new List<Tag>();

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
        /// Use the <code>GetDistributionBundles</code> action to get a list of distribution bundle
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
        /// </summary>
        public List<CacheBehaviorPerPath> CacheBehaviors
        {
            get { return this._cacheBehaviors; }
            set { this._cacheBehaviors = value; }
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this._cacheBehaviors != null && this._cacheBehaviors.Count > 0; 
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
        /// The possible values are <code>ipv4</code> for IPv4 only, and <code>dualstack</code>
        /// for IPv4 and IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>dualstack</code>.
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
        /// instance or load balancer.
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
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
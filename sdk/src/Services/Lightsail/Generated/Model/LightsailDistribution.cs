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
    /// Describes an Amazon Lightsail content delivery network (CDN) distribution.
    /// </summary>
    public partial class LightsailDistribution
    {
        private bool? _ableToUpdateBundle;
        private List<string> _alternativeDomainNames = new List<string>();
        private string _arn;
        private string _bundleId;
        private List<CacheBehaviorPerPath> _cacheBehaviors = new List<CacheBehaviorPerPath>();
        private CacheSettings _cacheBehaviorSettings;
        private string _certificateName;
        private DateTime? _createdAt;
        private CacheBehavior _defaultCacheBehavior;
        private string _domainName;
        private IpAddressType _ipAddressType;
        private bool? _isEnabled;
        private ResourceLocation _location;
        private string _name;
        private Origin _origin;
        private string _originPublicDNS;
        private ResourceType _resourceType;
        private string _status;
        private string _supportCode;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AbleToUpdateBundle. 
        /// <para>
        /// Indicates whether the bundle that is currently applied to your distribution, specified
        /// using the <code>distributionName</code> parameter, can be changed to another bundle.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>UpdateDistributionBundle</code> action to change your distribution's
        /// bundle.
        /// </para>
        /// </summary>
        public bool AbleToUpdateBundle
        {
            get { return this._ableToUpdateBundle.GetValueOrDefault(); }
            set { this._ableToUpdateBundle = value; }
        }

        // Check to see if AbleToUpdateBundle property is set
        internal bool IsSetAbleToUpdateBundle()
        {
            return this._ableToUpdateBundle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlternativeDomainNames. 
        /// <para>
        /// The alternate domain names of the distribution.
        /// </para>
        /// </summary>
        public List<string> AlternativeDomainNames
        {
            get { return this._alternativeDomainNames; }
            set { this._alternativeDomainNames = value; }
        }

        // Check to see if AlternativeDomainNames property is set
        internal bool IsSetAlternativeDomainNames()
        {
            return this._alternativeDomainNames != null && this._alternativeDomainNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle currently applied to the distribution.
        /// </para>
        /// </summary>
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
        /// An array of objects that describe the per-path cache behavior of the distribution.
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
        /// An object that describes the cache behavior settings of the distribution.
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
        /// The name of the SSL/TLS certificate attached to the distribution, if any.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the distribution was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// An object that describes the default cache behavior of the distribution.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the distribution.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the distribution.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <code>ipv4</code> for IPv4 only, and <code>dualstack</code>
        /// for IPv4 and IPv6.
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
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether the distribution is enabled.
        /// </para>
        /// </summary>
        public bool IsEnabled
        {
            get { return this._isEnabled.GetValueOrDefault(); }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the distribution, such as the AWS Region
        /// and Availability Zone.
        /// </para>
        ///  <note> 
        /// <para>
        /// Lightsail distributions are global resources that can reference an origin in any AWS
        /// Region, and distribute its content globally. However, all distributions are located
        /// in the <code>us-east-1</code> Region.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// An object that describes the origin resource of the distribution, such as a Lightsail
        /// instance or load balancer.
        /// </para>
        ///  
        /// <para>
        /// The distribution pulls, caches, and serves content from the origin.
        /// </para>
        /// </summary>
        public Origin Origin
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
        /// Gets and sets the property OriginPublicDNS. 
        /// <para>
        /// The public DNS of the origin.
        /// </para>
        /// </summary>
        public string OriginPublicDNS
        {
            get { return this._originPublicDNS; }
            set { this._originPublicDNS = value; }
        }

        // Check to see if OriginPublicDNS property is set
        internal bool IsSetOriginPublicDNS()
        {
            return this._originPublicDNS != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type (e.g., <code>Distribution</code>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the distribution.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail distribution. This code enables our support team to look up your
        /// Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Lightsail
        /// Dev Guide</a>.
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
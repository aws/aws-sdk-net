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
    /// Container for the parameters to the UpdateDistribution operation.
    /// Updates an existing Amazon Lightsail content delivery network (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// Use this action to update the configuration of your existing distribution.
    /// </para>
    /// </summary>
    public partial class UpdateDistributionRequest : AmazonLightsailRequest
    {
        private List<CacheBehaviorPerPath> _cacheBehaviors = AWSConfigs.InitializeCollections ? new List<CacheBehaviorPerPath>() : null;
        private CacheSettings _cacheBehaviorSettings;
        private string _certificateName;
        private CacheBehavior _defaultCacheBehavior;
        private string _distributionName;
        private bool? _isEnabled;
        private InputOrigin _origin;
        private bool? _useDefaultCertificate;
        private ViewerMinimumTlsProtocolVersionEnum _viewerMinimumTlsProtocolVersion;

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
        ///  <note> 
        /// <para>
        /// The <c>cacheBehaviorSettings</c> specified in your <c>UpdateDistributionRequest</c>
        /// will replace your distribution's existing settings.
        /// </para>
        ///  </note>
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
        /// Only certificates with a status of <c>ISSUED</c> can be attached to a distribution.
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
        /// The name of the distribution to update.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributions</c> action to get a list of distribution names that you
        /// can specify.
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
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether to enable the distribution.
        /// </para>
        /// </summary>
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
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
        /// Gets and sets the property UseDefaultCertificate. 
        /// <para>
        /// Indicates whether the default SSL/TLS certificate is attached to the distribution.
        /// The default value is <c>true</c>. When <c>true</c>, the distribution uses the default
        /// domain name such as <c>d111111abcdef8.cloudfront.net</c>.
        /// </para>
        ///  
        /// <para>
        ///  Set this value to <c>false</c> to attach a new certificate to the distribution.
        /// </para>
        /// </summary>
        public bool? UseDefaultCertificate
        {
            get { return this._useDefaultCertificate; }
            set { this._useDefaultCertificate = value; }
        }

        // Check to see if UseDefaultCertificate property is set
        internal bool IsSetUseDefaultCertificate()
        {
            return this._useDefaultCertificate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewerMinimumTlsProtocolVersion. 
        /// <para>
        /// Use this parameter to update the minimum TLS protocol version for the SSL/TLS certificate
        /// that's attached to the distribution.
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
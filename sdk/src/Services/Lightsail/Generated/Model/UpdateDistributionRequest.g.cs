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
    /// Container for the parameters to the UpdateDistribution operation. Updates an existing
    /// Amazon Lightsail content delivery network (CDN) distribution. <para> Use this action
    /// to update the configuration of your existing distribution. </para>
    /// </summary>
    public partial class UpdateDistributionRequest : AmazonLightsailRequest
    {
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
        public CacheSettings CacheBehaviorSettings { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehaviorSettings property is set.
        /// </summary>
        internal bool IsSetCacheBehaviorSettings() => this.CacheBehaviorSettings != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// An array of objects that describe the per-path cache behavior for the distribution.
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
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// An array of objects that describe the custom error responses for the distribution.
        /// With a custom error response, you can specify the page to return when the origin responds
        /// with a given HTTP error code. You can also specify the HTTP status code to send to
        /// the viewer.
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
        /// An object that describes the default cache behavior for the distribution.
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
        /// The object that you specify must be available from the origin.
        /// </para>
        /// </summary>
        public string DefaultRootObject { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRootObject property is set.
        /// </summary>
        internal bool IsSetDefaultRootObject() => this.DefaultRootObject != null;

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
        [AWSProperty(Required = true)]
        public string DistributionName { get; set; }

        /// <summary>
        /// Checks to see if the DistributionName property is set.
        /// </summary>
        internal bool IsSetDistributionName() => this.DistributionName != null;

        /// <summary>
        /// Gets and sets the property EnablePrivateOriginAccess. 
        /// <para>
        /// Specifies whether to enable private origin access for the distribution. With private
        /// origin access, the distribution can serve objects that aren't publicly accessible
        /// from a Lightsail bucket.
        /// </para>
        ///  
        /// <para>
        /// Lightsail grants the distribution permission to read the bucket's objects. Enabling
        /// private origin access doesn't change the bucket's access settings, and you can still
        /// retrieve publicly accessible objects directly from the bucket's endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you include this parameter, you must also include the <c>origin</c> parameter
        /// with the resource name, even if the origin is not changing.
        /// </para>
        ///  
        /// <para>
        /// You can enable private origin access only when the distribution's origin is a Lightsail
        /// bucket. If the origin is another resource type, the request fails.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnablePrivateOriginAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrivateOriginAccess property is set.
        /// </summary>
        internal bool IsSetEnablePrivateOriginAccess() => this.EnablePrivateOriginAccess.HasValue;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether to enable the distribution.
        /// </para>
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

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
        public InputOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

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
        public bool? UseDefaultCertificate { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaultCertificate property is set.
        /// </summary>
        internal bool IsSetUseDefaultCertificate() => this.UseDefaultCertificate.HasValue;

        /// <summary>
        /// Gets and sets the property ViewerMinimumTlsProtocolVersion. 
        /// <para>
        /// Use this parameter to update the minimum TLS protocol version for the SSL/TLS certificate
        /// that's attached to the distribution.
        /// </para>
        /// </summary>
        public ViewerMinimumTlsProtocolVersionEnum ViewerMinimumTlsProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ViewerMinimumTlsProtocolVersion property is set.
        /// </summary>
        internal bool IsSetViewerMinimumTlsProtocolVersion() => this.ViewerMinimumTlsProtocolVersion != null;
    }
}

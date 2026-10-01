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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A CloudFront distribution configuration.
    /// </summary>
    public partial class AwsCloudFrontDistributionDetails
    {
        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// Provides information about the cache configuration for the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionCacheBehaviors CacheBehaviors { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehaviors property is set.
        /// </summary>
        internal bool IsSetCacheBehaviors() => this.CacheBehaviors != null;

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// The default cache behavior for the configuration.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionDefaultCacheBehavior DefaultCacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCacheBehavior property is set.
        /// </summary>
        internal bool IsSetDefaultCacheBehavior() => this.DefaultCacheBehavior != null;

        /// <summary>
        /// Gets and sets the property DefaultRootObject. 
        /// <para>
        /// The object that CloudFront sends in response to requests from the origin (for example,
        /// index.html) when a viewer requests the root URL for the distribution (http://www.example.com)
        /// instead of an object in your distribution (http://www.example.com/product-description.html).
        /// 
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
        /// The domain name corresponding to the distribution.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag is a hash of the object.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Indicates when that the distribution was last modified.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// A complex type that controls whether access logs are written for the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionLogging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property OriginGroups. 
        /// <para>
        /// Provides information about the origin groups in the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginGroups OriginGroups { get; set; }

        /// <summary>
        /// Checks to see if the OriginGroups property is set.
        /// </summary>
        internal bool IsSetOriginGroups() => this.OriginGroups != null;

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// A complex type that contains information about origins for this distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOrigins Origins { get; set; }

        /// <summary>
        /// Checks to see if the Origins property is set.
        /// </summary>
        internal bool IsSetOrigins() => this.Origins != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the current status of the distribution.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ViewerCertificate. 
        /// <para>
        /// Provides information about the TLS/SSL configuration that the distribution uses to
        /// communicate with viewers.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionViewerCertificate ViewerCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ViewerCertificate property is set.
        /// </summary>
        internal bool IsSetViewerCertificate() => this.ViewerCertificate != null;

        /// <summary>
        /// Gets and sets the property WebAclId. 
        /// <para>
        /// A unique identifier that specifies the WAF web ACL, if any, to associate with this
        /// distribution.
        /// </para>
        /// </summary>
        public string WebAclId { get; set; }

        /// <summary>
        /// Checks to see if the WebAclId property is set.
        /// </summary>
        internal bool IsSetWebAclId() => this.WebAclId != null;
    }
}

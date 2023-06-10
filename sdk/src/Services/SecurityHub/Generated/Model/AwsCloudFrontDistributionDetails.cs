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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A CloudFront distribution configuration.
    /// </summary>
    public partial class AwsCloudFrontDistributionDetails
    {
        private AwsCloudFrontDistributionCacheBehaviors _cacheBehaviors;
        private AwsCloudFrontDistributionDefaultCacheBehavior _defaultCacheBehavior;
        private string _defaultRootObject;
        private string _domainName;
        private string _eTag;
        private string _lastModifiedTime;
        private AwsCloudFrontDistributionLogging _logging;
        private AwsCloudFrontDistributionOriginGroups _originGroups;
        private AwsCloudFrontDistributionOrigins _origins;
        private string _status;
        private AwsCloudFrontDistributionViewerCertificate _viewerCertificate;
        private string _webAclId;

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// Provides information about the cache configuration for the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionCacheBehaviors CacheBehaviors
        {
            get { return this._cacheBehaviors; }
            set { this._cacheBehaviors = value; }
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this._cacheBehaviors != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// The default cache behavior for the configuration.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionDefaultCacheBehavior DefaultCacheBehavior
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
        /// Gets and sets the property DefaultRootObject. 
        /// <para>
        /// The object that CloudFront sends in response to requests from the origin (for example,
        /// index.html) when a viewer requests the root URL for the distribution (http://www.example.com)
        /// instead of an object in your distribution (http://www.example.com/product-description.html).
        /// 
        /// </para>
        /// </summary>
        public string DefaultRootObject
        {
            get { return this._defaultRootObject; }
            set { this._defaultRootObject = value; }
        }

        // Check to see if DefaultRootObject property is set
        internal bool IsSetDefaultRootObject()
        {
            return this._defaultRootObject != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name corresponding to the distribution.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag is a hash of the object.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Indicates when that the distribution was last modified.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime != null;
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// A complex type that controls whether access logs are written for the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionLogging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property OriginGroups. 
        /// <para>
        /// Provides information about the origin groups in the distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOriginGroups OriginGroups
        {
            get { return this._originGroups; }
            set { this._originGroups = value; }
        }

        // Check to see if OriginGroups property is set
        internal bool IsSetOriginGroups()
        {
            return this._originGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// A complex type that contains information about origins for this distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionOrigins Origins
        {
            get { return this._origins; }
            set { this._origins = value; }
        }

        // Check to see if Origins property is set
        internal bool IsSetOrigins()
        {
            return this._origins != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the current status of the distribution.
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
        /// Gets and sets the property ViewerCertificate. 
        /// <para>
        /// Provides information about the TLS/SSL configuration that the distribution uses to
        /// communicate with viewers.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionViewerCertificate ViewerCertificate
        {
            get { return this._viewerCertificate; }
            set { this._viewerCertificate = value; }
        }

        // Check to see if ViewerCertificate property is set
        internal bool IsSetViewerCertificate()
        {
            return this._viewerCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property WebAclId. 
        /// <para>
        /// A unique identifier that specifies the WAF web ACL, if any, to associate with this
        /// distribution.
        /// </para>
        /// </summary>
        public string WebAclId
        {
            get { return this._webAclId; }
            set { this._webAclId = value; }
        }

        // Check to see if WebAclId property is set
        internal bool IsSetWebAclId()
        {
            return this._webAclId != null;
        }

    }
}
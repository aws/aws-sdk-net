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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that contains information about the Amazon S3 bucket from which you
    /// want CloudFront to get your media files for distribution.
    /// </summary>
    public partial class S3Origin
    {
        private string _domainName;
        private string _originAccessIdentity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public S3Origin() { }

        /// <summary>
        /// Instantiates S3Origin with the parameterized properties
        /// </summary>
        /// <param name="domainName">The DNS name of the Amazon S3 origin.</param>
        public S3Origin(string domainName)
        {
            _domainName = domainName;
        }

        /// <summary>
        /// Instantiates S3Origin with the parameterized properties
        /// </summary>
        /// <param name="domainName">The DNS name of the Amazon S3 origin.</param>
        /// <param name="originAccessIdentity">The CloudFront origin access identity to associate with the distribution. Use an origin access identity to configure the distribution so that end users can only access objects in an Amazon S3 bucket through CloudFront. If you want end users to be able to access objects using either the CloudFront URL or the Amazon S3 URL, specify an empty <code>OriginAccessIdentity</code> element. To delete the origin access identity from an existing distribution, update the distribution configuration and include an empty <code>OriginAccessIdentity</code> element. To replace the origin access identity, update the distribution configuration and specify the new origin access identity. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-s3.html">Using an Origin Access Identity to Restrict Access to Your Amazon S3 Content</a> in the <i> Amazon CloudFront Developer Guide</i>.</param>
        public S3Origin(string domainName, string originAccessIdentity)
        {
            _domainName = domainName;
            _originAccessIdentity = originAccessIdentity;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The DNS name of the Amazon S3 origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OriginAccessIdentity. 
        /// <para>
        /// The CloudFront origin access identity to associate with the distribution. Use an origin
        /// access identity to configure the distribution so that end users can only access objects
        /// in an Amazon S3 bucket through CloudFront.
        /// </para>
        ///  
        /// <para>
        /// If you want end users to be able to access objects using either the CloudFront URL
        /// or the Amazon S3 URL, specify an empty <code>OriginAccessIdentity</code> element.
        /// </para>
        ///  
        /// <para>
        /// To delete the origin access identity from an existing distribution, update the distribution
        /// configuration and include an empty <code>OriginAccessIdentity</code> element.
        /// </para>
        ///  
        /// <para>
        /// To replace the origin access identity, update the distribution configuration and specify
        /// the new origin access identity.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-s3.html">Using
        /// an Origin Access Identity to Restrict Access to Your Amazon S3 Content</a> in the
        /// <i> Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginAccessIdentity
        {
            get { return this._originAccessIdentity; }
            set { this._originAccessIdentity = value; }
        }

        // Check to see if OriginAccessIdentity property is set
        internal bool IsSetOriginAccessIdentity()
        {
            return this._originAccessIdentity != null;
        }

    }
}
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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that contains information about the Amazon S3 origin. If the origin
    /// is a custom origin or an S3 bucket that is configured as a website endpoint, use the
    /// <c>CustomOriginConfig</c> element instead.
    /// </summary>
    public partial class S3OriginConfig
    {
        private string _originAccessIdentity;
        private int? _originReadTimeout;

        /// <summary>
        /// Gets and sets the property OriginAccessIdentity. 
        /// <para>
        /// <note> 
        /// <para>
        /// If you're using origin access control (OAC) instead of origin access identity, specify
        /// an empty <c>OriginAccessIdentity</c> element. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-origin.html">Restricting
        /// access to an Amazon Web Services</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The CloudFront origin access identity to associate with the origin. Use an origin
        /// access identity to configure the origin so that viewers can <i>only</i> access objects
        /// in an Amazon S3 bucket through CloudFront. The format of the value is:
        /// </para>
        ///  
        /// <para>
        ///  <c>origin-access-identity/cloudfront/ID-of-origin-access-identity</c> 
        /// </para>
        ///  
        /// <para>
        /// The <c> <i>ID-of-origin-access-identity</i> </c> is the value that CloudFront returned
        /// in the <c>ID</c> element when you created the origin access identity.
        /// </para>
        ///  
        /// <para>
        /// If you want viewers to be able to access objects using either the CloudFront URL or
        /// the Amazon S3 URL, specify an empty <c>OriginAccessIdentity</c> element.
        /// </para>
        ///  
        /// <para>
        /// To delete the origin access identity from an existing distribution, update the distribution
        /// configuration and include an empty <c>OriginAccessIdentity</c> element.
        /// </para>
        ///  
        /// <para>
        /// To replace the origin access identity, update the distribution configuration and specify
        /// the new origin access identity.
        /// </para>
        ///  
        /// <para>
        /// For more information about the origin access identity, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// 
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

        /// <summary>
        /// Gets and sets the property OriginReadTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront waits for a response from the origin. This
        /// is also known as the <i>origin response timeout</i>. The minimum timeout is 1 second,
        /// the maximum is 120 seconds, and the default (if you don't specify otherwise) is 30
        /// seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginResponseTimeout">Response
        /// timeout</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int? OriginReadTimeout
        {
            get { return this._originReadTimeout; }
            set { this._originReadTimeout = value; }
        }

        // Check to see if OriginReadTimeout property is set
        internal bool IsSetOriginReadTimeout()
        {
            return this._originReadTimeout.HasValue; 
        }

    }
}
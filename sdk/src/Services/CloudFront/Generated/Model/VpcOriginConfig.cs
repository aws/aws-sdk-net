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
    /// An Amazon CloudFront VPC origin configuration.
    /// </summary>
    public partial class VpcOriginConfig
    {
        private int? _originKeepaliveTimeout;
        private int? _originReadTimeout;
        private string _vpcOriginId;

        /// <summary>
        /// Gets and sets the property OriginKeepaliveTimeout. 
        /// <para>
        /// Specifies how long, in seconds, CloudFront persists its connection to the origin.
        /// The minimum timeout is 1 second, the maximum is 120 seconds, and the default (if you
        /// don't specify otherwise) is 5 seconds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DownloadDistValuesOrigin.html#DownloadDistValuesOriginKeepaliveTimeout">Keep-alive
        /// timeout (custom origins only)</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public int? OriginKeepaliveTimeout
        {
            get { return this._originKeepaliveTimeout; }
            set { this._originKeepaliveTimeout = value; }
        }

        // Check to see if OriginKeepaliveTimeout property is set
        internal bool IsSetOriginKeepaliveTimeout()
        {
            return this._originKeepaliveTimeout.HasValue; 
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

        /// <summary>
        /// Gets and sets the property VpcOriginId. 
        /// <para>
        /// The VPC origin ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcOriginId
        {
            get { return this._vpcOriginId; }
            set { this._vpcOriginId = value; }
        }

        // Check to see if VpcOriginId property is set
        internal bool IsSetVpcOriginId()
        {
            return this._vpcOriginId != null;
        }

    }
}
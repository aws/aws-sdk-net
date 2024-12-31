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
    /// Amazon CloudFront supports gRPC, an open-source remote procedure call (RPC) framework
    /// built on HTTP/2. gRPC offers bi-directional streaming and binary protocol that buffers
    /// payloads, making it suitable for applications that require low latency communications.
    /// 
    ///  
    /// <para>
    /// To enable your distribution to handle gRPC requests, you must include HTTP/2 as one
    /// of the supported <c>HTTP</c> versions and allow <c>HTTP</c> methods, including <c>POST</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-using-grpc.html">Using
    /// gRPC with CloudFront distributions</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GrpcConfig
    {
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables your CloudFront distribution to receive gRPC requests and to proxy them directly
        /// to your origins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}
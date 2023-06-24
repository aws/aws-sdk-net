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
    /// Container for the parameters to the CreateResponseHeadersPolicy operation.
    /// Creates a response headers policy.
    /// 
    ///  
    /// <para>
    /// A response headers policy contains information about a set of HTTP headers. To create
    /// a response headers policy, you provide some metadata about the policy and a set of
    /// configurations that specify the headers.
    /// </para>
    ///  
    /// <para>
    /// After you create a response headers policy, you can use its ID to attach it to one
    /// or more cache behaviors in a CloudFront distribution. When it's attached to a cache
    /// behavior, the response headers policy affects the HTTP headers that CloudFront includes
    /// in HTTP responses to requests that match the cache behavior. CloudFront adds or removes
    /// response headers according to the configuration of the response headers policy.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/modifying-response-headers.html">Adding
    /// or removing HTTP headers in CloudFront responses</a> in the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateResponseHeadersPolicyRequest : AmazonCloudFrontRequest
    {
        private ResponseHeadersPolicyConfig _responseHeadersPolicyConfig;

        /// <summary>
        /// Gets and sets the property ResponseHeadersPolicyConfig. 
        /// <para>
        /// Contains metadata about the response headers policy, and a set of configurations that
        /// specify the HTTP headers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseHeadersPolicyConfig ResponseHeadersPolicyConfig
        {
            get { return this._responseHeadersPolicyConfig; }
            set { this._responseHeadersPolicyConfig = value; }
        }

        // Check to see if ResponseHeadersPolicyConfig property is set
        internal bool IsSetResponseHeadersPolicyConfig()
        {
            return this._responseHeadersPolicyConfig != null;
        }

    }
}
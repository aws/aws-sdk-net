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
    /// Contains a response headers policy.
    /// </summary>
    public partial class ResponseHeadersPolicySummary
    {
        private ResponseHeadersPolicy _responseHeadersPolicy;
        private ResponseHeadersPolicyType _type;

        /// <summary>
        /// Gets and sets the property ResponseHeadersPolicy. 
        /// <para>
        /// The response headers policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseHeadersPolicy ResponseHeadersPolicy
        {
            get { return this._responseHeadersPolicy; }
            set { this._responseHeadersPolicy = value; }
        }

        // Check to see if ResponseHeadersPolicy property is set
        internal bool IsSetResponseHeadersPolicy()
        {
            return this._responseHeadersPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of response headers policy, either <c>managed</c> (created by Amazon Web
        /// Services) or <c>custom</c> (created in this Amazon Web Services account).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseHeadersPolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
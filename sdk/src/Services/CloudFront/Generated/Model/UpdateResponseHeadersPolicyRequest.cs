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
    /// Container for the parameters to the UpdateResponseHeadersPolicy operation.
    /// Updates a response headers policy.
    /// 
    ///  
    /// <para>
    /// When you update a response headers policy, the entire policy is replaced. You cannot
    /// update some policy fields independent of others. To update a response headers policy
    /// configuration:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use <code>GetResponseHeadersPolicyConfig</code> to get the current policy's configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Modify the fields in the response headers policy configuration that you want to update.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call <code>UpdateResponseHeadersPolicy</code>, providing the entire response headers
    /// policy configuration, including the fields that you modified and those that you didn't.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateResponseHeadersPolicyRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private ResponseHeadersPolicyConfig _responseHeadersPolicyConfig;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the response headers policy that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The version of the response headers policy that you are updating.
        /// </para>
        ///  
        /// <para>
        /// The version is returned in the cache policy's <code>ETag</code> field in the response
        /// to <code>GetResponseHeadersPolicyConfig</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseHeadersPolicyConfig. 
        /// <para>
        /// A response headers policy configuration.
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
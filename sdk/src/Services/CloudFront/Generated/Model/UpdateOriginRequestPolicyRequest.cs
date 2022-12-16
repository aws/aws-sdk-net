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
    /// Container for the parameters to the UpdateOriginRequestPolicy operation.
    /// Updates an origin request policy configuration.
    /// 
    ///  
    /// <para>
    /// When you update an origin request policy configuration, all the fields are updated
    /// with the values provided in the request. You cannot update some fields independent
    /// of others. To update an origin request policy configuration:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use <code>GetOriginRequestPolicyConfig</code> to get the current configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Locally modify the fields in the origin request policy configuration that you want
    /// to update.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call <code>UpdateOriginRequestPolicy</code> by providing the entire origin request
    /// policy configuration, including the fields that you modified and those that you didn't.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateOriginRequestPolicyRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private OriginRequestPolicyConfig _originRequestPolicyConfig;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the origin request policy that you are updating. The identifier
        /// is returned in a cache behavior's <code>OriginRequestPolicyId</code> field in the
        /// response to <code>GetDistributionConfig</code>.
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
        /// The version of the origin request policy that you are updating. The version is returned
        /// in the origin request policy's <code>ETag</code> field in the response to <code>GetOriginRequestPolicyConfig</code>.
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
        /// Gets and sets the property OriginRequestPolicyConfig. 
        /// <para>
        /// An origin request policy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginRequestPolicyConfig OriginRequestPolicyConfig
        {
            get { return this._originRequestPolicyConfig; }
            set { this._originRequestPolicyConfig = value; }
        }

        // Check to see if OriginRequestPolicyConfig property is set
        internal bool IsSetOriginRequestPolicyConfig()
        {
            return this._originRequestPolicyConfig != null;
        }

    }
}
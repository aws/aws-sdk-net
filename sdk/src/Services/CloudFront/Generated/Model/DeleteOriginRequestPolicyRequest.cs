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
    /// Container for the parameters to the DeleteOriginRequestPolicy operation.
    /// Deletes an origin request policy.
    /// 
    ///  
    /// <para>
    /// You cannot delete an origin request policy if it's attached to any cache behaviors.
    /// First update your distributions to remove the origin request policy from all cache
    /// behaviors, then delete the origin request policy.
    /// </para>
    ///  
    /// <para>
    /// To delete an origin request policy, you must provide the policy's identifier and version.
    /// To get the identifier, you can use <code>ListOriginRequestPolicies</code> or <code>GetOriginRequestPolicy</code>.
    /// </para>
    /// </summary>
    public partial class DeleteOriginRequestPolicyRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the origin request policy that you are deleting. To get
        /// the identifier, you can use <code>ListOriginRequestPolicies</code>.
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
        /// The version of the origin request policy that you are deleting. The version is the
        /// origin request policy's <code>ETag</code> value, which you can get using <code>ListOriginRequestPolicies</code>,
        /// <code>GetOriginRequestPolicy</code>, or <code>GetOriginRequestPolicyConfig</code>.
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

    }
}
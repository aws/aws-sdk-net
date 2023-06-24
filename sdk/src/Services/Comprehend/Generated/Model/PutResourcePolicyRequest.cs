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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Attaches a resource-based policy to a custom model. You can use this policy to authorize
    /// an entity in another Amazon Web Services account to import the custom model, which
    /// replicates it in Amazon Comprehend in their account.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonComprehendRequest
    {
        private string _policyRevisionId;
        private string _resourceArn;
        private string _resourcePolicy;

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// The revision ID that Amazon Comprehend assigned to the policy that you are updating.
        /// If you are creating a new policy that has no prior version, don't use this parameter.
        /// Amazon Comprehend creates the revision ID for you.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string PolicyRevisionId
        {
            get { return this._policyRevisionId; }
            set { this._policyRevisionId = value; }
        }

        // Check to see if PolicyRevisionId property is set
        internal bool IsSetPolicyRevisionId()
        {
            return this._policyRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model to attach the policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The JSON resource-based policy to attach to your custom model. Provide your JSON as
        /// a UTF-8 encoded string without line breaks. To provide valid JSON for your policy,
        /// enclose the attribute names and values in double quotes. If the JSON body is also
        /// enclosed in double quotes, then you must escape the double quotes that are inside
        /// the policy:
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"attribute\": \"value\", \"attribute\": [\"value\"]}"</code> 
        /// </para>
        ///  
        /// <para>
        /// To avoid escaping quotes, you can use single quotes to enclose the policy and double
        /// quotes to enclose the JSON names and values:
        /// </para>
        ///  
        /// <para>
        ///  <code>'{"attribute": "value", "attribute": ["value"]}'</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20000)]
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

    }
}
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermissionPolicy operation.
    /// Attaches a IAM policy to the specified resource. The only supported use for this action
    /// is to share a RuleGroup across accounts.
    /// 
    ///  
    /// <para>
    /// The <code>PutPermissionPolicy</code> is subject to the following restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can attach only one policy with each <code>PutPermissionPolicy</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy must include an <code>Effect</code>, <code>Action</code> and <code>Principal</code>.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Effect</code> must specify <code>Allow</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Action</code> in the policy must be <code>waf:UpdateWebACL</code> and <code>waf-regional:UpdateWebACL</code>.
    /// Any extra or wildcard actions in the policy will be rejected.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy cannot include a <code>Resource</code> parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The ARN in the request must be a valid WAF RuleGroup ARN and the RuleGroup must exist
    /// in the same region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user making the request must be the owner of the RuleGroup.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your policy must be composed using IAM Policy version 2012-10-17.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
    /// Policies</a>. 
    /// </para>
    ///  
    /// <para>
    /// An example of a valid policy parameter is shown in the Examples section below.
    /// </para>
    /// </summary>
    public partial class PutPermissionPolicyRequest : AmazonWAFRequest
    {
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy to attach to the specified RuleGroup.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RuleGroup to which you want to attach the policy.
        /// </para>
        /// </summary>
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

    }
}
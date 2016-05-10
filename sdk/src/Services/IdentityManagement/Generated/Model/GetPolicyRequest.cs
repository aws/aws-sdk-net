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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetPolicy operation.
    /// Retrieves information about the specified managed policy, including the policy's default
    /// version and the total number of IAM users, groups, and roles to which the policy is
    /// attached. To retrieve the list of the specific users, groups, and roles that the policy
    /// is attached to, use the <a>ListEntitiesForPolicy</a> API. This API returns metadata
    /// about the policy. To retrieve the actual policy document for a specific version of
    /// the policy, use <a>GetPolicyVersion</a>.
    /// 
    ///  
    /// <para>
    /// This API retrieves information about managed policies. To retrieve information about
    /// an inline policy that is embedded with an IAM user, group, or role, use the <a>GetUserPolicy</a>,
    /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
    /// </para>
    ///  
    /// <para>
    /// For more information about policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the managed policy that you want information about.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

    }
}
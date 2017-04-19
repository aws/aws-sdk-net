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
    /// Container for the parameters to the AttachRolePolicy operation.
    /// Attaches the specified managed policy to the specified IAM role. When you attach a
    /// managed policy to a role, the managed policy becomes part of the role's permission
    /// (access) policy.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use a managed policy as the role's trust policy. The role's trust policy
    /// is created at the same time as the role, using <a>CreateRole</a>. You can update a
    /// role's trust policy using <a>UpdateAssumeRolePolicy</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Use this API to attach a <i>managed</i> policy to a role. To embed an inline policy
    /// in a role, use <a>PutRolePolicy</a>. For more information about policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttachRolePolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM policy you want to attach.
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

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name (friendly name, not ARN) of the role to attach the policy to.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}
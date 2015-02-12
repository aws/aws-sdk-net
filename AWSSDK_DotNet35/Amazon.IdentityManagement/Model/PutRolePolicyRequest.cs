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
    /// Container for the parameters to the PutRolePolicy operation.
    /// Adds (or updates) an inline policy document that is embedded in the specified role.
    /// 
    /// 
    ///  
    /// <para>
    /// When you embed an inline policy in a role, the inline policy is used as the role's
    /// access (permissions) policy. The role's trust policy is created at the same time as
    /// the role, using <a>CreateRole</a>. You can update a role's trust policy using <a>UpdateAssumeRolePolicy</a>.
    /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
    /// Roles to Delegate Permissions and Federate Identities</a>. 
    /// </para>
    ///  
    /// <para>
    /// A role can also have a managed policy attached to it. To attach a managed policy to
    /// a role, use <a>AttachRolePolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
    /// For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>Using IAM</i> guide. 
    /// </para>
    ///  
    /// <para>
    /// For information about limits on the number of inline policies that you can embed with
    /// a role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on IAM Entities</a> in the <i>Using IAM</i> guide. 
    /// </para>
    ///  <note>Because policy documents can be large, you should use POST rather than GET
    /// when calling <code>PutRolePolicy</code>. For general information about using the Query
    /// API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>Using IAM</i> guide. </note>
    /// </summary>
    public partial class PutRolePolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyDocument;
        private string _policyName;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy document.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to associate the policy with.
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
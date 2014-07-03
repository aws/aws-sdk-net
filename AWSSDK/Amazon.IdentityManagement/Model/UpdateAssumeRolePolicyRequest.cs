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
    /// Container for the parameters to the UpdateAssumeRolePolicy operation.
    /// Updates the policy that grants an entity permission to assume a role. For more information
    /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
    /// with            Roles</a>.
    /// </summary>
    public partial class UpdateAssumeRolePolicyRequest : AmazonWebServiceRequest
    {
        private string _policyDocument;
        private string _roleName;


        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy that grants an entity permission to assume the role.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }


        /// <summary>
        /// Sets the PolicyDocument property
        /// </summary>
        /// <param name="policyDocument">The value to set for the PolicyDocument property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAssumeRolePolicyRequest WithPolicyDocument(string policyDocument)
        {
            this._policyDocument = policyDocument;
            return this;
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }


        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// Name of the role to update.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }


        /// <summary>
        /// Sets the RoleName property
        /// </summary>
        /// <param name="roleName">The value to set for the RoleName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAssumeRolePolicyRequest WithRoleName(string roleName)
        {
            this._roleName = roleName;
            return this;
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}
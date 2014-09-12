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
    /// Container for the parameters to the DeleteUserPolicy operation.
    /// Deletes the specified policy associated with the specified user.
    /// </summary>
    public partial class DeleteUserPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyName;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteUserPolicyRequest() { }

        /// <summary>
        /// Instantiates DeleteUserPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">Name of the user the policy is associated with.</param>
        /// <param name="policyName">Name of the policy document to delete.</param>
        public DeleteUserPolicyRequest(string userName, string policyName)
        {
            _userName = userName;
            _policyName = policyName;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Name of the policy document to delete.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user the policy is associated with.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePolicy operation.
    /// Permanently deletes an AWS Firewall Manager policy.
    /// </summary>
    public partial class DeletePolicyRequest : AmazonFMSRequest
    {
        private bool? _deleteAllPolicyResources;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property DeleteAllPolicyResources. 
        /// <para>
        /// If <code>True</code>, the request will also perform a clean-up process that will:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delete rule groups created by AWS Firewall Manager
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove web ACLs from in-scope resources
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete web ACLs that contain no rules or rule groups
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After the cleanup, in-scope resources will no longer be protected by web ACLs in this
        /// policy. Protection of out-of-scope resources will remain unchanged. Scope is determined
        /// by tags and accounts associated with the policy. When creating the policy, if you
        /// specified that only resources in specific accounts or with specific tags be protected
        /// by the policy, those resources are in-scope. All others are out of scope. If you did
        /// not specify tags or accounts, all resources are in-scope. 
        /// </para>
        /// </summary>
        public bool DeleteAllPolicyResources
        {
            get { return this._deleteAllPolicyResources.GetValueOrDefault(); }
            set { this._deleteAllPolicyResources = value; }
        }

        // Check to see if DeleteAllPolicyResources property is set
        internal bool IsSetDeleteAllPolicyResources()
        {
            return this._deleteAllPolicyResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the policy that you want to delete. <code>PolicyId</code> is returned by
        /// <code>PutPolicy</code> and by <code>ListPolicies</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

    }
}
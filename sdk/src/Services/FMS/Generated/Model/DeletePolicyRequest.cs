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
        /// If <code>True</code>, the request will also delete all web ACLs in this policy. Associated
        /// resources will no longer be protected by web ACLs in this policy.
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
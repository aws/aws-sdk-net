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
    /// Container for the parameters to the GetComplianceDetail operation.
    /// Returns detailed compliance information about the specified member account. Details
    /// include resources that are in and out of compliance with the specified policy. Resources
    /// are considered non-compliant if the specified policy has not been applied to them.
    /// </summary>
    public partial class GetComplianceDetailRequest : AmazonFMSRequest
    {
        private string _memberAccount;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The AWS account that owns the resources that you want to get the details for.
        /// </para>
        /// </summary>
        public string MemberAccount
        {
            get { return this._memberAccount; }
            set { this._memberAccount = value; }
        }

        // Check to see if MemberAccount property is set
        internal bool IsSetMemberAccount()
        {
            return this._memberAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the policy that you want to get the details for. <code>PolicyId</code> is
        /// returned by <code>PutPolicy</code> and by <code>ListPolicies</code>.
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
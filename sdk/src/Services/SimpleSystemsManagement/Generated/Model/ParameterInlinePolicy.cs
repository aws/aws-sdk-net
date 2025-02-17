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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more policies assigned to a parameter.
    /// </summary>
    public partial class ParameterInlinePolicy
    {
        private string _policyStatus;
        private string _policyText;
        private string _policyType;

        /// <summary>
        /// Gets and sets the property PolicyStatus. 
        /// <para>
        /// The status of the policy. Policies report the following statuses: Pending (the policy
        /// hasn't been enforced or applied yet), Finished (the policy was applied), Failed (the
        /// policy wasn't applied), or InProgress (the policy is being applied now). 
        /// </para>
        /// </summary>
        public string PolicyStatus
        {
            get { return this._policyStatus; }
            set { this._policyStatus = value; }
        }

        // Check to see if PolicyStatus property is set
        internal bool IsSetPolicyStatus()
        {
            return this._policyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The JSON text of the policy.
        /// </para>
        /// </summary>
        public string PolicyText
        {
            get { return this._policyText; }
            set { this._policyText = value; }
        }

        // Check to see if PolicyText property is set
        internal bool IsSetPolicyText()
        {
            return this._policyText != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. Parameter Store, a tool in Amazon Web Services Systems Manager,
        /// supports the following policy types: Expiration, ExpirationNotification, and NoChangeNotification.
        /// 
        /// </para>
        /// </summary>
        public string PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}
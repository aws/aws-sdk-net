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
    /// A resource policy helps you to define the IAM entity (for example, an Amazon Web Services
    /// account) that can manage your Systems Manager resources. Currently, <c>OpsItemGroup</c>
    /// is the only resource that supports Systems Manager resource policies. The resource
    /// policy for <c>OpsItemGroup</c> enables Amazon Web Services accounts to view and interact
    /// with OpsCenter operational work items (OpsItems).
    /// </summary>
    public partial class GetResourcePoliciesResponseEntry
    {
        private string _policy;
        private string _policyHash;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A resource policy helps you to define the IAM entity (for example, an Amazon Web Services
        /// account) that can manage your Systems Manager resources. Currently, <c>OpsItemGroup</c>
        /// is the only resource that supports Systems Manager resource policies. The resource
        /// policy for <c>OpsItemGroup</c> enables Amazon Web Services accounts to view and interact
        /// with OpsCenter operational work items (OpsItems).
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
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// ID of the current policy version. The hash helps to prevent a situation where multiple
        /// users attempt to overwrite a policy. You must provide this hash when updating or deleting
        /// a policy.
        /// </para>
        /// </summary>
        public string PolicyHash
        {
            get { return this._policyHash; }
            set { this._policyHash = value; }
        }

        // Check to see if PolicyHash property is set
        internal bool IsSetPolicyHash()
        {
            return this._policyHash != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// A policy ID.
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
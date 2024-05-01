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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePolicy operation.
    /// Permanently deletes an Firewall Manager policy.
    /// </summary>
    public partial class DeletePolicyRequest : AmazonFMSRequest
    {
        private bool? _deleteAllPolicyResources;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property DeleteAllPolicyResources. 
        /// <para>
        /// If <c>True</c>, the request performs cleanup according to the policy type. 
        /// </para>
        ///  
        /// <para>
        /// For WAF and Shield Advanced policies, the cleanup does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Deletes rule groups created by Firewall Manager
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Removes web ACLs from in-scope resources
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes web ACLs that contain no rules or rule groups
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For security group policies, the cleanup does the following for each security group
        /// in the policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disassociates the security group from in-scope resources 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deletes the security group if it was created through Firewall Manager and if it's
        /// no longer associated with any resources through another policy
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// For security group common policies, even if set to <c>False</c>, Firewall Manager
        /// deletes all security groups created by Firewall Manager that aren't associated with
        /// any other resources through another policy.
        /// </para>
        ///  </note> 
        /// <para>
        /// After the cleanup, in-scope resources are no longer protected by web ACLs in this
        /// policy. Protection of out-of-scope resources remains unchanged. Scope is determined
        /// by tags that you create and accounts that you associate with the policy. When creating
        /// the policy, if you specify that only resources in specific accounts or with specific
        /// tags are in scope of the policy, those accounts and resources are handled by the policy.
        /// All others are out of scope. If you don't specify tags or accounts, all resources
        /// are in scope. 
        /// </para>
        /// </summary>
        public bool? DeleteAllPolicyResources
        {
            get { return this._deleteAllPolicyResources; }
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
        /// The ID of the policy that you want to delete. You can retrieve this ID from <c>PutPolicy</c>
        /// and <c>ListPolicies</c>.
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
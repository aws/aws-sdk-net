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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetDelegationRequest operation.
    /// Retrieves information about a specific delegation request.
    /// 
    ///  
    /// <para>
    ///  If a delegation request has no owner or owner account, <c>GetDelegationRequest</c>
    /// for that delegation request can be called by any account. If the owner account is
    /// assigned but there is no owner id, only identities within that owner account can call
    /// <c>GetDelegationRequest</c> for the delegation request. Once the delegation request
    /// is fully owned, the owner of the request gets a default permission to get that delegation
    /// request. For more details, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies-temporary-delegation.html#temporary-delegation-managing-permissions">
    /// Managing Permissions for Delegation Requests</a>. 
    /// </para>
    /// </summary>
    public partial class GetDelegationRequestRequest : AmazonIdentityManagementServiceRequest
    {
        private bool? _delegationPermissionCheck;
        private string _delegationRequestId;

        /// <summary>
        /// Gets and sets the property DelegationPermissionCheck. 
        /// <para>
        /// Specifies whether to perform a permission check for the delegation request.
        /// </para>
        ///  
        /// <para>
        /// If set to true, the <c>GetDelegationRequest</c> API call will start a permission check
        /// process. This process calculates whether the caller has sufficient permissions to
        /// cover the asks from this delegation request.
        /// </para>
        ///  
        /// <para>
        /// Setting this parameter to true does not guarantee an answer in the response. See the
        /// <c>PermissionCheckStatus</c> and the <c>PermissionCheckResult</c> response attributes
        /// for further details.
        /// </para>
        /// </summary>
        public bool DelegationPermissionCheck
        {
            get { return this._delegationPermissionCheck.GetValueOrDefault(); }
            set { this._delegationPermissionCheck = value; }
        }

        // Check to see if DelegationPermissionCheck property is set
        internal bool IsSetDelegationPermissionCheck()
        {
            return this._delegationPermissionCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier of the delegation request to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=128)]
        public string DelegationRequestId
        {
            get { return this._delegationRequestId; }
            set { this._delegationRequestId = value; }
        }

        // Check to see if DelegationRequestId property is set
        internal bool IsSetDelegationRequestId()
        {
            return this._delegationRequestId != null;
        }

    }
}
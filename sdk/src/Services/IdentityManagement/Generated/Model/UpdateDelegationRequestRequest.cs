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
    /// Container for the parameters to the UpdateDelegationRequest operation.
    /// Updates an existing delegation request with additional information. When the delegation
    /// request is updated, it reaches the <c>PENDING_APPROVAL</c> state. 
    /// 
    ///  
    /// <para>
    /// Once a delegation request has an owner, that owner gets a default permission to update
    /// the delegation request. For more details, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies-temporary-delegation.html#temporary-delegation-managing-permissions">
    /// Managing Permissions for Delegation Requests</a>. 
    /// </para>
    /// </summary>
    public partial class UpdateDelegationRequestRequest : AmazonIdentityManagementServiceRequest
    {
        private string _delegationRequestId;
        private string _notes;

        /// <summary>
        /// Gets and sets the property DelegationRequestId. 
        /// <para>
        /// The unique identifier of the delegation request to update.
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

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// Additional notes or comments to add to the delegation request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

    }
}
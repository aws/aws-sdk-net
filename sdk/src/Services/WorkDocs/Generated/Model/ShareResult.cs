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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the share results of a resource.
    /// </summary>
    public partial class ShareResult
    {
        private string _inviteePrincipalId;
        private string _principalId;
        private RoleType _role;
        private string _shareId;
        private ShareStatusType _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property InviteePrincipalId. 
        /// <para>
        /// The ID of the invited user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InviteePrincipalId
        {
            get { return this._inviteePrincipalId; }
            set { this._inviteePrincipalId = value; }
        }

        // Check to see if InviteePrincipalId property is set
        internal bool IsSetInviteePrincipalId()
        {
            return this._inviteePrincipalId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role.
        /// </para>
        /// </summary>
        public RoleType Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ShareId. 
        /// <para>
        /// The ID of the resource that was shared.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ShareId
        {
            get { return this._shareId; }
            set { this._shareId = value; }
        }

        // Check to see if ShareId property is set
        internal bool IsSetShareId()
        {
            return this._shareId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public ShareStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}
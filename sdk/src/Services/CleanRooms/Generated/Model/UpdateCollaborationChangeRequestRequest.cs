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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCollaborationChangeRequest operation.
    /// Updates an existing collaboration change request. This operation allows approval actions
    /// for pending change requests in collaborations (APPROVE, DENY, CANCEL, COMMIT).
    /// 
    ///  
    /// <para>
    /// For change requests without automatic approval, a member in the collaboration can
    /// manually APPROVE or DENY a change request. The collaboration owner can manually CANCEL
    /// or COMMIT a change request.
    /// </para>
    /// </summary>
    public partial class UpdateCollaborationChangeRequestRequest : AmazonCleanRoomsRequest
    {
        private ChangeRequestAction _action;
        private string _changeRequestIdentifier;
        private string _collaborationIdentifier;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on the change request. Valid values include APPROVE (approve
        /// the change), DENY (reject the change), CANCEL (cancel the request), and COMMIT (commit
        /// after the request is approved).
        /// </para>
        ///  
        /// <para>
        /// For change requests without automatic approval, a member in the collaboration can
        /// manually APPROVE or DENY a change request. The collaboration owner can manually CANCEL
        /// or COMMIT a change request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeRequestAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeRequestIdentifier. 
        /// <para>
        /// The unique identifier of the specific change request to be updated within the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ChangeRequestIdentifier
        {
            get { return this._changeRequestIdentifier; }
            set { this._changeRequestIdentifier = value; }
        }

        // Check to see if ChangeRequestIdentifier property is set
        internal bool IsSetChangeRequestIdentifier()
        {
            return this._changeRequestIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The unique identifier of the collaboration that contains the change request to be
        /// updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

    }
}
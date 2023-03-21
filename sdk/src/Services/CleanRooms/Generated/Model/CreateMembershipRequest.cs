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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembership operation.
    /// Creates a membership for a specific collaboration identifier and joins the collaboration.
    /// </summary>
    public partial class CreateMembershipRequest : AmazonCleanRoomsRequest
    {
        private string _collaborationIdentifier;
        private MembershipQueryLogStatus _queryLogStatus;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The unique ID for the associated collaboration.
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

        /// <summary>
        /// Gets and sets the property QueryLogStatus. 
        /// <para>
        /// An indicator as to whether query logging has been enabled or disabled for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipQueryLogStatus QueryLogStatus
        {
            get { return this._queryLogStatus; }
            set { this._queryLogStatus = value; }
        }

        // Check to see if QueryLogStatus property is set
        internal bool IsSetQueryLogStatus()
        {
            return this._queryLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional label that you can assign to a resource when you create it. Each tag consists
        /// of a key and an optional value, both of which you define. When you use tagging, you
        /// can also use tag-based access control in IAM policies to control access to this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
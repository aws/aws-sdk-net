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
    /// Container for the parameters to the UpdateMembership operation.
    /// Updates a membership.
    /// </summary>
    public partial class UpdateMembershipRequest : AmazonCleanRoomsRequest
    {
        private string _membershipIdentifier;
        private MembershipQueryLogStatus _queryLogStatus;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property QueryLogStatus. 
        /// <para>
        /// An indicator as to whether query logging has been enabled or disabled for the collaboration.
        /// </para>
        /// </summary>
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

    }
}
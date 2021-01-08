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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetInvitationsCount operation.
    /// </summary>
    public partial class GetInvitationsCountResponse : AmazonWebServiceResponse
    {
        private long? _invitationsCount;

        /// <summary>
        /// Gets and sets the property InvitationsCount. 
        /// <para>
        /// The total number of invitations that were received by the account, not including the
        /// currently accepted invitation.
        /// </para>
        /// </summary>
        public long InvitationsCount
        {
            get { return this._invitationsCount.GetValueOrDefault(); }
            set { this._invitationsCount = value; }
        }

        // Check to see if InvitationsCount property is set
        internal bool IsSetInvitationsCount()
        {
            return this._invitationsCount.HasValue; 
        }

    }
}
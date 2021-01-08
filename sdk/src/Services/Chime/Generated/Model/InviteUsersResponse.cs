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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the InviteUsers operation.
    /// </summary>
    public partial class InviteUsersResponse : AmazonWebServiceResponse
    {
        private List<Invite> _invites = new List<Invite>();

        /// <summary>
        /// Gets and sets the property Invites. 
        /// <para>
        /// The email invitation details.
        /// </para>
        /// </summary>
        public List<Invite> Invites
        {
            get { return this._invites; }
            set { this._invites = value; }
        }

        // Check to see if Invites property is set
        internal bool IsSetInvites()
        {
            return this._invites != null && this._invites.Count > 0; 
        }

    }
}
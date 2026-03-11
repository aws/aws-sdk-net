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
    /// Container for the parameters to the GetCollaborationChangeRequest operation.
    /// Retrieves detailed information about a specific collaboration change request.
    /// </summary>
    public partial class GetCollaborationChangeRequestRequest : AmazonCleanRoomsRequest
    {
        private string _changeRequestIdentifier;
        private string _collaborationIdentifier;

        /// <summary>
        /// Gets and sets the property ChangeRequestIdentifier. 
        /// <para>
        /// A unique identifier for the change request to retrieve.
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
        /// The identifier of the collaboration that the change request is made against.
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
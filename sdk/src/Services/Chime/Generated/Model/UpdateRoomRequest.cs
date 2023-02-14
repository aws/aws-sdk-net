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
    /// Container for the parameters to the UpdateRoom operation.
    /// Updates room details, such as the room name, for a room in an Amazon Chime Enterprise
    /// account.
    /// </summary>
    public partial class UpdateRoomRequest : AmazonChimeRequest
    {
        private string _accountId;
        private string _name;
        private string _roomId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The room name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoomId. 
        /// <para>
        /// The room ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoomId
        {
            get { return this._roomId; }
            set { this._roomId = value; }
        }

        // Check to see if RoomId property is set
        internal bool IsSetRoomId()
        {
            return this._roomId != null;
        }

    }
}
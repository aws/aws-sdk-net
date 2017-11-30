/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The data of a room.
    /// </summary>
    public partial class RoomData
    {
        private string _description;
        private string _profileArn;
        private string _profileName;
        private string _providerCalendarId;
        private string _roomArn;
        private string _roomName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a room.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The profile ARN of a room.
        /// </para>
        /// </summary>
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The profile name of a room.
        /// </para>
        /// </summary>
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderCalendarId. 
        /// <para>
        /// The provider calendar ARN of a room.
        /// </para>
        /// </summary>
        public string ProviderCalendarId
        {
            get { return this._providerCalendarId; }
            set { this._providerCalendarId = value; }
        }

        // Check to see if ProviderCalendarId property is set
        internal bool IsSetProviderCalendarId()
        {
            return this._providerCalendarId != null;
        }

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The ARN of a room.
        /// </para>
        /// </summary>
        public string RoomArn
        {
            get { return this._roomArn; }
            set { this._roomArn = value; }
        }

        // Check to see if RoomArn property is set
        internal bool IsSetRoomArn()
        {
            return this._roomArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoomName. 
        /// <para>
        /// The name of a room.
        /// </para>
        /// </summary>
        public string RoomName
        {
            get { return this._roomName; }
            set { this._roomName = value; }
        }

        // Check to see if RoomName property is set
        internal bool IsSetRoomName()
        {
            return this._roomName != null;
        }

    }
}
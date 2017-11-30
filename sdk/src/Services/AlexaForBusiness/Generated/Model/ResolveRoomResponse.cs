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
    /// This is the response object from the ResolveRoom operation.
    /// </summary>
    public partial class ResolveRoomResponse : AmazonWebServiceResponse
    {
        private string _roomArn;
        private string _roomName;
        private List<RoomSkillParameter> _roomSkillParameters = new List<RoomSkillParameter>();

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The ARN of the room from which the skill request was invoked.
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
        /// The name of the room from which the skill request was invoked.
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

        /// <summary>
        /// Gets and sets the property RoomSkillParameters. 
        /// <para>
        /// Response to get the room profile request. Required.
        /// </para>
        /// </summary>
        public List<RoomSkillParameter> RoomSkillParameters
        {
            get { return this._roomSkillParameters; }
            set { this._roomSkillParameters = value; }
        }

        // Check to see if RoomSkillParameters property is set
        internal bool IsSetRoomSkillParameters()
        {
            return this._roomSkillParameters != null && this._roomSkillParameters.Count > 0; 
        }

    }
}
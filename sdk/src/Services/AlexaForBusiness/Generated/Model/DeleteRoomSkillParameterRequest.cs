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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRoomSkillParameter operation.
    /// Deletes room skill parameter details by room, skill, and parameter key ID.
    /// </summary>
    public partial class DeleteRoomSkillParameterRequest : AmazonAlexaForBusinessRequest
    {
        private string _parameterKey;
        private string _roomArn;
        private string _skillId;

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The room skill parameter key for which to remove details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ParameterKey
        {
            get { return this._parameterKey; }
            set { this._parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this._parameterKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The ARN of the room from which to remove the room skill parameter details.
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
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The ID of the skill from which to remove the room skill parameter details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SkillId
        {
            get { return this._skillId; }
            set { this._skillId = value; }
        }

        // Check to see if SkillId property is set
        internal bool IsSetSkillId()
        {
            return this._skillId != null;
        }

    }
}
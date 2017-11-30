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
    /// This is the response object from the GetRoomSkillParameter operation.
    /// </summary>
    public partial class GetRoomSkillParameterResponse : AmazonWebServiceResponse
    {
        private RoomSkillParameter _roomSkillParameter;

        /// <summary>
        /// Gets and sets the property RoomSkillParameter. 
        /// <para>
        /// The details of the room skill parameter requested. Required.
        /// </para>
        /// </summary>
        public RoomSkillParameter RoomSkillParameter
        {
            get { return this._roomSkillParameter; }
            set { this._roomSkillParameter = value; }
        }

        // Check to see if RoomSkillParameter property is set
        internal bool IsSetRoomSkillParameter()
        {
            return this._roomSkillParameter != null;
        }

    }
}
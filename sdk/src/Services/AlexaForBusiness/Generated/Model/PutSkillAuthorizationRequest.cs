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
    /// Container for the parameters to the PutSkillAuthorization operation.
    /// Links a user's account to a third-party skill provider. If this API operation is called
    /// by an assumed IAM role, the skill being linked must be a private skill. Also, the
    /// skill must be owned by the AWS account that assumed the IAM role.
    /// </summary>
    public partial class PutSkillAuthorizationRequest : AmazonAlexaForBusinessRequest
    {
        private Dictionary<string, string> _authorizationResult = new Dictionary<string, string>();
        private string _roomArn;
        private string _skillId;

        /// <summary>
        /// Gets and sets the property AuthorizationResult. 
        /// <para>
        /// The authorization result specific to OAUTH code grant output. "Code” must be populated
        /// in the AuthorizationResult map to establish the authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> AuthorizationResult
        {
            get { return this._authorizationResult; }
            set { this._authorizationResult = value; }
        }

        // Check to see if AuthorizationResult property is set
        internal bool IsSetAuthorizationResult()
        {
            return this._authorizationResult != null && this._authorizationResult.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The room that the skill is authorized for.
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
        /// The unique identifier of a skill.
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
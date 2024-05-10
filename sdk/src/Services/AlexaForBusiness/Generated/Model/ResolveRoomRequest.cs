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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the ResolveRoom operation.
    /// Determines the details for the room from which a skill request was invoked. This operation
    /// is used by skill developers.
    /// 
    ///  
    /// <para>
    /// To query ResolveRoom from an Alexa skill, the skill ID needs to be authorized. When
    /// the skill is using an AWS Lambda function, the skill is automatically authorized when
    /// you publish your skill as a private skill to your AWS account. Skills that are hosted
    /// using a custom web service must be manually authorized. To get your skill authorized,
    /// contact AWS Support with your AWS account ID that queries the ResolveRoom API and
    /// skill ID. 
    /// </para>
    /// </summary>
    public partial class ResolveRoomRequest : AmazonAlexaForBusinessRequest
    {
        private string _skillId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The ARN of the skill that was requested. Required.
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

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ARN of the user. Required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}
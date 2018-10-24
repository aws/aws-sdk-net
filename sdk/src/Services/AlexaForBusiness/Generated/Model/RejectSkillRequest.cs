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
    /// Container for the parameters to the RejectSkill operation.
    /// Disassociates a skill from the organization under a user's AWS account. If the skill
    /// is a private skill, it moves to an AcceptStatus of PENDING. Any private or public
    /// skill that is rejected can be added later by calling the ApproveSkill API.
    /// </summary>
    public partial class RejectSkillRequest : AmazonAlexaForBusinessRequest
    {
        private string _skillId;

        /// <summary>
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The unique identifier of the skill.
        /// </para>
        /// </summary>
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
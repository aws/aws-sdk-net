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
    /// The summary of skills.
    /// </summary>
    public partial class SkillSummary
    {
        private string _skillId;
        private string _skillName;
        private bool? _supportsLinking;

        /// <summary>
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The ARN of the skill summary.
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

        /// <summary>
        /// Gets and sets the property SkillName. 
        /// <para>
        /// The name of the skill.
        /// </para>
        /// </summary>
        public string SkillName
        {
            get { return this._skillName; }
            set { this._skillName = value; }
        }

        // Check to see if SkillName property is set
        internal bool IsSetSkillName()
        {
            return this._skillName != null;
        }

        /// <summary>
        /// Gets and sets the property SupportsLinking. 
        /// <para>
        /// Linking support for a skill.
        /// </para>
        /// </summary>
        public bool SupportsLinking
        {
            get { return this._supportsLinking.GetValueOrDefault(); }
            set { this._supportsLinking = value; }
        }

        // Check to see if SupportsLinking property is set
        internal bool IsSetSupportsLinking()
        {
            return this._supportsLinking.HasValue; 
        }

    }
}
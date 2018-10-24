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
    /// The detailed information about an Alexa skill.
    /// </summary>
    public partial class SkillsStoreSkill
    {
        private string _iconUrl;
        private List<string> _sampleUtterances = new List<string>();
        private string _shortDescription;
        private SkillDetails _skillDetails;
        private string _skillId;
        private string _skillName;
        private bool? _supportsLinking;

        /// <summary>
        /// Gets and sets the property IconUrl. 
        /// <para>
        /// The URL where the skill icon resides.
        /// </para>
        /// </summary>
        public string IconUrl
        {
            get { return this._iconUrl; }
            set { this._iconUrl = value; }
        }

        // Check to see if IconUrl property is set
        internal bool IsSetIconUrl()
        {
            return this._iconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// Sample utterances that interact with the skill.
        /// </para>
        /// </summary>
        public List<string> SampleUtterances
        {
            get { return this._sampleUtterances; }
            set { this._sampleUtterances = value; }
        }

        // Check to see if SampleUtterances property is set
        internal bool IsSetSampleUtterances()
        {
            return this._sampleUtterances != null && this._sampleUtterances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// Short description about the skill.
        /// </para>
        /// </summary>
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SkillDetails. 
        /// <para>
        /// Information about the skill.
        /// </para>
        /// </summary>
        public SkillDetails SkillDetails
        {
            get { return this._skillDetails; }
            set { this._skillDetails = value; }
        }

        // Check to see if SkillDetails property is set
        internal bool IsSetSkillDetails()
        {
            return this._skillDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SkillId. 
        /// <para>
        /// The ARN of the skill.
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
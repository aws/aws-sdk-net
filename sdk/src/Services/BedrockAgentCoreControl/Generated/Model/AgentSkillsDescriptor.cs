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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The agent skills descriptor for a registry record. Contains an optional skill markdown
    /// definition in human-readable format and an optional structured skill definition.
    /// </summary>
    public partial class AgentSkillsDescriptor
    {
        private SkillDefinition _skillDefinition;
        private SkillMdDefinition _skillMd;

        /// <summary>
        /// Gets and sets the property SkillDefinition. 
        /// <para>
        /// The structured skill definition with schema version and content.
        /// </para>
        /// </summary>
        public SkillDefinition SkillDefinition
        {
            get { return this._skillDefinition; }
            set { this._skillDefinition = value; }
        }

        // Check to see if SkillDefinition property is set
        internal bool IsSetSkillDefinition()
        {
            return this._skillDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property SkillMd. 
        /// <para>
        /// The optional skill markdown definition describing the agent's skills in a human-readable
        /// format.
        /// </para>
        /// </summary>
        public SkillMdDefinition SkillMd
        {
            get { return this._skillMd; }
            set { this._skillMd = value; }
        }

        // Check to see if SkillMd property is set
        internal bool IsSetSkillMd()
        {
            return this._skillMd != null;
        }

    }
}
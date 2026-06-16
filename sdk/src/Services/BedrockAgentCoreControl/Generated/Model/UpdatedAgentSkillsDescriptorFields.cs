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
    /// Individual agent skills descriptor fields that can be updated independently.
    /// </summary>
    public partial class UpdatedAgentSkillsDescriptorFields
    {
        private UpdatedSkillDefinition _skillDefinition;
        private UpdatedSkillMdDefinition _skillMd;

        /// <summary>
        /// Gets and sets the property SkillDefinition. 
        /// <para>
        /// The updated skill definition.
        /// </para>
        /// </summary>
        public UpdatedSkillDefinition SkillDefinition
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
        /// The updated skill markdown definition.
        /// </para>
        /// </summary>
        public UpdatedSkillMdDefinition SkillMd
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
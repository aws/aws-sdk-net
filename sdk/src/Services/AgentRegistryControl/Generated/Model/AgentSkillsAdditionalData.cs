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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Additional data associated with an agent skills definition descriptor.
    /// </summary>
    public partial class AgentSkillsAdditionalData
    {
        private AgentSkillsMdDescriptor _skillMd;

        /// <summary>
        /// Gets and sets the property SkillMd. 
        /// <para>
        /// The markdown skill content associated with an agent skills definition.
        /// </para>
        /// </summary>
        public AgentSkillsMdDescriptor SkillMd
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
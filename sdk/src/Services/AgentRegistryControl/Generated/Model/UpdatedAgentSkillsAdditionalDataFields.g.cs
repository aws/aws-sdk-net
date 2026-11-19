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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The set of agent skills additional-data fields that can be individually updated.
    /// </summary>
    public partial class UpdatedAgentSkillsAdditionalDataFields
    {
        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The patch for the repository provider field.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsRepositoryProvider RepositoryProvider { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryProvider property is set.
        /// </summary>
        internal bool IsSetRepositoryProvider() => this.RepositoryProvider != null;

        /// <summary>
        /// Gets and sets the property SkillMd. 
        /// <para>
        /// The patch for the agent skills markdown descriptor field.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsMdDescriptor SkillMd { get; set; }

        /// <summary>
        /// Checks to see if the SkillMd property is set.
        /// </summary>
        internal bool IsSetSkillMd() => this.SkillMd != null;

        /// <summary>
        /// Gets and sets the property SkillPackage. 
        /// <para>
        /// The patch for the skill package source field.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsPackageDescriptor SkillPackage { get; set; }

        /// <summary>
        /// Checks to see if the SkillPackage property is set.
        /// </summary>
        internal bool IsSetSkillPackage() => this.SkillPackage != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The patch for the source configuration field.
        /// </para>
        /// </summary>
        public UpdatedAgentSkillsSourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;
    }
}

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
    /// Additional data associated with an agent skills definition descriptor: the skill's
    /// SKILL.md and the source that the registry synchronizes the skill from. A record synchronizes
    /// from one source at most, either <c>skillMd.source</c> for SKILL.md only or <c>skillPackage.source</c>
    /// for the full skill package. When the record has a skill package or a synchronized
    /// source, the registry sets <c>skillMd.data</c> from the SKILL.md in that package or
    /// source.
    /// </summary>
    public partial class AgentSkillsAdditionalData
    {
        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The repository provider of the record's skill source. Set it to <c>GITHUB</c> when
        /// <c>skillMd.source</c> or <c>skillPackage.source</c> is a GitHub folder URL. The registry
        /// treats an <c>https://</c> source as a GitHub source only when this member is set.
        /// Don't set it for an Amazon S3 source.
        /// </para>
        /// </summary>
        public AgentSkillsRepositoryProvider RepositoryProvider { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryProvider property is set.
        /// </summary>
        internal bool IsSetRepositoryProvider() => this.RepositoryProvider != null;

        /// <summary>
        /// Gets and sets the property SkillMd. 
        /// <para>
        /// The markdown skill content associated with an agent skills definition.
        /// </para>
        /// </summary>
        public AgentSkillsMdDescriptor SkillMd { get; set; }

        /// <summary>
        /// Checks to see if the SkillMd property is set.
        /// </summary>
        internal bool IsSetSkillMd() => this.SkillMd != null;

        /// <summary>
        /// Gets and sets the property SkillPackage. 
        /// <para>
        /// The source that the registry synchronizes the full skill package from. The registry
        /// validates and stores the package, sets <c>skillMd.data</c> from its SKILL.md, and
        /// returns the package in the <c>artifact</c> member of <c>GetRegistryRecord</c>. You
        /// can't set both this source and <c>skillMd.source</c>.
        /// </para>
        /// </summary>
        public AgentSkillsPackageDescriptor SkillPackage { get; set; }

        /// <summary>
        /// Checks to see if the SkillPackage property is set.
        /// </summary>
        internal bool IsSetSkillPackage() => this.SkillPackage != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The provider-specific settings of the record's skill source. For an Amazon S3 source,
        /// <c>s3.bucketOwnerAccountId</c> specifies the account that owns the source bucket.
        /// </para>
        /// </summary>
        public AgentSkillsSourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;
    }
}

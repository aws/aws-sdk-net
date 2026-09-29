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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A skill available to the agent.
    /// </summary>
    public partial class HarnessSkill
    {
        /// <summary>
        /// Gets and sets the property AwsSkills. 
        /// <para>
        /// AWS Skills baked into the Harness's underlying Runtime.
        /// </para>
        /// </summary>
        public HarnessSkillAwsSkillsSource AwsSkills { get; set; }

        /// <summary>
        /// Checks to see if the AwsSkills property is set.
        /// </summary>
        internal bool IsSetAwsSkills() => this.AwsSkills != null;

        /// <summary>
        /// Gets and sets the property Git. 
        /// <para>
        /// A git repository containing the skill.
        /// </para>
        /// </summary>
        public HarnessSkillGitSource Git { get; set; }

        /// <summary>
        /// Checks to see if the Git property is set.
        /// </summary>
        internal bool IsSetGit() => this.Git != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The filesystem path to the skill definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// An S3 source containing the skill.
        /// </para>
        /// </summary>
        public HarnessSkillS3Source S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}

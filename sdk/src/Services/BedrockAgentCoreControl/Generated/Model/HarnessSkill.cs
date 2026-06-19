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
    /// A skill available to the agent.
    /// </summary>
    public partial class HarnessSkill
    {
        private HarnessSkillAwsSkillsSource _awsSkills;
        private HarnessSkillGitSource _git;
        private string _path;
        private HarnessSkillS3Source _s3;

        /// <summary>
        /// Gets and sets the property AwsSkills. 
        /// <para>
        /// AWS Skills baked into the harness's underlying Runtime.
        /// </para>
        /// </summary>
        public HarnessSkillAwsSkillsSource AwsSkills
        {
            get { return this._awsSkills; }
            set { this._awsSkills = value; }
        }

        // Check to see if AwsSkills property is set
        internal bool IsSetAwsSkills()
        {
            return this._awsSkills != null;
        }

        /// <summary>
        /// Gets and sets the property Git. 
        /// <para>
        /// A git repository containing the skill.
        /// </para>
        /// </summary>
        public HarnessSkillGitSource Git
        {
            get { return this._git; }
            set { this._git = value; }
        }

        // Check to see if Git property is set
        internal bool IsSetGit()
        {
            return this._git != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The filesystem path to the skill definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// An S3 source containing the skill.
        /// </para>
        /// </summary>
        public HarnessSkillS3Source S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}
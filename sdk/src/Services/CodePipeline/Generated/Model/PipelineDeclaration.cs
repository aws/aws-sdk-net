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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the structure of actions and stages to be performed in the pipeline.
    /// </summary>
    public partial class PipelineDeclaration
    {
        private ArtifactStore _artifactStore;
        private string _name;
        private string _roleArn;
        private List<StageDeclaration> _stages = new List<StageDeclaration>();
        private int? _version;

        /// <summary>
        /// Gets and sets the property ArtifactStore. 
        /// <para>
        /// Represents the context of an action within the stage of a pipeline to a job worker.
        /// 
        /// </para>
        /// </summary>
        public ArtifactStore ArtifactStore
        {
            get { return this._artifactStore; }
            set { this._artifactStore = value; }
        }

        // Check to see if ArtifactStore property is set
        internal bool IsSetArtifactStore()
        {
            return this._artifactStore != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the action to be performed.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for AWS CodePipeline to use to either perform actions
        /// with no actionRoleArn, or to use to assume roles for actions with an actionRoleArn.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// The stage in which to perform the action.
        /// </para>
        /// </summary>
        public List<StageDeclaration> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && this._stages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the pipeline. A new pipeline always has a version number of
        /// 1. This number is automatically incremented when a pipeline is updated.
        /// </para>
        /// </summary>
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}
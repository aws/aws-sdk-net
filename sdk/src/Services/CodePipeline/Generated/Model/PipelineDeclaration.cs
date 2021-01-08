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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private Dictionary<string, ArtifactStore> _artifactStores = new Dictionary<string, ArtifactStore>();
        private string _name;
        private string _roleArn;
        private List<StageDeclaration> _stages = new List<StageDeclaration>();
        private int? _version;

        /// <summary>
        /// Gets and sets the property ArtifactStore. 
        /// <para>
        /// Represents information about the S3 bucket where artifacts are stored for the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ArtifactStores. 
        /// <para>
        /// A mapping of <code>artifactStore</code> objects and their corresponding AWS Regions.
        /// There must be an artifact store for the pipeline Region and for each cross-region
        /// action in the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must include either <code>artifactStore</code> or <code>artifactStores</code>
        /// in your pipeline, but you cannot use both. If you create a cross-region action in
        /// your pipeline, you must use <code>artifactStores</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, ArtifactStore> ArtifactStores
        {
            get { return this._artifactStores; }
            set { this._artifactStores = value; }
        }

        // Check to see if ArtifactStores property is set
        internal bool IsSetArtifactStores()
        {
            return this._artifactStores != null && this._artifactStores.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// with no <code>actionRoleArn</code>, or to use to assume roles for actions with an
        /// <code>actionRoleArn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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
        [AWSProperty(Required=true)]
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
        /// 1. This number is incremented when a pipeline is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
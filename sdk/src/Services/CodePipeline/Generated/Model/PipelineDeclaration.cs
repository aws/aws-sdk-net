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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the structure of actions and stages to be performed in the pipeline.
    /// </summary>
    public partial class PipelineDeclaration
    {
        private ArtifactStore _artifactStore;
        private Dictionary<string, ArtifactStore> _artifactStores = AWSConfigs.InitializeCollections ? new Dictionary<string, ArtifactStore>() : null;
        private ExecutionMode _executionMode;
        private string _name;
        private PipelineType _pipelineType;
        private string _roleArn;
        private List<StageDeclaration> _stages = AWSConfigs.InitializeCollections ? new List<StageDeclaration>() : null;
        private List<PipelineTriggerDeclaration> _triggers = AWSConfigs.InitializeCollections ? new List<PipelineTriggerDeclaration>() : null;
        private List<PipelineVariableDeclaration> _variables = AWSConfigs.InitializeCollections ? new List<PipelineVariableDeclaration>() : null;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ArtifactStore. 
        /// <para>
        /// Represents information about the S3 bucket where artifacts are stored for the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must include either <c>artifactStore</c> or <c>artifactStores</c> in your pipeline,
        /// but you cannot use both. If you create a cross-region action in your pipeline, you
        /// must use <c>artifactStores</c>.
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
        /// A mapping of <c>artifactStore</c> objects and their corresponding Amazon Web Services
        /// Regions. There must be an artifact store for the pipeline Region and for each cross-region
        /// action in the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must include either <c>artifactStore</c> or <c>artifactStores</c> in your pipeline,
        /// but you cannot use both. If you create a cross-region action in your pipeline, you
        /// must use <c>artifactStores</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ArtifactStore> ArtifactStores
        {
            get { return this._artifactStores; }
            set { this._artifactStores = value; }
        }

        // Check to see if ArtifactStores property is set
        internal bool IsSetArtifactStores()
        {
            return this._artifactStores != null && (this._artifactStores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The method that the pipeline will use to handle multiple executions. The default mode
        /// is SUPERSEDED.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode
        {
            get { return this._executionMode; }
            set { this._executionMode = value; }
        }

        // Check to see if ExecutionMode property is set
        internal bool IsSetExecutionMode()
        {
            return this._executionMode != null;
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
        /// Gets and sets the property PipelineType. 
        /// <para>
        /// CodePipeline provides the following pipeline types, which differ in characteristics
        /// and price, so that you can tailor your pipeline features and cost to the needs of
        /// your applications.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// V1 type pipelines have a JSON structure that contains standard pipeline, stage, and
        /// action-level parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// V2 type pipelines have the same structure as a V1 type, along with additional parameters
        /// for release safety and trigger configuration.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Including V2 parameters, such as triggers on Git tags, in the pipeline JSON when creating
        /// or updating a pipeline will result in the pipeline having the V2 type of pipeline
        /// and the associated costs.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about pricing for CodePipeline, see <a href="http://aws.amazon.com/codepipeline/pricing/">Pricing</a>.
        /// </para>
        ///  
        /// <para>
        ///  For information about which type of pipeline to choose, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-types-planning.html">What
        /// type of pipeline is right for me?</a>.
        /// </para>
        /// </summary>
        public PipelineType PipelineType
        {
            get { return this._pipelineType; }
            set { this._pipelineType = value; }
        }

        // Check to see if PipelineType property is set
        internal bool IsSetPipelineType()
        {
            return this._pipelineType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for CodePipeline to use to either perform actions with
        /// no <c>actionRoleArn</c>, or to use to assume roles for actions with an <c>actionRoleArn</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._stages != null && (this._stages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The trigger configuration specifying a type of event, such as Git tags, that starts
        /// the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// When a trigger configuration is specified, default change detection for repository
        /// and branch commits is disabled.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<PipelineTriggerDeclaration> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && (this._triggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A list that defines the pipeline variables for a pipeline resource. Variable names
        /// can have alphanumeric and underscore characters, and the values must match <c>[A-Za-z0-9@\-_]+</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<PipelineVariableDeclaration> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && (this._variables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the pipeline. A new pipeline always has a version number of
        /// 1. This number is incremented when a pipeline is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}
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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents the structure of actions and stages to be performed in the pipeline.
    /// </summary>
    public partial class PipelineDeclaration
    {
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
        public ArtifactStore ArtifactStore { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactStore property is set.
        /// </summary>
        internal bool IsSetArtifactStore() => this.ArtifactStore != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ArtifactStore> ArtifactStores { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ArtifactStore>() : null;

        /// <summary>
        /// Checks to see if the ArtifactStores property is set.
        /// </summary>
        internal bool IsSetArtifactStores() => this.ArtifactStores != null && (this.ArtifactStores.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionMode. 
        /// <para>
        /// The method that the pipeline will use to handle multiple executions. The default mode
        /// is SUPERSEDED.
        /// </para>
        /// </summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMode property is set.
        /// </summary>
        internal bool IsSetExecutionMode() => this.ExecutionMode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PipelineType. 
        /// <para>
        ///  CodePipeline provides the following pipeline types, which differ in characteristics
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
        public PipelineType PipelineType { get; set; }

        /// <summary>
        /// Checks to see if the PipelineType property is set.
        /// </summary>
        internal bool IsSetPipelineType() => this.PipelineType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for CodePipeline to use to either perform actions with
        /// no <c>actionRoleArn</c>, or to use to assume roles for actions with an <c>actionRoleArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// The stage in which to perform the action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<StageDeclaration> Stages { get; set; } = AWSConfigs.InitializeCollections ? new List<StageDeclaration>() : null;

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null && (this.Stages.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<PipelineTriggerDeclaration> Triggers { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineTriggerDeclaration>() : null;

        /// <summary>
        /// Checks to see if the Triggers property is set.
        /// </summary>
        internal bool IsSetTriggers() => this.Triggers != null && (this.Triggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A list that defines the pipeline variables for a pipeline resource. Variable names
        /// can have alphanumeric and underscore characters, and the values must match <c>[A-Za-z0-9@\-_]+</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<PipelineVariableDeclaration> Variables { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineVariableDeclaration>() : null;

        /// <summary>
        /// Checks to see if the Variables property is set.
        /// </summary>
        internal bool IsSetVariables() => this.Variables != null && (this.Variables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the pipeline. A new pipeline always has a version number of
        /// 1. This number is incremented when a pipeline is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}

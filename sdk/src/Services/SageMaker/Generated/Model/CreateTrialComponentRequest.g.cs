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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrialComponent operation. Creates a <i>trial
    /// component</i>, which is a stage of a machine learning <i>trial</i>. A trial is composed
    /// of one or more trial components. A trial component can be used in multiple trials.
    /// <para> Trial components include pre-processing jobs, training jobs, and batch transform
    /// jobs. </para> <para> When you use SageMaker Studio or the SageMaker Python SDK, all
    /// experiments, trials, and trial components are automatically tracked, logged, and indexed.
    /// When you use the Amazon Web Services SDK for Python (Boto), you must use the logging
    /// APIs provided by the SDK. </para> <para> You can add tags to a trial component and
    /// then use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API to search for the tags. </para>
    /// </summary>
    public partial class CreateTrialComponentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the component as displayed. The name doesn't need to be unique. If <c>DisplayName</c>
        /// isn't specified, <c>TrialComponentName</c> is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the component ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The input artifacts for the component. Examples of input artifacts are datasets, algorithms,
        /// hyperparameters, source code, and instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public Dictionary<string, TrialComponentArtifact> InputArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TrialComponentArtifact>() : null;

        /// <summary>
        /// Checks to see if the InputArtifacts property is set.
        /// </summary>
        internal bool IsSetInputArtifacts() => this.InputArtifacts != null && (this.InputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties { get; set; }

        /// <summary>
        /// Checks to see if the MetadataProperties property is set.
        /// </summary>
        internal bool IsSetMetadataProperties() => this.MetadataProperties != null;

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The output artifacts for the component. Examples of output artifacts are metrics,
        /// snapshots, logs, and images.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public Dictionary<string, TrialComponentArtifact> OutputArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TrialComponentArtifact>() : null;

        /// <summary>
        /// Checks to see if the OutputArtifacts property is set.
        /// </summary>
        internal bool IsSetOutputArtifacts() => this.OutputArtifacts != null && (this.OutputArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The hyperparameters for the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public Dictionary<string, TrialComponentParameterValue> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TrialComponentParameterValue>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the component started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TrialComponentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the component. You can use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API to search on the tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the component. The name must be unique in your Amazon Web Services account
        /// and is not case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string TrialComponentName { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentName property is set.
        /// </summary>
        internal bool IsSetTrialComponentName() => this.TrialComponentName != null;
    }
}

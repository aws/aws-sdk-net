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
    /// This is the response object from the DescribeTrialComponent operation.
    /// </summary>
    public partial class DescribeTrialComponentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the trial component.
        /// </para>
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the component was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the component as displayed. If <c>DisplayName</c> isn't specified, <c>TrialComponentName</c>
        /// is displayed.
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
        /// The input artifacts of the component.
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
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who last modified the component.
        /// </para>
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the component was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LineageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lineage group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LineageGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LineageGroupArn property is set.
        /// </summary>
        internal bool IsSetLineageGroupArn() => this.LineageGroupArn != null;

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties { get; set; }

        /// <summary>
        /// Checks to see if the MetadataProperties property is set.
        /// </summary>
        internal bool IsSetMetadataProperties() => this.MetadataProperties != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrialComponentMetricSummary> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<TrialComponentMetricSummary>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The output artifacts of the component.
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
        /// The hyperparameters of the component.
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source and, optionally, the job type.
        /// </para>
        /// </summary>
        public TrialComponentSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// A list of ARNs and, if applicable, job types for multiple sources of an experiment
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrialComponentSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<TrialComponentSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property TrialComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrialComponentArn { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentArn property is set.
        /// </summary>
        internal bool IsSetTrialComponentArn() => this.TrialComponentArn != null;

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string TrialComponentName { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentName property is set.
        /// </summary>
        internal bool IsSetTrialComponentName() => this.TrialComponentName != null;
    }
}

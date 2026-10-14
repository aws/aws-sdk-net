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
    /// Information about a candidate produced by an AutoML training job, including its status,
    /// steps, and other properties.
    /// </summary>
    public partial class AutoMLCandidate
    {
        /// <summary>
        /// Gets and sets the property CandidateName. 
        /// <para>
        /// The name of the candidate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CandidateName { get; set; }

        /// <summary>
        /// Checks to see if the CandidateName property is set.
        /// </summary>
        internal bool IsSetCandidateName() => this.CandidateName != null;

        /// <summary>
        /// Gets and sets the property CandidateProperties. 
        /// <para>
        /// The properties of an AutoML candidate job.
        /// </para>
        /// </summary>
        public CandidateProperties CandidateProperties { get; set; }

        /// <summary>
        /// Checks to see if the CandidateProperties property is set.
        /// </summary>
        internal bool IsSetCandidateProperties() => this.CandidateProperties != null;

        /// <summary>
        /// Gets and sets the property CandidateStatus. 
        /// <para>
        /// The candidate's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CandidateStatus CandidateStatus { get; set; }

        /// <summary>
        /// Checks to see if the CandidateStatus property is set.
        /// </summary>
        internal bool IsSetCandidateStatus() => this.CandidateStatus != null;

        /// <summary>
        /// Gets and sets the property CandidateSteps. 
        /// <para>
        /// Information about the candidate's steps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutoMLCandidateStep> CandidateSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoMLCandidateStep>() : null;

        /// <summary>
        /// Checks to see if the CandidateSteps property is set.
        /// </summary>
        internal bool IsSetCandidateSteps() => this.CandidateSteps != null && (this.CandidateSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FinalAutoMLJobObjectiveMetric.
        /// </summary>
        public FinalAutoMLJobObjectiveMetric FinalAutoMLJobObjectiveMetric { get; set; }

        /// <summary>
        /// Checks to see if the FinalAutoMLJobObjectiveMetric property is set.
        /// </summary>
        internal bool IsSetFinalAutoMLJobObjectiveMetric() => this.FinalAutoMLJobObjectiveMetric != null;

        /// <summary>
        /// Gets and sets the property InferenceContainerDefinitions. 
        /// <para>
        /// The mapping of all supported processing unit (CPU, GPU, etc...) to inference container
        /// definitions for the candidate. This field is populated for the AutoML jobs V2 (for
        /// example, for jobs created by calling <c>CreateAutoMLJobV2</c>) related to image or
        /// text classification problem types only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public Dictionary<string, List<AutoMLContainerDefinition>> InferenceContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<AutoMLContainerDefinition>>() : null;

        /// <summary>
        /// Checks to see if the InferenceContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetInferenceContainerDefinitions() => this.InferenceContainerDefinitions != null && (this.InferenceContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceContainers. 
        /// <para>
        /// Information about the recommended inference container definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<AutoMLContainerDefinition> InferenceContainers { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoMLContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the InferenceContainers property is set.
        /// </summary>
        internal bool IsSetInferenceContainers() => this.InferenceContainers != null && (this.InferenceContainers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectiveStatus. 
        /// <para>
        /// The objective's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectiveStatus ObjectiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the ObjectiveStatus property is set.
        /// </summary>
        internal bool IsSetObjectiveStatus() => this.ObjectiveStatus != null;
    }
}

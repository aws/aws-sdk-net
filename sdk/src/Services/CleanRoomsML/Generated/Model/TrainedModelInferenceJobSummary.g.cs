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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides information about the trained model inference job.
    /// </summary>
    public partial class TrainedModelInferenceJobSummary
    {
        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the trained model inference
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured model algorithm association that
        /// is used for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ConfiguredModelAlgorithmAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredModelAlgorithmAssociationArn property is set.
        /// </summary>
        internal bool IsSetConfiguredModelAlgorithmAssociationArn() => this.ConfiguredModelAlgorithmAssociationArn != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the trained model inference job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// The log status of the trained model inference job.
        /// </para>
        /// </summary>
        public LogsStatus LogsStatus { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatus property is set.
        /// </summary>
        internal bool IsSetLogsStatus() => this.LogsStatus != null;

        /// <summary>
        /// Gets and sets the property LogsStatusDetails. 
        /// <para>
        /// Details about the log status for the trained model inference job.
        /// </para>
        /// </summary>
        public string LogsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatusDetails property is set.
        /// </summary>
        internal bool IsSetLogsStatusDetails() => this.LogsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the membership that contains the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetricsStatus. 
        /// <para>
        /// The metric status of the trained model inference job.
        /// </para>
        /// </summary>
        public MetricsStatus MetricsStatus { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatus property is set.
        /// </summary>
        internal bool IsSetMetricsStatus() => this.MetricsStatus != null;

        /// <summary>
        /// Gets and sets the property MetricsStatusDetails. 
        /// <para>
        /// Details about the metrics status for the trained model inference job.
        /// </para>
        /// </summary>
        public string MetricsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatusDetails property is set.
        /// </summary>
        internal bool IsSetMetricsStatusDetails() => this.MetricsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MlModelInferencePayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying for model inference costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string MlModelInferencePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MlModelInferencePayerAccountId property is set.
        /// </summary>
        internal bool IsSetMlModelInferencePayerAccountId() => this.MlModelInferencePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The output configuration information of the trained model job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainedModelInferenceJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model that is used for the trained model
        /// inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelArn() => this.TrainedModelArn != null;

        /// <summary>
        /// Gets and sets the property TrainedModelInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelInferenceJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelInferenceJobArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelInferenceJobArn() => this.TrainedModelInferenceJobArn != null;

        /// <summary>
        /// Gets and sets the property TrainedModelVersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model that was used for inference in this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string TrainedModelVersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelVersionIdentifier property is set.
        /// </summary>
        internal bool IsSetTrainedModelVersionIdentifier() => this.TrainedModelVersionIdentifier != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model inference job was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}

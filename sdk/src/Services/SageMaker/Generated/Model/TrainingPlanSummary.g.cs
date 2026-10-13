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
    /// Details of the training plan.
    /// 
    ///  
    /// <para>
    /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
    /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class TrainingPlanSummary
    {
        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the upfront fee (e.g., USD).
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The number of whole hours in the total duration for this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 87600)]
        public long? DurationHours { get; set; }

        /// <summary>
        /// Checks to see if the DurationHours property is set.
        /// </summary>
        internal bool IsSetDurationHours() => this.DurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The additional minutes beyond whole hours in the total duration for this training
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 59)]
        public long? DurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationMinutes property is set.
        /// </summary>
        internal bool IsSetDurationMinutes() => this.DurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the training plan.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances currently in use from this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InUseInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseInstanceCount property is set.
        /// </summary>
        internal bool IsSetInUseInstanceCount() => this.InUseInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedCapacitySummaries. 
        /// <para>
        /// A list of reserved capacities associated with this training plan, including details
        /// such as instance types, counts, and availability zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ReservedCapacitySummary> ReservedCapacitySummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedCapacitySummary>() : null;

        /// <summary>
        /// Checks to see if the ReservedCapacitySummaries property is set.
        /// </summary>
        internal bool IsSetReservedCapacitySummaries() => this.ReservedCapacitySummaries != null && (this.ReservedCapacitySummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the training plan.
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
        /// The current status of the training plan (e.g., Pending, Active, Expired). To see the
        /// complete list of status values available for a training plan, refer to the <c>Status</c>
        /// attribute within the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingPlanSummary.html">TrainingPlanSummary</a>
        /// </c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingPlanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional information about the current status of the training
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetResources. 
        /// <para>
        /// The target resources (e.g., training jobs, HyperPod clusters, Endpoints, Studio apps)
        /// that can use this training plan.
        /// </para>
        ///  
        /// <para>
        /// Training plans are specific to their target resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A training plan designed for SageMaker training jobs can only be used to schedule
        /// and run training jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A training plan for HyperPod clusters can be used exclusively to provide compute resources
        /// to a cluster's instance group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A training plan for SageMaker endpoints can be used exclusively to provide compute
        /// resources to SageMaker endpoints for model deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A training plan for Studio apps can be used to launch JupyterLab and Code Editor apps
        /// on reserved training plan capacity.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> TargetResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetResources property is set.
        /// </summary>
        internal bool IsSetTargetResources() => this.TargetResources != null && (this.TargetResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances reserved in this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalUltraServerCount. 
        /// <para>
        /// The total number of UltraServers allocated to this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TotalUltraServerCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalUltraServerCount property is set.
        /// </summary>
        internal bool IsSetTotalUltraServerCount() => this.TotalUltraServerCount.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 2048)]
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;

        /// <summary>
        /// Gets and sets the property TrainingPlanName. 
        /// <para>
        /// The name of the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TrainingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanName property is set.
        /// </summary>
        internal bool IsSetTrainingPlanName() => this.TrainingPlanName != null;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The upfront fee for the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string UpfrontFee { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontFee property is set.
        /// </summary>
        internal bool IsSetUpfrontFee() => this.UpfrontFee != null;
    }
}

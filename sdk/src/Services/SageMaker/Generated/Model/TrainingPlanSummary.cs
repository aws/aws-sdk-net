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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private int? _availableInstanceCount;
        private string _currencyCode;
        private long? _durationHours;
        private long? _durationMinutes;
        private DateTime? _endTime;
        private int? _inUseInstanceCount;
        private List<ReservedCapacitySummary> _reservedCapacitySummaries = AWSConfigs.InitializeCollections ? new List<ReservedCapacitySummary>() : null;
        private DateTime? _startTime;
        private TrainingPlanStatus _status;
        private string _statusMessage;
        private List<string> _targetResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _totalInstanceCount;
        private int? _totalUltraServerCount;
        private string _trainingPlanArn;
        private string _trainingPlanName;
        private string _upfrontFee;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances currently available for use in this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableInstanceCount
        {
            get { return this._availableInstanceCount; }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the upfront fee (e.g., USD).
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The number of whole hours in the total duration for this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=87600)]
        public long? DurationHours
        {
            get { return this._durationHours; }
            set { this._durationHours = value; }
        }

        // Check to see if DurationHours property is set
        internal bool IsSetDurationHours()
        {
            return this._durationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The additional minutes beyond whole hours in the total duration for this training
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=59)]
        public long? DurationMinutes
        {
            get { return this._durationMinutes; }
            set { this._durationMinutes = value; }
        }

        // Check to see if DurationMinutes property is set
        internal bool IsSetDurationMinutes()
        {
            return this._durationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the training plan.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances currently in use from this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InUseInstanceCount
        {
            get { return this._inUseInstanceCount; }
            set { this._inUseInstanceCount = value; }
        }

        // Check to see if InUseInstanceCount property is set
        internal bool IsSetInUseInstanceCount()
        {
            return this._inUseInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedCapacitySummaries. 
        /// <para>
        /// A list of reserved capacities associated with this training plan, including details
        /// such as instance types, counts, and availability zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ReservedCapacitySummary> ReservedCapacitySummaries
        {
            get { return this._reservedCapacitySummaries; }
            set { this._reservedCapacitySummaries = value; }
        }

        // Check to see if ReservedCapacitySummaries property is set
        internal bool IsSetReservedCapacitySummaries()
        {
            return this._reservedCapacitySummaries != null && (this._reservedCapacitySummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the training plan.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the training plan (e.g., Pending, Active, Expired). To see the
        /// complete list of status values available for a training plan, refer to the <c>Status</c>
        /// attribute within the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingPlanSummary.html">TrainingPlanSummary</a>
        /// </c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingPlanStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message providing additional information about the current status of the training
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResources. 
        /// <para>
        /// The target resources (e.g., training jobs, HyperPod clusters) that can use this training
        /// plan.
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
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetResources
        {
            get { return this._targetResources; }
            set { this._targetResources = value; }
        }

        // Check to see if TargetResources property is set
        internal bool IsSetTargetResources()
        {
            return this._targetResources != null && (this._targetResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The total number of instances reserved in this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalInstanceCount
        {
            get { return this._totalInstanceCount; }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalUltraServerCount. 
        /// <para>
        /// The total number of UltraServers allocated to this training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TotalUltraServerCount
        {
            get { return this._totalUltraServerCount; }
            set { this._totalUltraServerCount = value; }
        }

        // Check to see if TotalUltraServerCount property is set
        internal bool IsSetTotalUltraServerCount()
        {
            return this._totalUltraServerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=2048)]
        public string TrainingPlanArn
        {
            get { return this._trainingPlanArn; }
            set { this._trainingPlanArn = value; }
        }

        // Check to see if TrainingPlanArn property is set
        internal bool IsSetTrainingPlanArn()
        {
            return this._trainingPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanName. 
        /// <para>
        /// The name of the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TrainingPlanName
        {
            get { return this._trainingPlanName; }
            set { this._trainingPlanName = value; }
        }

        // Check to see if TrainingPlanName property is set
        internal bool IsSetTrainingPlanName()
        {
            return this._trainingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The upfront fee for the training plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string UpfrontFee
        {
            get { return this._upfrontFee; }
            set { this._upfrontFee = value; }
        }

        // Check to see if UpfrontFee property is set
        internal bool IsSetUpfrontFee()
        {
            return this._upfrontFee != null;
        }

    }
}
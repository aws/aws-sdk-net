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
    /// Container for the parameters to the SearchTrainingPlanOfferings operation.
    /// Searches for available training plan offerings based on specified criteria. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Users search for available plan offerings based on their requirements (e.g., instance
    /// type, count, start time, duration). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// And then, they create a plan that best matches their needs using the ID of the plan
    /// offering they want to use. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how to reserve GPU capacity for your SageMaker training
    /// jobs or SageMaker HyperPod clusters using Amazon SageMaker Training Plan , see <c>
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class SearchTrainingPlanOfferingsRequest : AmazonSageMakerRequest
    {
        private long? _durationHours;
        private DateTime? _endTimeBefore;
        private int? _instanceCount;
        private ReservedCapacityInstanceType _instanceType;
        private DateTime? _startTimeAfter;
        private List<string> _targetResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _ultraServerCount;
        private string _ultraServerType;

        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The desired duration in hours for the training plan offerings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=87600)]
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
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// A filter to search for reserved capacity offerings with an end time before a specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore
        {
            get { return this._endTimeBefore; }
            set { this._endTimeBefore = value; }
        }

        // Check to see if EndTimeBefore property is set
        internal bool IsSetEndTimeBefore()
        {
            return this._endTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances you want to reserve in the training plan offerings. This allows
        /// you to specify the quantity of compute resources needed for your SageMaker training
        /// jobs or SageMaker HyperPod clusters, helping you find reserved capacity offerings
        /// that match your requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance you want to search for in the available training plan offerings.
        /// This field allows you to filter the search results based on the specific compute resources
        /// you require for your SageMaker training jobs or SageMaker HyperPod clusters. When
        /// searching for training plan offerings, specifying the instance type helps you find
        /// Reserved Instances that match your computational needs.
        /// </para>
        /// </summary>
        public ReservedCapacityInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeAfter. 
        /// <para>
        /// A filter to search for training plan offerings with a start time after a specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? StartTimeAfter
        {
            get { return this._startTimeAfter; }
            set { this._startTimeAfter = value; }
        }

        // Check to see if StartTimeAfter property is set
        internal bool IsSetStartTimeAfter()
        {
            return this._startTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetResources. 
        /// <para>
        /// The target resources (e.g., SageMaker Training Jobs, SageMaker HyperPod) to search
        /// for in the offerings.
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
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? UltraServerCount
        {
            get { return this._ultraServerCount; }
            set { this._ultraServerCount = value; }
        }

        // Check to see if UltraServerCount property is set
        internal bool IsSetUltraServerCount()
        {
            return this._ultraServerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer to search for, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string UltraServerType
        {
            get { return this._ultraServerType; }
            set { this._ultraServerType = value; }
        }

        // Check to see if UltraServerType property is set
        internal bool IsSetUltraServerType()
        {
            return this._ultraServerType != null;
        }

    }
}
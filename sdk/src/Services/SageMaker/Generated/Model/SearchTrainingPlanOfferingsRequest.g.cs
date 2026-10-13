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
    /// Container for the parameters to the SearchTrainingPlanOfferings operation. Searches
    /// for available training plan offerings based on specified criteria. <ul> <li> <para>
    /// Users search for available plan offerings based on their requirements (e.g., instance
    /// type, count, start time, duration). </para> </li> <li> <para> And then, they create
    /// a plan that best matches their needs using the ID of the plan offering they want to
    /// use. </para> </li> </ul> <para> For more information about how to reserve GPU capacity
    /// for your SageMaker training jobs or SageMaker HyperPod clusters using Amazon SageMaker
    /// Training Plan , see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>. </para>
    /// </summary>
    public partial class SearchTrainingPlanOfferingsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The desired duration in hours for the training plan offerings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 87600)]
        public long? DurationHours { get; set; }

        /// <summary>
        /// Checks to see if the DurationHours property is set.
        /// </summary>
        internal bool IsSetDurationHours() => this.DurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimeBefore. 
        /// <para>
        /// A filter to search for reserved capacity offerings with an end time before a specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeBefore property is set.
        /// </summary>
        internal bool IsSetEndTimeBefore() => this.EndTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances you want to reserve in the training plan offerings. This allows
        /// you to specify the quantity of compute resources needed for your SageMaker training
        /// jobs or SageMaker HyperPod clusters, helping you find reserved capacity offerings
        /// that match your requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

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
        public ReservedCapacityInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property StartTimeAfter. 
        /// <para>
        /// A filter to search for training plan offerings with a start time after a specified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeAfter property is set.
        /// </summary>
        internal bool IsSetStartTimeAfter() => this.StartTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property TargetResources. 
        /// <para>
        /// The target resources (e.g., SageMaker Training Jobs, SageMaker HyperPod, SageMaker
        /// Endpoints, Studio apps) to search for in the offerings.
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
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of an existing training plan to search for extension
        /// offerings. When specified, the API returns extension offerings that can be used to
        /// extend the specified training plan.
        /// </para>
        /// </summary>
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;

        /// <summary>
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? UltraServerCount { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerCount property is set.
        /// </summary>
        internal bool IsSetUltraServerCount() => this.UltraServerCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer to search for, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UltraServerType { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerType property is set.
        /// </summary>
        internal bool IsSetUltraServerType() => this.UltraServerType != null;
    }
}

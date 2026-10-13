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
    /// Details about a training plan offering.
    /// 
    ///  
    /// <para>
    /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
    /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class TrainingPlanOffering
    {
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
        /// The number of whole hours in the total duration for this training plan offering.
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
        /// plan offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 59)]
        public long? DurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationMinutes property is set.
        /// </summary>
        internal bool IsSetDurationMinutes() => this.DurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedEndTimeBefore. 
        /// <para>
        /// The requested end time that the user specified when searching for the training plan
        /// offering.
        /// </para>
        /// </summary>
        public DateTime? RequestedEndTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the RequestedEndTimeBefore property is set.
        /// </summary>
        internal bool IsSetRequestedEndTimeBefore() => this.RequestedEndTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedStartTimeAfter. 
        /// <para>
        /// The requested start time that the user specified when searching for the training plan
        /// offering.
        /// </para>
        /// </summary>
        public DateTime? RequestedStartTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the RequestedStartTimeAfter property is set.
        /// </summary>
        internal bool IsSetRequestedStartTimeAfter() => this.RequestedStartTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedCapacityOfferings. 
        /// <para>
        /// A list of reserved capacity offerings associated with this training plan offering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<ReservedCapacityOffering> ReservedCapacityOfferings { get; set; } = AWSConfigs.InitializeCollections ? new List<ReservedCapacityOffering>() : null;

        /// <summary>
        /// Checks to see if the ReservedCapacityOfferings property is set.
        /// </summary>
        internal bool IsSetReservedCapacityOfferings() => this.ReservedCapacityOfferings != null && (this.ReservedCapacityOfferings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetResources. 
        /// <para>
        /// The target resources (e.g., SageMaker Training Jobs, SageMaker HyperPod, SageMaker
        /// Endpoints, Studio apps) for this training plan offering.
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
        [AWSProperty(Required = true, Min = 1)]
        public List<string> TargetResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetResources property is set.
        /// </summary>
        internal bool IsSetTargetResources() => this.TargetResources != null && (this.TargetResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingPlanOfferingId. 
        /// <para>
        /// The unique identifier for this training plan offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TrainingPlanOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanOfferingId property is set.
        /// </summary>
        internal bool IsSetTrainingPlanOfferingId() => this.TrainingPlanOfferingId != null;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The upfront fee for this training plan offering.
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

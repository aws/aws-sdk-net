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
    /// Details about an available extension offering for a training plan. Use the offering
    /// ID with the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ExtendTrainingPlan.html">ExtendTrainingPlan</a>
    /// </c> API to extend a training plan.
    /// </summary>
    public partial class TrainingPlanExtensionOffering
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for this extension offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

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
        /// The duration of this extension offering in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4368)]
        public int? DurationHours { get; set; }

        /// <summary>
        /// Checks to see if the DurationHours property is set.
        /// </summary>
        internal bool IsSetDurationHours() => this.DurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of this extension offering.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of this extension offering.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingPlanExtensionOfferingId. 
        /// <para>
        /// The unique identifier for this extension offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrainingPlanExtensionOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanExtensionOfferingId property is set.
        /// </summary>
        internal bool IsSetTrainingPlanExtensionOfferingId() => this.TrainingPlanExtensionOfferingId != null;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The upfront fee for this extension offering.
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

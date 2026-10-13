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
    /// Details about an extension to a training plan, including the offering ID, dates, status,
    /// and cost information.
    /// </summary>
    public partial class TrainingPlanExtension
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the extension.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

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
        /// The duration of the extension in hours.
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
        /// The end date of the extension period.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExtendedAt. 
        /// <para>
        /// The timestamp when the extension was created.
        /// </para>
        /// </summary>
        public DateTime? ExtendedAt { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedAt property is set.
        /// </summary>
        internal bool IsSetExtendedAt() => this.ExtendedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentStatus. 
        /// <para>
        /// The payment processing status of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the PaymentStatus property is set.
        /// </summary>
        internal bool IsSetPaymentStatus() => this.PaymentStatus != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the extension period.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the extension (e.g., Pending, Active, Scheduled, Failed, Expired).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingPlanExtensionOfferingId. 
        /// <para>
        /// The unique identifier of the extension offering that was used to create this extension.
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
        /// The upfront fee for the extension.
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

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
    /// Details about an extension to a training plan, including the offering ID, dates, status,
    /// and cost information.
    /// </summary>
    public partial class TrainingPlanExtension
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _currencyCode;
        private int? _durationHours;
        private DateTime? _endDate;
        private DateTime? _extendedAt;
        private string _paymentStatus;
        private DateTime? _startDate;
        private string _status;
        private string _trainingPlanExtensionOfferingId;
        private string _upfrontFee;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the extension.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
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
        /// The duration of the extension in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4368)]
        public int DurationHours
        {
            get { return this._durationHours.GetValueOrDefault(); }
            set { this._durationHours = value; }
        }

        // Check to see if DurationHours property is set
        internal bool IsSetDurationHours()
        {
            return this._durationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the extension period.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedAt. 
        /// <para>
        /// The timestamp when the extension was created.
        /// </para>
        /// </summary>
        public DateTime ExtendedAt
        {
            get { return this._extendedAt.GetValueOrDefault(); }
            set { this._extendedAt = value; }
        }

        // Check to see if ExtendedAt property is set
        internal bool IsSetExtendedAt()
        {
            return this._extendedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentStatus. 
        /// <para>
        /// The payment processing status of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string PaymentStatus
        {
            get { return this._paymentStatus; }
            set { this._paymentStatus = value; }
        }

        // Check to see if PaymentStatus property is set
        internal bool IsSetPaymentStatus()
        {
            return this._paymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the extension period.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the extension (e.g., Pending, Active, Scheduled, Failed, Expired).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Status
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
        /// Gets and sets the property TrainingPlanExtensionOfferingId. 
        /// <para>
        /// The unique identifier of the extension offering that was used to create this extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrainingPlanExtensionOfferingId
        {
            get { return this._trainingPlanExtensionOfferingId; }
            set { this._trainingPlanExtensionOfferingId = value; }
        }

        // Check to see if TrainingPlanExtensionOfferingId property is set
        internal bool IsSetTrainingPlanExtensionOfferingId()
        {
            return this._trainingPlanExtensionOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The upfront fee for the extension.
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
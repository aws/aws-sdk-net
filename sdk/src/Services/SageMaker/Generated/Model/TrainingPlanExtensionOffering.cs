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
    /// Details about an available extension offering for a training plan. Use the offering
    /// ID with the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ExtendTrainingPlan.html">ExtendTrainingPlan</a>
    /// </c> API to extend a training plan.
    /// </summary>
    public partial class TrainingPlanExtensionOffering
    {
        private string _availabilityZone;
        private string _currencyCode;
        private int? _durationHours;
        private DateTime? _endDate;
        private DateTime? _startDate;
        private string _trainingPlanExtensionOfferingId;
        private string _upfrontFee;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for this extension offering.
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
        /// The duration of this extension offering in hours.
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
        /// The end date of this extension offering.
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of this extension offering.
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
        /// Gets and sets the property TrainingPlanExtensionOfferingId. 
        /// <para>
        /// The unique identifier for this extension offering.
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
        /// The upfront fee for this extension offering.
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
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for DeleteReservationResponse
    /// </summary>
    public partial class DeleteReservationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private int? _count;
        private string _currencyCode;
        private int? _duration;
        private OfferingDurationUnits _durationUnits;
        private string _end;
        private double? _fixedPrice;
        private string _name;
        private string _offeringDescription;
        private string _offeringId;
        private OfferingType _offeringType;
        private string _region;
        private RenewalSettings _renewalSettings;
        private string _reservationId;
        private ReservationResourceSpecification _resourceSpecification;
        private string _start;
        private ReservationState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property Arn. Unique reservation ARN, e.g. 'arn:aws:medialive:us-west-2:123456789012:reservation:1234567'
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Count. Number of reserved resources
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. Currency code for usagePrice and fixedPrice
        /// in ISO-4217 format, e.g. 'USD'
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
        /// Gets and sets the property Duration. Lease duration, e.g. '12'
        /// </summary>
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationUnits. Units for duration, e.g. 'MONTHS'
        /// </summary>
        public OfferingDurationUnits DurationUnits
        {
            get { return this._durationUnits; }
            set { this._durationUnits = value; }
        }

        // Check to see if DurationUnits property is set
        internal bool IsSetDurationUnits()
        {
            return this._durationUnits != null;
        }

        /// <summary>
        /// Gets and sets the property End. Reservation UTC end date and time in ISO-8601 format,
        /// e.g. '2019-03-01T00:00:00'
        /// </summary>
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. One-time charge for each reserved resource,
        /// e.g. '0.0' for a NO_UPFRONT offering
        /// </summary>
        public double? FixedPrice
        {
            get { return this._fixedPrice; }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. User specified reservation name
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingDescription. Offering description, e.g. 'HD AVC
        /// output at 10-20 Mbps, 30 fps, and standard VQ in US West (Oregon)'
        /// </summary>
        public string OfferingDescription
        {
            get { return this._offeringDescription; }
            set { this._offeringDescription = value; }
        }

        // Check to see if OfferingDescription property is set
        internal bool IsSetOfferingDescription()
        {
            return this._offeringDescription != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. Unique offering ID, e.g. '87654321'
        /// </summary>
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingType. Offering type, e.g. 'NO_UPFRONT'
        /// </summary>
        public OfferingType OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property Region. AWS region, e.g. 'us-west-2'
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalSettings. Renewal settings for the reservation
        /// </summary>
        public RenewalSettings RenewalSettings
        {
            get { return this._renewalSettings; }
            set { this._renewalSettings = value; }
        }

        // Check to see if RenewalSettings property is set
        internal bool IsSetRenewalSettings()
        {
            return this._renewalSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationId. Unique reservation ID, e.g. '1234567'
        /// </summary>
        public string ReservationId
        {
            get { return this._reservationId; }
            set { this._reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this._reservationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. Resource configuration details
        /// </summary>
        public ReservationResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Start. Reservation UTC start date and time in ISO-8601
        /// format, e.g. '2018-03-01T00:00:00'
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

        /// <summary>
        /// Gets and sets the property State. Current state of reservation, e.g. 'ACTIVE'
        /// </summary>
        public ReservationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. Recurring usage charge for each reserved resource,
        /// e.g. '157.0'
        /// </summary>
        public double? UsagePrice
        {
            get { return this._usagePrice; }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}
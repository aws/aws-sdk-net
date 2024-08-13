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
    /// Placeholder documentation for DescribeOfferingResponse
    /// </summary>
    public partial class DescribeOfferingResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _currencyCode;
        private int? _duration;
        private OfferingDurationUnits _durationUnits;
        private double? _fixedPrice;
        private string _offeringDescription;
        private string _offeringId;
        private OfferingType _offeringType;
        private string _region;
        private ReservationResourceSpecification _resourceSpecification;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property Arn. Unique offering ARN, e.g. 'arn:aws:medialive:us-west-2:123456789012:offering:87654321'
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
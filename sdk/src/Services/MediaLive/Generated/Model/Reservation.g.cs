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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Reserved resources available to use
    /// </summary>
    public partial class Reservation
    {
        /// <summary>
        /// Gets and sets the property Arn. Unique reservation ARN, e.g. 'arn:aws:medialive:us-west-2:123456789012:reservation:1234567'
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Count. Number of reserved resources
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. Currency code for usagePrice and fixedPrice
        /// in ISO-4217 format, e.g. 'USD'
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. Lease duration, e.g. '12'
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DurationUnits. Units for duration, e.g. 'MONTHS'
        /// </summary>
        public OfferingDurationUnits DurationUnits { get; set; }

        /// <summary>
        /// Checks to see if the DurationUnits property is set.
        /// </summary>
        internal bool IsSetDurationUnits() => this.DurationUnits != null;

        /// <summary>
        /// Gets and sets the property End. Reservation UTC end date and time in ISO-8601 format,
        /// e.g. '2019-03-01T00:00:00'
        /// </summary>
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property FixedPrice. One-time charge for each reserved resource,
        /// e.g. '0.0' for a NO_UPFRONT offering
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property Name. User specified reservation name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OfferingDescription. Offering description, e.g. 'HD AVC
        /// output at 10-20 Mbps, 30 fps, and standard VQ in US West (Oregon)'
        /// </summary>
        public string OfferingDescription { get; set; }

        /// <summary>
        /// Checks to see if the OfferingDescription property is set.
        /// </summary>
        internal bool IsSetOfferingDescription() => this.OfferingDescription != null;

        /// <summary>
        /// Gets and sets the property OfferingId. Unique offering ID, e.g. '87654321'
        /// </summary>
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property OfferingType. Offering type, e.g. 'NO_UPFRONT'
        /// </summary>
        public OfferingType OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property Region. AWS region, e.g. 'us-west-2'
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RenewalSettings. Renewal settings for the reservation
        /// </summary>
        public RenewalSettings RenewalSettings { get; set; }

        /// <summary>
        /// Checks to see if the RenewalSettings property is set.
        /// </summary>
        internal bool IsSetRenewalSettings() => this.RenewalSettings != null;

        /// <summary>
        /// Gets and sets the property ReservationId. Unique reservation ID, e.g. '1234567'
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// Checks to see if the ReservationId property is set.
        /// </summary>
        internal bool IsSetReservationId() => this.ReservationId != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. Resource configuration details
        /// </summary>
        public ReservationResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;

        /// <summary>
        /// Gets and sets the property Start. Reservation UTC start date and time in ISO-8601
        /// format, e.g. '2018-03-01T00:00:00'
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;

        /// <summary>
        /// Gets and sets the property State. Current state of reservation, e.g. 'ACTIVE'
        /// </summary>
        public ReservationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsagePrice. Recurring usage charge for each reserved resource,
        /// e.g. '157.0'
        /// </summary>
        public double? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}

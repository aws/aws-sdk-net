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
    /// This is the response object from the DescribeOffering operation.
    /// </summary>
    public partial class DescribeOfferingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. Unique offering ARN, e.g. 'arn:aws:medialive:us-west-2:123456789012:offering:87654321'
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Gets and sets the property FixedPrice. One-time charge for each reserved resource,
        /// e.g. '0.0' for a NO_UPFRONT offering
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

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
        /// Gets and sets the property ResourceSpecification. Resource configuration details
        /// </summary>
        public ReservationResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;

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

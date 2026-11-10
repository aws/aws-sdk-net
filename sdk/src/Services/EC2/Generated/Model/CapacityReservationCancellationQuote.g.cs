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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Capacity Reservation cancellation quote, which provides the cancellation
    /// terms for cancelling a future-dated Capacity Reservation during its commitment duration.
    /// </summary>
    public partial class CapacityReservationCancellationQuote
    {
        /// <summary>
        /// Gets and sets the property CancellationTerms. 
        /// <para>
        /// The cancellation terms associated with the quote, including the fee type and charge
        /// details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CancellationTerms> CancellationTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<CancellationTerms>() : null;

        /// <summary>
        /// Checks to see if the CancellationTerms property is set.
        /// </summary>
        internal bool IsSetCancellationTerms() => this.CancellationTerms != null && (this.CancellationTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationCancellationQuoteId. 
        /// <para>
        /// The ID of the cancellation quote.
        /// </para>
        /// </summary>
        public string CapacityReservationCancellationQuoteId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationCancellationQuoteId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationCancellationQuoteId() => this.CapacityReservationCancellationQuoteId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation associated with the cancellation quote.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the cancellation quote was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// The current configuration of the Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentConfiguration() => this.CurrentConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time at which the cancellation quote expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property QuoteState. 
        /// <para>
        /// The state of the cancellation quote. Possible values include <c>pending</c>, <c>active</c>,
        /// and <c>expired</c>.
        /// </para>
        /// </summary>
        public CapacityReservationCancellationQuoteState QuoteState { get; set; }

        /// <summary>
        /// Checks to see if the QuoteState property is set.
        /// </summary>
        internal bool IsSetQuoteState() => this.QuoteState != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the cancellation quote.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

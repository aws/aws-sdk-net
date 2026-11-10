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
    /// Describes a Capacity Reservation modification quote, which provides the terms for
    /// changing the start date or the commitment of a future-dated Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationModificationQuote
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation associated with the modification quote.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationModificationQuoteId. 
        /// <para>
        /// The ID of the modification quote.
        /// </para>
        /// </summary>
        public string CapacityReservationModificationQuoteId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationModificationQuoteId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationModificationQuoteId() => this.CapacityReservationModificationQuoteId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the modification quote was created.
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
        /// The configuration that the Capacity Reservation has at the time the quote was generated.
        /// </para>
        /// </summary>
        public ModificationQuoteCurrentConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentConfiguration property is set.
        /// </summary>
        internal bool IsSetCurrentConfiguration() => this.CurrentConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time at which the modification quote expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModificationTerms. 
        /// <para>
        /// The terms of the modification, including the configuration that the Capacity Reservation
        /// will have if you accept them by using <c>ModifyCapacityReservation</c>.
        /// </para>
        /// </summary>
        public ModificationTerms ModificationTerms { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTerms property is set.
        /// </summary>
        internal bool IsSetModificationTerms() => this.ModificationTerms != null;

        /// <summary>
        /// Gets and sets the property QuoteState. 
        /// <para>
        /// The state of the modification quote itself. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The quote can still be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The quote can no longer be used. A quote becomes <c>expired</c>
        /// at its <c>expirationTime</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationModificationQuoteState QuoteState { get; set; }

        /// <summary>
        /// Checks to see if the QuoteState property is set.
        /// </summary>
        internal bool IsSetQuoteState() => this.QuoteState != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the modification quote.
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

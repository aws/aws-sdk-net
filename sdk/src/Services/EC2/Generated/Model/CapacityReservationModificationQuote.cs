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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _capacityReservationId;
        private string _capacityReservationModificationQuoteId;
        private DateTime? _createTime;
        private ModificationQuoteCurrentConfiguration _currentConfiguration;
        private DateTime? _expirationTime;
        private ModificationTerms _modificationTerms;
        private CapacityReservationModificationQuoteState _quoteState;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation associated with the modification quote.
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationModificationQuoteId. 
        /// <para>
        /// The ID of the modification quote.
        /// </para>
        /// </summary>
        public string CapacityReservationModificationQuoteId
        {
            get { return this._capacityReservationModificationQuoteId; }
            set { this._capacityReservationModificationQuoteId = value; }
        }

        // Check to see if CapacityReservationModificationQuoteId property is set
        internal bool IsSetCapacityReservationModificationQuoteId()
        {
            return this._capacityReservationModificationQuoteId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the modification quote was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// The configuration that the Capacity Reservation has at the time the quote was generated.
        /// </para>
        /// </summary>
        public ModificationQuoteCurrentConfiguration CurrentConfiguration
        {
            get { return this._currentConfiguration; }
            set { this._currentConfiguration = value; }
        }

        // Check to see if CurrentConfiguration property is set
        internal bool IsSetCurrentConfiguration()
        {
            return this._currentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time at which the modification quote expires.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationTerms. 
        /// <para>
        /// The terms of the modification, including the configuration that the Capacity Reservation
        /// will have if you accept them by using <c>ModifyCapacityReservation</c>.
        /// </para>
        /// </summary>
        public ModificationTerms ModificationTerms
        {
            get { return this._modificationTerms; }
            set { this._modificationTerms = value; }
        }

        // Check to see if ModificationTerms property is set
        internal bool IsSetModificationTerms()
        {
            return this._modificationTerms != null;
        }

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
        public CapacityReservationModificationQuoteState QuoteState
        {
            get { return this._quoteState; }
            set { this._quoteState = value; }
        }

        // Check to see if QuoteState property is set
        internal bool IsSetQuoteState()
        {
            return this._quoteState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the modification quote.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
    /// Describes a Capacity Reservation cancellation quote, which provides the cancellation
    /// terms for cancelling a future-dated Capacity Reservation during its commitment duration.
    /// </summary>
    public partial class CapacityReservationCancellationQuote
    {
        private List<CancellationTerms> _cancellationTerms = AWSConfigs.InitializeCollections ? new List<CancellationTerms>() : null;
        private string _capacityReservationCancellationQuoteId;
        private string _capacityReservationId;
        private DateTime? _createTime;
        private CapacityReservationConfiguration _currentConfiguration;
        private DateTime? _expirationTime;
        private CapacityReservationCancellationQuoteState _quoteState;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CancellationTerms. 
        /// <para>
        /// The cancellation terms associated with the quote, including the fee type and charge
        /// details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CancellationTerms> CancellationTerms
        {
            get { return this._cancellationTerms; }
            set { this._cancellationTerms = value; }
        }

        // Check to see if CancellationTerms property is set
        internal bool IsSetCancellationTerms()
        {
            return this._cancellationTerms != null && (this._cancellationTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationCancellationQuoteId. 
        /// <para>
        /// The ID of the cancellation quote.
        /// </para>
        /// </summary>
        public string CapacityReservationCancellationQuoteId
        {
            get { return this._capacityReservationCancellationQuoteId; }
            set { this._capacityReservationCancellationQuoteId = value; }
        }

        // Check to see if CapacityReservationCancellationQuoteId property is set
        internal bool IsSetCapacityReservationCancellationQuoteId()
        {
            return this._capacityReservationCancellationQuoteId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation associated with the cancellation quote.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time at which the cancellation quote was created.
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
        /// The current configuration of the Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationConfiguration CurrentConfiguration
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
        /// The date and time at which the cancellation quote expires.
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
        /// Gets and sets the property QuoteState. 
        /// <para>
        /// The state of the cancellation quote. Possible values include <c>pending</c>, <c>active</c>,
        /// and <c>expired</c>.
        /// </para>
        /// </summary>
        public CapacityReservationCancellationQuoteState QuoteState
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
        /// The tags assigned to the cancellation quote.
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
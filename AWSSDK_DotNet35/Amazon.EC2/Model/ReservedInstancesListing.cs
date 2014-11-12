/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Reserved Instance listing.
    /// </summary>
    public partial class ReservedInstancesListing
    {
        private string _clientToken;
        private DateTime? _createDate;
        private List<InstanceCount> _instanceCounts = new List<InstanceCount>();
        private List<PriceSchedule> _priceSchedules = new List<PriceSchedule>();
        private string _reservedInstancesId;
        private string _reservedInstancesListingId;
        private ListingStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = new List<Tag>();
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token you provided when you created the listing.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The time the listing was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCounts. 
        /// <para>
        /// The number of instances in this state.
        /// </para>
        /// </summary>
        public List<InstanceCount> InstanceCounts
        {
            get { return this._instanceCounts; }
            set { this._instanceCounts = value; }
        }

        // Check to see if InstanceCounts property is set
        internal bool IsSetInstanceCounts()
        {
            return this._instanceCounts != null && this._instanceCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PriceSchedules. 
        /// <para>
        /// The price of the Reserved Instance listing.
        /// </para>
        /// </summary>
        public List<PriceSchedule> PriceSchedules
        {
            get { return this._priceSchedules; }
            set { this._priceSchedules = value; }
        }

        // Check to see if PriceSchedules property is set
        internal bool IsSetPriceSchedules()
        {
            return this._priceSchedules != null && this._priceSchedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesId. 
        /// <para>
        /// The ID of the Reserved Instance.
        /// </para>
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this._reservedInstancesId; }
            set { this._reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this._reservedInstancesId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesListingId. 
        /// <para>
        /// The ID of the Reserved Instance listing.
        /// </para>
        /// </summary>
        public string ReservedInstancesListingId
        {
            get { return this._reservedInstancesListingId; }
            set { this._reservedInstancesListingId = value; }
        }

        // Check to see if ReservedInstancesListingId property is set
        internal bool IsSetReservedInstancesListingId()
        {
            return this._reservedInstancesListingId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Reserved Instance listing.
        /// </para>
        /// </summary>
        public ListingStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The reason for the current status of the Reserved Instance listing. The response can
        /// be blank.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the resource.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The last modified timestamp of the listing.
        /// </para>
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this._updateDate.GetValueOrDefault(); }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}
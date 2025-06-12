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
    /// Describes a Reserved Instance listing.
    /// </summary>
    public partial class ReservedInstancesListing
    {
        private string _clientToken;
        private DateTime? _createDate;
        private List<InstanceCount> _instanceCounts = AWSConfigs.InitializeCollections ? new List<InstanceCount>() : null;
        private List<PriceSchedule> _priceSchedules = AWSConfigs.InitializeCollections ? new List<PriceSchedule>() : null;
        private string _reservedInstancesId;
        private string _reservedInstancesListingId;
        private ListingStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive key supplied by the client to ensure that the request is
        /// idempotent. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        public DateTime? CreateDate
        {
            get { return this._createDate; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceCount> InstanceCounts
        {
            get { return this._instanceCounts; }
            set { this._instanceCounts = value; }
        }

        // Check to see if InstanceCounts property is set
        internal bool IsSetInstanceCounts()
        {
            return this._instanceCounts != null && (this._instanceCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PriceSchedules. 
        /// <para>
        /// The price of the Reserved Instance listing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PriceSchedule> PriceSchedules
        {
            get { return this._priceSchedules; }
            set { this._priceSchedules = value; }
        }

        // Check to see if PriceSchedules property is set
        internal bool IsSetPriceSchedules()
        {
            return this._priceSchedules != null && (this._priceSchedules.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// The last modified timestamp of the listing.
        /// </para>
        /// </summary>
        public DateTime? UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}
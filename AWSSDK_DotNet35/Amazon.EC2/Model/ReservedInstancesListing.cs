/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>Reserved Instances Listing
    /// </summary>
    public class ReservedInstancesListing
    {
        
        private string reservedInstancesListingId;
        private string reservedInstancesId;
        private DateTime? createDate;
        private DateTime? updateDate;
        private ListingStatus status;
        private string statusMessage;
        private List<InstanceCount> instanceCounts = new List<InstanceCount>();
        private List<PriceSchedule> priceSchedules = new List<PriceSchedule>();
        private List<Tag> tags = new List<Tag>();
        private string clientToken;

        public string ReservedInstancesListingId
        {
            get { return this.reservedInstancesListingId; }
            set { this.reservedInstancesListingId = value; }
        }

        // Check to see if ReservedInstancesListingId property is set
        internal bool IsSetReservedInstancesListingId()
        {
            return this.reservedInstancesListingId != null;
        }
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesId; }
            set { this.reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesId != null;
        }
        public DateTime CreateDate
        {
            get { return this.createDate ?? default(DateTime); }
            set { this.createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDate.HasValue;
        }
        public DateTime UpdateDate
        {
            get { return this.updateDate ?? default(DateTime); }
            set { this.updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this.updateDate.HasValue;
        }
        public ListingStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;
        }
        public List<InstanceCount> InstanceCounts
        {
            get { return this.instanceCounts; }
            set { this.instanceCounts = value; }
        }

        // Check to see if InstanceCounts property is set
        internal bool IsSetInstanceCounts()
        {
            return this.instanceCounts.Count > 0;
        }
        public List<PriceSchedule> PriceSchedules
        {
            get { return this.priceSchedules; }
            set { this.priceSchedules = value; }
        }

        // Check to see if PriceSchedules property is set
        internal bool IsSetPriceSchedules()
        {
            return this.priceSchedules.Count > 0;
        }
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }
    }
}

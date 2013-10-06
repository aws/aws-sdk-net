/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Reserved Instances listing
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstancesListing
    {
        private string reservedInstancesListingIdField;
        private string reservedInstancesIdField;
        private string createDateField;
        private string updateDateField;
        private string statusField;
        private string statusMessageField;
        private List<InstanceCounts> instanceCountsField;
        private List<PriceSchedule> priceSchedulesField;
        private List<Tag> tagsField;
        private string clientTokenField;

        /// <summary>
        /// The ID of the Reserved Instance Listing 
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesListingId")]
        public string ReservedInstancesListingId
        {
            get { return this.reservedInstancesListingIdField; }
            set { this.reservedInstancesListingIdField = value; }
        }

        /// <summary>
        /// Checks if the ReservedInstancesListingId property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetReservedInstancesListingId()
        {
            return !string.IsNullOrEmpty(this.reservedInstancesListingIdField);
        }

        /// <summary>
        /// The ID of the Reserved Instance 
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesIdField; }
            set { this.reservedInstancesIdField = value; }
        }

        /// <summary>
        /// Checks if the ReservedInstancesId property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetReservedInstancesId()
        {
            return !string.IsNullOrEmpty(this.reservedInstancesIdField);
        }

        /// <summary>
        /// The time the listing was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateDate")]
        public string CreateDate
        {
            get { return this.createDateField; }
            set { this.createDateField = value; }
        }

        /// <summary>
        /// Checks if the CreateDate property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetCreateDate()
        {
            return !string.IsNullOrEmpty(this.createDateField);
        }

        /// <summary>
        /// The last-modified timestamp of the listing.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpdateDate")]
        public string UpdateDate
        {
            get { return this.updateDateField; }
            set { this.updateDateField = value; }
        }

        /// <summary>
        /// Checks if the UpdateDate property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetUpdateDate()
        {
            return !string.IsNullOrEmpty(this.updateDateField);
        }

        /// <summary>
        /// The status of the listing.
        /// </summary>
        /// <remarks>Possible values = "active", "pending", "cancelled" or "closed"</remarks>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Checks if the Status property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.statusField);
        }

        /// <summary>
        /// The reason for current state (can be blank)
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField; }
            set { this.statusMessageField = value; }
        }

        /// <summary>
        /// Checks if the StatusMessage property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetStatusMessage()
        {
            return !string.IsNullOrEmpty(this.statusMessageField);
        }

        /// <summary>
        /// Number of instances in the state specified by the Status property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCounts")]
        public List<InstanceCounts> InstanceCounts
        {
            get
            {
                if (this.instanceCountsField == null)
                    this.instanceCountsField = new List<InstanceCounts>();

                return this.instanceCountsField;
            }
            set { this.instanceCountsField = value; }
        }

        /// <summary>
        /// Checks if the InstanceCounts property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetInstanceCounts()
        {
            return (this.InstanceCounts.Count > 0);
        }

        /// <summary>
        /// Price of the Reserved Instance listing.
        /// </summary>
        [XmlElementAttribute(ElementName = "PriceSchedules")]
        public List<PriceSchedule> PriceSchedules
        {
            get
            {
                if (this.priceSchedulesField == null)
                    this.priceSchedulesField = new List<PriceSchedule>();

                return this.priceSchedulesField;
            }
            set { this.priceSchedulesField = value; }
        }

        /// <summary>
        /// Checks if the PriceSchedules property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetPriceSchedules()
        {
            return (this.PriceSchedules.Count > 0);
        }

        /// <summary>
        /// A list of tags for the Image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagsField == null)
                    this.tagsField = new List<Tag>();

                return this.tagsField;
            }
            set { this.tagsField = value; }
        }

        /// <summary>
        /// Checks if the Tag property is set
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetTag()
        {
            return (this.Tag.Count > 0);
        }
        
        /// <summary>
        /// The idempotency token you provided when you created the listing.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Checks if the ClientToken property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetClientToken()
        {
            return !string.IsNullOrEmpty(this.clientTokenField);
        }
    }
}

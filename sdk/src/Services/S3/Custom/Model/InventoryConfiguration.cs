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


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for MetricsConfiguration
    /// </summary>
    public class InventoryConfiguration
    {
        private InventoryDestination inventoryDestination;
        private bool isEnabled;
        private InventoryFilter inventoryFilter;
        private string inventoryId;
        private InventoryIncludedObjectVersions inventoryIncludedObjectVersions;
        private List<InventoryOptionalField> inventoryOptionalFields = new List<InventoryOptionalField>();
        private InventorySchedule inventorySchedule;

        /// <summary>
        /// Contains information about where to publish the inventory results.
        /// </summary>
        public InventoryDestination Destination
        {
            get { return this.inventoryDestination; }
            set { this.inventoryDestination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this.inventoryDestination != null;
        }

        /// <summary>
        /// Specifies whether the inventory is enabled or disabled.
        /// </summary>
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { this.isEnabled = value; }
        }

        /// <summary>
        /// Specifies an inventory filter. The inventory only includes objects that meet the filter's criteria.
        /// </summary>
        public InventoryFilter InventoryFilter
        {
            get { return this.inventoryFilter; }
            set { this.inventoryFilter = value; }
        }

        // Check to see if InventoryFilter property is set
        internal bool IsSetInventoryFilter()
        {
            return this.inventoryFilter != null;
        }
        /// <summary>
        /// The ID used to identify the inventory configuration.
        /// </summary>
        public string InventoryId
        {
            get { return this.inventoryId; }
            set { this.inventoryId = value; }
        }

        // Check to see if InventoryId property is set
        internal bool IsSetInventoryId()
        {
            return !(string.IsNullOrEmpty(this.inventoryId));
        }

        /// <summary>
        /// Specifies which object version(s) to included in the inventory results.
        /// </summary>
        public InventoryIncludedObjectVersions IncludedObjectVersions
        {
            get { return this.inventoryIncludedObjectVersions; }
            set { this.inventoryIncludedObjectVersions = value; }
        }

        // Check to see if InventoryIncludedObjectVersions property is set
        internal bool IsSetIncludedObjectVersions()
        {
            return this.inventoryIncludedObjectVersions != null;
        }

        /// <summary>
        /// Contains the optional fields that are included in the inventory results.
        /// </summary>
        public List<InventoryOptionalField> InventoryOptionalFields
        {
            get { return this.inventoryOptionalFields; }
            set { this.inventoryOptionalFields = value; }
        }

        // Check to see if InventoryOptionalFields property is set
        internal bool IsSetInventoryOptionalFields()
        {
            return this.inventoryOptionalFields.Count > 0;
        }

        /// <summary>
        /// Specifies the schedule for generating inventory results.
        /// </summary>
        public InventorySchedule Schedule
        {
            get { return this.inventorySchedule; }
            set { this.inventorySchedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this.inventorySchedule != null;
        }
    }
}

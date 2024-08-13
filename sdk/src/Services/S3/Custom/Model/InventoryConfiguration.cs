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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the inventory configuration for an Amazon S3 bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketGETInventoryConfig.html">GET
    /// Bucket inventory</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public class InventoryConfiguration
    {
        private InventoryDestination inventoryDestination;
        private InventoryFilter inventoryFilter;
        private string inventoryId;
        private bool? isEnabled;
        private InventoryIncludedObjectVersions inventoryIncludedObjectVersions;
        private List<InventoryOptionalField> inventoryOptionalFields = AWSConfigs.InitializeCollections ? new List<InventoryOptionalField>() : null;
        private InventorySchedule inventorySchedule;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Contains information about where to publish the inventory results.
        /// </para>
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
        /// Gets and sets the property IncludedObjectVersions. 
        /// <para>
        /// Object versions to include in the inventory list. If set to <code>All</code>, the
        /// list includes all the object versions, which adds the version-related fields <code>VersionId</code>,
        /// <code>IsLatest</code>, and <code>DeleteMarker</code> to the list. If set to <code>Current</code>,
        /// the list does not contain these version-related fields.
        /// </para>
        /// </summary>
        public InventoryIncludedObjectVersions IncludedObjectVersions
        {
            get { return this.inventoryIncludedObjectVersions; }
            set { this.inventoryIncludedObjectVersions = value; }
        }

        // Check to see if IncludedObjectVersions property is set
        internal bool IsSetIncludedObjectVersions()
        {
            return this.inventoryIncludedObjectVersions != null;
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Specifies whether the inventory is enabled or disabled. If set to <code>True</code>,
        /// an inventory list is generated. If set to <code>False</code>, no inventory list is
        /// generated.
        /// </para>
        /// </summary>
        public bool? IsEnabled
        {
            get { return this.isEnabled; }
            set { this.isEnabled = value; }
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
            return this.inventoryOptionalFields != null && (this.inventoryOptionalFields.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Specifies the schedule for generating inventory results.
        /// </para>
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

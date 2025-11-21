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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the S3 Inventory configuration for an Amazon S3 bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketGETInventoryConfig.html">GET
    /// Bucket inventory</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public partial class InventoryConfiguration
    {
        private InventoryDestination _destination;
        private InventoryIncludedObjectVersions _includedObjectVersions;
        private InventoryFilter _inventoryFilter;
        private string _inventoryId;
        private List<InventoryOptionalField> _inventoryOptionalFields = AWSConfigs.InitializeCollections ? new List<InventoryOptionalField>() : null;
        private bool? _isEnabled;
        private InventorySchedule _schedule;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Contains information about where to publish the inventory results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedObjectVersions. 
        /// <para>
        /// Object versions to include in the inventory list. If set to <c>All</c>, the list includes
        /// all the object versions, which adds the version-related fields <c>VersionId</c>, <c>IsLatest</c>,
        /// and <c>DeleteMarker</c> to the list. If set to <c>Current</c>, the list does not contain
        /// these version-related fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryIncludedObjectVersions IncludedObjectVersions
        {
            get { return this._includedObjectVersions; }
            set { this._includedObjectVersions = value; }
        }

        // Check to see if IncludedObjectVersions property is set
        internal bool IsSetIncludedObjectVersions()
        {
            return this._includedObjectVersions != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryFilter. 
        /// <para>
        /// Specifies an inventory filter. The inventory only includes objects that meet the filter's
        /// criteria.
        /// </para>
        /// </summary>
        public InventoryFilter InventoryFilter
        {
            get { return this._inventoryFilter; }
            set { this._inventoryFilter = value; }
        }

        // Check to see if InventoryFilter property is set
        internal bool IsSetInventoryFilter()
        {
            return this._inventoryFilter != null;
        }

        /// <summary>
        /// Gets and sets the property InventoryId. 
        /// <para>
        /// The ID used to identify the inventory configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InventoryId
        {
            get { return this._inventoryId; }
            set { this._inventoryId = value; }
        }

        // Check to see if InventoryId property is set
        internal bool IsSetInventoryId()
        {
            return !String.IsNullOrEmpty(this._inventoryId);
        }

        /// <summary>
        /// Gets and sets the property InventoryOptionalFields. 
        /// <para>
        /// Contains the optional fields that are included in the inventory results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InventoryOptionalField> InventoryOptionalFields
        {
            get { return this._inventoryOptionalFields; }
            set { this._inventoryOptionalFields = value; }
        }

        // Check to see if InventoryOptionalFields property is set
        internal bool IsSetInventoryOptionalFields()
        {
            return this._inventoryOptionalFields != null && (this._inventoryOptionalFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Specifies whether the inventory is enabled or disabled. If set to <c>True</c>, an
        /// inventory list is generated. If set to <c>False</c>, no inventory list is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Specifies the schedule for generating inventory results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventorySchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

    }
}
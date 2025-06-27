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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a complete set of updates to be applied to an Iceberg table, including schema
    /// changes, partitioning modifications, sort order adjustments, location updates, and
    /// property changes.
    /// </summary>
    public partial class IcebergTableUpdate
    {
        private string _location;
        private IcebergPartitionSpec _partitionSpec;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IcebergSchema _schema;
        private IcebergSortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The updated S3 location where the Iceberg table data will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2056)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The updated partitioning specification that defines how the table data should be reorganized
        /// and partitioned.
        /// </para>
        /// </summary>
        public IcebergPartitionSpec PartitionSpec
        {
            get { return this._partitionSpec; }
            set { this._partitionSpec = value; }
        }

        // Check to see if PartitionSpec property is set
        internal bool IsSetPartitionSpec()
        {
            return this._partitionSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Updated key-value pairs of table properties and configuration settings for the Iceberg
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The updated schema definition for the Iceberg table, specifying any changes to field
        /// structure, data types, or schema metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IcebergSchema Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The updated sort order specification that defines how data should be ordered within
        /// partitions for optimal query performance.
        /// </para>
        /// </summary>
        public IcebergSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}
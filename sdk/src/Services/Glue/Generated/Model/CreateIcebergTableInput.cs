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
    /// The configuration parameters required to create a new Iceberg table in the Glue Data
    /// Catalog, including table properties and metadata specifications.
    /// </summary>
    public partial class CreateIcebergTableInput
    {
        private string _location;
        private IcebergPartitionSpec _partitionSpec;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IcebergSchema _schema;
        private IcebergSortOrder _writeOrder;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The S3 location where the Iceberg table data will be stored.
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
        /// The partitioning specification that defines how the Iceberg table data will be organized
        /// and partitioned for optimal query performance.
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
        /// Key-value pairs of additional table properties and configuration settings for the
        /// Iceberg table.
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
        /// The schema definition that specifies the structure, field types, and metadata for
        /// the Iceberg table.
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
        /// Gets and sets the property WriteOrder. 
        /// <para>
        /// The sort order specification that defines how data should be ordered within each partition
        /// to optimize query performance.
        /// </para>
        /// </summary>
        public IcebergSortOrder WriteOrder
        {
            get { return this._writeOrder; }
            set { this._writeOrder = value; }
        }

        // Check to see if WriteOrder property is set
        internal bool IsSetWriteOrder()
        {
            return this._writeOrder != null;
        }

    }
}
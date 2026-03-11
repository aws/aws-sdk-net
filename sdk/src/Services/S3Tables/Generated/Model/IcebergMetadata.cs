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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about the metadata for an Iceberg table.
    /// </summary>
    public partial class IcebergMetadata
    {
        private IcebergPartitionSpec _partitionSpec;
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IcebergSchema _schema;
        private IcebergSortOrder _writeOrder;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partition specification for the Iceberg table. Partitioning organizes data into
        /// separate files based on the values of one or more fields, which can improve query
        /// performance by reducing the amount of data scanned. Each partition field applies a
        /// transform (such as identity, year, month, or bucket) to a single field.
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
        /// A map of custom configuration properties for the Iceberg table.
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
        /// The schema for an Iceberg table.
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
        /// The sort order for the Iceberg table. Sort order defines how data is sorted within
        /// data files, which can improve query performance by enabling more efficient data skipping
        /// and filtering.
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
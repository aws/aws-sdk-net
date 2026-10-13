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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of update action to be performed on the Iceberg table. Defines the specific
        /// operation such as adding schema, setting current schema, adding partition spec, or
        /// managing encryption keys.
        /// </para>
        /// </summary>
        public IcebergUpdateAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// Encryption key information associated with an Iceberg table update operation. Used
        /// when adding or removing encryption keys from the table metadata during table evolution.
        /// </para>
        /// </summary>
        public IcebergEncryptedKey EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifier of the encryption key involved in an Iceberg table update operation. References
        /// the specific key being added to or removed from the table's encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2056)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The updated S3 location where the Iceberg table data will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2056)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The updated partitioning specification that defines how the table data should be reorganized
        /// and partitioned.
        /// </para>
        /// </summary>
        public IcebergPartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Checks to see if the PartitionSpec property is set.
        /// </summary>
        internal bool IsSetPartitionSpec() => this.PartitionSpec != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Updated key-value pairs of table properties and configuration settings for the Iceberg
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The updated schema definition for the Iceberg table, specifying any changes to field
        /// structure, data types, or schema metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IcebergSchema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The updated sort order specification that defines how data should be ordered within
        /// partitions for optimal query performance.
        /// </para>
        /// </summary>
        public IcebergSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}

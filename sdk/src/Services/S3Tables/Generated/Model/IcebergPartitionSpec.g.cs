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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Defines how data in an Iceberg table is partitioned. Partitioning helps optimize query
    /// performance by organizing data into separate files based on field values. Each partition
    /// field specifies a transform to apply to a source field.
    /// </summary>
    public partial class IcebergPartitionSpec
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of partition fields that define how the table data is partitioned. Each field
        /// specifies a source field and a transform to apply. This field is required if <c>partitionSpec</c>
        /// is provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IcebergPartitionField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<IcebergPartitionField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpecId. 
        /// <para>
        /// The unique identifier for this partition specification. If not specified, defaults
        /// to <c>0</c>.
        /// </para>
        /// </summary>
        public int? SpecId { get; set; }

        /// <summary>
        /// Checks to see if the SpecId property is set.
        /// </summary>
        internal bool IsSetSpecId() => this.SpecId.HasValue;
    }
}

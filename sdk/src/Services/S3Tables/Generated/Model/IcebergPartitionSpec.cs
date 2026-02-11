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
    /// Defines how data in an Iceberg table is partitioned. Partitioning helps optimize query
    /// performance by organizing data into separate files based on field values. Each partition
    /// field specifies a transform to apply to a source field.
    /// </summary>
    public partial class IcebergPartitionSpec
    {
        private List<IcebergPartitionField> _fields = AWSConfigs.InitializeCollections ? new List<IcebergPartitionField>() : null;
        private int? _specId;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of partition fields that define how the table data is partitioned. Each field
        /// specifies a source field and a transform to apply. This field is required if <c>partitionSpec</c>
        /// is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IcebergPartitionField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpecId. 
        /// <para>
        /// The unique identifier for this partition specification. If not specified, defaults
        /// to <c>0</c>.
        /// </para>
        /// </summary>
        public int SpecId
        {
            get { return this._specId.GetValueOrDefault(); }
            set { this._specId = value; }
        }

        // Check to see if SpecId property is set
        internal bool IsSetSpecId()
        {
            return this._specId.HasValue; 
        }

    }
}
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
    /// Defines the partitioning specification for an Iceberg table, determining how table
    /// data will be organized and partitioned for optimal query performance.
    /// </summary>
    public partial class IcebergPartitionSpec
    {
        private List<IcebergPartitionField> _fields = AWSConfigs.InitializeCollections ? new List<IcebergPartitionField>() : null;
        private int? _specId;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of partition fields that define how the table data should be partitioned,
        /// including source fields and their transformations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The unique identifier for this partition specification within the Iceberg table's
        /// metadata history.
        /// </para>
        /// </summary>
        public int? SpecId
        {
            get { return this._specId; }
            set { this._specId = value; }
        }

        // Check to see if SpecId property is set
        internal bool IsSetSpecId()
        {
            return this._specId.HasValue; 
        }

    }
}
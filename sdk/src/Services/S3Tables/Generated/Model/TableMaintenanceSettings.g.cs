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
    /// Contains details about maintenance settings for the table.
    /// </summary>
    public partial class TableMaintenanceSettings
    {
        /// <summary>
        /// Gets and sets the property IcebergCompaction. 
        /// <para>
        /// Contains details about the Iceberg compaction settings for the table.
        /// </para>
        /// </summary>
        public IcebergCompactionSettings IcebergCompaction { get; set; }

        /// <summary>
        /// Checks to see if the IcebergCompaction property is set.
        /// </summary>
        internal bool IsSetIcebergCompaction() => this.IcebergCompaction != null;

        /// <summary>
        /// Gets and sets the property IcebergSnapshotManagement. 
        /// <para>
        /// Contains details about the Iceberg snapshot management settings for the table.
        /// </para>
        /// </summary>
        public IcebergSnapshotManagementSettings IcebergSnapshotManagement { get; set; }

        /// <summary>
        /// Checks to see if the IcebergSnapshotManagement property is set.
        /// </summary>
        internal bool IsSetIcebergSnapshotManagement() => this.IcebergSnapshotManagement != null;
    }
}

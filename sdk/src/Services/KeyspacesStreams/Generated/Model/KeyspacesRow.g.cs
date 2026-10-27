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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Represents a row in an Amazon Keyspaces table, containing regular column values, static
    /// column values, and row-level metadata.
    /// </summary>
    public partial class KeyspacesRow
    {
        /// <summary>
        /// Gets and sets the property RowMetadata. 
        /// <para>
        /// Metadata that applies to the entire row, such as timestamps and TTL information.
        /// </para>
        /// </summary>
        public KeyspacesMetadata RowMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RowMetadata property is set.
        /// </summary>
        internal bool IsSetRowMetadata() => this.RowMetadata != null;

        /// <summary>
        /// Gets and sets the property StaticCells. 
        /// <para>
        /// A map of static column cells shared by all rows with the same partition key, where
        /// keys are column names and values are the corresponding cells.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> StaticCells { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the StaticCells property is set.
        /// </summary>
        internal bool IsSetStaticCells() => this.StaticCells != null && (this.StaticCells.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValueCells. 
        /// <para>
        /// A map of regular (non-static) column cells in the row, where keys are column names
        /// and values are the corresponding cells.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> ValueCells { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;

        /// <summary>
        /// Checks to see if the ValueCells property is set.
        /// </summary>
        internal bool IsSetValueCells() => this.ValueCells != null && (this.ValueCells.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

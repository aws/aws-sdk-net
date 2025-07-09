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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
        private KeyspacesMetadata _rowMetadata;
        private Dictionary<string, KeyspacesCell> _staticCells = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;
        private Dictionary<string, KeyspacesCell> _valueCells = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCell>() : null;

        /// <summary>
        /// Gets and sets the property RowMetadata. 
        /// <para>
        /// Metadata that applies to the entire row, such as timestamps and TTL information.
        /// </para>
        /// </summary>
        public KeyspacesMetadata RowMetadata
        {
            get { return this._rowMetadata; }
            set { this._rowMetadata = value; }
        }

        // Check to see if RowMetadata property is set
        internal bool IsSetRowMetadata()
        {
            return this._rowMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property StaticCells. 
        /// <para>
        /// A map of static column cells shared by all rows with the same partition key, where
        /// keys are column names and values are the corresponding cells.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> StaticCells
        {
            get { return this._staticCells; }
            set { this._staticCells = value; }
        }

        // Check to see if StaticCells property is set
        internal bool IsSetStaticCells()
        {
            return this._staticCells != null && (this._staticCells.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueCells. 
        /// <para>
        /// A map of regular (non-static) column cells in the row, where keys are column names
        /// and values are the corresponding cells.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCell> ValueCells
        {
            get { return this._valueCells; }
            set { this._valueCells = value; }
        }

        // Check to see if ValueCells property is set
        internal bool IsSetValueCells()
        {
            return this._valueCells != null && (this._valueCells.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
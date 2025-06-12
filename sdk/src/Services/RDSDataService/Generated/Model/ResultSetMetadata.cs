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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The metadata of the result set returned by a SQL statement.
    /// </summary>
    public partial class ResultSetMetadata
    {
        private long? _columnCount;
        private List<ColumnMetadata> _columnMetadata = AWSConfigs.InitializeCollections ? new List<ColumnMetadata>() : null;

        /// <summary>
        /// Gets and sets the property ColumnCount. 
        /// <para>
        /// The number of columns in the result set.
        /// </para>
        /// </summary>
        public long? ColumnCount
        {
            get { return this._columnCount; }
            set { this._columnCount = value; }
        }

        // Check to see if ColumnCount property is set
        internal bool IsSetColumnCount()
        {
            return this._columnCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnMetadata. 
        /// <para>
        /// The metadata of the columns in the result set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata
        {
            get { return this._columnMetadata; }
            set { this._columnMetadata = value; }
        }

        // Check to see if ColumnMetadata property is set
        internal bool IsSetColumnMetadata()
        {
            return this._columnMetadata != null && (this._columnMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
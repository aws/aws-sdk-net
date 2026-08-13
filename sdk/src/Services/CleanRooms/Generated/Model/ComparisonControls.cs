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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Specifies how a query can compare the columns in a table, including literal comparisons
    /// and column-to-column comparisons.
    /// </summary>
    public partial class ComparisonControls
    {
        private List<string> _allowedColumnComparisonColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedLiteralComparisonColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedColumnComparisonColumns. 
        /// <para>
        /// The columns that a query can compare to another column, for example, in a join, a
        /// WHERE clause, a GROUP BY clause, or a window function. Clean Rooms rejects a query
        /// that uses any other column in a column-to-column comparison. Specify an empty list
        /// to block column-to-column comparison on every column.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllowedColumnComparisonColumns
        {
            get { return this._allowedColumnComparisonColumns; }
            set { this._allowedColumnComparisonColumns = value; }
        }

        // Check to see if AllowedColumnComparisonColumns property is set
        internal bool IsSetAllowedColumnComparisonColumns()
        {
            return this._allowedColumnComparisonColumns != null && (this._allowedColumnComparisonColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedLiteralComparisonColumns. 
        /// <para>
        /// The columns that a query can compare to literal values, for example, in a WHERE clause.
        /// Clean Rooms rejects a query that compares any other column to a literal value. Specify
        /// an empty list to block literal comparison on every column. You can't specify a column
        /// that you also use as an identity column in an aggregation threshold.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllowedLiteralComparisonColumns
        {
            get { return this._allowedLiteralComparisonColumns; }
            set { this._allowedLiteralComparisonColumns = value; }
        }

        // Check to see if AllowedLiteralComparisonColumns property is set
        internal bool IsSetAllowedLiteralComparisonColumns()
        {
            return this._allowedLiteralComparisonColumns != null && (this._allowedLiteralComparisonColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
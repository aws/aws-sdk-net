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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a set of options that define how DataBrew will interpret a Microsoft Excel
    /// file when creating a dataset from that file.
    /// </summary>
    public partial class ExcelOptions
    {
        private bool? _headerRow;
        private List<int> _sheetIndexes = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<string> _sheetNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property HeaderRow. 
        /// <para>
        /// A variable that specifies whether the first row in the file is parsed as the header.
        /// If this value is false, column names are auto-generated.
        /// </para>
        /// </summary>
        public bool? HeaderRow
        {
            get { return this._headerRow; }
            set { this._headerRow = value; }
        }

        // Check to see if HeaderRow property is set
        internal bool IsSetHeaderRow()
        {
            return this._headerRow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SheetIndexes. 
        /// <para>
        /// One or more sheet numbers in the Excel file that will be included in the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<int> SheetIndexes
        {
            get { return this._sheetIndexes; }
            set { this._sheetIndexes = value; }
        }

        // Check to see if SheetIndexes property is set
        internal bool IsSetSheetIndexes()
        {
            return this._sheetIndexes != null && (this._sheetIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SheetNames. 
        /// <para>
        /// One or more named sheets in the Excel file that will be included in the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SheetNames
        {
            get { return this._sheetNames; }
            set { this._sheetNames = value; }
        }

        // Check to see if SheetNames property is set
        internal bool IsSetSheetNames()
        {
            return this._sheetNames != null && (this._sheetNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
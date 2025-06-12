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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains information that identifies the snapshot that needs to be
    /// generated.
    /// </summary>
    public partial class SnapshotFileSheetSelection
    {
        private SnapshotFileSheetSelectionScope _selectionScope;
        private string _sheetId;
        private List<string> _visualIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SelectionScope. 
        /// <para>
        /// The selection scope of the visuals on a sheet of a dashboard that you are generating
        /// a snapthot of. You can choose one of the following options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_VISUALS</c> - Selects all visuals that are on the sheet. This value is required
        /// if the snapshot is a PDF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SELECTED_VISUALS</c> - Select the visual that you want to add to the snapshot.
        /// This value is required if the snapshot is a CSV or Excel workbook.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotFileSheetSelectionScope SelectionScope
        {
            get { return this._selectionScope; }
            set { this._selectionScope = value; }
        }

        // Check to see if SelectionScope property is set
        internal bool IsSetSelectionScope()
        {
            return this._selectionScope != null;
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The sheet ID of the dashboard to generate the snapshot artifact from. This value is
        /// required for CSV, Excel, and PDF format types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SheetId
        {
            get { return this._sheetId; }
            set { this._sheetId = value; }
        }

        // Check to see if SheetId property is set
        internal bool IsSetSheetId()
        {
            return this._sheetId != null;
        }

        /// <summary>
        /// Gets and sets the property VisualIds. 
        /// <para>
        ///  A structure that lists the IDs of the visuals in the selected sheet. Supported visual
        /// types are table, pivot table visuals. This value is required if you are generating
        /// a CSV or Excel workbook. This value supports a maximum of 1 visual ID for CSV and
        /// 5 visual IDs across up to 5 sheet selections for Excel. If you are generating an Excel
        /// workbook, the order of the visual IDs provided in this structure determines the order
        /// of the worksheets in the Excel file. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> VisualIds
        {
            get { return this._visualIds; }
            set { this._visualIds = value; }
        }

        // Check to see if VisualIds property is set
        internal bool IsSetVisualIds()
        {
            return this._visualIds != null && (this._visualIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
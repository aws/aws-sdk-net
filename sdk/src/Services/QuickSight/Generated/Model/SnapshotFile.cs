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
    /// A structure that contains the information for the snapshot that you want to generate.
    /// This information is provided by you when you start a new snapshot job.
    /// </summary>
    public partial class SnapshotFile
    {
        private SnapshotFileFormatType _formatType;
        private List<SnapshotFileSheetSelection> _sheetSelections = AWSConfigs.InitializeCollections ? new List<SnapshotFileSheetSelection>() : null;

        /// <summary>
        /// Gets and sets the property FormatType. 
        /// <para>
        /// The format of the snapshot file to be generated. You can choose between <c>CSV</c>,
        /// <c>Excel</c>, or <c>PDF</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotFileFormatType FormatType
        {
            get { return this._formatType; }
            set { this._formatType = value; }
        }

        // Check to see if FormatType property is set
        internal bool IsSetFormatType()
        {
            return this._formatType != null;
        }

        /// <summary>
        /// Gets and sets the property SheetSelections. 
        /// <para>
        /// A list of <c>SnapshotFileSheetSelection</c> objects that contain information on the
        /// dashboard sheet that is exported. These objects provide information about the snapshot
        /// artifacts that are generated during the job. This structure can hold a maximum of
        /// 5 CSV configurations, 5 Excel configurations, or 1 configuration for PDF.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<SnapshotFileSheetSelection> SheetSelections
        {
            get { return this._sheetSelections; }
            set { this._sheetSelections = value; }
        }

        // Check to see if SheetSelections property is set
        internal bool IsSetSheetSelections()
        {
            return this._sheetSelections != null && (this._sheetSelections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
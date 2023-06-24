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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The source controls that are used in a <code>CascadingControlConfiguration</code>.
    /// </summary>
    public partial class CascadingControlSource
    {
        private ColumnIdentifier _columnToMatch;
        private string _sourceSheetControlId;

        /// <summary>
        /// Gets and sets the property ColumnToMatch. 
        /// <para>
        /// The column identifier that determines which column to look up for the source sheet
        /// control.
        /// </para>
        /// </summary>
        public ColumnIdentifier ColumnToMatch
        {
            get { return this._columnToMatch; }
            set { this._columnToMatch = value; }
        }

        // Check to see if ColumnToMatch property is set
        internal bool IsSetColumnToMatch()
        {
            return this._columnToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSheetControlId. 
        /// <para>
        /// The source sheet control ID of a <code>CascadingControlSource</code>.
        /// </para>
        /// </summary>
        public string SourceSheetControlId
        {
            get { return this._sourceSheetControlId; }
            set { this._sourceSheetControlId = value; }
        }

        // Check to see if SourceSheetControlId property is set
        internal bool IsSetSourceSheetControlId()
        {
            return this._sourceSheetControlId != null;
        }

    }
}
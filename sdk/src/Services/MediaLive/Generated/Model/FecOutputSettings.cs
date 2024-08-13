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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Fec Output Settings
    /// </summary>
    public partial class FecOutputSettings
    {
        private int? _columnDepth;
        private FecOutputIncludeFec _includeFec;
        private int? _rowLength;

        /// <summary>
        /// Gets and sets the property ColumnDepth. Parameter D from SMPTE 2022-1. The height
        /// of the FEC protection matrix.  The number of transport stream packets per column error
        /// correction packet. Must be between 4 and 20, inclusive.
        /// </summary>
        [AWSProperty(Min=4, Max=20)]
        public int? ColumnDepth
        {
            get { return this._columnDepth; }
            set { this._columnDepth = value; }
        }

        // Check to see if ColumnDepth property is set
        internal bool IsSetColumnDepth()
        {
            return this._columnDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeFec. Enables column only or column and row based
        /// FEC
        /// </summary>
        public FecOutputIncludeFec IncludeFec
        {
            get { return this._includeFec; }
            set { this._includeFec = value; }
        }

        // Check to see if IncludeFec property is set
        internal bool IsSetIncludeFec()
        {
            return this._includeFec != null;
        }

        /// <summary>
        /// Gets and sets the property RowLength. Parameter L from SMPTE 2022-1. The width of
        /// the FEC protection matrix.  Must be between 1 and 20, inclusive. If only Column FEC
        /// is used, then larger values increase robustness.  If Row FEC is used, then this is
        /// the number of transport stream packets per row error correction packet, and the value
        /// must be between 4 and 20, inclusive, if includeFec is columnAndRow. If includeFec
        /// is column, this value must be 1 to 20, inclusive.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? RowLength
        {
            get { return this._rowLength; }
            set { this._rowLength = value; }
        }

        // Check to see if RowLength property is set
        internal bool IsSetRowLength()
        {
            return this._rowLength.HasValue; 
        }

    }
}
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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Options that define how DataBrew will interpret a Microsoft Excel file, when creating
    /// a dataset from that file.
    /// </summary>
    public partial class ExcelOptions
    {
        private List<int> _sheetIndexes = new List<int>();
        private List<string> _sheetNames = new List<string>();

        /// <summary>
        /// Gets and sets the property SheetIndexes. 
        /// <para>
        /// Specifies one or more sheet numbers in the Excel file, which will be included in the
        /// dataset.
        /// </para>
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
            return this._sheetIndexes != null && this._sheetIndexes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SheetNames. 
        /// <para>
        /// Specifies one or more named sheets in the Excel file, which will be included in the
        /// dataset.
        /// </para>
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
            return this._sheetNames != null && this._sheetNames.Count > 0; 
        }

    }
}
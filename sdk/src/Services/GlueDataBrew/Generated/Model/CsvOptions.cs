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
    /// Represents a set of options that define how DataBrew will read a comma-separated value
    /// (CSV) file when creating a dataset from that file.
    /// </summary>
    public partial class CsvOptions
    {
        private string _delimiter;
        private bool? _headerRow;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A single character that specifies the delimiter being used in the CSV file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

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

    }
}
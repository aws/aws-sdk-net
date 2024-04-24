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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about the column used to track time in a source data file.
    /// </summary>
    public partial class TimestampColumn
    {
        private string _columnFormat;
        private string _columnName;

        /// <summary>
        /// Gets and sets the property ColumnFormat. 
        /// <para>
        /// The format of the timestamp column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string ColumnFormat
        {
            get { return this._columnFormat; }
            set { this._columnFormat = value; }
        }

        // Check to see if ColumnFormat property is set
        internal bool IsSetColumnFormat()
        {
            return this._columnFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the timestamp column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

    }
}
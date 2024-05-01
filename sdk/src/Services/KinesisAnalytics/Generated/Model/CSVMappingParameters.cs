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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides additional mapping information when the record format uses delimiters, such
    /// as CSV. For example, the following sample records use CSV format, where the records
    /// use the <i>'\n'</i> as the row delimiter and a comma (",") as the column delimiter:
    /// 
    /// 
    ///  
    /// <para>
    ///  <c>"name1", "address1"</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"name2", "address2"</c> 
    /// </para>
    /// </summary>
    public partial class CSVMappingParameters
    {
        private string _recordColumnDelimiter;
        private string _recordRowDelimiter;

        /// <summary>
        /// Gets and sets the property RecordColumnDelimiter. 
        /// <para>
        /// Column delimiter. For example, in a CSV format, a comma (",") is the typical column
        /// delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string RecordColumnDelimiter
        {
            get { return this._recordColumnDelimiter; }
            set { this._recordColumnDelimiter = value; }
        }

        // Check to see if RecordColumnDelimiter property is set
        internal bool IsSetRecordColumnDelimiter()
        {
            return this._recordColumnDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property RecordRowDelimiter. 
        /// <para>
        /// Row delimiter. For example, in a CSV format, <i>'\n'</i> is the typical row delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string RecordRowDelimiter
        {
            get { return this._recordRowDelimiter; }
            set { this._recordRowDelimiter = value; }
        }

        // Check to see if RecordRowDelimiter property is set
        internal bool IsSetRecordRowDelimiter()
        {
            return this._recordRowDelimiter != null;
        }

    }
}
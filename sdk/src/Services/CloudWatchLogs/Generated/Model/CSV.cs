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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// The <c>CSV</c> processor parses comma-separated values (CSV) from the log events into
    /// columns.
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-csv">
    /// csv</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CSV
    {
        private List<string> _columns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _delimiter;
        private string _quoteCharacter;
        private string _source;

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// An array of names to use for the columns in the transformed log event.
        /// </para>
        ///  
        /// <para>
        /// If you omit this, default column names (<c>[column_1, column_2 ...]</c>) are used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && (this._columns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The character used to separate each column in the original comma-separated value log
        /// event. If you omit this, the processor looks for the comma <c>,</c> character as the
        /// delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// The character used used as a text qualifier for a single column of data. If you omit
        /// this, the double quotation mark <c>"</c> character is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string QuoteCharacter
        {
            get { return this._quoteCharacter; }
            set { this._quoteCharacter = value; }
        }

        // Check to see if QuoteCharacter property is set
        internal bool IsSetQuoteCharacter()
        {
            return this._quoteCharacter != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The path to the field in the log event that has the comma separated values to be parsed.
        /// If you omit this value, the whole log message is processed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}
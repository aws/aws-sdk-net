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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> Columns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Columns property is set.
        /// </summary>
        internal bool IsSetColumns() => this.Columns != null && (this.Columns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The character used to separate each column in the original comma-separated value log
        /// event. If you omit this, the processor looks for the comma <c>,</c> character as the
        /// delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The path to the parent field to put transformed key value pairs under. If you omit
        /// this value, the key value pairs will be placed under the root node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// The character used used as a text qualifier for a single column of data. If you omit
        /// this, the double quotation mark <c>"</c> character is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string QuoteCharacter { get; set; }

        /// <summary>
        /// Checks to see if the QuoteCharacter property is set.
        /// </summary>
        internal bool IsSetQuoteCharacter() => this.QuoteCharacter != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The path to the field in the log event that has the comma separated values to be parsed.
        /// If you omit this value, the whole log message is processed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}

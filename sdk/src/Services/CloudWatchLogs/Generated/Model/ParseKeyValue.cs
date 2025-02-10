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
    /// This processor parses a specified field in the original log event into key-value pairs.
    /// 
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseKeyValue">
    /// parseKeyValue</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ParseKeyValue
    {
        private string _destination;
        private string _fieldDelimiter;
        private string _keyPrefix;
        private string _keyValueDelimiter;
        private string _nonMatchValue;
        private bool? _overwriteIfExists;
        private string _source;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination field to put the extracted key-value pairs into
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// The field delimiter string that is used between key-value pairs in the original log
        /// events. If you omit this, the ampersand <c>&amp;</c> character is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FieldDelimiter
        {
            get { return this._fieldDelimiter; }
            set { this._fieldDelimiter = value; }
        }

        // Check to see if FieldDelimiter property is set
        internal bool IsSetFieldDelimiter()
        {
            return this._fieldDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// If you want to add a prefix to all transformed keys, specify it here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValueDelimiter. 
        /// <para>
        /// The delimiter string to use between the key and value in each pair in the transformed
        /// log event.
        /// </para>
        ///  
        /// <para>
        ///  If you omit this, the equal <c>=</c> character is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyValueDelimiter
        {
            get { return this._keyValueDelimiter; }
            set { this._keyValueDelimiter = value; }
        }

        // Check to see if KeyValueDelimiter property is set
        internal bool IsSetKeyValueDelimiter()
        {
            return this._keyValueDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property NonMatchValue. 
        /// <para>
        /// A value to insert into the value field in the result, when a key-value pair is not
        /// successfully split.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NonMatchValue
        {
            get { return this._nonMatchValue; }
            set { this._nonMatchValue = value; }
        }

        // Check to see if NonMatchValue property is set
        internal bool IsSetNonMatchValue()
        {
            return this._nonMatchValue != null;
        }

        /// <summary>
        /// Gets and sets the property OverwriteIfExists. 
        /// <para>
        /// Specifies whether to overwrite the value if the destination key already exists. If
        /// you omit this, the default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? OverwriteIfExists
        {
            get { return this._overwriteIfExists; }
            set { this._overwriteIfExists = value; }
        }

        // Check to see if OverwriteIfExists property is set
        internal bool IsSetOverwriteIfExists()
        {
            return this._overwriteIfExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Path to the field in the log event that will be parsed. Use dot notation to access
        /// child fields. For example, <c>store.book</c> 
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
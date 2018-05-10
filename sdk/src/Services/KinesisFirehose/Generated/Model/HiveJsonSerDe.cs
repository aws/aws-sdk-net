/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The native Hive / HCatalog JsonSerDe. Used by Kinesis Data Firehose for deserializing
    /// data, which means converting it from the JSON format in preparation for serializing
    /// it to the Parquet or ORC format. This is one of two deserializers you can choose,
    /// depending on which one offers the functionality you need. The other option is the
    /// OpenX SerDe.
    /// </summary>
    public partial class HiveJsonSerDe
    {
        private List<string> _timestampFormats = new List<string>();

        /// <summary>
        /// Gets and sets the property TimestampFormats. 
        /// <para>
        /// Indicates how you want Kinesis Data Firehose to parse the date and time stamps that
        /// may be present in your input data JSON. To specify these format strings, follow the
        /// pattern syntax of JodaTime's DateTimeFormat format strings. For more information,
        /// see <a href="https://www.joda.org/joda-time/apidocs/org/joda/time/format/DateTimeFormat.html">Class
        /// DateTimeFormat</a>. You can also use the special value <code>millis</code> to parse
        /// time stamps in epoch milliseconds. If you don't specify a format, Kinesis Data Firehose
        /// uses <code>java.sql.Timestamp::valueOf</code> by default.
        /// </para>
        /// </summary>
        public List<string> TimestampFormats
        {
            get { return this._timestampFormats; }
            set { this._timestampFormats = value; }
        }

        // Check to see if TimestampFormats property is set
        internal bool IsSetTimestampFormats()
        {
            return this._timestampFormats != null && this._timestampFormats.Count > 0; 
        }

    }
}
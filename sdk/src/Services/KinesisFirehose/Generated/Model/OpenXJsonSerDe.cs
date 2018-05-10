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
    /// The OpenX SerDe. Used by Kinesis Data Firehose for deserializing data, which means
    /// converting it from the JSON format in preparation for serializing it to the Parquet
    /// or ORC format. This is one of two deserializers you can choose, depending on which
    /// one offers the functionality you need. The other option is the native Hive / HCatalog
    /// JsonSerDe.
    /// </summary>
    public partial class OpenXJsonSerDe
    {
        private bool? _caseInsensitive;
        private Dictionary<string, string> _columnToJsonKeyMappings = new Dictionary<string, string>();
        private bool? _convertDotsInJsonKeysToUnderscores;

        /// <summary>
        /// Gets and sets the property CaseInsensitive. 
        /// <para>
        /// When set to <code>true</code>, which is the default, Kinesis Data Firehose converts
        /// JSON keys to lowercase before deserializing them.
        /// </para>
        /// </summary>
        public bool CaseInsensitive
        {
            get { return this._caseInsensitive.GetValueOrDefault(); }
            set { this._caseInsensitive = value; }
        }

        // Check to see if CaseInsensitive property is set
        internal bool IsSetCaseInsensitive()
        {
            return this._caseInsensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnToJsonKeyMappings. 
        /// <para>
        /// Maps column names to JSON keys that aren't identical to the column names. This is
        /// useful when the JSON contains keys that are Hive keywords. For example, <code>timestamp</code>
        /// is a Hive keyword. If you have a JSON key named <code>timestamp</code>, set this parameter
        /// to <code>{"ts": "timestamp"}</code> to map this key to a column named <code>ts</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ColumnToJsonKeyMappings
        {
            get { return this._columnToJsonKeyMappings; }
            set { this._columnToJsonKeyMappings = value; }
        }

        // Check to see if ColumnToJsonKeyMappings property is set
        internal bool IsSetColumnToJsonKeyMappings()
        {
            return this._columnToJsonKeyMappings != null && this._columnToJsonKeyMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConvertDotsInJsonKeysToUnderscores. 
        /// <para>
        /// When set to <code>true</code>, specifies that the names of the keys include dots and
        /// that you want Kinesis Data Firehose to replace them with underscores. This is useful
        /// because Apache Hive does not allow dots in column names. For example, if the JSON
        /// contains a key whose name is "a.b", you can define the column name to be "a_b" when
        /// using this option.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ConvertDotsInJsonKeysToUnderscores
        {
            get { return this._convertDotsInJsonKeysToUnderscores.GetValueOrDefault(); }
            set { this._convertDotsInJsonKeysToUnderscores = value; }
        }

        // Check to see if ConvertDotsInJsonKeysToUnderscores property is set
        internal bool IsSetConvertDotsInJsonKeysToUnderscores()
        {
            return this._convertDotsInJsonKeysToUnderscores.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The OpenX SerDe. Used by Firehose for deserializing data, which means converting it
    /// from the JSON format in preparation for serializing it to the Parquet or ORC format.
    /// This is one of two deserializers you can choose, depending on which one offers the
    /// functionality you need. The other option is the native Hive / HCatalog JsonSerDe.
    /// </summary>
    public partial class OpenXJsonSerDe
    {
        private bool? _caseInsensitive;
        private Dictionary<string, string> _columnToJsonKeyMappings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _convertDotsInJsonKeysToUnderscores;

        /// <summary>
        /// Gets and sets the property CaseInsensitive. 
        /// <para>
        /// When set to <c>true</c>, which is the default, Firehose converts JSON keys to lowercase
        /// before deserializing them.
        /// </para>
        /// </summary>
        public bool? CaseInsensitive
        {
            get { return this._caseInsensitive; }
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
        /// useful when the JSON contains keys that are Hive keywords. For example, <c>timestamp</c>
        /// is a Hive keyword. If you have a JSON key named <c>timestamp</c>, set this parameter
        /// to <c>{"ts": "timestamp"}</c> to map this key to a column named <c>ts</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ColumnToJsonKeyMappings
        {
            get { return this._columnToJsonKeyMappings; }
            set { this._columnToJsonKeyMappings = value; }
        }

        // Check to see if ColumnToJsonKeyMappings property is set
        internal bool IsSetColumnToJsonKeyMappings()
        {
            return this._columnToJsonKeyMappings != null && (this._columnToJsonKeyMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConvertDotsInJsonKeysToUnderscores. 
        /// <para>
        /// When set to <c>true</c>, specifies that the names of the keys include dots and that
        /// you want Firehose to replace them with underscores. This is useful because Apache
        /// Hive does not allow dots in column names. For example, if the JSON contains a key
        /// whose name is "a.b", you can define the column name to be "a_b" when using this option.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ConvertDotsInJsonKeysToUnderscores
        {
            get { return this._convertDotsInJsonKeysToUnderscores; }
            set { this._convertDotsInJsonKeysToUnderscores = value; }
        }

        // Check to see if ConvertDotsInJsonKeysToUnderscores property is set
        internal bool IsSetConvertDotsInJsonKeysToUnderscores()
        {
            return this._convertDotsInJsonKeysToUnderscores.HasValue; 
        }

    }
}
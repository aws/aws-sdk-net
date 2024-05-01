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
    /// The deserializer you want Firehose to use for converting the input data from JSON.
    /// Firehose then serializes the data to its final format using the <a>Serializer</a>.
    /// Firehose supports two types of deserializers: the <a href="https://cwiki.apache.org/confluence/display/Hive/LanguageManual+DDL#LanguageManualDDL-JSON">Apache
    /// Hive JSON SerDe</a> and the <a href="https://github.com/rcongiu/Hive-JSON-Serde">OpenX
    /// JSON SerDe</a>.
    /// </summary>
    public partial class Deserializer
    {
        private HiveJsonSerDe _hiveJsonSerDe;
        private OpenXJsonSerDe _openXJsonSerDe;

        /// <summary>
        /// Gets and sets the property HiveJsonSerDe. 
        /// <para>
        /// The native Hive / HCatalog JsonSerDe. Used by Firehose for deserializing data, which
        /// means converting it from the JSON format in preparation for serializing it to the
        /// Parquet or ORC format. This is one of two deserializers you can choose, depending
        /// on which one offers the functionality you need. The other option is the OpenX SerDe.
        /// </para>
        /// </summary>
        public HiveJsonSerDe HiveJsonSerDe
        {
            get { return this._hiveJsonSerDe; }
            set { this._hiveJsonSerDe = value; }
        }

        // Check to see if HiveJsonSerDe property is set
        internal bool IsSetHiveJsonSerDe()
        {
            return this._hiveJsonSerDe != null;
        }

        /// <summary>
        /// Gets and sets the property OpenXJsonSerDe. 
        /// <para>
        /// The OpenX SerDe. Used by Firehose for deserializing data, which means converting it
        /// from the JSON format in preparation for serializing it to the Parquet or ORC format.
        /// This is one of two deserializers you can choose, depending on which one offers the
        /// functionality you need. The other option is the native Hive / HCatalog JsonSerDe.
        /// </para>
        /// </summary>
        public OpenXJsonSerDe OpenXJsonSerDe
        {
            get { return this._openXJsonSerDe; }
            set { this._openXJsonSerDe = value; }
        }

        // Check to see if OpenXJsonSerDe property is set
        internal bool IsSetOpenXJsonSerDe()
        {
            return this._openXJsonSerDe != null;
        }

    }
}
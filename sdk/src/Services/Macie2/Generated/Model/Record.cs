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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the location of an occurrence of sensitive data in an Apache Avro object
    /// container or Apache Parquet file.
    /// </summary>
    public partial class Record
    {
        private string _jsonPath;
        private long? _recordIndex;

        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// The path, as a JSONPath expression, to the field in the record that contains the data.
        /// </para>
        ///  
        /// <para>
        /// If the name of an element exceeds 20 characters, Amazon Macie truncates the name by
        /// removing characters from the beginning of the name. If the resulting full path exceeds
        /// 250 characters, Macie also truncates the path, starting with the first element in
        /// the path, until the path contains 250 or fewer characters.
        /// </para>
        /// </summary>
        public string JsonPath
        {
            get { return this._jsonPath; }
            set { this._jsonPath = value; }
        }

        // Check to see if JsonPath property is set
        internal bool IsSetJsonPath()
        {
            return this._jsonPath != null;
        }

        /// <summary>
        /// Gets and sets the property RecordIndex. 
        /// <para>
        /// The record index, starting from 0, for the record that contains the data.
        /// </para>
        /// </summary>
        public long RecordIndex
        {
            get { return this._recordIndex.GetValueOrDefault(); }
            set { this._recordIndex = value; }
        }

        // Check to see if RecordIndex property is set
        internal bool IsSetRecordIndex()
        {
            return this._recordIndex.HasValue; 
        }

    }
}
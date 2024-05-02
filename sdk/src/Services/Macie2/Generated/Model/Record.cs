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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the location of an occurrence of sensitive data in an Apache Avro object
    /// container, Apache Parquet file, JSON file, or JSON Lines file.
    /// </summary>
    public partial class Record
    {
        private string _jsonPath;
        private long? _recordIndex;

        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// The path, as a JSONPath expression, to the sensitive data. For an Avro object container
        /// or Parquet file, this is the path to the field in the record (recordIndex) that contains
        /// the data. For a JSON or JSON Lines file, this is the path to the field or array that
        /// contains the data. If the data is a value in an array, the path also indicates which
        /// value contains the data.
        /// </para>
        ///  
        /// <para>
        /// If Amazon Macie detects sensitive data in the name of any element in the path, Macie
        /// omits this field. If the name of an element exceeds 240 characters, Macie truncates
        /// the name by removing characters from the beginning of the name. If the resulting full
        /// path exceeds 250 characters, Macie also truncates the path, starting with the first
        /// element in the path, until the path contains 250 or fewer characters.
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
        /// For an Avro object container or Parquet file, the record index, starting from 0, for
        /// the record that contains the sensitive data. For a JSON Lines file, the line index,
        /// starting from 0, for the line that contains the sensitive data. This value is always
        /// 0 for JSON files.
        /// </para>
        /// </summary>
        public long? RecordIndex
        {
            get { return this._recordIndex; }
            set { this._recordIndex = value; }
        }

        // Check to see if RecordIndex property is set
        internal bool IsSetRecordIndex()
        {
            return this._recordIndex.HasValue; 
        }

    }
}
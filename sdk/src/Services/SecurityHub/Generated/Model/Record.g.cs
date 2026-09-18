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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An occurrence of sensitive data in an Apache Avro object container or an Apache Parquet
    /// file.
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// The path, as a JSONPath expression, to the field in the record that contains the data.
        /// If the field name is longer than 20 characters, it is truncated. If the path is longer
        /// than 250 characters, it is truncated.
        /// </para>
        /// </summary>
        public string JsonPath { get; set; }

        /// <summary>
        /// Checks to see if the JsonPath property is set.
        /// </summary>
        internal bool IsSetJsonPath() => this.JsonPath != null;

        /// <summary>
        /// Gets and sets the property RecordIndex. 
        /// <para>
        /// The record index, starting from 0, for the record that contains the data.
        /// </para>
        /// </summary>
        public long? RecordIndex { get; set; }

        /// <summary>
        /// Checks to see if the RecordIndex property is set.
        /// </summary>
        internal bool IsSetRecordIndex() => this.RecordIndex.HasValue;
    }
}

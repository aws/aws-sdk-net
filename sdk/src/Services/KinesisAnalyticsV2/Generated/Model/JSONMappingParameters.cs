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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application, provides additional mapping information
    /// when JSON is the record format on the streaming source.
    /// </summary>
    public partial class JSONMappingParameters
    {
        private string _recordRowPath;

        /// <summary>
        /// Gets and sets the property RecordRowPath. 
        /// <para>
        /// The path to the top-level parent that contains the records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public string RecordRowPath
        {
            get { return this._recordRowPath; }
            set { this._recordRowPath = value; }
        }

        // Check to see if RecordRowPath property is set
        internal bool IsSetRecordRowPath()
        {
            return this._recordRowPath != null;
        }

    }
}
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
    /// When you configure a SQL-based Kinesis Data Analytics application's input at the time
    /// of creating or updating an application, provides additional mapping information specific
    /// to the record format (such as JSON, CSV, or record fields delimited by some delimiter)
    /// on the streaming source.
    /// </summary>
    public partial class MappingParameters
    {
        private CSVMappingParameters _csvMappingParameters;
        private JSONMappingParameters _jsonMappingParameters;

        /// <summary>
        /// Gets and sets the property CSVMappingParameters. 
        /// <para>
        /// Provides additional mapping information when the record format uses delimiters (for
        /// example, CSV).
        /// </para>
        /// </summary>
        public CSVMappingParameters CSVMappingParameters
        {
            get { return this._csvMappingParameters; }
            set { this._csvMappingParameters = value; }
        }

        // Check to see if CSVMappingParameters property is set
        internal bool IsSetCSVMappingParameters()
        {
            return this._csvMappingParameters != null;
        }

        /// <summary>
        /// Gets and sets the property JSONMappingParameters. 
        /// <para>
        /// Provides additional mapping information when JSON is the record format on the streaming
        /// source.
        /// </para>
        /// </summary>
        public JSONMappingParameters JSONMappingParameters
        {
            get { return this._jsonMappingParameters; }
            set { this._jsonMappingParameters = value; }
        }

        // Check to see if JSONMappingParameters property is set
        internal bool IsSetJSONMappingParameters()
        {
            return this._jsonMappingParameters != null;
        }

    }
}
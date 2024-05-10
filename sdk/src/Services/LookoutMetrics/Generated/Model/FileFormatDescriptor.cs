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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about a source file's formatting.
    /// </summary>
    public partial class FileFormatDescriptor
    {
        private CsvFormatDescriptor _csvFormatDescriptor;
        private JsonFormatDescriptor _jsonFormatDescriptor;

        /// <summary>
        /// Gets and sets the property CsvFormatDescriptor. 
        /// <para>
        /// Contains information about how a source CSV data file should be analyzed.
        /// </para>
        /// </summary>
        public CsvFormatDescriptor CsvFormatDescriptor
        {
            get { return this._csvFormatDescriptor; }
            set { this._csvFormatDescriptor = value; }
        }

        // Check to see if CsvFormatDescriptor property is set
        internal bool IsSetCsvFormatDescriptor()
        {
            return this._csvFormatDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property JsonFormatDescriptor. 
        /// <para>
        /// Contains information about how a source JSON data file should be analyzed.
        /// </para>
        /// </summary>
        public JsonFormatDescriptor JsonFormatDescriptor
        {
            get { return this._jsonFormatDescriptor; }
            set { this._jsonFormatDescriptor = value; }
        }

        // Check to see if JsonFormatDescriptor property is set
        internal bool IsSetJsonFormatDescriptor()
        {
            return this._jsonFormatDescriptor != null;
        }

    }
}
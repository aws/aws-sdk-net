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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Describes how the select output is serialized.
    /// </summary>
    public partial class OutputSerialization
    {
        private CSVOutput _csv;

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        /// Describes the serialization of CSV-encoded query results.
        /// </para>
        /// </summary>
        public CSVOutput Csv
        {
            get { return this._csv; }
            set { this._csv = value; }
        }

        // Check to see if Csv property is set
        internal bool IsSetCsv()
        {
            return this._csv != null;
        }

    }
}
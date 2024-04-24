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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The format options for the data that was imported into the target table. There is
    /// one value, CsvOption.
    /// </summary>
    public partial class InputFormatOptions
    {
        private CsvOptions _csv;

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        ///  The options for imported source files in CSV format. The values are Delimiter and
        /// HeaderList. 
        /// </para>
        /// </summary>
        public CsvOptions Csv
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
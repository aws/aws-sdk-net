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
    /// Processing options for the CSV file being imported.
    /// </summary>
    public partial class CsvOptions
    {
        private string _delimiter;
        private List<string> _headerList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        ///  The delimiter used for separating items in the CSV file being imported. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderList. 
        /// <para>
        ///  List of the headers used to specify a common header for all source CSV files being
        /// imported. If this field is specified then the first line of each CSV file is treated
        /// as data instead of the header. If this field is not specified the the first line of
        /// each CSV file is treated as the header. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public List<string> HeaderList
        {
            get { return this._headerList; }
            set { this._headerList = value; }
        }

        // Check to see if HeaderList property is set
        internal bool IsSetHeaderList()
        {
            return this._headerList != null && (this._headerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
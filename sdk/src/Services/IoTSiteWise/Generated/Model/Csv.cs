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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A .CSV file.
    /// </summary>
    public partial class Csv
    {
        private List<string> _columnNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// The column names specified in the .csv file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ColumnNames
        {
            get { return this._columnNames; }
            set { this._columnNames = value; }
        }

        // Check to see if ColumnNames property is set
        internal bool IsSetColumnNames()
        {
            return this._columnNames != null && (this._columnNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
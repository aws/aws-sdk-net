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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that contains the options relating to the destination of the import request.
    /// </summary>
    public partial class DestinationOptions
    {
        private Dictionary<string, SourceDataColumnProperties> _columnMap = new Dictionary<string, SourceDataColumnProperties>();

        /// <summary>
        /// Gets and sets the property ColumnMap. 
        /// <para>
        /// A map of the column id to the import properties for each column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, SourceDataColumnProperties> ColumnMap
        {
            get { return this._columnMap; }
            set { this._columnMap = value; }
        }

        // Check to see if ColumnMap property is set
        internal bool IsSetColumnMap()
        {
            return this._columnMap != null && this._columnMap.Count > 0; 
        }

    }
}
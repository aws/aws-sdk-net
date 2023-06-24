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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The data path options for the pivot table field options.
    /// </summary>
    public partial class PivotTableDataPathOption
    {
        private List<DataPathValue> _dataPathList = new List<DataPathValue>();
        private string _width;

        /// <summary>
        /// Gets and sets the property DataPathList. 
        /// <para>
        /// The list of data path values for the data path options.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
        public List<DataPathValue> DataPathList
        {
            get { return this._dataPathList; }
            set { this._dataPathList = value; }
        }

        // Check to see if DataPathList property is set
        internal bool IsSetDataPathList()
        {
            return this._dataPathList != null && this._dataPathList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the data path option.
        /// </para>
        /// </summary>
        public string Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width != null;
        }

    }
}
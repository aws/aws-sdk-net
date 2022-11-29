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
    /// A column of a data set.
    /// </summary>
    public partial class ColumnIdentifier
    {
        private string _columnName;
        private string _dataSetIdentifier;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetIdentifier. 
        /// <para>
        /// The data set that the column belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DataSetIdentifier
        {
            get { return this._dataSetIdentifier; }
            set { this._dataSetIdentifier = value; }
        }

        // Check to see if DataSetIdentifier property is set
        internal bool IsSetDataSetIdentifier()
        {
            return this._dataSetIdentifier != null;
        }

    }
}
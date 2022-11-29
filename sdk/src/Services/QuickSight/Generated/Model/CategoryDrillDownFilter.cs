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
    /// The numeric equality type drill down filter.
    /// </summary>
    public partial class CategoryDrillDownFilter
    {
        private List<string> _categoryValues = new List<string>();
        private ColumnIdentifier _column;

        /// <summary>
        /// Gets and sets the property CategoryValues. 
        /// <para>
        /// A list of the string inputs that are the values of the category drill down filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100000)]
        public List<string> CategoryValues
        {
            get { return this._categoryValues; }
            set { this._categoryValues = value; }
        }

        // Check to see if CategoryValues property is set
        internal bool IsSetCategoryValues()
        {
            return this._categoryValues != null && this._categoryValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

    }
}
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
    /// A list of selectable values that are used in a control.
    /// </summary>
    public partial class ParameterSelectableValues
    {
        private ColumnIdentifier _linkToDataSetColumn;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property LinkToDataSetColumn. 
        /// <para>
        /// The column identifier that fetches values from the data set.
        /// </para>
        /// </summary>
        public ColumnIdentifier LinkToDataSetColumn
        {
            get { return this._linkToDataSetColumn; }
            set { this._linkToDataSetColumn = value; }
        }

        // Check to see if LinkToDataSetColumn property is set
        internal bool IsSetLinkToDataSetColumn()
        {
            return this._linkToDataSetColumn != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that are used in <code>ParameterSelectableValues</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
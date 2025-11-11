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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter condition for string columns, supporting both comparison and list-based filtering.
    /// </summary>
    public partial class DataSetStringFilterCondition
    {
        private string _columnName;
        private DataSetStringComparisonFilterCondition _comparisonFilterCondition;
        private DataSetStringListFilterCondition _listFilterCondition;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the string column to filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ComparisonFilterCondition. 
        /// <para>
        /// A comparison-based filter condition for the string column.
        /// </para>
        /// </summary>
        public DataSetStringComparisonFilterCondition ComparisonFilterCondition
        {
            get { return this._comparisonFilterCondition; }
            set { this._comparisonFilterCondition = value; }
        }

        // Check to see if ComparisonFilterCondition property is set
        internal bool IsSetComparisonFilterCondition()
        {
            return this._comparisonFilterCondition != null;
        }

        /// <summary>
        /// Gets and sets the property ListFilterCondition. 
        /// <para>
        /// A list-based filter condition that includes or excludes values from a specified list.
        /// </para>
        /// </summary>
        public DataSetStringListFilterCondition ListFilterCondition
        {
            get { return this._listFilterCondition; }
            set { this._listFilterCondition = value; }
        }

        // Check to see if ListFilterCondition property is set
        internal bool IsSetListFilterCondition()
        {
            return this._listFilterCondition != null;
        }

    }
}
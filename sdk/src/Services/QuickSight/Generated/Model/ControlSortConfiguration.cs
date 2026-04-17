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
    /// The sort configuration for control values. This is a tagged union type. Specify either
    /// <c>SelectableValuesSort</c> or <c>ControlColumnSort</c>, but not both.
    /// </summary>
    public partial class ControlSortConfiguration
    {
        private AggregationSortConfiguration _controlColumnSort;
        private SelectableValuesSort _selectableValuesSort;

        /// <summary>
        /// Gets and sets the property ControlColumnSort. 
        /// <para>
        /// The sort configuration for controls that are tied to a dataset column. Use this option
        /// to sort control values by an aggregate of a column.
        /// </para>
        /// </summary>
        public AggregationSortConfiguration ControlColumnSort
        {
            get { return this._controlColumnSort; }
            set { this._controlColumnSort = value; }
        }

        // Check to see if ControlColumnSort property is set
        internal bool IsSetControlColumnSort()
        {
            return this._controlColumnSort != null;
        }

        /// <summary>
        /// Gets and sets the property SelectableValuesSort. 
        /// <para>
        /// The sort configuration for user-specified values in the control. Use this option to
        /// sort values that are manually entered by users in a dropdown or list control.
        /// </para>
        /// </summary>
        public SelectableValuesSort SelectableValuesSort
        {
            get { return this._selectableValuesSort; }
            set { this._selectableValuesSort = value; }
        }

        // Check to see if SelectableValuesSort property is set
        internal bool IsSetSelectableValuesSort()
        {
            return this._selectableValuesSort != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Describes a filter for choosing a subset of dimension values. Each filter consists
    /// of the dimension that you want to include and the condition statement. The condition
    /// statement is specified in the <c>FilterOperation</c> object.
    /// </summary>
    public partial class Filter
    {
        private string _dimensionValue;
        private FilterOperation _filterOperation;

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// The value that you want to include in the filter.
        /// </para>
        /// </summary>
        public string DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }

        // Check to see if DimensionValue property is set
        internal bool IsSetDimensionValue()
        {
            return this._dimensionValue != null;
        }

        /// <summary>
        /// Gets and sets the property FilterOperation. 
        /// <para>
        /// The condition to apply.
        /// </para>
        /// </summary>
        public FilterOperation FilterOperation
        {
            get { return this._filterOperation; }
            set { this._filterOperation = value; }
        }

        // Check to see if FilterOperation property is set
        internal bool IsSetFilterOperation()
        {
            return this._filterOperation != null;
        }

    }
}
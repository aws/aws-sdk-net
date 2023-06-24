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
    /// The dimension type field.
    /// </summary>
    public partial class DimensionField
    {
        private CategoricalDimensionField _categoricalDimensionField;
        private DateDimensionField _dateDimensionField;
        private NumericalDimensionField _numericalDimensionField;

        /// <summary>
        /// Gets and sets the property CategoricalDimensionField. 
        /// <para>
        /// The dimension type field with categorical type columns.
        /// </para>
        /// </summary>
        public CategoricalDimensionField CategoricalDimensionField
        {
            get { return this._categoricalDimensionField; }
            set { this._categoricalDimensionField = value; }
        }

        // Check to see if CategoricalDimensionField property is set
        internal bool IsSetCategoricalDimensionField()
        {
            return this._categoricalDimensionField != null;
        }

        /// <summary>
        /// Gets and sets the property DateDimensionField. 
        /// <para>
        /// The dimension type field with date type columns.
        /// </para>
        /// </summary>
        public DateDimensionField DateDimensionField
        {
            get { return this._dateDimensionField; }
            set { this._dateDimensionField = value; }
        }

        // Check to see if DateDimensionField property is set
        internal bool IsSetDateDimensionField()
        {
            return this._dateDimensionField != null;
        }

        /// <summary>
        /// Gets and sets the property NumericalDimensionField. 
        /// <para>
        /// The dimension type field with numerical type columns.
        /// </para>
        /// </summary>
        public NumericalDimensionField NumericalDimensionField
        {
            get { return this._numericalDimensionField; }
            set { this._numericalDimensionField = value; }
        }

        // Check to see if NumericalDimensionField property is set
        internal bool IsSetNumericalDimensionField()
        {
            return this._numericalDimensionField != null;
        }

    }
}
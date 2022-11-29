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
    /// The measure (metric) type field.
    /// </summary>
    public partial class MeasureField
    {
        private CalculatedMeasureField _calculatedMeasureField;
        private CategoricalMeasureField _categoricalMeasureField;
        private DateMeasureField _dateMeasureField;
        private NumericalMeasureField _numericalMeasureField;

        /// <summary>
        /// Gets and sets the property CalculatedMeasureField. 
        /// <para>
        /// The calculated measure field only used in pivot tables.
        /// </para>
        /// </summary>
        public CalculatedMeasureField CalculatedMeasureField
        {
            get { return this._calculatedMeasureField; }
            set { this._calculatedMeasureField = value; }
        }

        // Check to see if CalculatedMeasureField property is set
        internal bool IsSetCalculatedMeasureField()
        {
            return this._calculatedMeasureField != null;
        }

        /// <summary>
        /// Gets and sets the property CategoricalMeasureField. 
        /// <para>
        /// The measure type field with categorical type columns.
        /// </para>
        /// </summary>
        public CategoricalMeasureField CategoricalMeasureField
        {
            get { return this._categoricalMeasureField; }
            set { this._categoricalMeasureField = value; }
        }

        // Check to see if CategoricalMeasureField property is set
        internal bool IsSetCategoricalMeasureField()
        {
            return this._categoricalMeasureField != null;
        }

        /// <summary>
        /// Gets and sets the property DateMeasureField. 
        /// <para>
        /// The measure type field with date type columns.
        /// </para>
        /// </summary>
        public DateMeasureField DateMeasureField
        {
            get { return this._dateMeasureField; }
            set { this._dateMeasureField = value; }
        }

        // Check to see if DateMeasureField property is set
        internal bool IsSetDateMeasureField()
        {
            return this._dateMeasureField != null;
        }

        /// <summary>
        /// Gets and sets the property NumericalMeasureField. 
        /// <para>
        /// The measure type field with numerical type columns.
        /// </para>
        /// </summary>
        public NumericalMeasureField NumericalMeasureField
        {
            get { return this._numericalMeasureField; }
            set { this._numericalMeasureField = value; }
        }

        // Check to see if NumericalMeasureField property is set
        internal bool IsSetNumericalMeasureField()
        {
            return this._numericalMeasureField != null;
        }

    }
}
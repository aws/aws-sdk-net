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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The measure (metric) type field.
    /// </summary>
    public partial class MeasureField
    {
        /// <summary>
        /// Gets and sets the property CalculatedMeasureField. 
        /// <para>
        /// The calculated measure field only used in pivot tables.
        /// </para>
        /// </summary>
        public CalculatedMeasureField CalculatedMeasureField { get; set; }

        /// <summary>
        /// Checks to see if the CalculatedMeasureField property is set.
        /// </summary>
        internal bool IsSetCalculatedMeasureField() => this.CalculatedMeasureField != null;

        /// <summary>
        /// Gets and sets the property CategoricalMeasureField. 
        /// <para>
        /// The measure type field with categorical type columns.
        /// </para>
        /// </summary>
        public CategoricalMeasureField CategoricalMeasureField { get; set; }

        /// <summary>
        /// Checks to see if the CategoricalMeasureField property is set.
        /// </summary>
        internal bool IsSetCategoricalMeasureField() => this.CategoricalMeasureField != null;

        /// <summary>
        /// Gets and sets the property DateMeasureField. 
        /// <para>
        /// The measure type field with date type columns.
        /// </para>
        /// </summary>
        public DateMeasureField DateMeasureField { get; set; }

        /// <summary>
        /// Checks to see if the DateMeasureField property is set.
        /// </summary>
        internal bool IsSetDateMeasureField() => this.DateMeasureField != null;

        /// <summary>
        /// Gets and sets the property NumericalMeasureField. 
        /// <para>
        /// The measure type field with numerical type columns.
        /// </para>
        /// </summary>
        public NumericalMeasureField NumericalMeasureField { get; set; }

        /// <summary>
        /// Checks to see if the NumericalMeasureField property is set.
        /// </summary>
        internal bool IsSetNumericalMeasureField() => this.NumericalMeasureField != null;
    }
}

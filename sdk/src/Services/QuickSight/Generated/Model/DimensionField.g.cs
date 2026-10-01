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
    /// The dimension type field.
    /// </summary>
    public partial class DimensionField
    {
        /// <summary>
        /// Gets and sets the property CategoricalDimensionField. 
        /// <para>
        /// The dimension type field with categorical type columns.
        /// </para>
        /// </summary>
        public CategoricalDimensionField CategoricalDimensionField { get; set; }

        /// <summary>
        /// Checks to see if the CategoricalDimensionField property is set.
        /// </summary>
        internal bool IsSetCategoricalDimensionField() => this.CategoricalDimensionField != null;

        /// <summary>
        /// Gets and sets the property DateDimensionField. 
        /// <para>
        /// The dimension type field with date type columns.
        /// </para>
        /// </summary>
        public DateDimensionField DateDimensionField { get; set; }

        /// <summary>
        /// Checks to see if the DateDimensionField property is set.
        /// </summary>
        internal bool IsSetDateDimensionField() => this.DateDimensionField != null;

        /// <summary>
        /// Gets and sets the property NumericalDimensionField. 
        /// <para>
        /// The dimension type field with numerical type columns.
        /// </para>
        /// </summary>
        public NumericalDimensionField NumericalDimensionField { get; set; }

        /// <summary>
        /// Checks to see if the NumericalDimensionField property is set.
        /// </summary>
        internal bool IsSetNumericalDimensionField() => this.NumericalDimensionField != null;
    }
}

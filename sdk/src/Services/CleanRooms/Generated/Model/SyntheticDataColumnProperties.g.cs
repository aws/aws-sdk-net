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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Properties that define how a specific data column should be handled during synthetic
    /// data generation, including its name, type, and role in predictive modeling.
    /// </summary>
    public partial class SyntheticDataColumnProperties
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the data column as it appears in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property ColumnType. 
        /// <para>
        /// The data type of the column, which determines how the synthetic data generation algorithm
        /// processes and synthesizes values for this column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyntheticDataColumnType ColumnType { get; set; }

        /// <summary>
        /// Checks to see if the ColumnType property is set.
        /// </summary>
        internal bool IsSetColumnType() => this.ColumnType != null;

        /// <summary>
        /// Gets and sets the property IsPredictiveValue. 
        /// <para>
        /// Indicates if this column contains predictive values that should be treated as target
        /// variables in machine learning models. This affects how the synthetic data generation
        /// preserves statistical relationships.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsPredictiveValue { get; set; }

        /// <summary>
        /// Checks to see if the IsPredictiveValue property is set.
        /// </summary>
        internal bool IsSetIsPredictiveValue() => this.IsPredictiveValue.HasValue;
    }
}

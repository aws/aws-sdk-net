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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Properties that define how a specific data column should be handled during synthetic
    /// data generation, including its name, type, and role in predictive modeling.
    /// </summary>
    public partial class SyntheticDataColumnProperties
    {
        private string _columnName;
        private SyntheticDataColumnType _columnType;
        private bool? _isPredictiveValue;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the data column as it appears in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        /// Gets and sets the property ColumnType. 
        /// <para>
        /// The data type of the column, which determines how the synthetic data generation algorithm
        /// processes and synthesizes values for this column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyntheticDataColumnType ColumnType
        {
            get { return this._columnType; }
            set { this._columnType = value; }
        }

        // Check to see if ColumnType property is set
        internal bool IsSetColumnType()
        {
            return this._columnType != null;
        }

        /// <summary>
        /// Gets and sets the property IsPredictiveValue. 
        /// <para>
        /// Indicates if this column contains predictive values that should be treated as target
        /// variables in machine learning models. This affects how the synthetic data generation
        /// preserves statistical relationships.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsPredictiveValue
        {
            get { return this._isPredictiveValue.GetValueOrDefault(); }
            set { this._isPredictiveValue = value; }
        }

        // Check to see if IsPredictiveValue property is set
        internal bool IsSetIsPredictiveValue()
        {
            return this._isPredictiveValue.HasValue; 
        }

    }
}
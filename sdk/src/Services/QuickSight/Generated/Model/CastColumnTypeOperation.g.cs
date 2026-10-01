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
    /// A transform operation that casts a column to a different type.
    /// </summary>
    public partial class CastColumnTypeOperation
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Column name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// When casting a column from string to datetime type, you can supply a string in a format
        /// supported by Quick Sight to denote the source data format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property NewColumnType. 
        /// <para>
        /// New column data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnDataType NewColumnType { get; set; }

        /// <summary>
        /// Checks to see if the NewColumnType property is set.
        /// </summary>
        internal bool IsSetNewColumnType() => this.NewColumnType != null;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The sub data type of the new column. Sub types are only available for decimal columns
        /// that are part of a SPICE dataset.
        /// </para>
        /// </summary>
        public ColumnDataSubType SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;
    }
}

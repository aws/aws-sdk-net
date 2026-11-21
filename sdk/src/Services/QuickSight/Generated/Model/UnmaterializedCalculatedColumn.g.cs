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
    /// A calculated column that is not materialized in the prepared data. The column is computed
    /// at analysis time and can use aggregate expressions.
    /// </summary>
    public partial class UnmaterializedCalculatedColumn
    {
        /// <summary>
        /// Gets and sets the property ColumnId. 
        /// <para>
        /// A unique ID to identify the unmaterialized calculated column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ColumnId { get; set; }

        /// <summary>
        /// Checks to see if the ColumnId property is set.
        /// </summary>
        internal bool IsSetColumnId() => this.ColumnId != null;

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the unmaterialized calculated column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that defines the unmaterialized calculated column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 250000)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The sub data type of the unmaterialized calculated column.
        /// </para>
        /// </summary>
        public ColumnDataSubType SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the unmaterialized calculated column.
        /// </para>
        /// </summary>
        public ColumnDataType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

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
    /// A transform operation that pivots data by converting row values into columns.
    /// </summary>
    public partial class PivotOperation
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property GroupByColumnNames. 
        /// <para>
        /// The list of column names to group by when performing the pivot operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public List<string> GroupByColumnNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GroupByColumnNames property is set.
        /// </summary>
        internal bool IsSetGroupByColumnNames() => this.GroupByColumnNames != null && (this.GroupByColumnNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PivotConfiguration. 
        /// <para>
        /// Configuration that specifies which labels to pivot and how to structure the resulting
        /// columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PivotConfiguration PivotConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PivotConfiguration property is set.
        /// </summary>
        internal bool IsSetPivotConfiguration() => this.PivotConfiguration != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source transform operation that provides input data for pivoting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformOperationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property ValueColumnConfiguration. 
        /// <para>
        /// Configuration for how to aggregate values when multiple rows map to the same pivoted
        /// column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ValueColumnConfiguration ValueColumnConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ValueColumnConfiguration property is set.
        /// </summary>
        internal bool IsSetValueColumnConfiguration() => this.ValueColumnConfiguration != null;
    }
}

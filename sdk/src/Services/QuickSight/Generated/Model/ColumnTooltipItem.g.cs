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
    /// The tooltip item for the columns that are not part of a field well.
    /// </summary>
    public partial class ColumnTooltipItem
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation function of the column tooltip item.
        /// </para>
        /// </summary>
        public AggregationFunction Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The target column of the tooltip item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label of the tooltip item.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property TooltipTarget. 
        /// <para>
        /// Determines the target of the column tooltip item in a combo chart visual.
        /// </para>
        /// </summary>
        public TooltipTarget TooltipTarget { get; set; }

        /// <summary>
        /// Checks to see if the TooltipTarget property is set.
        /// </summary>
        internal bool IsSetTooltipTarget() => this.TooltipTarget != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of the tooltip item.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}

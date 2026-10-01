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
    /// The field series item configuration of a line chart.
    /// </summary>
    public partial class FieldSeriesItem
    {
        /// <summary>
        /// Gets and sets the property AxisBinding. 
        /// <para>
        /// The axis that you are binding the field to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AxisBinding AxisBinding { get; set; }

        /// <summary>
        /// Checks to see if the AxisBinding property is set.
        /// </summary>
        internal bool IsSetAxisBinding() => this.AxisBinding != null;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the field for which you are setting the axis binding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The options that determine the presentation of line series associated to the field.
        /// </para>
        /// </summary>
        public LineChartSeriesSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;
    }
}

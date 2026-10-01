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
    /// The data field series item configuration of a <c>BarChartVisual</c>.
    /// </summary>
    public partial class DataFieldBarSeriesItem
    {
        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// Field ID of the field that you are setting the series configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property FieldValue. 
        /// <para>
        /// Field value of the field that you are setting the series configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FieldValue { get; set; }

        /// <summary>
        /// Checks to see if the FieldValue property is set.
        /// </summary>
        internal bool IsSetFieldValue() => this.FieldValue != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Options that determine the presentation of bar series associated to the field.
        /// </para>
        /// </summary>
        public BarChartSeriesSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;
    }
}

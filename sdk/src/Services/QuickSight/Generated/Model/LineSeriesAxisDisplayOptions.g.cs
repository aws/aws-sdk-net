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
    /// The series axis configuration of a line chart.
    /// </summary>
    public partial class LineSeriesAxisDisplayOptions
    {
        /// <summary>
        /// Gets and sets the property AxisOptions. 
        /// <para>
        /// The options that determine the presentation of the line series axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions AxisOptions { get; set; }

        /// <summary>
        /// Checks to see if the AxisOptions property is set.
        /// </summary>
        internal bool IsSetAxisOptions() => this.AxisOptions != null;

        /// <summary>
        /// Gets and sets the property MissingDataConfigurations. 
        /// <para>
        /// The configuration options that determine how missing data is treated during the rendering
        /// of a line chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<MissingDataConfiguration> MissingDataConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MissingDataConfiguration>() : null;

        /// <summary>
        /// Checks to see if the MissingDataConfigurations property is set.
        /// </summary>
        internal bool IsSetMissingDataConfigurations() => this.MissingDataConfigurations != null && (this.MissingDataConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

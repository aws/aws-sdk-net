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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// A single timeseries item to process. Exactly one of timeSeriesId or propertyAlias
    /// must be provided.
    /// </summary>
    public partial class TimeseriesItem
    {
        /// <summary>
        /// Gets and sets the property FormatSettings. 
        /// <para>
        /// The optional format settings for the output.
        /// </para>
        /// </summary>
        public FormatSettings FormatSettings { get; set; }

        /// <summary>
        /// Checks to see if the FormatSettings property is set.
        /// </summary>
        internal bool IsSetFormatSettings() => this.FormatSettings != null;

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The customer-friendly alias for the timeseries. Mutually exclusive with timeSeriesId.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// Checks to see if the PropertyAlias property is set.
        /// </summary>
        internal bool IsSetPropertyAlias() => this.PropertyAlias != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The unique identifier for the timeseries. Mutually exclusive with propertyAlias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;

        /// <summary>
        /// Gets and sets the property TrimSettings. 
        /// <para>
        /// The trim settings for the time range to export. Required for VIDEO and TELEMETRY data
        /// types; optional for ANNOTATION data types.
        /// </para>
        /// </summary>
        public TrimSettings TrimSettings { get; set; }

        /// <summary>
        /// Checks to see if the TrimSettings property is set.
        /// </summary>
        internal bool IsSetTrimSettings() => this.TrimSettings != null;
    }
}

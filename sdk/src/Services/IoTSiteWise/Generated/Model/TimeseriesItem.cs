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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
    /// &lt;p&gt;A single timeseries item to process. Exactly one of timeSeriesId or propertyAlias
    /// must be provided.&lt;/p&gt;
    /// </summary>
    public partial class TimeseriesItem
    {
        private FormatSettings _formatSettings;
        private string _propertyAlias;
        private string _timeSeriesId;
        private TrimSettings _trimSettings;

        /// <summary>
        /// Gets and sets the property FormatSettings. &lt;p&gt;The optional format settings for
        /// the output.&lt;/p&gt;
        /// </summary>
        public FormatSettings FormatSettings
        {
            get { return this._formatSettings; }
            set { this._formatSettings = value; }
        }

        // Check to see if FormatSettings property is set
        internal bool IsSetFormatSettings()
        {
            return this._formatSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. &lt;p&gt;The customer-friendly alias for
        /// the timeseries. Mutually exclusive with timeSeriesId.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. &lt;p&gt;The unique identifier for the timeseries.
        /// Mutually exclusive with propertyAlias.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

        /// <summary>
        /// Gets and sets the property TrimSettings. &lt;p&gt;The trim settings for the time range
        /// to export. Required for VIDEO and TELEMETRY data types; optional for ANNOTATION data
        /// types.&lt;/p&gt;
        /// </summary>
        public TrimSettings TrimSettings
        {
            get { return this._trimSettings; }
            set { this._trimSettings = value; }
        }

        // Check to see if TrimSettings property is set
        internal bool IsSetTrimSettings()
        {
            return this._trimSettings != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Data model for a batch load task.
    /// </summary>
    public partial class DataModel
    {
        private List<DimensionMapping> _dimensionMappings = new List<DimensionMapping>();
        private string _measureNameColumn;
        private List<MixedMeasureMapping> _mixedMeasureMappings = new List<MixedMeasureMapping>();
        private MultiMeasureMappings _multiMeasureMappings;
        private string _timeColumn;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property DimensionMappings. 
        /// <para>
        /// Source to target mappings for dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<DimensionMapping> DimensionMappings
        {
            get { return this._dimensionMappings; }
            set { this._dimensionMappings = value; }
        }

        // Check to see if DimensionMappings property is set
        internal bool IsSetDimensionMappings()
        {
            return this._dimensionMappings != null && this._dimensionMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MeasureNameColumn.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MeasureNameColumn
        {
            get { return this._measureNameColumn; }
            set { this._measureNameColumn = value; }
        }

        // Check to see if MeasureNameColumn property is set
        internal bool IsSetMeasureNameColumn()
        {
            return this._measureNameColumn != null;
        }

        /// <summary>
        /// Gets and sets the property MixedMeasureMappings. 
        /// <para>
        /// Source to target mappings for measures.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<MixedMeasureMapping> MixedMeasureMappings
        {
            get { return this._mixedMeasureMappings; }
            set { this._mixedMeasureMappings = value; }
        }

        // Check to see if MixedMeasureMappings property is set
        internal bool IsSetMixedMeasureMappings()
        {
            return this._mixedMeasureMappings != null && this._mixedMeasureMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Source to target mappings for multi-measure records.
        /// </para>
        /// </summary>
        public MultiMeasureMappings MultiMeasureMappings
        {
            get { return this._multiMeasureMappings; }
            set { this._multiMeasureMappings = value; }
        }

        // Check to see if MultiMeasureMappings property is set
        internal bool IsSetMultiMeasureMappings()
        {
            return this._multiMeasureMappings != null;
        }

        /// <summary>
        /// Gets and sets the property TimeColumn. 
        /// <para>
        /// Source column to be mapped to time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TimeColumn
        {
            get { return this._timeColumn; }
            set { this._timeColumn = value; }
        }

        // Check to see if TimeColumn property is set
        internal bool IsSetTimeColumn()
        {
            return this._timeColumn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeUnit. 
        /// <para>
        ///  The granularity of the timestamp unit. It indicates if the time value is in seconds,
        /// milliseconds, nanoseconds, or other supported values. Default is <code>MILLISECONDS</code>.
        /// 
        /// </para>
        /// </summary>
        public TimeUnit TimeUnit
        {
            get { return this._timeUnit; }
            set { this._timeUnit = value; }
        }

        // Check to see if TimeUnit property is set
        internal bool IsSetTimeUnit()
        {
            return this._timeUnit != null;
        }

    }
}
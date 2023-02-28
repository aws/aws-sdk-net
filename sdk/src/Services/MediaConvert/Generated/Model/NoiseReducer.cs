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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Enable the Noise reducer feature to remove noise from your video output if necessary.
    /// Enable or disable this feature for each output individually. This setting is disabled
    /// by default. When you enable Noise reducer, you must also select a value for Noise
    /// reducer filter. For AVC outputs, when you include Noise reducer, you cannot include
    /// the Bandwidth reduction filter.
    /// </summary>
    public partial class NoiseReducer
    {
        private NoiseReducerFilter _filter;
        private NoiseReducerFilterSettings _filterSettings;
        private NoiseReducerSpatialFilterSettings _spatialFilterSettings;
        private NoiseReducerTemporalFilterSettings _temporalFilterSettings;

        /// <summary>
        /// Gets and sets the property Filter. Use Noise reducer filter (NoiseReducerFilter) to
        /// select one of the following spatial image filtering functions. To use this setting,
        /// you must also enable Noise reducer (NoiseReducer). * Bilateral preserves edges while
        /// reducing noise. * Mean (softest), Gaussian, Lanczos, and Sharpen (sharpest) do convolution
        /// filtering. * Conserve does min/max noise reduction. * Spatial does frequency-domain
        /// filtering based on JND principles. * Temporal optimizes video quality for complex
        /// motion.
        /// </summary>
        public NoiseReducerFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property FilterSettings. Settings for a noise reducer filter
        /// </summary>
        public NoiseReducerFilterSettings FilterSettings
        {
            get { return this._filterSettings; }
            set { this._filterSettings = value; }
        }

        // Check to see if FilterSettings property is set
        internal bool IsSetFilterSettings()
        {
            return this._filterSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SpatialFilterSettings. Noise reducer filter settings for
        /// spatial filter.
        /// </summary>
        public NoiseReducerSpatialFilterSettings SpatialFilterSettings
        {
            get { return this._spatialFilterSettings; }
            set { this._spatialFilterSettings = value; }
        }

        // Check to see if SpatialFilterSettings property is set
        internal bool IsSetSpatialFilterSettings()
        {
            return this._spatialFilterSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalFilterSettings. Noise reducer filter settings for
        /// temporal filter.
        /// </summary>
        public NoiseReducerTemporalFilterSettings TemporalFilterSettings
        {
            get { return this._temporalFilterSettings; }
            set { this._temporalFilterSettings = value; }
        }

        // Check to see if TemporalFilterSettings property is set
        internal bool IsSetTemporalFilterSettings()
        {
            return this._temporalFilterSettings != null;
        }

    }
}
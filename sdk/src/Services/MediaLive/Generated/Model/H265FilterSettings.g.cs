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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// H265 Filter Settings
    /// </summary>
    public partial class H265FilterSettings
    {
        /// <summary>
        /// Gets and sets the property AutoFilterSettings.
        /// </summary>
        public AutoFilterSettings AutoFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the AutoFilterSettings property is set.
        /// </summary>
        internal bool IsSetAutoFilterSettings() => this.AutoFilterSettings != null;

        /// <summary>
        /// Gets and sets the property BandwidthReductionFilterSettings.
        /// </summary>
        public BandwidthReductionFilterSettings BandwidthReductionFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthReductionFilterSettings property is set.
        /// </summary>
        internal bool IsSetBandwidthReductionFilterSettings() => this.BandwidthReductionFilterSettings != null;

        /// <summary>
        /// Gets and sets the property NoneFilterSettings.
        /// </summary>
        public NoneFilterSettings NoneFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the NoneFilterSettings property is set.
        /// </summary>
        internal bool IsSetNoneFilterSettings() => this.NoneFilterSettings != null;

        /// <summary>
        /// Gets and sets the property PerceptualFilterSettings.
        /// </summary>
        public PerceptualFilterSettings PerceptualFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the PerceptualFilterSettings property is set.
        /// </summary>
        internal bool IsSetPerceptualFilterSettings() => this.PerceptualFilterSettings != null;

        /// <summary>
        /// Gets and sets the property TemporalFilterSettings.
        /// </summary>
        public TemporalFilterSettings TemporalFilterSettings { get; set; }

        /// <summary>
        /// Checks to see if the TemporalFilterSettings property is set.
        /// </summary>
        internal bool IsSetTemporalFilterSettings() => this.TemporalFilterSettings != null;
    }
}

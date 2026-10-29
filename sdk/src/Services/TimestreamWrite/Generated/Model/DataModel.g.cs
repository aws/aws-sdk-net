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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Data model for a batch load task.
    /// </summary>
    public partial class DataModel
    {
        /// <summary>
        /// Gets and sets the property DimensionMappings. 
        /// <para>
        /// Source to target mappings for dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<DimensionMapping> DimensionMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionMapping>() : null;

        /// <summary>
        /// Checks to see if the DimensionMappings property is set.
        /// </summary>
        internal bool IsSetDimensionMappings() => this.DimensionMappings != null && (this.DimensionMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MeasureNameColumn. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MeasureNameColumn { get; set; }

        /// <summary>
        /// Checks to see if the MeasureNameColumn property is set.
        /// </summary>
        internal bool IsSetMeasureNameColumn() => this.MeasureNameColumn != null;

        /// <summary>
        /// Gets and sets the property MixedMeasureMappings. 
        /// <para>
        /// Source to target mappings for measures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<MixedMeasureMapping> MixedMeasureMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<MixedMeasureMapping>() : null;

        /// <summary>
        /// Checks to see if the MixedMeasureMappings property is set.
        /// </summary>
        internal bool IsSetMixedMeasureMappings() => this.MixedMeasureMappings != null && (this.MixedMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Source to target mappings for multi-measure records.
        /// </para>
        /// </summary>
        public MultiMeasureMappings MultiMeasureMappings { get; set; }

        /// <summary>
        /// Checks to see if the MultiMeasureMappings property is set.
        /// </summary>
        internal bool IsSetMultiMeasureMappings() => this.MultiMeasureMappings != null;

        /// <summary>
        /// Gets and sets the property TimeColumn. 
        /// <para>
        /// Source column to be mapped to time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TimeColumn { get; set; }

        /// <summary>
        /// Checks to see if the TimeColumn property is set.
        /// </summary>
        internal bool IsSetTimeColumn() => this.TimeColumn != null;

        /// <summary>
        /// Gets and sets the property TimeUnit. 
        /// <para>
        ///  The granularity of the timestamp unit. It indicates if the time value is in seconds,
        /// milliseconds, nanoseconds, or other supported values. Default is <c>MILLISECONDS</c>.
        /// 
        /// </para>
        /// </summary>
        public TimeUnit TimeUnit { get; set; }

        /// <summary>
        /// Checks to see if the TimeUnit property is set.
        /// </summary>
        internal bool IsSetTimeUnit() => this.TimeUnit != null;
    }
}

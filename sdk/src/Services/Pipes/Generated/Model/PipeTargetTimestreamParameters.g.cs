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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a Timestream for LiveAnalytics table as a target.
    /// </summary>
    public partial class PipeTargetTimestreamParameters
    {
        /// <summary>
        /// Gets and sets the property DimensionMappings. 
        /// <para>
        /// Map source data to dimensions in the target Timestream for LiveAnalytics table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/concepts.html">Amazon
        /// Timestream for LiveAnalytics concepts</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public List<DimensionMapping> DimensionMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DimensionMapping>() : null;

        /// <summary>
        /// Checks to see if the DimensionMappings property is set.
        /// </summary>
        internal bool IsSetDimensionMappings() => this.DimensionMappings != null && (this.DimensionMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EpochTimeUnit. 
        /// <para>
        /// The granularity of the time units used. Default is <c>MILLISECONDS</c>.
        /// </para>
        ///  
        /// <para>
        /// Required if <c>TimeFieldType</c> is specified as <c>EPOCH</c>.
        /// </para>
        /// </summary>
        public EpochTimeUnit EpochTimeUnit { get; set; }

        /// <summary>
        /// Checks to see if the EpochTimeUnit property is set.
        /// </summary>
        internal bool IsSetEpochTimeUnit() => this.EpochTimeUnit != null;

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Maps multiple measures from the source event to the same record in the specified Timestream
        /// for LiveAnalytics table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public List<MultiMeasureMapping> MultiMeasureMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<MultiMeasureMapping>() : null;

        /// <summary>
        /// Checks to see if the MultiMeasureMappings property is set.
        /// </summary>
        internal bool IsSetMultiMeasureMappings() => this.MultiMeasureMappings != null && (this.MultiMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SingleMeasureMappings. 
        /// <para>
        /// Mappings of single source data fields to individual records in the specified Timestream
        /// for LiveAnalytics table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public List<SingleMeasureMapping> SingleMeasureMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<SingleMeasureMapping>() : null;

        /// <summary>
        /// Checks to see if the SingleMeasureMappings property is set.
        /// </summary>
        internal bool IsSetSingleMeasureMappings() => this.SingleMeasureMappings != null && (this.SingleMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeFieldType. 
        /// <para>
        /// The type of time value used.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>EPOCH</c>.
        /// </para>
        /// </summary>
        public TimeFieldType TimeFieldType { get; set; }

        /// <summary>
        /// Checks to see if the TimeFieldType property is set.
        /// </summary>
        internal bool IsSetTimeFieldType() => this.TimeFieldType != null;

        /// <summary>
        /// Gets and sets the property TimeValue. 
        /// <para>
        /// Dynamic path to the source data field that represents the time value for your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TimeValue { get; set; }

        /// <summary>
        /// Checks to see if the TimeValue property is set.
        /// </summary>
        internal bool IsSetTimeValue() => this.TimeValue != null;

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// How to format the timestamps. For example, <c>yyyy-MM-dd'T'HH:mm:ss'Z'</c>.
        /// </para>
        ///  
        /// <para>
        /// Required if <c>TimeFieldType</c> is specified as <c>TIMESTAMP_FORMAT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TimestampFormat { get; set; }

        /// <summary>
        /// Checks to see if the TimestampFormat property is set.
        /// </summary>
        internal bool IsSetTimestampFormat() => this.TimestampFormat != null;

        /// <summary>
        /// Gets and sets the property VersionValue. 
        /// <para>
        /// 64 bit version value or source data field that represents the version value for your
        /// data.
        /// </para>
        ///  
        /// <para>
        /// Write requests with a higher version number will update the existing measure values
        /// of the record and version. In cases where the measure value is the same, the version
        /// will still be updated. 
        /// </para>
        ///  
        /// <para>
        /// Default value is 1. 
        /// </para>
        ///  
        /// <para>
        /// Timestream for LiveAnalytics does not support updating partial measure values in a
        /// record.
        /// </para>
        ///  
        /// <para>
        /// Write requests for duplicate data with a higher version number will update the existing
        /// measure value and version. In cases where the measure value is the same, <c>Version</c>
        /// will still be updated. Default value is <c>1</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Version</c> must be <c>1</c> or greater, or you will receive a <c>ValidationException</c>
        /// error.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VersionValue { get; set; }

        /// <summary>
        /// Checks to see if the VersionValue property is set.
        /// </summary>
        internal bool IsSetVersionValue() => this.VersionValue != null;
    }
}

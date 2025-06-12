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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
        private List<DimensionMapping> _dimensionMappings = AWSConfigs.InitializeCollections ? new List<DimensionMapping>() : null;
        private EpochTimeUnit _epochTimeUnit;
        private List<MultiMeasureMapping> _multiMeasureMappings = AWSConfigs.InitializeCollections ? new List<MultiMeasureMapping>() : null;
        private List<SingleMeasureMapping> _singleMeasureMappings = AWSConfigs.InitializeCollections ? new List<SingleMeasureMapping>() : null;
        private TimeFieldType _timeFieldType;
        private string _timestampFormat;
        private string _timeValue;
        private string _versionValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public List<DimensionMapping> DimensionMappings
        {
            get { return this._dimensionMappings; }
            set { this._dimensionMappings = value; }
        }

        // Check to see if DimensionMappings property is set
        internal bool IsSetDimensionMappings()
        {
            return this._dimensionMappings != null && (this._dimensionMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public EpochTimeUnit EpochTimeUnit
        {
            get { return this._epochTimeUnit; }
            set { this._epochTimeUnit = value; }
        }

        // Check to see if EpochTimeUnit property is set
        internal bool IsSetEpochTimeUnit()
        {
            return this._epochTimeUnit != null;
        }

        /// <summary>
        /// Gets and sets the property MultiMeasureMappings. 
        /// <para>
        /// Maps multiple measures from the source event to the same record in the specified Timestream
        /// for LiveAnalytics table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public List<MultiMeasureMapping> MultiMeasureMappings
        {
            get { return this._multiMeasureMappings; }
            set { this._multiMeasureMappings = value; }
        }

        // Check to see if MultiMeasureMappings property is set
        internal bool IsSetMultiMeasureMappings()
        {
            return this._multiMeasureMappings != null && (this._multiMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SingleMeasureMappings. 
        /// <para>
        /// Mappings of single source data fields to individual records in the specified Timestream
        /// for LiveAnalytics table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public List<SingleMeasureMapping> SingleMeasureMappings
        {
            get { return this._singleMeasureMappings; }
            set { this._singleMeasureMappings = value; }
        }

        // Check to see if SingleMeasureMappings property is set
        internal bool IsSetSingleMeasureMappings()
        {
            return this._singleMeasureMappings != null && (this._singleMeasureMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public TimeFieldType TimeFieldType
        {
            get { return this._timeFieldType; }
            set { this._timeFieldType = value; }
        }

        // Check to see if TimeFieldType property is set
        internal bool IsSetTimeFieldType()
        {
            return this._timeFieldType != null;
        }

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
        [AWSProperty(Min=1, Max=256)]
        public string TimestampFormat
        {
            get { return this._timestampFormat; }
            set { this._timestampFormat = value; }
        }

        // Check to see if TimestampFormat property is set
        internal bool IsSetTimestampFormat()
        {
            return this._timestampFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TimeValue. 
        /// <para>
        /// Dynamic path to the source data field that represents the time value for your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TimeValue
        {
            get { return this._timeValue; }
            set { this._timeValue = value; }
        }

        // Check to see if TimeValue property is set
        internal bool IsSetTimeValue()
        {
            return this._timeValue != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VersionValue
        {
            get { return this._versionValue; }
            set { this._versionValue = value; }
        }

        // Check to see if VersionValue property is set
        internal bool IsSetVersionValue()
        {
            return this._versionValue != null;
        }

    }
}
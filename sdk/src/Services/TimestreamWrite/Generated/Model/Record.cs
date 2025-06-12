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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents a time-series data point being written into Timestream. Each record contains
    /// an array of dimensions. Dimensions represent the metadata attributes of a time-series
    /// data point, such as the instance name or Availability Zone of an EC2 instance. A record
    /// also contains the measure name, which is the name of the measure being collected (for
    /// example, the CPU utilization of an EC2 instance). Additionally, a record contains
    /// the measure value and the value type, which is the data type of the measure value.
    /// Also, the record contains the timestamp of when the measure was collected and the
    /// timestamp unit, which represents the granularity of the timestamp. 
    /// 
    ///  
    /// <para>
    ///  Records have a <c>Version</c> field, which is a 64-bit <c>long</c> that you can use
    /// for updating data points. Writes of a duplicate record with the same dimension, timestamp,
    /// and measure name but different measure value will only succeed if the <c>Version</c>
    /// attribute of the record in the write request is higher than that of the existing record.
    /// Timestream defaults to a <c>Version</c> of <c>1</c> for records without the <c>Version</c>
    /// field. 
    /// </para>
    /// </summary>
    public partial class Record
    {
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private string _measureName;
        private string _measureValue;
        private List<MeasureValue> _measureValues = AWSConfigs.InitializeCollections ? new List<MeasureValue>() : null;
        private MeasureValueType _measureValueType;
        private string _time;
        private TimeUnit _timeUnit;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Contains the list of dimensions for time-series data points.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=128)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MeasureName. 
        /// <para>
        /// Measure represents the data attribute of the time series. For example, the CPU utilization
        /// of an EC2 instance or the RPM of a wind turbine are measures. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string MeasureName
        {
            get { return this._measureName; }
            set { this._measureName = value; }
        }

        // Check to see if MeasureName property is set
        internal bool IsSetMeasureName()
        {
            return this._measureName != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureValue. 
        /// <para>
        ///  Contains the measure value for the time-series data point. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MeasureValue
        {
            get { return this._measureValue; }
            set { this._measureValue = value; }
        }

        // Check to see if MeasureValue property is set
        internal bool IsSetMeasureValue()
        {
            return this._measureValue != null;
        }

        /// <summary>
        /// Gets and sets the property MeasureValues. 
        /// <para>
        ///  Contains the list of MeasureValue for time-series data points. 
        /// </para>
        ///  
        /// <para>
        ///  This is only allowed for type <c>MULTI</c>. For scalar values, use <c>MeasureValue</c>
        /// attribute of the record directly. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MeasureValue> MeasureValues
        {
            get { return this._measureValues; }
            set { this._measureValues = value; }
        }

        // Check to see if MeasureValues property is set
        internal bool IsSetMeasureValues()
        {
            return this._measureValues != null && (this._measureValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        ///  Contains the data type of the measure value for the time-series data point. Default
        /// type is <c>DOUBLE</c>. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/writes.html#writes.data-types">Data
        /// types</a>.
        /// </para>
        /// </summary>
        public MeasureValueType MeasureValueType
        {
            get { return this._measureValueType; }
            set { this._measureValueType = value; }
        }

        // Check to see if MeasureValueType property is set
        internal bool IsSetMeasureValueType()
        {
            return this._measureValueType != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        ///  Contains the time at which the measure value for the data point was collected. The
        /// time value plus the unit provides the time elapsed since the epoch. For example, if
        /// the time value is <c>12345</c> and the unit is <c>ms</c>, then <c>12345 ms</c> have
        /// elapsed since the epoch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

        /// <summary>
        /// Gets and sets the property TimeUnit. 
        /// <para>
        ///  The granularity of the timestamp unit. It indicates if the time value is in seconds,
        /// milliseconds, nanoseconds, or other supported values. Default is <c>MILLISECONDS</c>.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// 64-bit attribute used for record updates. Write requests for duplicate data with a
        /// higher version number will update the existing measure value and version. In cases
        /// where the measure value is the same, <c>Version</c> will still be updated. Default
        /// value is <c>1</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Version</c> must be <c>1</c> or greater, or you will receive a <c>ValidationException</c>
        /// error.
        /// </para>
        ///  </note>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}
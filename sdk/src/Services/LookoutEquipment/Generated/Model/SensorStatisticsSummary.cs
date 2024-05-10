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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Summary of ingestion statistics like whether data exists, number of missing values,
    /// number of invalid values and so on related to the particular sensor.
    /// </summary>
    public partial class SensorStatisticsSummary
    {
        private CategoricalValues _categoricalValues;
        private string _componentName;
        private DateTime? _dataEndTime;
        private bool? _dataExists;
        private DateTime? _dataStartTime;
        private CountPercent _duplicateTimestamps;
        private CountPercent _invalidDateEntries;
        private CountPercent _invalidValues;
        private LargeTimestampGaps _largeTimestampGaps;
        private CountPercent _missingValues;
        private MonotonicValues _monotonicValues;
        private MultipleOperatingModes _multipleOperatingModes;
        private string _sensorName;

        /// <summary>
        /// Gets and sets the property CategoricalValues. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// is categorical. 
        /// </para>
        /// </summary>
        public CategoricalValues CategoricalValues
        {
            get { return this._categoricalValues; }
            set { this._categoricalValues = value; }
        }

        // Check to see if CategoricalValues property is set
        internal bool IsSetCategoricalValues()
        {
            return this._categoricalValues != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        ///  Name of the component to which the particular sensor belongs for which the statistics
        /// belong to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property DataEndTime. 
        /// <para>
        ///  Indicates the time reference to indicate the end of valid data associated with the
        /// sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime
        {
            get { return this._dataEndTime; }
            set { this._dataEndTime = value; }
        }

        // Check to see if DataEndTime property is set
        internal bool IsSetDataEndTime()
        {
            return this._dataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataExists. 
        /// <para>
        ///  Parameter that indicates whether data exists for the sensor that the statistics belong
        /// to. 
        /// </para>
        /// </summary>
        public bool? DataExists
        {
            get { return this._dataExists; }
            set { this._dataExists = value; }
        }

        // Check to see if DataExists property is set
        internal bool IsSetDataExists()
        {
            return this._dataExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        ///  Indicates the time reference to indicate the beginning of valid data associated with
        /// the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime
        {
            get { return this._dataStartTime; }
            set { this._dataStartTime = value; }
        }

        // Check to see if DataStartTime property is set
        internal bool IsSetDataStartTime()
        {
            return this._dataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DuplicateTimestamps. 
        /// <para>
        ///  Parameter that describes the total number of duplicate timestamp records associated
        /// with the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent DuplicateTimestamps
        {
            get { return this._duplicateTimestamps; }
            set { this._duplicateTimestamps = value; }
        }

        // Check to see if DuplicateTimestamps property is set
        internal bool IsSetDuplicateTimestamps()
        {
            return this._duplicateTimestamps != null;
        }

        /// <summary>
        /// Gets and sets the property InvalidDateEntries. 
        /// <para>
        ///  Parameter that describes the total number of invalid date entries associated with
        /// the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent InvalidDateEntries
        {
            get { return this._invalidDateEntries; }
            set { this._invalidDateEntries = value; }
        }

        // Check to see if InvalidDateEntries property is set
        internal bool IsSetInvalidDateEntries()
        {
            return this._invalidDateEntries != null;
        }

        /// <summary>
        /// Gets and sets the property InvalidValues. 
        /// <para>
        ///  Parameter that describes the total number of, and percentage of, values that are
        /// invalid for the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent InvalidValues
        {
            get { return this._invalidValues; }
            set { this._invalidValues = value; }
        }

        // Check to see if InvalidValues property is set
        internal bool IsSetInvalidValues()
        {
            return this._invalidValues != null;
        }

        /// <summary>
        /// Gets and sets the property LargeTimestampGaps. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// contains one or more large gaps between consecutive timestamps. 
        /// </para>
        /// </summary>
        public LargeTimestampGaps LargeTimestampGaps
        {
            get { return this._largeTimestampGaps; }
            set { this._largeTimestampGaps = value; }
        }

        // Check to see if LargeTimestampGaps property is set
        internal bool IsSetLargeTimestampGaps()
        {
            return this._largeTimestampGaps != null;
        }

        /// <summary>
        /// Gets and sets the property MissingValues. 
        /// <para>
        ///  Parameter that describes the total number of, and percentage of, values that are
        /// missing for the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent MissingValues
        {
            get { return this._missingValues; }
            set { this._missingValues = value; }
        }

        // Check to see if MissingValues property is set
        internal bool IsSetMissingValues()
        {
            return this._missingValues != null;
        }

        /// <summary>
        /// Gets and sets the property MonotonicValues. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// is mostly monotonic. 
        /// </para>
        /// </summary>
        public MonotonicValues MonotonicValues
        {
            get { return this._monotonicValues; }
            set { this._monotonicValues = value; }
        }

        // Check to see if MonotonicValues property is set
        internal bool IsSetMonotonicValues()
        {
            return this._monotonicValues != null;
        }

        /// <summary>
        /// Gets and sets the property MultipleOperatingModes. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// has more than one operating mode. 
        /// </para>
        /// </summary>
        public MultipleOperatingModes MultipleOperatingModes
        {
            get { return this._multipleOperatingModes; }
            set { this._multipleOperatingModes = value; }
        }

        // Check to see if MultipleOperatingModes property is set
        internal bool IsSetMultipleOperatingModes()
        {
            return this._multipleOperatingModes != null;
        }

        /// <summary>
        /// Gets and sets the property SensorName. 
        /// <para>
        ///  Name of the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string SensorName
        {
            get { return this._sensorName; }
            set { this._sensorName = value; }
        }

        // Check to see if SensorName property is set
        internal bool IsSetSensorName()
        {
            return this._sensorName != null;
        }

    }
}
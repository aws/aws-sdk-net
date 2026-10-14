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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Summary of ingestion statistics like whether data exists, number of missing values,
    /// number of invalid values and so on related to the particular sensor.
    /// </summary>
    public partial class SensorStatisticsSummary
    {
        /// <summary>
        /// Gets and sets the property CategoricalValues. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// is categorical. 
        /// </para>
        /// </summary>
        public CategoricalValues CategoricalValues { get; set; }

        /// <summary>
        /// Checks to see if the CategoricalValues property is set.
        /// </summary>
        internal bool IsSetCategoricalValues() => this.CategoricalValues != null;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        ///  Name of the component to which the particular sensor belongs for which the statistics
        /// belong to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property DataEndTime. 
        /// <para>
        ///  Indicates the time reference to indicate the end of valid data associated with the
        /// sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DataEndTime property is set.
        /// </summary>
        internal bool IsSetDataEndTime() => this.DataEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataExists. 
        /// <para>
        ///  Parameter that indicates whether data exists for the sensor that the statistics belong
        /// to. 
        /// </para>
        /// </summary>
        public bool? DataExists { get; set; }

        /// <summary>
        /// Checks to see if the DataExists property is set.
        /// </summary>
        internal bool IsSetDataExists() => this.DataExists.HasValue;

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        ///  Indicates the time reference to indicate the beginning of valid data associated with
        /// the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DataStartTime property is set.
        /// </summary>
        internal bool IsSetDataStartTime() => this.DataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DuplicateTimestamps. 
        /// <para>
        ///  Parameter that describes the total number of duplicate timestamp records associated
        /// with the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent DuplicateTimestamps { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateTimestamps property is set.
        /// </summary>
        internal bool IsSetDuplicateTimestamps() => this.DuplicateTimestamps != null;

        /// <summary>
        /// Gets and sets the property InvalidDateEntries. 
        /// <para>
        ///  Parameter that describes the total number of invalid date entries associated with
        /// the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent InvalidDateEntries { get; set; }

        /// <summary>
        /// Checks to see if the InvalidDateEntries property is set.
        /// </summary>
        internal bool IsSetInvalidDateEntries() => this.InvalidDateEntries != null;

        /// <summary>
        /// Gets and sets the property InvalidValues. 
        /// <para>
        ///  Parameter that describes the total number of, and percentage of, values that are
        /// invalid for the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent InvalidValues { get; set; }

        /// <summary>
        /// Checks to see if the InvalidValues property is set.
        /// </summary>
        internal bool IsSetInvalidValues() => this.InvalidValues != null;

        /// <summary>
        /// Gets and sets the property LargeTimestampGaps. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// contains one or more large gaps between consecutive timestamps. 
        /// </para>
        /// </summary>
        public LargeTimestampGaps LargeTimestampGaps { get; set; }

        /// <summary>
        /// Checks to see if the LargeTimestampGaps property is set.
        /// </summary>
        internal bool IsSetLargeTimestampGaps() => this.LargeTimestampGaps != null;

        /// <summary>
        /// Gets and sets the property MissingValues. 
        /// <para>
        ///  Parameter that describes the total number of, and percentage of, values that are
        /// missing for the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        public CountPercent MissingValues { get; set; }

        /// <summary>
        /// Checks to see if the MissingValues property is set.
        /// </summary>
        internal bool IsSetMissingValues() => this.MissingValues != null;

        /// <summary>
        /// Gets and sets the property MonotonicValues. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// is mostly monotonic. 
        /// </para>
        /// </summary>
        public MonotonicValues MonotonicValues { get; set; }

        /// <summary>
        /// Checks to see if the MonotonicValues property is set.
        /// </summary>
        internal bool IsSetMonotonicValues() => this.MonotonicValues != null;

        /// <summary>
        /// Gets and sets the property MultipleOperatingModes. 
        /// <para>
        ///  Parameter that describes potential risk about whether data associated with the sensor
        /// has more than one operating mode. 
        /// </para>
        /// </summary>
        public MultipleOperatingModes MultipleOperatingModes { get; set; }

        /// <summary>
        /// Checks to see if the MultipleOperatingModes property is set.
        /// </summary>
        internal bool IsSetMultipleOperatingModes() => this.MultipleOperatingModes != null;

        /// <summary>
        /// Gets and sets the property SensorName. 
        /// <para>
        ///  Name of the sensor that the statistics belong to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string SensorName { get; set; }

        /// <summary>
        /// Checks to see if the SensorName property is set.
        /// </summary>
        internal bool IsSetSensorName() => this.SensorName != null;
    }
}

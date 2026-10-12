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
    /// DataQualitySummary gives aggregated statistics over all the sensors about a completed
    /// ingestion job. It primarily gives more information about statistics over different
    /// incorrect data like MissingCompleteSensorData, MissingSensorData, UnsupportedDateFormats,
    /// InsufficientSensorData, DuplicateTimeStamps.
    /// </summary>
    public partial class DataQualitySummary
    {
        /// <summary>
        /// Gets and sets the property DuplicateTimestamps. 
        /// <para>
        ///  Parameter that gives information about duplicate timestamps in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DuplicateTimestamps DuplicateTimestamps { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateTimestamps property is set.
        /// </summary>
        internal bool IsSetDuplicateTimestamps() => this.DuplicateTimestamps != null;

        /// <summary>
        /// Gets and sets the property InsufficientSensorData. 
        /// <para>
        ///  Parameter that gives information about insufficient data for sensors in the dataset.
        /// This includes information about those sensors that have complete data missing and
        /// those with a short date range. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsufficientSensorData InsufficientSensorData { get; set; }

        /// <summary>
        /// Checks to see if the InsufficientSensorData property is set.
        /// </summary>
        internal bool IsSetInsufficientSensorData() => this.InsufficientSensorData != null;

        /// <summary>
        /// Gets and sets the property InvalidSensorData. 
        /// <para>
        ///  Parameter that gives information about data that is invalid over all the sensors
        /// in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvalidSensorData InvalidSensorData { get; set; }

        /// <summary>
        /// Checks to see if the InvalidSensorData property is set.
        /// </summary>
        internal bool IsSetInvalidSensorData() => this.InvalidSensorData != null;

        /// <summary>
        /// Gets and sets the property MissingSensorData. 
        /// <para>
        ///  Parameter that gives information about data that is missing over all the sensors
        /// in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MissingSensorData MissingSensorData { get; set; }

        /// <summary>
        /// Checks to see if the MissingSensorData property is set.
        /// </summary>
        internal bool IsSetMissingSensorData() => this.MissingSensorData != null;

        /// <summary>
        /// Gets and sets the property UnsupportedTimestamps. 
        /// <para>
        ///  Parameter that gives information about unsupported timestamps in the input data.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UnsupportedTimestamps UnsupportedTimestamps { get; set; }

        /// <summary>
        /// Checks to see if the UnsupportedTimestamps property is set.
        /// </summary>
        internal bool IsSetUnsupportedTimestamps() => this.UnsupportedTimestamps != null;
    }
}

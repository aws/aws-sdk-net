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
    /// DataQualitySummary gives aggregated statistics over all the sensors about a completed
    /// ingestion job. It primarily gives more information about statistics over different
    /// incorrect data like MissingCompleteSensorData, MissingSensorData, UnsupportedDateFormats,
    /// InsufficientSensorData, DuplicateTimeStamps.
    /// </summary>
    public partial class DataQualitySummary
    {
        private DuplicateTimestamps _duplicateTimestamps;
        private InsufficientSensorData _insufficientSensorData;
        private InvalidSensorData _invalidSensorData;
        private MissingSensorData _missingSensorData;
        private UnsupportedTimestamps _unsupportedTimestamps;

        /// <summary>
        /// Gets and sets the property DuplicateTimestamps. 
        /// <para>
        ///  Parameter that gives information about duplicate timestamps in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DuplicateTimestamps DuplicateTimestamps
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
        /// Gets and sets the property InsufficientSensorData. 
        /// <para>
        ///  Parameter that gives information about insufficient data for sensors in the dataset.
        /// This includes information about those sensors that have complete data missing and
        /// those with a short date range. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InsufficientSensorData InsufficientSensorData
        {
            get { return this._insufficientSensorData; }
            set { this._insufficientSensorData = value; }
        }

        // Check to see if InsufficientSensorData property is set
        internal bool IsSetInsufficientSensorData()
        {
            return this._insufficientSensorData != null;
        }

        /// <summary>
        /// Gets and sets the property InvalidSensorData. 
        /// <para>
        ///  Parameter that gives information about data that is invalid over all the sensors
        /// in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvalidSensorData InvalidSensorData
        {
            get { return this._invalidSensorData; }
            set { this._invalidSensorData = value; }
        }

        // Check to see if InvalidSensorData property is set
        internal bool IsSetInvalidSensorData()
        {
            return this._invalidSensorData != null;
        }

        /// <summary>
        /// Gets and sets the property MissingSensorData. 
        /// <para>
        ///  Parameter that gives information about data that is missing over all the sensors
        /// in the input data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MissingSensorData MissingSensorData
        {
            get { return this._missingSensorData; }
            set { this._missingSensorData = value; }
        }

        // Check to see if MissingSensorData property is set
        internal bool IsSetMissingSensorData()
        {
            return this._missingSensorData != null;
        }

        /// <summary>
        /// Gets and sets the property UnsupportedTimestamps. 
        /// <para>
        ///  Parameter that gives information about unsupported timestamps in the input data.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnsupportedTimestamps UnsupportedTimestamps
        {
            get { return this._unsupportedTimestamps; }
            set { this._unsupportedTimestamps = value; }
        }

        // Check to see if UnsupportedTimestamps property is set
        internal bool IsSetUnsupportedTimestamps()
        {
            return this._unsupportedTimestamps != null;
        }

    }
}
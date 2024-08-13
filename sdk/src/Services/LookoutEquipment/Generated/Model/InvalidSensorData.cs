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
    /// Entity that comprises aggregated information on sensors having insufficient data.
    /// </summary>
    public partial class InvalidSensorData
    {
        private int? _affectedSensorCount;
        private int? _totalNumberOfInvalidValues;

        /// <summary>
        /// Gets and sets the property AffectedSensorCount. 
        /// <para>
        ///  Indicates the number of sensors that have at least some invalid values. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? AffectedSensorCount
        {
            get { return this._affectedSensorCount; }
            set { this._affectedSensorCount = value; }
        }

        // Check to see if AffectedSensorCount property is set
        internal bool IsSetAffectedSensorCount()
        {
            return this._affectedSensorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfInvalidValues. 
        /// <para>
        ///  Indicates the total number of invalid values across all the sensors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalNumberOfInvalidValues
        {
            get { return this._totalNumberOfInvalidValues; }
            set { this._totalNumberOfInvalidValues = value; }
        }

        // Check to see if TotalNumberOfInvalidValues property is set
        internal bool IsSetTotalNumberOfInvalidValues()
        {
            return this._totalNumberOfInvalidValues.HasValue; 
        }

    }
}
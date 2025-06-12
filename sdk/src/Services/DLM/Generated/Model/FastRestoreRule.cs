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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom snapshot policies only]</b> Specifies a rule for enabling fast snapshot
    /// restore for snapshots created by snapshot policies. You can enable fast snapshot restore
    /// based on either a count or a time interval.
    /// </summary>
    public partial class FastRestoreRule
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _count;
        private int? _interval;
        private RetentionIntervalUnitValues _intervalUnit;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones in which to enable fast snapshot restore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of snapshots to be enabled with fast snapshot restore.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The amount of time to enable fast snapshot restore. The maximum is 100 years. This
        /// is equivalent to 1200 months, 5200 weeks, or 36500 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalUnit. 
        /// <para>
        /// The unit of time for enabling fast snapshot restore.
        /// </para>
        /// </summary>
        public RetentionIntervalUnitValues IntervalUnit
        {
            get { return this._intervalUnit; }
            set { this._intervalUnit = value; }
        }

        // Check to see if IntervalUnit property is set
        internal bool IsSetIntervalUnit()
        {
            return this._intervalUnit != null;
        }

    }
}
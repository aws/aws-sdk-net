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
    /// <b>[Custom snapshot policies only]</b> Describes the retention rule for archived
    /// snapshots. Once the archive retention threshold is met, the snapshots are permanently
    /// deleted from the archive tier.
    /// 
    ///  <note> 
    /// <para>
    /// The archive retention rule must retain snapshots in the archive tier for a minimum
    /// of 90 days.
    /// </para>
    ///  </note> 
    /// <para>
    /// For <b>count-based schedules</b>, you must specify <b>Count</b>. For <b>age-based
    /// schedules</b>, you must specify <b>Interval</b> and <b> IntervalUnit</b>.
    /// </para>
    ///  
    /// <para>
    /// For more information about using snapshot archiving, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-ami-policy.html#dlm-archive">Considerations
    /// for snapshot lifecycle policies</a>.
    /// </para>
    /// </summary>
    public partial class RetentionArchiveTier
    {
        private int? _count;
        private int? _interval;
        private RetentionIntervalUnitValues _intervalUnit;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The maximum number of snapshots to retain in the archive storage tier for each volume.
        /// The count must ensure that each snapshot remains in the archive tier for at least
        /// 90 days. For example, if the schedule creates snapshots every 30 days, you must specify
        /// a count of 3 or more to ensure that each snapshot is archived for at least 90 days.
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
        /// Specifies the period of time to retain snapshots in the archive tier. After this period
        /// expires, the snapshot is permanently deleted.
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
        /// The unit of time in which to measure the <b>Interval</b>. For example, to retain a
        /// snapshots in the archive tier for 6 months, specify <c>Interval=6</c> and <c>IntervalUnit=MONTHS</c>.
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
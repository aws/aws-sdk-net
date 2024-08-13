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
    /// <b>[Custom snapshot and AMI policies only]</b> Specifies a retention rule for snapshots
    /// created by snapshot policies, or for AMIs created by AMI policies.
    /// 
    ///  <note> 
    /// <para>
    /// For snapshot policies that have an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>,
    /// this retention rule applies to standard tier retention. When the retention threshold
    /// is met, snapshots are moved from the standard to the archive tier.
    /// </para>
    ///  
    /// <para>
    /// For snapshot policies that do not have an <b>ArchiveRule</b>, snapshots are permanently
    /// deleted when this retention threshold is met.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can retain snapshots based on either a count or a time interval.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Count-based retention</b> 
    /// </para>
    ///  
    /// <para>
    /// You must specify <b>Count</b>. If you specify an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>
    /// for the schedule, then you can specify a retention count of <c>0</c> to archive snapshots
    /// immediately after creation. If you specify a <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_FastRestoreRule.html">FastRestoreRule</a>,
    /// <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ShareRule.html">ShareRule</a>,
    /// or a <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_CrossRegionCopyRule.html">CrossRegionCopyRule</a>,
    /// then you must specify a retention count of <c>1</c> or more.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Age-based retention</b> 
    /// </para>
    ///  
    /// <para>
    /// You must specify <b>Interval</b> and <b>IntervalUnit</b>. If you specify an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>
    /// for the schedule, then you can specify a retention interval of <c>0</c> days to archive
    /// snapshots immediately after creation. If you specify a <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_FastRestoreRule.html">FastRestoreRule</a>,
    /// <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ShareRule.html">ShareRule</a>,
    /// or a <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_CrossRegionCopyRule.html">CrossRegionCopyRule</a>,
    /// then you must specify a retention interval of <c>1</c> day or more.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetainRule
    {
        private int? _count;
        private int? _interval;
        private RetentionIntervalUnitValues _intervalUnit;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of snapshots to retain for each volume, up to a maximum of 1000. For example
        /// if you want to retain a maximum of three snapshots, specify <c>3</c>. When the fourth
        /// snapshot is created, the oldest retained snapshot is deleted, or it is moved to the
        /// archive tier if you have specified an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// The amount of time to retain each snapshot. The maximum is 100 years. This is equivalent
        /// to 1200 months, 5200 weeks, or 36500 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// The unit of time for time-based retention. For example, to retain snapshots for 3
        /// months, specify <c>Interval=3</c> and <c>IntervalUnit=MONTHS</c>. Once the snapshot
        /// has been retained for 3 months, it is deleted, or it is moved to the archive tier
        /// if you have specified an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>.
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
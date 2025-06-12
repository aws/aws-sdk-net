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
    /// <b>[Custom snapshot and AMI policies only]</b> Specifies when the policy should create
    /// snapshots or AMIs.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// You must specify either <b>CronExpression</b>, or <b>Interval</b>, <b>IntervalUnit</b>,
    /// and <b>Times</b>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you need to specify an <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_ArchiveRule.html">ArchiveRule</a>
    /// for the schedule, then you must specify a creation frequency of at least 28 days.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateRule
    {
        private string _cronExpression;
        private int? _interval;
        private IntervalUnitValues _intervalUnit;
        private LocationValues _location;
        private List<Script> _scripts = AWSConfigs.InitializeCollections ? new List<Script>() : null;
        private List<string> _times = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The schedule, as a Cron expression. The schedule interval must be between 1 hour and
        /// 1 year. For more information, see the <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-cron-expressions.html">Cron
        /// expressions reference</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=106)]
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval between snapshots. The supported values are 1, 2, 3, 4, 6, 8, 12, and
        /// 24.
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
        /// The interval unit.
        /// </para>
        /// </summary>
        public IntervalUnitValues IntervalUnit
        {
            get { return this._intervalUnit; }
            set { this._intervalUnit = value; }
        }

        // Check to see if IntervalUnit property is set
        internal bool IsSetIntervalUnit()
        {
            return this._intervalUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  <b>[Custom snapshot policies only]</b> Specifies the destination for snapshots created
        /// by the policy. The allowed destinations depend on the location of the targeted resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the policy targets resources in a Region, then you must create snapshots in the
        /// same Region as the source resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the policy targets resources in a Local Zone, you can create snapshots in the same
        /// Local Zone or in its parent Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the policy targets resources on an Outpost, then you can create snapshots on the
        /// same Outpost or in its parent Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create snapshots in the same Region as the source resource, specify <c>CLOUD</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create snapshots in the same Local Zone as the source resource, specify <c>LOCAL_ZONE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create snapshots on the same Outpost as the source resource, specify <c>OUTPOST_LOCAL</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>CLOUD</c> 
        /// </para>
        /// </summary>
        public LocationValues Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Scripts. 
        /// <para>
        ///  <b>[Custom snapshot policies that target instances only]</b> Specifies pre and/or
        /// post scripts for a snapshot lifecycle policy that targets instances. This is useful
        /// for creating application-consistent snapshots, or for performing specific administrative
        /// tasks before or after Amazon Data Lifecycle Manager initiates snapshot creation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/automate-app-consistent-backups.html">Automating
        /// application-consistent snapshots with pre and post scripts</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Script> Scripts
        {
            get { return this._scripts; }
            set { this._scripts = value; }
        }

        // Check to see if Scripts property is set
        internal bool IsSetScripts()
        {
            return this._scripts != null && (this._scripts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Times. 
        /// <para>
        /// The time, in UTC, to start the operation. The supported format is hh:mm.
        /// </para>
        ///  
        /// <para>
        /// The operation occurs within a one-hour window following the specified time. If you
        /// do not specify a time, Amazon Data Lifecycle Manager selects a time within the next
        /// 24 hours.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> Times
        {
            get { return this._times; }
            set { this._times = value; }
        }

        // Check to see if Times property is set
        internal bool IsSetTimes()
        {
            return this._times != null && (this._times.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
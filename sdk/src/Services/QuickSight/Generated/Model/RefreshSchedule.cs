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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The refresh schedule of a dataset.
    /// </summary>
    public partial class RefreshSchedule
    {
        private string _arn;
        private IngestionType _refreshType;
        private RefreshFrequency _scheduleFrequency;
        private string _scheduleId;
        private DateTime? _startAfterDateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the refresh schedule.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshType. 
        /// <para>
        /// The type of refresh that a datset undergoes. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FULL_REFRESH</c>: A complete refresh of a dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCREMENTAL_REFRESH</c>: A partial refresh of some rows of a dataset, based on
        /// the time window specified.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on full and incremental refreshes, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/refreshing-imported-data.html">Refreshing
        /// SPICE data</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestionType RefreshType
        {
            get { return this._refreshType; }
            set { this._refreshType = value; }
        }

        // Check to see if RefreshType property is set
        internal bool IsSetRefreshType()
        {
            return this._refreshType != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The frequency for the refresh schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RefreshFrequency ScheduleFrequency
        {
            get { return this._scheduleFrequency; }
            set { this._scheduleFrequency = value; }
        }

        // Check to see if ScheduleFrequency property is set
        internal bool IsSetScheduleFrequency()
        {
            return this._scheduleFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// An identifier for the refresh schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        // Check to see if ScheduleId property is set
        internal bool IsSetScheduleId()
        {
            return this._scheduleId != null;
        }

        /// <summary>
        /// Gets and sets the property StartAfterDateTime. 
        /// <para>
        /// Time after which the refresh schedule can be started, expressed in <c>YYYY-MM-DDTHH:MM:SS</c>
        /// format.
        /// </para>
        /// </summary>
        public DateTime? StartAfterDateTime
        {
            get { return this._startAfterDateTime; }
            set { this._startAfterDateTime = value; }
        }

        // Check to see if StartAfterDateTime property is set
        internal bool IsSetStartAfterDateTime()
        {
            return this._startAfterDateTime.HasValue; 
        }

    }
}
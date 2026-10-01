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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The refresh schedule of a dataset.
    /// </summary>
    public partial class RefreshSchedule
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the refresh schedule.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// SPICE data</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestionType RefreshType { get; set; }

        /// <summary>
        /// Checks to see if the RefreshType property is set.
        /// </summary>
        internal bool IsSetRefreshType() => this.RefreshType != null;

        /// <summary>
        /// Gets and sets the property ScheduleFrequency. 
        /// <para>
        /// The frequency for the refresh schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RefreshFrequency ScheduleFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleFrequency property is set.
        /// </summary>
        internal bool IsSetScheduleFrequency() => this.ScheduleFrequency != null;

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// An identifier for the refresh schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleId property is set.
        /// </summary>
        internal bool IsSetScheduleId() => this.ScheduleId != null;

        /// <summary>
        /// Gets and sets the property StartAfterDateTime. 
        /// <para>
        /// Time after which the refresh schedule can be started, expressed in <c>YYYY-MM-DDTHH:MM:SS</c>
        /// format.
        /// </para>
        /// </summary>
        public DateTime? StartAfterDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartAfterDateTime property is set.
        /// </summary>
        internal bool IsSetStartAfterDateTime() => this.StartAfterDateTime.HasValue;
    }
}

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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the PutSegmentSubscription operation.
    /// </summary>
    public partial class PutSegmentSubscriptionResponse : AmazonWebServiceResponse
    {
        private ScheduleConfiguration _scheduleConfiguration;
        private DateTime? _startedAt;
        private SegmentSubscriptionStatus _status;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The schedule configuration for the subscription, if configured. 
        /// </para>
        /// </summary>
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp of when the subscription was started. 
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle status of the subscription. The following are valid values:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STARTING</b>: Initial snapshot is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RUNNING</b>: Notifications are active and running. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STOPPED</b>: Notifications have been stopped. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>: Notifications failed (for example, the Amazon Kinesis data stream
        /// became inaccessible). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SegmentSubscriptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
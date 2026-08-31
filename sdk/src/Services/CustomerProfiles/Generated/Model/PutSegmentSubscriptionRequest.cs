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
    /// Container for the parameters to the PutSegmentSubscription operation.
    /// Creates or updates a segment subscription for membership events. When a subscription
    /// is created, an initial snapshot is taken and the system begins monitoring for membership
    /// changes. 
    /// 
    ///  
    /// <para>
    /// You can optionally set a schedule configuration interval to control how often membership
    /// snapshots are run. The interval can be from 1 to 24 hours. If not set, the interval
    /// defaults to 24 hours. Scheduled snapshots run on a best-effort basis. If a scheduled
    /// snapshot takes longer than the configured interval, the next scheduled run does not
    /// start until the in-progress snapshot completes, so a run might be delayed or skipped
    /// and is not guaranteed to occur at exactly the requested time. 
    /// </para>
    ///  
    /// <para>
    /// For Classic segments, membership events are generated from these scheduled snapshots
    /// and also in near real-time as profile attribute changes occur. For SQL segments, membership
    /// events are generated only from the scheduled snapshots. 
    /// </para>
    /// </summary>
    public partial class PutSegmentSubscriptionRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private ScheduleConfiguration _scheduleConfiguration;
        private string _segmentDefinitionName;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The optional schedule configuration that controls how often membership snapshots are
        /// run. If not provided, the subscription defaults to a 24-hour interval. 
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
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The unique name of the segment definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SegmentDefinitionName
        {
            get { return this._segmentDefinitionName; }
            set { this._segmentDefinitionName = value; }
        }

        // Check to see if SegmentDefinitionName property is set
        internal bool IsSetSegmentDefinitionName()
        {
            return this._segmentDefinitionName != null;
        }

    }
}
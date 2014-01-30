/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVolumeStatus operation.
    /// <para>Describes the status of the specified volumes. Volume status provides the result of the checks performed on your volumes to determine
    /// events that can impair the performance of your volumes. The performance of a volume can be affected if an issue occurs on the volume's
    /// underlying host. If the volume's underlying host experiences a power outage or system issue, after the system is restored, there could be
    /// data inconsistencies on the volume. Volume events notify you if this occurs. Volume actions notify you if any action needs to be taken in
    /// response to the event.</para> <para>The <c>DescribeVolumeStatus</c> operation provides the following information about the specified
    /// volumes:</para> <para> <i>Status</i> : Reflects the current status of the volume. The possible values are <c>ok</c> ,
    /// <c>impaired</c> ,
    /// <c>warning</c> , or <c>insufficient-data</c> . If all checks pass, the overall status of the volume is <c>ok</c> . If
    /// the check fails, the overall status is <c>impaired</c> . If the status is <c>insufficient-data</c> , then the checks may still be taking
    /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html" >Monitoring the Status of Your Volumes</a> .</para>
    /// <para> <i>Events</i> : Reflect the cause of a volume status and may require you to take action. For example, if your volume returns an
    /// <c>impaired</c> status, then the volume event might be <c>potential-data-inconsistency</c> . This means that your volume has been affected
    /// by an issue with the underlying host, has all I/O operations disabled, and may have inconsistent data.</para> <para> <i>Actions</i> :
    /// Reflect the actions you may have to take in response to an event. For example, if the status of the volume is <c>impaired</c> and the volume
    /// event shows <c>potential-data-inconsistency</c> , then the action shows <c>enable-volume-io</c> . This means that you may want to enable the
    /// I/O operations for the volume by calling the EnableVolumeIO action and then check the volume for data consistency.</para> <para><b>NOTE:</b>
    /// Volume status is based on the volume status checks, and does not reflect the volume state. Therefore, volume status does not indicate
    /// volumes in the error state (for example, when a volume is incapable of accepting I/O.) </para>
    /// </summary>
    public partial class DescribeVolumeStatusRequest : AmazonEC2Request
    {
        private List<string> volumeIds = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private string nextToken;
        private int? maxResults;


        /// <summary>
        /// One or more volume IDs. Default: Describes all your volumes.
        ///  
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this.volumeIds; }
            set { this.volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this.volumeIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>action.code</c> - The action code for the event (for example, <c>enable-volume-io</c>). </li> <li>
        /// <c>action.description</c> - A description of the action. </li> <li> <c>action.event-id</c> - The event ID associated with the action. </li>
        /// <li> <c>availability-zone</c> - The Availability Zone of the instance. </li> <li> <c>event.description</c> - A description of the event.
        /// </li> <li> <c>event.event-id</c> - The event ID. </li> <li> <c>event.event-type</c> - The event type (for <c>io-enabled</c>: <c>passed</c> |
        /// <c>failed</c>; for <c>io-performance</c>: <c>io-performance:degraded</c> | <c>io-performance:severely-degraded</c> |
        /// <c>io-performance:stalled</c>). </li> <li> <c>event.not-after</c> - The latest end time for the event. </li> <li> <c>event.not-before</c> -
        /// The earliest start time for the event. </li> <li> <c>volume-status.details-name</c> - The cause for <c>volume-status.status</c>
        /// (<c>io-enabled</c> | <c>io-performance</c>). </li> <li> <c>volume-status.details-status</c> - The status of
        /// <c>volume-status.details-name</c> (for <c>io-enabled</c>: <c>passed</c> | <c>failed</c>; for <c>io-performance</c>: <c>normal</c> |
        /// <c>degraded</c> | <c>severely-degraded</c> | <c>stalled</c>). </li> <li> <c>volume-status.status</c> - The status of the volume (<c>ok</c> |
        /// <c>impaired</c> | <c>warning</c> | <c>insufficient-data</c>). </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The next paginated set of results to return using the pagination token returned by a previous call.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// The maximum number of paginated volume items per response.
        ///  
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

    }
}
    

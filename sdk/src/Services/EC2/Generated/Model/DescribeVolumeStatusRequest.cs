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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVolumeStatus operation.
    /// Describes the status of the specified volumes. Volume status provides the result of
    /// the checks performed on your volumes to determine events that can impair the performance
    /// of your volumes. The performance of a volume can be affected if an issue occurs on
    /// the volume's underlying host. If the volume's underlying host experiences a power
    /// outage or system issue, after the system is restored, there could be data inconsistencies
    /// on the volume. Volume events notify you if this occurs. Volume actions notify you
    /// if any action needs to be taken in response to the event.
    /// 
    ///  
    /// <para>
    /// The <code>DescribeVolumeStatus</code> operation provides the following information
    /// about the specified volumes:
    /// </para>
    ///  
    /// <para>
    ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
    /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
    /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
    /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
    /// then the checks might still be taking place on your volume at the time. We recommend
    /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitor
    /// the status of your volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <i>Events</i>: Reflect the cause of a volume status and might require you to take
    /// action. For example, if your volume returns an <code>impaired</code> status, then
    /// the volume event might be <code>potential-data-inconsistency</code>. This means that
    /// your volume has been affected by an issue with the underlying host, has all I/O operations
    /// disabled, and might have inconsistent data.
    /// </para>
    ///  
    /// <para>
    ///  <i>Actions</i>: Reflect the actions you might have to take in response to an event.
    /// For example, if the status of the volume is <code>impaired</code> and the volume event
    /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
    /// This means that you may want to enable the I/O operations for the volume by calling
    /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
    /// </para>
    ///  
    /// <para>
    /// Volume status is based on the volume status checks, and does not reflect the volume
    /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
    /// state (for example, when a volume is incapable of accepting I/O.)
    /// </para>
    /// </summary>
    public partial class DescribeVolumeStatusRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>action.code</code> - The action code for the event (for example, <code>enable-volume-io</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>action.description</code> - A description of the action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>action.event-id</code> - The event ID associated with the action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.description</code> - A description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.event-id</code> - The event ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.event-type</code> - The event type (for <code>io-enabled</code>: <code>passed</code>
        /// | <code>failed</code>; for <code>io-performance</code>: <code>io-performance:degraded</code>
        /// | <code>io-performance:severely-degraded</code> | <code>io-performance:stalled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.not-after</code> - The latest end time for the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.not-before</code> - The earliest start time for the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-status.details-name</code> - The cause for <code>volume-status.status</code>
        /// (<code>io-enabled</code> | <code>io-performance</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-status.details-status</code> - The status of <code>volume-status.details-name</code>
        /// (for <code>io-enabled</code>: <code>passed</code> | <code>failed</code>; for <code>io-performance</code>:
        /// <code>normal</code> | <code>degraded</code> | <code>severely-degraded</code> | <code>stalled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-status.status</code> - The status of the volume (<code>ok</code> | <code>impaired</code>
        /// | <code>warning</code> | <code>insufficient-data</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. This value can be between
        /// 5 and 1,000; if the value is larger than 1,000, only 1,000 results are returned. If
        /// this parameter is not used, then all items are returned. You cannot specify this parameter
        /// and the volume IDs parameter in the same request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// The IDs of the volumes.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your volumes.
        /// </para>
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this._volumeIds; }
            set { this._volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this._volumeIds != null && this._volumeIds.Count > 0; 
        }

    }
}
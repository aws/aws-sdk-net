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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// The <c>DescribeVolumeStatus</c> operation provides the following information about
    /// the specified volumes:
    /// </para>
    ///  
    /// <para>
    ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
    /// <c>ok</c>, <c>impaired</c> , <c>warning</c>, or <c>insufficient-data</c>. If all checks
    /// pass, the overall status of the volume is <c>ok</c>. If the check fails, the overall
    /// status is <c>impaired</c>. If the status is <c>insufficient-data</c>, then the checks
    /// might still be taking place on your volume at the time. We recommend that you retry
    /// the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-status.html">Monitor
    /// the status of your volumes</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <i>Events</i>: Reflect the cause of a volume status and might require you to take
    /// action. For example, if your volume returns an <c>impaired</c> status, then the volume
    /// event might be <c>potential-data-inconsistency</c>. This means that your volume has
    /// been affected by an issue with the underlying host, has all I/O operations disabled,
    /// and might have inconsistent data.
    /// </para>
    ///  
    /// <para>
    ///  <i>Actions</i>: Reflect the actions you might have to take in response to an event.
    /// For example, if the status of the volume is <c>impaired</c> and the volume event shows
    /// <c>potential-data-inconsistency</c>, then the action shows <c>enable-volume-io</c>.
    /// This means that you may want to enable the I/O operations for the volume and then
    /// check the volume for data consistency. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/work_volumes_impaired.html">Work
    /// with an impaired EBS volume</a>.
    /// </para>
    ///  
    /// <para>
    /// Volume status is based on the volume status checks, and does not reflect the volume
    /// state. Therefore, volume status does not indicate volumes in the <c>error</c> state
    /// (for example, when a volume is incapable of accepting I/O.)
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeVolumeStatusRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>action.code</c> - The action code for the event (for example, <c>enable-volume-io</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>action.description</c> - A description of the action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>action.event-id</c> - The event ID associated with the action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.description</c> - A description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.event-id</c> - The event ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.event-type</c> - The event type (for <c>io-enabled</c>: <c>passed</c> |
        /// <c>failed</c>; for <c>io-performance</c>: <c>io-performance:degraded</c> | <c>io-performance:severely-degraded</c>
        /// | <c>io-performance:stalled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.not-after</c> - The latest end time for the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.not-before</c> - The earliest start time for the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-status.details-name</c> - The cause for <c>volume-status.status</c> (<c>io-enabled</c>
        /// | <c>io-performance</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-status.details-status</c> - The status of <c>volume-status.details-name</c>
        /// (for <c>io-enabled</c>: <c>passed</c> | <c>failed</c>; for <c>io-performance</c>:
        /// <c>normal</c> | <c>degraded</c> | <c>severely-degraded</c> | <c>stalled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-status.status</c> - The status of the volume (<c>ok</c> | <c>impaired</c>
        /// | <c>warning</c> | <c>insufficient-data</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this._volumeIds; }
            set { this._volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this._volumeIds != null && (this._volumeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
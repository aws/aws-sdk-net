/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVolumes operation.
    /// Describes the specified EBS volumes.
    /// 
    ///  
    /// <para>
    /// If you are describing a long list of volumes, you can paginate the output to make
    /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
    /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
    /// value, then that number of results is returned along with a <code>NextToken</code>
    /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
    /// the remaining results.
    /// </para>
    ///  
    /// <para>
    /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
    /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeVolumesRequest() { }

        /// <summary>
        /// Instantiates DescribeVolumesRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeIds">One or more volume IDs.</param>
        public DescribeVolumesRequest(List<string> volumeIds)
        {
            _volumeIds = volumeIds;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>attachment.attach-time</code> - The time stamp when the attachment initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.delete-on-termination</code> - Whether the volume is deleted on
        /// instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.device</code> - The device name specified in the block device mapping
        /// (for example, <code>/dev/sda1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.instance-id</code> - The ID of the instance the volume is attached
        /// to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.status</code> - The attachment state (<code>attaching</code> | <code>attached</code>
        /// | <code>detaching</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone in which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>create-time</code> - The time stamp when the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>encrypted</code> - The encryption status of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>size</code> - The size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>snapshot-id</code> - The snapshot from which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - The status of the volume (<code>creating</code> | <code>available</code>
        /// | <code>in-use</code> | <code>deleting</code> | <code>deleted</code> | <code>error</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource. Specify the key of the tag in the filter name and the value of the
        /// tag in the filter value. For example, for the tag Purpose=X, specify <code>tag:Purpose</code>
        /// for the filter name and <code>X</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. This filter is
        /// independent of the <code>tag-value</code> filter. For example, if you use both the
        /// filter "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned
        /// both the tag key Purpose (regardless of what the tag's value is), and the tag value
        /// X (regardless of what the tag's key is). If you want to list only resources where
        /// Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-id</code> - The volume ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-type</code> - The Amazon EBS volume type. This can be <code>gp2</code>
        /// for General Purpose SSD, <code>io1</code> for Provisioned IOPS SSD, <code>st1</code>
        /// for Throughput Optimized HDD, <code>sc1</code> for Cold HDD, or <code>standard</code>
        /// for Magnetic volumes.
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
        /// The maximum number of volume results returned by <code>DescribeVolumes</code> in paginated
        /// output. When this parameter is used, <code>DescribeVolumes</code> only returns <code>MaxResults</code>
        /// results in a single page along with a <code>NextToken</code> response element. The
        /// remaining results of the initial request can be seen by sending another <code>DescribeVolumes</code>
        /// request with the returned <code>NextToken</code> value. This value can be between
        /// 5 and 500; if <code>MaxResults</code> is given a value larger than 500, only 500 results
        /// are returned. If this parameter is not used, then <code>DescribeVolumes</code> returns
        /// all results. You cannot specify this parameter and the volume IDs parameter in the
        /// same request.
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
        /// The <code>NextToken</code> value returned from a previous paginated <code>DescribeVolumes</code>
        /// request where <code>MaxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>NextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
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
        /// One or more volume IDs.
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
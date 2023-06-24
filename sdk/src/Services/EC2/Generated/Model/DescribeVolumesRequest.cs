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
    /// Container for the parameters to the DescribeVolumes operation.
    /// Describes the specified EBS volumes or all of your EBS volumes.
    /// 
    ///  
    /// <para>
    /// If you are describing a long list of volumes, we recommend that you paginate the output
    /// to make the list more manageable. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// <param name="volumeIds">The volume IDs.</param>
        public DescribeVolumesRequest(List<string> volumeIds)
        {
            _volumeIds = volumeIds;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
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
        ///  <code>encrypted</code> - Indicates whether the volume is encrypted (<code>true</code>
        /// | <code>false</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>multi-attach-enabled</code> - Indicates whether the volume is enabled for Multi-Attach
        /// (<code>true</code> | <code>false</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fast-restored</code> - Indicates whether the volume was created from a snapshot
        /// that is enabled for fast snapshot restore (<code>true</code> | <code>false</code>).
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
        ///  <code>status</code> - The state of the volume (<code>creating</code> | <code>available</code>
        /// | <code>in-use</code> | <code>deleting</code> | <code>deleted</code> | <code>error</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-id</code> - The volume ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-type</code> - The Amazon EBS volume type (<code>gp2</code> | <code>gp3</code>
        /// | <code>io1</code> | <code>io2</code> | <code>st1</code> | <code>sc1</code>| <code>standard</code>)
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
        /// The maximum number of volumes to return for this request. This value can be between
        /// 5 and 500; if you specify a value larger than 500, only 500 items are returned. If
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
        /// end of the items returned from the previous request.
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
        /// The volume IDs.
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
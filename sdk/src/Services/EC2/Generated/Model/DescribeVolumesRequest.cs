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
    /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volumes.html">Amazon
    /// EBS volumes</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend using only paginated requests. Unpaginated requests are susceptible
    /// to throttling and timeouts.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeVolumesRequest() { }

        /// <summary>
        /// Instantiates DescribeVolumesRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeIds">The volume IDs. If not specified, then all volumes are included in the response.</param>
        public DescribeVolumesRequest(List<string> volumeIds)
        {
            _volumeIds = volumeIds;
        }

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
        ///  <c>attachment.attach-time</c> - The time stamp when the attachment initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.delete-on-termination</c> - Whether the volume is deleted on instance
        /// termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.device</c> - The device name specified in the block device mapping
        /// (for example, <c>/dev/sda1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.instance-id</c> - The ID of the instance the volume is attached to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.status</c> - The attachment state (<c>attaching</c> | <c>attached</c>
        /// | <c>detaching</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone in which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone in which the volume
        /// was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-time</c> - The time stamp when the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>encrypted</c> - Indicates whether the volume is encrypted (<c>true</c> | <c>false</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fast-restored</c> - Indicates whether the volume was created from a snapshot that
        /// is enabled for fast snapshot restore (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>multi-attach-enabled</c> - Indicates whether the volume is enabled for Multi-Attach
        /// (<c>true</c> | <c>false</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.managed</c> - A Boolean that indicates whether this is a managed volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.principal</c> - The principal that manages the volume. Only valid for
        /// managed volumes, where <c>managed</c> is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>size</c> - The size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>snapshot-id</c> - The snapshot from which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The state of the volume (<c>creating</c> | <c>available</c> | <c>in-use</c>
        /// | <c>deleting</c> | <c>deleted</c> | <c>error</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-id</c> - The volume ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-type</c> - The Amazon EBS volume type (<c>gp2</c> | <c>gp3</c> | <c>io1</c>
        /// | <c>io2</c> | <c>st1</c> | <c>sc1</c>| <c>standard</c>)
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
        /// The volume IDs. If not specified, then all volumes are included in the response.
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
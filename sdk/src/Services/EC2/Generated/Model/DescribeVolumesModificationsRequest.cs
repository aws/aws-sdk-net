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
    /// Container for the parameters to the DescribeVolumesModifications operation.
    /// Describes the most recent volume modification request for the specified EBS volumes.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-modifications.html">
    /// Monitor the progress of volume modifications</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesModificationsRequest : AmazonEC2Request
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
        ///  <c>modification-state</c> - The current modification state (modifying | optimizing
        /// | completed | failed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>original-iops</c> - The original IOPS rate of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>original-size</c> - The original size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>original-volume-type</c> - The original volume type of the volume (standard |
        /// io1 | io2 | gp2 | sc1 | st1).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>originalMultiAttachEnabled</c> - Indicates whether Multi-Attach support was enabled
        /// (true | false).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start-time</c> - The modification start time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target-iops</c> - The target IOPS rate of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target-size</c> - The target size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>target-volume-type</c> - The target volume type of the volume (standard | io1
        /// | io2 | gp2 | sc1 | st1).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>targetMultiAttachEnabled</c> - Indicates whether Multi-Attach support is to be
        /// enabled (true | false).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-id</c> - The ID of the volume.
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
        /// The maximum number of results (up to a limit of 500) to be returned in a paginated
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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
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
    /// Container for the parameters to the DescribeVolumesModifications operation.
    /// Describes the most recent volume modification request for the specified EBS volumes.
    /// 
    ///  
    /// <para>
    /// If a volume has never been modified, some information in the output will be null.
    /// If a volume has been modified more than once, the output includes only the most recent
    /// modification request.
    /// </para>
    ///  
    /// <para>
    /// You can also use CloudWatch Events to check the status of a modification to an EBS
    /// volume. For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
    /// CloudWatch Events User Guide</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-modifications.html">Monitor
    /// the progress of volume modifications</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesModificationsRequest : AmazonEC2Request
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
        ///  <code>modification-state</code> - The current modification state (modifying | optimizing
        /// | completed | failed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>original-iops</code> - The original IOPS rate of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>original-size</code> - The original size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>original-volume-type</code> - The original volume type of the volume (standard
        /// | io1 | io2 | gp2 | sc1 | st1).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>originalMultiAttachEnabled</code> - Indicates whether Multi-Attach support
        /// was enabled (true | false).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start-time</code> - The modification start time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target-iops</code> - The target IOPS rate of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target-size</code> - The target size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>target-volume-type</code> - The target volume type of the volume (standard
        /// | io1 | io2 | gp2 | sc1 | st1).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>targetMultiAttachEnabled</code> - Indicates whether Multi-Attach support is
        /// to be enabled (true | false).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-id</code> - The ID of the volume.
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
        /// The maximum number of results (up to a limit of 500) to be returned in a paginated
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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
        /// The token returned by a previous paginated request. Pagination continues from the
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
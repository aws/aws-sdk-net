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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeVolumesModifications operation. Describes
    /// the most recent volume modification request for the specified EBS volumes. <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-modifications.html">
    /// Monitor the progress of volume modifications</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesModificationsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeManagedResources. 
        /// <para>
        /// Indicates whether to include managed resources in the output. If this parameter is
        /// set to <c>true</c>, the output includes resources that are managed by Amazon Web Services
        /// services, even if managed resource visibility is set to hidden.
        /// </para>
        /// </summary>
        public bool? IncludeManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeManagedResources property is set.
        /// </summary>
        internal bool IsSetIncludeManagedResources() => this.IncludeManagedResources.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results (up to a limit of 500) to be returned in a paginated
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// The IDs of the volumes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VolumeIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VolumeIds property is set.
        /// </summary>
        internal bool IsSetVolumeIds() => this.VolumeIds != null && (this.VolumeIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

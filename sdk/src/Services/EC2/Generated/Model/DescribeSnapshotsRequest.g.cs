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
    /// Container for the parameters to the DescribeSnapshots operation. Describes the specified
    /// EBS snapshots available to you or all of the EBS snapshots available to you. <para>
    /// The snapshots available to you include public snapshots, private snapshots that you
    /// own, and private snapshots owned by other Amazon Web Services accounts for which you
    /// have explicit create volume permissions. </para> <para> The create volume permissions
    /// fall into the following categories: </para> <ul> <li> <para> <i>public</i>: The owner
    /// of the snapshot granted create volume permissions for the snapshot to the <c>all</c>
    /// group. All Amazon Web Services accounts have create volume permissions for these snapshots.
    /// </para> </li> <li> <para> <i>explicit</i>: The owner of the snapshot granted create
    /// volume permissions to a specific Amazon Web Services account. </para> </li> <li> <para>
    /// <i>implicit</i>: An Amazon Web Services account has implicit create volume permissions
    /// for all snapshots it owns. </para> </li> </ul> <para> The list of snapshots returned
    /// can be filtered by specifying snapshot IDs, snapshot owners, or Amazon Web Services
    /// accounts with create volume permissions. If no options are specified, Amazon EC2 returns
    /// all snapshots for which you have create volume permissions. </para> <para> If you
    /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned.
    /// If you specify an invalid snapshot ID, an error is returned. If you specify a snapshot
    /// ID for which you do not have access, it is not included in the returned results. </para>
    /// <para> If you specify one or more snapshot owners using the <c>OwnerIds</c> option,
    /// only snapshots from the specified owners and for which you have access are returned.
    /// The results can include the Amazon Web Services account IDs of the specified owners,
    /// <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
    /// own. </para> <para> If you specify a list of restorable users, only snapshots with
    /// create snapshot permissions for those users are returned. You can specify Amazon Web
    /// Services account IDs (if you own the snapshots), <c>self</c> for snapshots for which
    /// you own or have explicit permissions, or <c>all</c> for public snapshots. </para>
    /// <para> If you are describing a long list of snapshots, we recommend that you paginate
    /// the output to make the list more manageable. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
    /// </para> <para> For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-snapshots.html">Amazon
    /// EBS snapshots</a> in the <i>Amazon EBS User Guide</i>. </para> <important> <para>
    /// We strongly recommend using only paginated requests. Unpaginated requests are susceptible
    /// to throttling and timeouts. </para> </important>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonEC2Request
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
        ///  <c>description</c> - A description of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>encrypted</c> - Indicates whether the snapshot is encrypted (<c>true</c> | <c>false</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-alias</c> - The owner alias, from an Amazon-maintained list (<c>amazon</c>).
        /// This is not the user-configured Amazon Web Services account alias set using the IAM
        /// console. We recommend that you use the related parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the owner. We recommend that
        /// you use the related parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>progress</c> - The progress of the snapshot, as a percentage (for example, 80%).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>snapshot-id</c> - The snapshot ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start-time</c> - The time stamp when the snapshot was initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the snapshot (<c>pending</c> | <c>completed</c> | <c>error</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>storage-tier</c> - The storage tier of the snapshot (<c>archive</c> | <c>standard</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transfer-type</c> - The type of operation used to create the snapshot (<c>time-based</c>
        /// | <c>standard</c>).
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
        ///  <c>volume-id</c> - The ID of the volume the snapshot is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-size</c> - The size of the volume, in GiB.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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
        /// Gets and sets the property OwnerIds. 
        /// <para>
        /// Scopes the results to snapshots with the specified owners. You can specify a combination
        /// of Amazon Web Services account IDs, <c>self</c>, and <c>amazon</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OwnerIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OwnerIds property is set.
        /// </summary>
        internal bool IsSetOwnerIds() => this.OwnerIds != null && (this.OwnerIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestorableByUserIds. 
        /// <para>
        /// The IDs of the Amazon Web Services accounts that can create volumes from the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RestorableByUserIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RestorableByUserIds property is set.
        /// </summary>
        internal bool IsSetRestorableByUserIds() => this.RestorableByUserIds != null && (this.RestorableByUserIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotIds. 
        /// <para>
        /// The snapshot IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes the snapshots for which you have create volume permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotIds property is set.
        /// </summary>
        internal bool IsSetSnapshotIds() => this.SnapshotIds != null && (this.SnapshotIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

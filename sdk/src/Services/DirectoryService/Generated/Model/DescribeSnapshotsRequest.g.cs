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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation. Obtains information
    /// about the directory snapshots that belong to this account. <para> This operation supports
    /// pagination with the use of the <i>NextToken</i> request and response parameters. If
    /// more results are available, the <i>DescribeSnapshots.NextToken</i> member contains
    /// a token that you pass in the next call to <a>DescribeSnapshots</a> to retrieve the
    /// next set of items. </para> <para> You can also specify a maximum number of return
    /// results with the <i>Limit</i> parameter. </para>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to retrieve snapshot information.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of objects to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <i>DescribeSnapshotsResult.NextToken</i> value from a previous call to <a>DescribeSnapshots</a>.
        /// Pass null if this is the first call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SnapshotIds. 
        /// <para>
        /// A list of identifiers of the snapshots to obtain the information for. If this member
        /// is null or empty, all snapshots are returned using the <i>Limit</i> and <i>NextToken</i>
        /// members.
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

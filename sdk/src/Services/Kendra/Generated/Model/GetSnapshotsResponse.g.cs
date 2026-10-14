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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the GetSnapshots operation.
    /// </summary>
    public partial class GetSnapshotsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Kendra returns this token, which you can use
        /// in a later request to retrieve the next set of search metrics data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 800)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SnapShotTimeFilter. 
        /// <para>
        /// The Unix timestamp for the beginning and end of the time window for the search metrics
        /// data.
        /// </para>
        /// </summary>
        public TimeRange SnapShotTimeFilter { get; set; }

        /// <summary>
        /// Checks to see if the SnapShotTimeFilter property is set.
        /// </summary>
        internal bool IsSetSnapShotTimeFilter() => this.SnapShotTimeFilter != null;

        /// <summary>
        /// Gets and sets the property SnapshotsData. 
        /// <para>
        /// The search metrics data. The data returned depends on the metric type you requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> SnapshotsData { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the SnapshotsData property is set.
        /// </summary>
        internal bool IsSetSnapshotsData() => this.SnapshotsData != null && (this.SnapshotsData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotsDataHeader. 
        /// <para>
        /// The column headers for the search metrics data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotsDataHeader { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotsDataHeader property is set.
        /// </summary>
        internal bool IsSetSnapshotsDataHeader() => this.SnapshotsDataHeader != null && (this.SnapshotsDataHeader.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListMlflowTrackingServers operation. Lists all
    /// MLflow Tracking Servers.
    /// </summary>
    public partial class ListMlflowTrackingServersRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Use the <c>CreatedAfter</c> filter to only list tracking servers created after a specific
        /// date and time. Listed tracking servers are shown with a date and time such as <c>"2024-03-16T01:46:56+00:00"</c>.
        /// The <c>CreatedAfter</c> parameter takes in a Unix timestamp. To convert a date and
        /// time into a Unix timestamp, see <a href="https://www.epochconverter.com/">EpochConverter</a>.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Use the <c>CreatedBefore</c> filter to only list tracking servers created before a
        /// specific date and time. Listed tracking servers are shown with a date and time such
        /// as <c>"2024-03-16T01:46:56+00:00"</c>. The <c>CreatedBefore</c> parameter takes in
        /// a Unix timestamp. To convert a date and time into a Unix timestamp, see <a href="https://www.epochconverter.com/">EpochConverter</a>.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tracking servers to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// Filter for tracking servers using the specified MLflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string MlflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the MlflowVersion property is set.
        /// </summary>
        internal bool IsSetMlflowVersion() => this.MlflowVersion != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you will receive this token. Use it in your
        /// next request to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Filter for trackings servers sorting by name, creation time, or creation status.
        /// </para>
        /// </summary>
        public SortTrackingServerBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Change the order of the listed tracking servers. By default, tracking servers are
        /// listed in <c>Descending</c> order by creation time. To change the list order, you
        /// can specify <c>SortOrder</c> to be <c>Ascending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property TrackingServerStatus. 
        /// <para>
        /// Filter for tracking servers with a specified creation status.
        /// </para>
        /// </summary>
        public TrackingServerStatus TrackingServerStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrackingServerStatus property is set.
        /// </summary>
        internal bool IsSetTrackingServerStatus() => this.TrackingServerStatus != null;
    }
}

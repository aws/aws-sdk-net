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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobsByConsumableResource operation. Returns
    /// a list of Batch jobs that require a specific consumable resource.
    /// </summary>
    public partial class ListJobsByConsumableResourceRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property ConsumableResource. 
        /// <para>
        /// The name or ARN of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConsumableResource { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResource property is set.
        /// </summary>
        internal bool IsSetConsumableResource() => this.ConsumableResource != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to the job list query. If used, only those jobs requiring the
        /// specified consumable resource (<c>consumableResource</c>) and that match the value
        /// of the filters are listed. The filter names and values can be:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// name: <c>JOB_STATUS</c> 
        /// </para>
        ///  
        /// <para>
        /// values: <c>SUBMITTED | PENDING | RUNNABLE | STARTING | RUNNING | SUCCEEDED | FAILED</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// name: <c>JOB_NAME </c> 
        /// </para>
        ///  
        /// <para>
        /// The values are case-insensitive matches for the job name. If a filter value ends with
        /// an asterisk (*), it matches any job name that begins with the string before the '*'.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuesPair> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuesPair>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c>ListJobsByConsumableResource</c> in paginated
        /// output. When this parameter is used, <c>ListJobsByConsumableResource</c> only returns
        /// <c>maxResults</c> results in a single page and a <c>nextToken</c> response element.
        /// The remaining results of the initial request can be seen by sending another <c>ListJobsByConsumableResource</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 100. If this parameter isn't used, then <c>ListJobsByConsumableResource</c> returns
        /// up to 100 results and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListJobsByConsumableResource</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// Treat this token as an opaque identifier that's only used to retrieve the next items
        /// in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

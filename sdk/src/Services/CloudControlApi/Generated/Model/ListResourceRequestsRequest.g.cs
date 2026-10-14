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

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceRequests operation. Returns existing
    /// resource operation requests. This includes requests of all status types. For more
    /// information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-list">Listing
    /// active resource operation requests</a> in the <i>Amazon Web Services Cloud Control
    /// API User Guide</i>. <note> <para> Resource operation requests expire after 7 days.
    /// </para> </note>
    /// </summary>
    public partial class ListResourceRequestsRequest : AmazonCloudControlApiRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned with a single call. If the number of
        /// available results exceeds this maximum, the response includes a <c>NextToken</c> value
        /// that you can assign to the <c>NextToken</c> request parameter to get the next set
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>20</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request didn't return all of the remaining results, the
        /// response object's <c>NextToken</c> parameter value is set to a token. To retrieve
        /// the next set of results, call this action again and assign that token to the request
        /// object's <c>NextToken</c> parameter. If there are no remaining results, the previous
        /// response object's <c>NextToken</c> parameter is set to <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceRequestStatusFilter. 
        /// <para>
        /// The filter criteria to apply to the requests returned.
        /// </para>
        /// </summary>
        public ResourceRequestStatusFilter ResourceRequestStatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRequestStatusFilter property is set.
        /// </summary>
        internal bool IsSetResourceRequestStatusFilter() => this.ResourceRequestStatusFilter != null;
    }
}

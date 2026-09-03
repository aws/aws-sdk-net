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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListGatewayInstances operation. Displays a list
    /// of instances associated with the Amazon Web Services account. This request returns
    /// a paginated result. You can use the filterArn property to display only the instances
    /// associated with the selected Gateway Amazon Resource Name (ARN).
    /// </summary>
    public partial class ListGatewayInstancesRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        ///  Filter the list results to display only the instances associated with the selected
        /// Gateway ARN.
        /// </para>
        /// </summary>
        public string FilterArn { get; set; }

        /// <summary>
        /// Checks to see if the FilterArn property is set.
        /// </summary>
        internal bool IsSetFilterArn() => this.FilterArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per API request. 
        /// </para>
        ///  
        /// <para>
        /// For example, you submit a ListInstances request with <c>MaxResults</c> set at 5. Although
        /// 20 items match your request, the service returns no more than the first 5 items. (The
        /// service also returns a <c>NextToken</c> value that you can use to fetch the next batch
        /// of results.) 
        /// </para>
        ///  
        /// <para>
        /// The service might return fewer results than the <c>MaxResults</c> value. If <c>MaxResults</c>
        /// is not included in the request, the service defaults to pagination with a maximum
        /// of 10 results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token that identifies the batch of results that you want to see. 
        /// </para>
        ///  
        /// <para>
        /// For example, you submit a <c>ListInstances</c> request with <c>MaxResults</c> set
        /// at 5. The service returns the first batch of results (up to 5) and a <c>NextToken</c>
        /// value. To see the next batch of results, you can submit the <c>ListInstances</c> request
        /// a second time and specify the <c>NextToken</c> value.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

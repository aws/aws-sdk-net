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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation. Retrieves a paginated list
    /// of the asynchronous jobs in your account. You can filter the results by status, brand
    /// profile, or operation type.
    /// </summary>
    public partial class ListJobsRequest : AmazonEndUserMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property BrandProfileId. 
        /// <para>
        /// Filters the results to jobs for the specified brand profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BrandProfileId { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileId property is set.
        /// </summary>
        internal bool IsSetBrandProfileId() => this.BrandProfileId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        /// The token to retrieve the next page of results. This value is returned when more results
        /// are available, and is null when there are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// Filters the results to jobs of the specified operation type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the results to jobs that have the specified status.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

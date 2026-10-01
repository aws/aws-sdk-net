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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListImportJobs operation. Lists all of the import
    /// jobs.
    /// </summary>
    public partial class ListImportJobsRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ImportDestinationType. 
        /// <para>
        /// The destination of the import job, which can be used to list import jobs that have
        /// a certain <c>ImportDestinationType</c>.
        /// </para>
        /// </summary>
        public ImportDestinationType ImportDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the ImportDestinationType property is set.
        /// </summary>
        internal bool IsSetImportDestinationType() => this.ImportDestinationType != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string token indicating that there might be additional import jobs available to
        /// be listed. Copy this token to a subsequent call to <c>ListImportJobs</c> with the
        /// same parameters to retrieve the next page of import jobs.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Maximum number of import jobs to return at once. Use this parameter to paginate results.
        /// If additional import jobs exist beyond the specified limit, the <c>NextToken</c> element
        /// is sent in the response. Use the <c>NextToken</c> value in subsequent requests to
        /// retrieve additional addresses.
        /// </para>
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}

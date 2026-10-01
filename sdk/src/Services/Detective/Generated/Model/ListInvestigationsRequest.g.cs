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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the ListInvestigations operation. Detective investigations
    /// lets you investigate IAM users and IAM roles using indicators of compromise. An indicator
    /// of compromise (IOC) is an artifact observed in or on a network, system, or environment
    /// that can (with a high level of confidence) identify malicious activity or a security
    /// incident. <c>ListInvestigations</c> lists all active Detective investigations.
    /// </summary>
    public partial class ListInvestigationsRequest : AmazonDetectiveRequest
    {
        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// Filters the investigation results based on a criteria.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the behavior graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphArn { get; set; }

        /// <summary>
        /// Checks to see if the GraphArn property is set.
        /// </summary>
        internal bool IsSetGraphArn() => this.GraphArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Lists the maximum number of investigations in a page.
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
        /// Lists if there are more results available. The value of nextToken is a unique pagination
        /// token for each page. Repeat the call using the returned token to retrieve the next
        /// page. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// Each pagination token expires after 24 hours. Using an expired pagination token will
        /// return a Validation Exception error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// Sorts the investigation results based on a criteria.
        /// </para>
        /// </summary>
        public SortCriteria SortCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SortCriteria property is set.
        /// </summary>
        internal bool IsSetSortCriteria() => this.SortCriteria != null;
    }
}

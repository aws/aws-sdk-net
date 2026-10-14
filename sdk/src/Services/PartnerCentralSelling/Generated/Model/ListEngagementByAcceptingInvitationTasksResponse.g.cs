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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the ListEngagementByAcceptingInvitationTasks operation.
    /// </summary>
    public partial class ListEngagementByAcceptingInvitationTasksResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token used for pagination to retrieve the next page of results.If there are more
        /// results available, this field will contain a token that can be used in a subsequent
        /// API call to retrieve the next page. If there are no more results, this field will
        /// be null or an empty string. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TaskSummaries. 
        /// <para>
        ///  An array of <c>EngagementByAcceptingInvitationTaskSummary</c> objects, each representing
        /// a task that matches the specified filters. The array may be empty if no tasks match
        /// the criteria. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListEngagementByAcceptingInvitationTaskSummary> TaskSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ListEngagementByAcceptingInvitationTaskSummary>() : null;

        /// <summary>
        /// Checks to see if the TaskSummaries property is set.
        /// </summary>
        internal bool IsSetTaskSummaries() => this.TaskSummaries != null && (this.TaskSummaries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

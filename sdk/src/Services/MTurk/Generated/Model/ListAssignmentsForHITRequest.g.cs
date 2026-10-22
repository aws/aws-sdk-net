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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssignmentsForHIT operation. The <c>ListAssignmentsForHIT</c>
    /// operation retrieves completed assignments for a HIT. You can use this operation to
    /// retrieve the results for a HIT. <para> You can get assignments for a HIT at any time,
    /// even if the HIT is not yet Reviewable. If a HIT requested multiple assignments, and
    /// has received some results but has not yet become Reviewable, you can still retrieve
    /// the partial results with this operation. </para> <para> Use the AssignmentStatus parameter
    /// to control which set of assignments for a HIT are returned. The ListAssignmentsForHIT
    /// operation can return submitted assignments awaiting approval, or it can return assignments
    /// that have already been approved or rejected. You can set AssignmentStatus=Approved,Rejected
    /// to get assignments that have already been approved and rejected together in one result
    /// set. </para> <para> Only the Requester who created the HIT can retrieve the assignments
    /// for that HIT. </para> <para> Results are sorted and divided into numbered pages and
    /// the operation returns a single page of results. You can use the parameters of the
    /// operation to control sorting and pagination. </para>
    /// </summary>
    public partial class ListAssignmentsForHITRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property AssignmentStatuses. 
        /// <para>
        /// The status of the assignments to return: Submitted | Approved | Rejected
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssignmentStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssignmentStatuses property is set.
        /// </summary>
        internal bool IsSetAssignmentStatuses() => this.AssignmentStatuses != null && (this.AssignmentStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The ID of the HIT.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string HITId { get; set; }

        /// <summary>
        /// Checks to see if the HITId property is set.
        /// </summary>
        internal bool IsSetHITId() => this.HITId != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
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
        /// Pagination token
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

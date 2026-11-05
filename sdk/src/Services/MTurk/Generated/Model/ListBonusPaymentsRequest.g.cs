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
    /// Container for the parameters to the ListBonusPayments operation. The <c>ListBonusPayments</c>
    /// operation retrieves the amounts of bonuses you have paid to Workers for a given HIT
    /// or assignment.
    /// </summary>
    public partial class ListBonusPaymentsRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment associated with the bonus payments to retrieve. If specified,
        /// only bonus payments for the given assignment are returned. Either the HITId parameter
        /// or the AssignmentId parameter must be specified
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssignmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentId property is set.
        /// </summary>
        internal bool IsSetAssignmentId() => this.AssignmentId != null;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The ID of the HIT associated with the bonus payments to retrieve. If not specified,
        /// all bonus payments for all assignments for the given HIT are returned. Either the
        /// HITId parameter or the AssignmentId parameter must be specified
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
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

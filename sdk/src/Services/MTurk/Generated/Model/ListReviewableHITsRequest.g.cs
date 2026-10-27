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
    /// Container for the parameters to the ListReviewableHITs operation. The <c>ListReviewableHITs</c>
    /// operation retrieves the HITs with Status equal to Reviewable or Status equal to Reviewing
    /// that belong to the Requester calling the operation.
    /// </summary>
    public partial class ListReviewableHITsRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property HITTypeId. 
        /// <para>
        ///  The ID of the HIT type of the HITs to consider for the query. If not specified, all
        /// HITs for the Reviewer are considered 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HITTypeId { get; set; }

        /// <summary>
        /// Checks to see if the HITTypeId property is set.
        /// </summary>
        internal bool IsSetHITTypeId() => this.HITTypeId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Limit the number of results returned. 
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
        /// Pagination Token
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Can be either <c>Reviewable</c> or <c>Reviewing</c>. Reviewable is the default value.
        /// 
        /// </para>
        /// </summary>
        public ReviewableHITStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

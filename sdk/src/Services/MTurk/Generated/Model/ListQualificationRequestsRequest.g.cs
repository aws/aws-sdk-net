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
    /// Container for the parameters to the ListQualificationRequests operation. The <c>ListQualificationRequests</c>
    /// operation retrieves requests for Qualifications of a particular Qualification type.
    /// The owner of the Qualification type calls this operation to poll for pending requests,
    /// and accepts them using the AcceptQualification operation.
    /// </summary>
    public partial class ListQualificationRequestsRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        /// The ID of the QualificationType.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string QualificationTypeId { get; set; }

        /// <summary>
        /// Checks to see if the QualificationTypeId property is set.
        /// </summary>
        internal bool IsSetQualificationTypeId() => this.QualificationTypeId != null;
    }
}

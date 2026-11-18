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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the ListSessions operation. Lists sign-in sessions
    /// for an IAM identity in your account. If you omit principalArn, the operation lists
    /// the caller's own sessions. Specify a user or role ARN to list that identity's sessions,
    /// or specify arn:aws:iam::{account-id}:* to list all sessions in the account. Filters
    /// are combined with a logical AND.
    /// </summary>
    public partial class ListSessionsRequest : AmazonSigninRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. Returns only sessions created by this OAuth client
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property IssuedAfter. Returns only sessions created at or after
        /// this time, in Unix epoch seconds
        /// </summary>
        public long? IssuedAfter { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAfter property is set.
        /// </summary>
        internal bool IsSetIssuedAfter() => this.IssuedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedBefore. Returns only sessions created before this
        /// time, in Unix epoch seconds
        /// </summary>
        public long? IssuedBefore { get; set; }

        /// <summary>
        /// Checks to see if the IssuedBefore property is set.
        /// </summary>
        internal bool IsSetIssuedBefore() => this.IssuedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. Maximum number of results to return
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Token for pagination
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. The identity whose sessions to list. Omit
        /// to list the caller's own sessions. Specify arn:aws:iam::{account-id}:* to list all
        /// sessions in the account.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property Status. Returns only sessions with this status
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

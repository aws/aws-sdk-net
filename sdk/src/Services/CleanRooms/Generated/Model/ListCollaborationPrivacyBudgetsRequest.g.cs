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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the ListCollaborationPrivacyBudgets operation. Returns
    /// an array that summarizes each privacy budget in a specified collaboration. The summary
    /// includes the collaboration ARN, creation time, creating account, and privacy budget
    /// details.
    /// </summary>
    public partial class ListCollaborationPrivacyBudgetsRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property AccessBudgetResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Configured Table Association (ConfiguredTableAssociation)
        /// used to filter privacy budgets.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string AccessBudgetResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessBudgetResourceArn property is set.
        /// </summary>
        internal bool IsSetAccessBudgetResourceArn() => this.AccessBudgetResourceArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// A unique identifier for one of your collaborations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned for an API request call. The service
        /// chooses a default number if you don't set one. The service might return a `nextToken`
        /// even if the `maxResults` value has not been met.
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
        /// The pagination token that's used to fetch the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10240)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PrivacyBudgetType. 
        /// <para>
        /// Specifies the type of the privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivacyBudgetType PrivacyBudgetType { get; set; }

        /// <summary>
        /// Checks to see if the PrivacyBudgetType property is set.
        /// </summary>
        internal bool IsSetPrivacyBudgetType() => this.PrivacyBudgetType != null;
    }
}

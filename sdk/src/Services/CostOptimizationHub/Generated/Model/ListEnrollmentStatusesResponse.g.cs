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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// This is the response object from the ListEnrollmentStatuses operation.
    /// </summary>
    public partial class ListEnrollmentStatusesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// The enrollment status of all member accounts in the organization if the account is
        /// the management account or delegated administrator.
        /// </para>
        /// </summary>
        public bool? IncludeMemberAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMemberAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeMemberAccounts() => this.IncludeMemberAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The enrollment status of a specific account ID, including creation and last updated
        /// timestamps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountEnrollmentStatus> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountEnrollmentStatus>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}

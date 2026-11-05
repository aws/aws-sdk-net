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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Container for the parameters to the ListMemberAccounts operation. Returns a list of
    /// member accounts associated with a notification configuration.
    /// </summary>
    public partial class ListMemberAccountsRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Valid values are 1-100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The member account identifier used to filter the results.
        /// </para>
        /// </summary>
        public string MemberAccount { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccount property is set.
        /// </summary>
        internal bool IsSetMemberAccount() => this.MemberAccount != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results. Use the value returned in the previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notification configuration used to filter the
        /// member accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The organizational unit ID used to filter the member accounts.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status used to filter the member accounts.
        /// </para>
        /// </summary>
        public MemberAccountNotificationConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

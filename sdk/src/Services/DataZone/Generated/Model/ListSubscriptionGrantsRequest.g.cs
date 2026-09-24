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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListSubscriptionGrants operation. Lists subscription
    /// grants.
    /// </summary>
    public partial class ListSubscriptionGrantsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the Amazon DataZone environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of subscription grants to return in a single call to <c>ListSubscriptionGrants</c>.
        /// When the number of subscription grants to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListSubscriptionGrants</c> to list the next set of subscription grants.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of subscription grants is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of subscription grants, the response includes a pagination token named
        /// <c>NextToken</c>. You can specify this <c>NextToken</c> value in a subsequent call
        /// to <c>ListSubscriptionGrants</c> to list the next set of subscription grants.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OwningGroupId. 
        /// <para>
        /// The ID of the owning group.
        /// </para>
        /// </summary>
        public string OwningGroupId { get; set; }

        /// <summary>
        /// Checks to see if the OwningGroupId property is set.
        /// </summary>
        internal bool IsSetOwningGroupId() => this.OwningGroupId != null;

        /// <summary>
        /// Gets and sets the property OwningIamPrincipalArn. 
        /// <para>
        /// The ARN of the owning IAM principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OwningIamPrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the OwningIamPrincipalArn property is set.
        /// </summary>
        internal bool IsSetOwningIamPrincipalArn() => this.OwningIamPrincipalArn != null;

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the owning project of the subscription grants.
        /// </para>
        /// </summary>
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;

        /// <summary>
        /// Gets and sets the property OwningUserId. 
        /// <para>
        /// The ID of the owning user.
        /// </para>
        /// </summary>
        public string OwningUserId { get; set; }

        /// <summary>
        /// Checks to see if the OwningUserId property is set.
        /// </summary>
        internal bool IsSetOwningUserId() => this.OwningUserId != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Specifies the way of sorting the results of this action.
        /// </para>
        /// </summary>
        [Obsolete("Results are always sorted by updatedAt")]
        public SortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specifies the sort order of this action.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property SubscribedListingId. 
        /// <para>
        /// The identifier of the subscribed listing.
        /// </para>
        /// </summary>
        public string SubscribedListingId { get; set; }

        /// <summary>
        /// Checks to see if the SubscribedListingId property is set.
        /// </summary>
        internal bool IsSetSubscribedListingId() => this.SubscribedListingId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The identifier of the subscription.
        /// </para>
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionTargetId. 
        /// <para>
        /// The identifier of the subscription target.
        /// </para>
        /// </summary>
        public string SubscriptionTargetId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionTargetId property is set.
        /// </summary>
        internal bool IsSetSubscriptionTargetId() => this.SubscriptionTargetId != null;
    }
}

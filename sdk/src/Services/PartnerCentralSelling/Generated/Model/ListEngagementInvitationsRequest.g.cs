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
    /// Container for the parameters to the ListEngagementInvitations operation. Retrieves
    /// a list of engagement invitations sent to the partner. This allows partners to view
    /// all pending or past engagement invitations, helping them track opportunities shared
    /// by AWS.
    /// </summary>
    public partial class ListEngagementInvitationsRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog from which to list the engagement invitations. Use <c>AWS</c>
        /// for production invitations or <c>Sandbox</c> for testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  Retrieves a list of engagement invitation summaries based on specified filters. The
        /// ListEngagementInvitations operation allows you to view all invitations that you have
        /// sent or received. You must specify the ParticipantType to filter invitations where
        /// you are either the SENDER or the RECEIVER. Invitations will automatically expire if
        /// not accepted within 15 days. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> EngagementIdentifier { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null && (this.EngagementIdentifier.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of engagement invitations to return in the response.
        /// If more results are available, a pagination token will be provided.
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
        /// A pagination token used to retrieve additional pages of results when the response
        /// to a previous request was truncated. Pass this token to continue listing invitations
        /// from where the previous call left off.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Specifies the type of participant for which to list engagement invitations. Identifies
        /// the role of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantType ParticipantType { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantType property is set.
        /// </summary>
        internal bool IsSetParticipantType() => this.ParticipantType != null;

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// Defines the type of payload associated with the engagement invitations to be listed.
        /// The attributes in this payload help decide on acceptance or rejection of the invitation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PayloadType { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PayloadType property is set.
        /// </summary>
        internal bool IsSetPayloadType() => this.PayloadType != null && (this.PayloadType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        ///  List of sender AWS account IDs to filter the invitations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> SenderAwsAccountId { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SenderAwsAccountId property is set.
        /// </summary>
        internal bool IsSetSenderAwsAccountId() => this.SenderAwsAccountId != null && (this.SenderAwsAccountId.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the sorting options for listing engagement invitations. Invitations can
        /// be sorted by fields such as <c>InvitationDate</c> or <c>Status</c> to help partners
        /// view results in their preferred order.
        /// </para>
        /// </summary>
        public OpportunityEngagementInvitationSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status values to filter the invitations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
    /// Container for the parameters to the ListEngagementInvitations operation.
    /// Retrieves a list of engagement invitations sent to the partner. This allows partners
    /// to view all pending or past engagement invitations, helping them track opportunities
    /// shared by AWS.
    /// </summary>
    public partial class ListEngagementInvitationsRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private List<string> _engagementIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private ParticipantType _participantType;
        private List<string> _payloadType = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _senderAwsAccountId = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OpportunityEngagementInvitationSort _sort;
        private List<string> _status = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog from which to list the engagement invitations. Use <c>AWS</c>
        /// for production invitations or <c>Sandbox</c> for testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> EngagementIdentifier
        {
            get { return this._engagementIdentifier; }
            set { this._engagementIdentifier = value; }
        }

        // Check to see if EngagementIdentifier property is set
        internal bool IsSetEngagementIdentifier()
        {
            return this._engagementIdentifier != null && (this._engagementIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of engagement invitations to return in the response.
        /// If more results are available, a pagination token will be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used to retrieve additional pages of results when the response
        /// to a previous request was truncated. Pass this token to continue listing invitations
        /// from where the previous call left off.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantType. 
        /// <para>
        /// Specifies the type of participant for which to list engagement invitations. Identifies
        /// the role of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantType ParticipantType
        {
            get { return this._participantType; }
            set { this._participantType = value; }
        }

        // Check to see if ParticipantType property is set
        internal bool IsSetParticipantType()
        {
            return this._participantType != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// Defines the type of payload associated with the engagement invitations to be listed.
        /// The attributes in this payload help decide on acceptance or rejection of the invitation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PayloadType
        {
            get { return this._payloadType; }
            set { this._payloadType = value; }
        }

        // Check to see if PayloadType property is set
        internal bool IsSetPayloadType()
        {
            return this._payloadType != null && (this._payloadType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SenderAwsAccountId. 
        /// <para>
        ///  List of sender AWS account IDs to filter the invitations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SenderAwsAccountId
        {
            get { return this._senderAwsAccountId; }
            set { this._senderAwsAccountId = value; }
        }

        // Check to see if SenderAwsAccountId property is set
        internal bool IsSetSenderAwsAccountId()
        {
            return this._senderAwsAccountId != null && (this._senderAwsAccountId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the sorting options for listing engagement invitations. Invitations can
        /// be sorted by fields such as <c>InvitationDate</c> or <c>Status</c> to help partners
        /// view results in their preferred order.
        /// </para>
        /// </summary>
        public OpportunityEngagementInvitationSort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status values to filter the invitations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && (this._status.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
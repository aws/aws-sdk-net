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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Container for the parameters to the ListChannelHandshakes operation.
    /// Lists channel handshakes based on specified criteria.
    /// </summary>
    public partial class ListChannelHandshakesRequest : AmazonPartnerCentralChannelRequest
    {
        private List<string> _associatedResourceIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _catalog;
        private HandshakeType _handshakeType;
        private ListChannelHandshakesTypeFilters _handshakeTypeFilters;
        private ListChannelHandshakesTypeSort _handshakeTypeSort;
        private int? _maxResults;
        private string _nextToken;
        private ParticipantType _participantType;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceIdentifiers. 
        /// <para>
        /// Filter by associated resource identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedResourceIdentifiers
        {
            get { return this._associatedResourceIdentifiers; }
            set { this._associatedResourceIdentifiers = value; }
        }

        // Check to see if AssociatedResourceIdentifiers property is set
        internal bool IsSetAssociatedResourceIdentifiers()
        {
            return this._associatedResourceIdentifiers != null && (this._associatedResourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier to filter handshakes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property HandshakeType. 
        /// <para>
        /// Filter results by handshake type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HandshakeType HandshakeType
        {
            get { return this._handshakeType; }
            set { this._handshakeType = value; }
        }

        // Check to see if HandshakeType property is set
        internal bool IsSetHandshakeType()
        {
            return this._handshakeType != null;
        }

        /// <summary>
        /// Gets and sets the property HandshakeTypeFilters. 
        /// <para>
        /// Type-specific filters for handshakes.
        /// </para>
        /// </summary>
        public ListChannelHandshakesTypeFilters HandshakeTypeFilters
        {
            get { return this._handshakeTypeFilters; }
            set { this._handshakeTypeFilters = value; }
        }

        // Check to see if HandshakeTypeFilters property is set
        internal bool IsSetHandshakeTypeFilters()
        {
            return this._handshakeTypeFilters != null;
        }

        /// <summary>
        /// Gets and sets the property HandshakeTypeSort. 
        /// <para>
        /// Type-specific sorting options for handshakes.
        /// </para>
        /// </summary>
        public ListChannelHandshakesTypeSort HandshakeTypeSort
        {
            get { return this._handshakeTypeSort; }
            set { this._handshakeTypeSort = value; }
        }

        // Check to see if HandshakeTypeSort property is set
        internal bool IsSetHandshakeTypeSort()
        {
            return this._handshakeTypeSort != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
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
        /// Token for retrieving the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Filter by participant type (sender or receiver).
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
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Filter results by handshake status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
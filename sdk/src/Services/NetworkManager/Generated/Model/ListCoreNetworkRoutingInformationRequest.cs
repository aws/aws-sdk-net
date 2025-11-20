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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListCoreNetworkRoutingInformation operation.
    /// Lists routing information for a core network, including routes and their attributes.
    /// </summary>
    public partial class ListCoreNetworkRoutingInformationRequest : AmazonNetworkManagerRequest
    {
        private List<string> _communityMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _coreNetworkId;
        private string _edgeLocation;
        private List<string> _exactAsPathMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _localPreferenceMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private List<string> _medMatches = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, List<string>> _nextHopFilters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _nextToken;
        private string _segmentName;

        /// <summary>
        /// Gets and sets the property CommunityMatches. 
        /// <para>
        /// BGP community values to match when filtering routing information.
        /// </para>
        /// </summary>
        public List<string> CommunityMatches
        {
            get { return this._communityMatches; }
            set { this._communityMatches = value; }
        }

        // Check to see if CommunityMatches property is set
        internal bool IsSetCommunityMatches()
        {
            return this._communityMatches != null && (this._communityMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network to retrieve routing information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location to filter routing information by.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeLocation
        {
            get { return this._edgeLocation; }
            set { this._edgeLocation = value; }
        }

        // Check to see if EdgeLocation property is set
        internal bool IsSetEdgeLocation()
        {
            return this._edgeLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ExactAsPathMatches. 
        /// <para>
        /// Exact AS path values to match when filtering routing information.
        /// </para>
        /// </summary>
        public List<string> ExactAsPathMatches
        {
            get { return this._exactAsPathMatches; }
            set { this._exactAsPathMatches = value; }
        }

        // Check to see if ExactAsPathMatches property is set
        internal bool IsSetExactAsPathMatches()
        {
            return this._exactAsPathMatches != null && (this._exactAsPathMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocalPreferenceMatches. 
        /// <para>
        /// Local preference values to match when filtering routing information.
        /// </para>
        /// </summary>
        public List<string> LocalPreferenceMatches
        {
            get { return this._localPreferenceMatches; }
            set { this._localPreferenceMatches = value; }
        }

        // Check to see if LocalPreferenceMatches property is set
        internal bool IsSetLocalPreferenceMatches()
        {
            return this._localPreferenceMatches != null && (this._localPreferenceMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of routing information entries to return in a single page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MedMatches. 
        /// <para>
        /// Multi-Exit Discriminator (MED) values to match when filtering routing information.
        /// </para>
        /// </summary>
        public List<string> MedMatches
        {
            get { return this._medMatches; }
            set { this._medMatches = value; }
        }

        // Check to see if MedMatches property is set
        internal bool IsSetMedMatches()
        {
            return this._medMatches != null && (this._medMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextHopFilters. 
        /// <para>
        /// Filters to apply based on next hop information.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> NextHopFilters
        {
            get { return this._nextHopFilters; }
            set { this._nextHopFilters = value; }
        }

        // Check to see if NextHopFilters property is set
        internal bool IsSetNextHopFilters()
        {
            return this._nextHopFilters != null && (this._nextHopFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment to filter routing information by.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

    }
}
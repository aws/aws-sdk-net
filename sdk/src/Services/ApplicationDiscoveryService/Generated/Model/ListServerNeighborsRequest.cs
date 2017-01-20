/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the ListServerNeighbors operation.
    /// Retrieves a list of servers which are one network hop away from a specified server.
    /// </summary>
    public partial class ListServerNeighborsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private string _configurationId;
        private int? _maxResults;
        private List<string> _neighborConfigurationIds = new List<string>();
        private string _nextToken;
        private bool? _portInformationNeeded;

        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// Configuration ID of the server for which neighbors are being listed.
        /// </para>
        /// </summary>
        public string ConfigurationId
        {
            get { return this._configurationId; }
            set { this._configurationId = value; }
        }

        // Check to see if ConfigurationId property is set
        internal bool IsSetConfigurationId()
        {
            return this._configurationId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return in a single page of output.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NeighborConfigurationIds. 
        /// <para>
        /// List of configuration IDs to test for one-hop-away.
        /// </para>
        /// </summary>
        public List<string> NeighborConfigurationIds
        {
            get { return this._neighborConfigurationIds; }
            set { this._neighborConfigurationIds = value; }
        }

        // Check to see if NeighborConfigurationIds property is set
        internal bool IsSetNeighborConfigurationIds()
        {
            return this._neighborConfigurationIds != null && this._neighborConfigurationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to retrieve the next set of results. For example, if you previously specified
        /// 100 IDs for <code>ListServerNeighborsRequest$neighborConfigurationIds</code> but set
        /// <code>ListServerNeighborsRequest$maxResults</code> to 10, you received a set of 10
        /// results along with a token. Use that token in this query to get the next set of 10.
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
        /// Gets and sets the property PortInformationNeeded. 
        /// <para>
        /// Flag to indicate if port and protocol information is needed as part of the response.
        /// </para>
        /// </summary>
        public bool PortInformationNeeded
        {
            get { return this._portInformationNeeded.GetValueOrDefault(); }
            set { this._portInformationNeeded = value; }
        }

        // Check to see if PortInformationNeeded property is set
        internal bool IsSetPortInformationNeeded()
        {
            return this._portInformationNeeded.HasValue; 
        }

    }
}
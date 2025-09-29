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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceConfigurations operation.
    /// Lists the resource configurations owned by or shared with this account.
    /// </summary>
    public partial class ListResourceConfigurationsRequest : AmazonVPCLatticeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceConfigurationGroupIdentifier;
        private string _resourceGatewayIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
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
        /// A pagination token for the next page of results.
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
        /// Gets and sets the property ResourceConfigurationGroupIdentifier. 
        /// <para>
        /// The ID of the resource configuration of type <c>Group</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationGroupIdentifier
        {
            get { return this._resourceConfigurationGroupIdentifier; }
            set { this._resourceConfigurationGroupIdentifier = value; }
        }

        // Check to see if ResourceConfigurationGroupIdentifier property is set
        internal bool IsSetResourceConfigurationGroupIdentifier()
        {
            return this._resourceConfigurationGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayIdentifier. 
        /// <para>
        /// The ID of the resource gateway for the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=2048)]
        public string ResourceGatewayIdentifier
        {
            get { return this._resourceGatewayIdentifier; }
            set { this._resourceGatewayIdentifier = value; }
        }

        // Check to see if ResourceGatewayIdentifier property is set
        internal bool IsSetResourceGatewayIdentifier()
        {
            return this._resourceGatewayIdentifier != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the ListOdbPeeringConnections operation.
    /// </summary>
    public partial class ListOdbPeeringConnectionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OdbPeeringConnectionSummary> _odbPeeringConnections = AWSConfigs.InitializeCollections ? new List<OdbPeeringConnectionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next page of ODB peering connections.
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
        /// Gets and sets the property OdbPeeringConnections. 
        /// <para>
        /// The list of ODB peering connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<OdbPeeringConnectionSummary> OdbPeeringConnections
        {
            get { return this._odbPeeringConnections; }
            set { this._odbPeeringConnections = value; }
        }

        // Check to see if OdbPeeringConnections property is set
        internal bool IsSetOdbPeeringConnections()
        {
            return this._odbPeeringConnections != null && (this._odbPeeringConnections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
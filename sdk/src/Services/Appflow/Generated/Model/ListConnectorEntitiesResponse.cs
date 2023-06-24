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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the ListConnectorEntities operation.
    /// </summary>
    public partial class ListConnectorEntitiesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, List<ConnectorEntity>> _connectorEntityMap = new Dictionary<string, List<ConnectorEntity>>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectorEntityMap. 
        /// <para>
        ///  The response of <code>ListConnectorEntities</code> lists entities grouped by category.
        /// This map's key represents the group name, and its value contains the list of entities
        /// belonging to that group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<ConnectorEntity>> ConnectorEntityMap
        {
            get { return this._connectorEntityMap; }
            set { this._connectorEntityMap = value; }
        }

        // Check to see if ConnectorEntityMap property is set
        internal bool IsSetConnectorEntityMap()
        {
            return this._connectorEntityMap != null && this._connectorEntityMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that you specify in your next <code>ListConnectorEntities</code> operation
        /// to get the next page of results in paginated response. The <code>ListConnectorEntities</code>
        /// operation provides this token if the response is too big for the page size.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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

    }
}
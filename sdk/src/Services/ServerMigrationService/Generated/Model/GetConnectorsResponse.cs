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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// This is the response object from the GetConnectors operation.
    /// </summary>
    public partial class GetConnectorsResponse : AmazonWebServiceResponse
    {
        private List<Connector> _connectorList = new List<Connector>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectorList. 
        /// <para>
        /// Information about the registered connectors.
        /// </para>
        /// </summary>
        public List<Connector> ConnectorList
        {
            get { return this._connectorList; }
            set { this._connectorList = value; }
        }

        // Check to see if ConnectorList property is set
        internal bool IsSetConnectorList()
        {
            return this._connectorList != null && this._connectorList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required to retrieve the next set of results. This value is null when there
        /// are no more results to return.
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

    }
}
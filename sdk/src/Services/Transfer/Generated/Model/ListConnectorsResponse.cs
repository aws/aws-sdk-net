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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the ListConnectors operation.
    /// </summary>
    public partial class ListConnectorsResponse : AmazonWebServiceResponse
    {
        private List<ListedConnector> _connectors = AWSConfigs.InitializeCollections ? new List<ListedConnector>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Connectors. 
        /// <para>
        /// Returns an array, where each item contains the details of a connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedConnector> Connectors
        {
            get { return this._connectors; }
            set { this._connectors = value; }
        }

        // Check to see if Connectors property is set
        internal bool IsSetConnectors()
        {
            return this._connectors != null && (this._connectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Returns a token that you can use to call <c>ListConnectors</c> again and receive additional
        /// results, if there are any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
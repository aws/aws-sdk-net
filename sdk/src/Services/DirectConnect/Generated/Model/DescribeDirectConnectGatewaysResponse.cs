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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeDirectConnectGateways operation.
    /// </summary>
    public partial class DescribeDirectConnectGatewaysResponse : AmazonWebServiceResponse
    {
        private List<DirectConnectGateway> _directConnectGateways = new List<DirectConnectGateway>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DirectConnectGateways. 
        /// <para>
        /// The Direct Connect gateways.
        /// </para>
        /// </summary>
        public List<DirectConnectGateway> DirectConnectGateways
        {
            get { return this._directConnectGateways; }
            set { this._directConnectGateways = value; }
        }

        // Check to see if DirectConnectGateways property is set
        internal bool IsSetDirectConnectGateways()
        {
            return this._directConnectGateways != null && this._directConnectGateways.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page.
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
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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// This is the response object from the ListOrders operation.
    /// </summary>
    public partial class ListOrdersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Order> _orders = AWSConfigs.InitializeCollections ? new List<Order>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
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
        /// Gets and sets the property Orders. 
        /// <para>
        /// Information about the orders.
        /// </para>
        /// </summary>
        public List<Order> Orders
        {
            get { return this._orders; }
            set { this._orders = value; }
        }

        // Check to see if Orders property is set
        internal bool IsSetOrders()
        {
            return this._orders != null && (this._orders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
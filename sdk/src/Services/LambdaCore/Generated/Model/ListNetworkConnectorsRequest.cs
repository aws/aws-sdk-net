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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
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
namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the ListNetworkConnectors operation.
    /// Returns a paginated list of network connectors in your account for the current Region.
    /// You can optionally filter results by connector state. Use the <c>Marker</c> parameter
    /// from a previous response to retrieve the next page of results.
    /// 
    ///  
    /// <para>
    /// Each item in the response includes the connector ARN, name, ID, type, current state,
    /// and last modified timestamp. To retrieve full configuration details for a specific
    /// connector, use <c>GetNetworkConnector</c>.
    /// </para>
    /// </summary>
    public partial class ListNetworkConnectorsRequest : AmazonLambdaCoreRequest
    {
        private string _marker;
        private int? _maxItems;
        private NetworkConnectorState _state;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token from a previous <c>ListNetworkConnectors</c> response. Use this
        /// value to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of connectors to return per page. Valid range: 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Optional filter to return only connectors in the specified state (for example, <c>ACTIVE</c>
        /// or <c>FAILED</c>).
        /// </para>
        /// </summary>
        public NetworkConnectorState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}
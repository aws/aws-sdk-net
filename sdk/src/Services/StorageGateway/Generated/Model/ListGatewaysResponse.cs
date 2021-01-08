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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the ListGateways operation.
    /// </summary>
    public partial class ListGatewaysResponse : AmazonWebServiceResponse
    {
        private List<GatewayInfo> _gateways = new List<GatewayInfo>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property Gateways. 
        /// <para>
        /// An array of <a>GatewayInfo</a> objects.
        /// </para>
        /// </summary>
        public List<GatewayInfo> Gateways
        {
            get { return this._gateways; }
            set { this._gateways = value; }
        }

        // Check to see if Gateways property is set
        internal bool IsSetGateways()
        {
            return this._gateways != null && this._gateways.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use the marker in your next request to fetch the next set of gateways in the list.
        /// If there are no more gateways to list, this field does not appear in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

    }
}
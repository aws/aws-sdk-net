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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the SearchTransitGatewayRoutes operation.
    /// </summary>
    public partial class SearchTransitGatewayRoutesResponse : AmazonWebServiceResponse
    {
        private bool? _additionalRoutesAvailable;
        private List<TransitGatewayRoute> _routes = new List<TransitGatewayRoute>();

        /// <summary>
        /// Gets and sets the property AdditionalRoutesAvailable. 
        /// <para>
        /// Indicates whether there are additional routes available.
        /// </para>
        /// </summary>
        public bool AdditionalRoutesAvailable
        {
            get { return this._additionalRoutesAvailable.GetValueOrDefault(); }
            set { this._additionalRoutesAvailable = value; }
        }

        // Check to see if AdditionalRoutesAvailable property is set
        internal bool IsSetAdditionalRoutesAvailable()
        {
            return this._additionalRoutesAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// Information about the routes.
        /// </para>
        /// </summary>
        public List<TransitGatewayRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && this._routes.Count > 0; 
        }

    }
}
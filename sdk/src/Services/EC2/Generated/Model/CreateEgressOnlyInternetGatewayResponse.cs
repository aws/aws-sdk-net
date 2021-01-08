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
    /// This is the response object from the CreateEgressOnlyInternetGateway operation.
    /// </summary>
    public partial class CreateEgressOnlyInternetGatewayResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private EgressOnlyInternetGateway _egressOnlyInternetGateway;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway. 
        /// <para>
        /// Information about the egress-only internet gateway.
        /// </para>
        /// </summary>
        public EgressOnlyInternetGateway EgressOnlyInternetGateway
        {
            get { return this._egressOnlyInternetGateway; }
            set { this._egressOnlyInternetGateway = value; }
        }

        // Check to see if EgressOnlyInternetGateway property is set
        internal bool IsSetEgressOnlyInternetGateway()
        {
            return this._egressOnlyInternetGateway != null;
        }

    }
}
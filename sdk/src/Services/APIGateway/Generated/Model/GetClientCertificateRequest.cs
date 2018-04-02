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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetClientCertificate operation.
    /// Gets information about the current <a>ClientCertificate</a> resource.
    /// </summary>
    public partial class GetClientCertificateRequest : AmazonAPIGatewayRequest
    {
        private string _clientCertificateId;

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// [Required] The identifier of the <a>ClientCertificate</a> resource to be described.
        /// </para>
        /// </summary>
        public string ClientCertificateId
        {
            get { return this._clientCertificateId; }
            set { this._clientCertificateId = value; }
        }

        // Check to see if ClientCertificateId property is set
        internal bool IsSetClientCertificateId()
        {
            return this._clientCertificateId != null;
        }

    }
}
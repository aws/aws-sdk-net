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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetApiMapping operation.
    /// Gets an API mapping.
    /// </summary>
    public partial class GetApiMappingRequest : AmazonApiGatewayV2Request
    {
        private string _apiMappingId;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property ApiMappingId. 
        /// <para>
        /// The API mapping identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiMappingId
        {
            get { return this._apiMappingId; }
            set { this._apiMappingId = value; }
        }

        // Check to see if ApiMappingId property is set
        internal bool IsSetApiMappingId()
        {
            return this._apiMappingId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}
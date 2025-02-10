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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetBasePathMapping operation.
    /// Describe a BasePathMapping resource.
    /// </summary>
    public partial class GetBasePathMappingRequest : AmazonAPIGatewayRequest
    {
        private string _basePath;
        private string _domainName;
        private string _domainNameId;

        /// <summary>
        /// Gets and sets the property BasePath. 
        /// <para>
        /// The base path name that callers of the API must provide as part of the URL after the
        /// domain name. This value must be unique for all of the mappings across a single API.
        /// Specify '(none)' if you do not want callers to specify any base path name after the
        /// domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BasePath
        {
            get { return this._basePath; }
            set { this._basePath = value; }
        }

        // Check to see if BasePath property is set
        internal bool IsSetBasePath()
        {
            return this._basePath != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the BasePathMapping resource to be described.
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

        /// <summary>
        /// Gets and sets the property DomainNameId. 
        /// <para>
        /// The identifier for the domain name resource. Supported only for private custom domain
        /// names. 
        /// </para>
        /// </summary>
        public string DomainNameId
        {
            get { return this._domainNameId; }
            set { this._domainNameId = value; }
        }

        // Check to see if DomainNameId property is set
        internal bool IsSetDomainNameId()
        {
            return this._domainNameId != null;
        }

    }
}
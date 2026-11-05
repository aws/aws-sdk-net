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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateBasePathMapping operation. Creates a new
    /// BasePathMapping resource.
    /// </summary>
    public partial class CreateBasePathMappingRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property BasePath. 
        /// <para>
        /// The base path name that callers of the API must provide as part of the URL after the
        /// domain name. This value must be unique for all of the mappings across a single API.
        /// Specify '(none)' if you do not want callers to specify a base path name after the
        /// domain name.
        /// </para>
        /// </summary>
        public string BasePath { get; set; }

        /// <summary>
        /// Checks to see if the BasePath property is set.
        /// </summary>
        internal bool IsSetBasePath() => this.BasePath != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the BasePathMapping resource to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainNameId. 
        /// <para>
        /// The identifier for the domain name resource. Required for private custom domain names.
        /// </para>
        /// </summary>
        public string DomainNameId { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameId property is set.
        /// </summary>
        internal bool IsSetDomainNameId() => this.DomainNameId != null;

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The name of the API's stage that you want to use for this mapping. Specify '(none)'
        /// if you want callers to explicitly specify the stage name after any base path name.
        /// </para>
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}

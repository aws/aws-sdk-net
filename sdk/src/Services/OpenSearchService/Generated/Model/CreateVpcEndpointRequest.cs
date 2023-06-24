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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcEndpoint operation.
    /// Creates an Amazon OpenSearch Service-managed VPC endpoint.
    /// </summary>
    public partial class CreateVpcEndpointRequest : AmazonOpenSearchServiceRequest
    {
        private string _clientToken;
        private string _domainArn;
        private VPCOptions _vpcOptions;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain to create the endpoint for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DomainArn
        {
            get { return this._domainArn; }
            set { this._domainArn = value; }
        }

        // Check to see if DomainArn property is set
        internal bool IsSetDomainArn()
        {
            return this._domainArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOptions. 
        /// <para>
        /// Options to specify the subnets and security groups for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VPCOptions VpcOptions
        {
            get { return this._vpcOptions; }
            set { this._vpcOptions = value; }
        }

        // Check to see if VpcOptions property is set
        internal bool IsSetVpcOptions()
        {
            return this._vpcOptions != null;
        }

    }
}
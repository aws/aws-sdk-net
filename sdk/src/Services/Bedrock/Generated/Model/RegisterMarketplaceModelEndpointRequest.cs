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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterMarketplaceModelEndpoint operation.
    /// Registers an existing Amazon SageMaker endpoint with Amazon Bedrock Marketplace, allowing
    /// it to be used with Amazon Bedrock APIs.
    /// </summary>
    public partial class RegisterMarketplaceModelEndpointRequest : AmazonBedrockRequest
    {
        private string _endpointIdentifier;
        private string _modelSourceIdentifier;

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The ARN of the Amazon SageMaker endpoint you want to register with Amazon Bedrock
        /// Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string EndpointIdentifier
        {
            get { return this._endpointIdentifier; }
            set { this._endpointIdentifier = value; }
        }

        // Check to see if EndpointIdentifier property is set
        internal bool IsSetEndpointIdentifier()
        {
            return this._endpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSourceIdentifier. 
        /// <para>
        /// The ARN of the model from Amazon Bedrock Marketplace that is deployed on the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ModelSourceIdentifier
        {
            get { return this._modelSourceIdentifier; }
            set { this._modelSourceIdentifier = value; }
        }

        // Check to see if ModelSourceIdentifier property is set
        internal bool IsSetModelSourceIdentifier()
        {
            return this._modelSourceIdentifier != null;
        }

    }
}
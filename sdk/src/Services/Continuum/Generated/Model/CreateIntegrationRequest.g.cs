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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegration operation. Creates a new integration
    /// with an external source provider. Repeating an identical request with the same clientToken
    /// returns the original integrationId, integrationArn, and createdAt. Token records are
    /// retained for eight hours after success or terminal failure, including after the integration
    /// is deleted; replaying a deleted integration's token does not recreate it. An identical
    /// request with a retained terminal failure returns the recorded error. Reusing a token
    /// with different parameters returns ValidationException. A fresh token starts a new
    /// create attempt; if the name is already owned by another integration, ConflictException
    /// includes that integration's identifier. An attempt still in progress may return ThrottlingException
    /// with retryAfterSeconds set to 1; retry with the same token and identical parameters.
    /// GitHub authorization codes are single use. Retry an unresolved attempt with its original
    /// token and unchanged parameters first. If the service reports a terminal failure, an
    /// expired attempt, or a successful token exchange whose integration could not be saved,
    /// restart GitHub authorization with a fresh token and authorization code. The service
    /// does not checkpoint provider results for recovery by another request.
    /// </summary>
    public partial class CreateIntegrationRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. An optional token identifying one create attempt
        /// within the caller's account, Region, and operation. SDKs generate a token when omitted.
        /// If a request reaches the service without a token, the service generates one for that
        /// request. Each request without a token starts a new attempt. To replay an attempt,
        /// supply the same token and identical input. Authorized users and roles in the same
        /// account can retry an attempt this way. Token records are retained for eight hours
        /// after success or terminal failure, including after deletion of a successfully created
        /// integration. Different input with the same token returns ValidationException.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Name. The name for the integration.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderConfiguration. The provider-specific configuration
        /// required to create the integration. Only one member may be specified.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderConfiguration ProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderConfiguration() => this.ProviderConfiguration != null;
    }
}

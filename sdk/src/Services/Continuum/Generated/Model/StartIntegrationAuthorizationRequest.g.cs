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
    /// Container for the parameters to the StartIntegrationAuthorization operation. Starts
    /// an OAuth authorization for a new integration and returns the values the caller sends
    /// to the provider's authorization endpoint. The authorization belongs to the calling
    /// AWS account, can be redeemed once by CreateIntegration from that same account, and
    /// expires after ten minutes.
    /// </summary>
    public partial class StartIntegrationAuthorizationRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property Name. The name the integration will be created with. When
        /// specified, the request fails with ConflictException if an integration with this name
        /// already exists in the account, before the caller leaves for the provider. The name
        /// is only checked: it is not reserved, stored, or authorized. CreateIntegration requires
        /// its own name, checks it again, and may use a different one.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderType. The provider to authorize. Only GITHUB is
        /// supported.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationAuthorizationProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;
    }
}

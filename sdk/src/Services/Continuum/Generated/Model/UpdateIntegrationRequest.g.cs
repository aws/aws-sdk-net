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
    /// Container for the parameters to the UpdateIntegration operation. Rotates the credentials
    /// used by an Amazon S3 integration. Only S3 integrations can be updated; GitHub integrations
    /// cannot be modified. The integration's name, provider type, and bucket remain fixed.
    /// The caller must have iam:PassRole permission for the supplied role, including when
    /// only the external ID changes. Continuum verifies that the role can be assumed with
    /// the requested external ID and can access the existing bucket before saving both credentials
    /// atomically. Omitting externalId preserves its current value. Repeating both current
    /// credentials leaves updatedAt unchanged, but still requires authorization and access
    /// validation.
    /// </summary>
    public partial class UpdateIntegrationRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property IntegrationId. The unique identifier of the S3 integration
        /// to update.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property ProviderConfiguration. The provider-specific changes to
        /// apply. The member must match the integration's provider type, and only S3 integrations
        /// can be updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateProviderConfiguration ProviderConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderConfiguration() => this.ProviderConfiguration != null;
    }
}

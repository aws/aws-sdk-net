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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProvisioningProfile operation. Create a
    /// provisioning profile for executing device provisioning flows. The provisioning profile
    /// is a document that defines the set of resources and policies applied to a device during
    /// the provisioning process.
    /// </summary>
    public partial class CreateProvisioningProfileRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property CaCertificate. 
        /// <para>
        /// The body of the PEM-encoded certificate authority (CA) certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CaCertificate { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificate property is set.
        /// </summary>
        internal bool IsSetCaCertificate() => this.CaCertificate != null;

        /// <summary>
        /// Gets and sets the property ClaimCertificate. 
        /// <para>
        /// The body of the PEM-encoded claim certificate. If a claim certificate is provided,
        /// it will be used for the provisioning profile. Otherwise, a claim certificate will
        /// be generated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ClaimCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ClaimCertificate property is set.
        /// </summary>
        internal bool IsSetClaimCertificate() => this.ClaimCertificate != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token. If you retry a request that completed successfully initially
        /// using the same client token and parameters, then the retry attempt will succeed without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the provisioning profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProvisioningType. 
        /// <para>
        /// The type of provisioning workflow the device uses for onboarding to IoT managed integrations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvisioningType ProvisioningType { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningType property is set.
        /// </summary>
        internal bool IsSetProvisioningType() => this.ProvisioningType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the provisioning profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

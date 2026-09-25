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
    /// Container for the parameters to the CreateConnectorDestination operation. Create a
    /// connector destination for connecting a cloud-to-cloud (C2C) connector to the customer's
    /// Amazon Web Services account.
    /// </summary>
    public partial class CreateConnectorDestinationRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthConfig. 
        /// <para>
        /// The authentication configuration details for the connector destination, including
        /// OAuth settings and other authentication parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthConfig property is set.
        /// </summary>
        internal bool IsSetAuthConfig() => this.AuthConfig != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authentication type used for the connector destination, which determines how credentials
        /// and access are managed.
        /// </para>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

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
        /// Gets and sets the property CloudConnectorId. 
        /// <para>
        /// The identifier of the C2C connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CloudConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the CloudConnectorId property is set.
        /// </summary>
        internal bool IsSetCloudConnectorId() => this.CloudConnectorId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the connector destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecretsManager. 
        /// <para>
        /// The AWS Secrets Manager configuration used to securely store and manage sensitive
        /// information for the connector destination.
        /// </para>
        /// </summary>
        public SecretsManager SecretsManager { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManager property is set.
        /// </summary>
        internal bool IsSetSecretsManager() => this.SecretsManager != null;
    }
}

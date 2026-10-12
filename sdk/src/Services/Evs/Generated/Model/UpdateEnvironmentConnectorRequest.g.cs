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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironmentConnector operation. Updates
    /// a connector for an Amazon EVS environment. You can update the Amazon Web Services
    /// Secrets Manager secret ARN or the appliance FQDN to reconfigure the connector metadata.
    /// <note> <para> You cannot update both the secret and the FQDN in the same request.
    /// </para> </note>
    /// </summary>
    public partial class UpdateEnvironmentConnectorRequest : AmazonEvsRequest
    {
        /// <summary>
        /// Gets and sets the property ApplianceFqdn. 
        /// <para>
        /// The new fully qualified domain name (FQDN) of the VCF appliance that the connector
        /// connects to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string ApplianceFqdn { get; set; }

        /// <summary>
        /// Checks to see if the ApplianceFqdn property is set.
        /// </summary>
        internal bool IsSetApplianceFqdn() => this.ApplianceFqdn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the connector update request. If you do not specify a client token, a randomly generated
        /// token is used for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// A unique ID for the connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment that the connector belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property SecretIdentifier. 
        /// <para>
        /// The new ARN or name of the Amazon Web Services Secrets Manager secret that stores
        /// the credentials for the VCF appliance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SecretIdentifier property is set.
        /// </summary>
        internal bool IsSetSecretIdentifier() => this.SecretIdentifier != null;
    }
}

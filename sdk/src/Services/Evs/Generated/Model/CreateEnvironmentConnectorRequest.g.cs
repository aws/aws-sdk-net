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
    /// Container for the parameters to the CreateEnvironmentConnector operation. Creates
    /// a connector for an Amazon EVS environment. A connector allows the Amazon EVS control
    /// plane to interface with VCF appliances using a fully qualified domain name. <para>
    /// You can create only one connector of each type per environment. For environments where
    /// Amazon EVS installs VCF, the <c>SDDC_MANAGER</c> connector is created automatically.
    /// </para> <note> <para> Amazon EVS requires an active connector to SDDC Manager or VCF
    /// Operations Manager to monitor environment health and license compliance. </para> </note>
    /// </summary>
    public partial class CreateEnvironmentConnectorRequest : AmazonEvsRequest
    {
        /// <summary>
        /// Gets and sets the property ApplianceFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the VCF appliance that the connector targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
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
        /// the connector creation request. If you do not specify a client token, a randomly generated
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment to create the connector in.
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
        /// The ARN or name of the Amazon Web Services Secrets Manager secret that stores the
        /// credentials for the VCF appliance. <c>SDDC_MANAGER</c> requires an <c>apiKey</c> field;
        /// <c>OPERATIONS_MANAGER</c> and <c>VCENTER</c> require <c>username</c> and <c>password</c>
        /// fields.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not use credentials with Administrator privileges. We recommend using a service
        /// account with read-only permissions.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SecretIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SecretIdentifier property is set.
        /// </summary>
        internal bool IsSetSecretIdentifier() => this.SecretIdentifier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of connector to create.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OPERATIONS_MANAGER</c>: Connector to an Operations Manager appliance. Required
        /// for VCF 9x environments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDDC_MANAGER</c>: Connector to an SDDC Manager appliance. Required for VCF 5.x
        /// environments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VCENTER</c>: Connector to a vCenter Server appliance. Required for features that
        /// depend on vCenter, such as Windows Server license-included.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

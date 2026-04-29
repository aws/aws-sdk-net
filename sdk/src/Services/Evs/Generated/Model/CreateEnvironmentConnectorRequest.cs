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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
    /// Container for the parameters to the CreateEnvironmentConnector operation.
    /// Creates a connector for an Amazon EVS environment. A connector establishes a connection
    /// to a VCF appliance, such as vCenter, using a fully qualified domain name and an Amazon
    /// Web Services Secrets Manager secret that stores the appliance credentials.
    /// </summary>
    public partial class CreateEnvironmentConnectorRequest : AmazonEvsRequest
    {
        private string _applianceFqdn;
        private string _clientToken;
        private string _environmentId;
        private string _secretIdentifier;
        private ConnectorType _type;

        /// <summary>
        /// Gets and sets the property ApplianceFqdn. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the VCF appliance that the connector targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string ApplianceFqdn
        {
            get { return this._applianceFqdn; }
            set { this._applianceFqdn = value; }
        }

        // Check to see if ApplianceFqdn property is set
        internal bool IsSetApplianceFqdn()
        {
            return this._applianceFqdn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
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
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment to create the connector in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretIdentifier. 
        /// <para>
        /// The ARN or name of the Amazon Web Services Secrets Manager secret that stores the
        /// credentials for the VCF appliance.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not use credentials with Administrator privileges. We recommend using a service
        /// account with the minimum required permissions.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SecretIdentifier
        {
            get { return this._secretIdentifier; }
            set { this._secretIdentifier = value; }
        }

        // Check to see if SecretIdentifier property is set
        internal bool IsSetSecretIdentifier()
        {
            return this._secretIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of connector to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
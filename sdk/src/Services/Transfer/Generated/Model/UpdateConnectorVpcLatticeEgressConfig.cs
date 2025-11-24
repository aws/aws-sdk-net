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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// VPC_LATTICE egress configuration updates for modifying how the connector routes traffic
    /// through customer VPCs. Changes to these settings may require connector restart to
    /// take effect.
    /// </summary>
    public partial class UpdateConnectorVpcLatticeEgressConfig
    {
        private int? _portNumber;
        private string _resourceConfigurationArn;

        /// <summary>
        /// Gets and sets the property PortNumber. 
        /// <para>
        /// Updated port number for SFTP connections through VPC_LATTICE. Change this if the target
        /// SFTP server port has been modified or if connecting to a different server endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? PortNumber
        {
            get { return this._portNumber; }
            set { this._portNumber = value; }
        }

        // Check to see if PortNumber property is set
        internal bool IsSetPortNumber()
        {
            return this._portNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// Updated ARN of the VPC_LATTICE Resource Configuration. Use this to change the target
        /// SFTP server location or modify the network path through the customer's VPC infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceConfigurationArn
        {
            get { return this._resourceConfigurationArn; }
            set { this._resourceConfigurationArn = value; }
        }

        // Check to see if ResourceConfigurationArn property is set
        internal bool IsSetResourceConfigurationArn()
        {
            return this._resourceConfigurationArn != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes configuration settings related to outbound network traffic of an App Runner
    /// service.
    /// </summary>
    public partial class EgressConfiguration
    {
        private EgressType _egressType;
        private string _vpcConnectorArn;

        /// <summary>
        /// Gets and sets the property EgressType. 
        /// <para>
        /// The type of egress configuration.
        /// </para>
        ///  
        /// <para>
        /// Set to <c>DEFAULT</c> for access to resources hosted on public networks.
        /// </para>
        ///  
        /// <para>
        /// Set to <c>VPC</c> to associate your service to a custom VPC specified by <c>VpcConnectorArn</c>.
        /// </para>
        /// </summary>
        public EgressType EgressType
        {
            get { return this._egressType; }
            set { this._egressType = value; }
        }

        // Check to see if EgressType property is set
        internal bool IsSetEgressType()
        {
            return this._egressType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate
        /// with your App Runner service. Only valid when <c>EgressType = VPC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string VpcConnectorArn
        {
            get { return this._vpcConnectorArn; }
            set { this._vpcConnectorArn = value; }
        }

        // Check to see if VpcConnectorArn property is set
        internal bool IsSetVpcConnectorArn()
        {
            return this._vpcConnectorArn != null;
        }

    }
}
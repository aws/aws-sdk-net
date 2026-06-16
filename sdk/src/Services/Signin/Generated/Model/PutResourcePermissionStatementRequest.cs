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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePermissionStatement operation.
    /// Create a permission statement in the account's SignIn resource-based policy
    /// </summary>
    public partial class PutResourcePermissionStatementRequest : AmazonSigninRequest
    {
        private string _clientToken;
        private string _consoleSourceVpce;
        private string _excludedPrincipal;
        private string _requestedRegion;
        private string _signinSourceVpce;
        private string _sourceIp;
        private string _sourceVpc;
        private string _vpcSourceIp;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token for the request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ConsoleSourceVpce. 
        /// <para>
        /// Console VPC endpoint identifier
        /// </para>
        /// </summary>
        public string ConsoleSourceVpce
        {
            get { return this._consoleSourceVpce; }
            set { this._consoleSourceVpce = value; }
        }

        // Check to see if ConsoleSourceVpce property is set
        internal bool IsSetConsoleSourceVpce()
        {
            return this._consoleSourceVpce != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedPrincipal. 
        /// <para>
        /// Principal to exclude from the permission statement
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExcludedPrincipal
        {
            get { return this._excludedPrincipal; }
            set { this._excludedPrincipal = value; }
        }

        // Check to see if ExcludedPrincipal property is set
        internal bool IsSetExcludedPrincipal()
        {
            return this._excludedPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedRegion. 
        /// <para>
        /// AWS region where the VPC and VPC endpoint reside Required when sourceVpc or signinSourceVpce/consoleSourceVpce
        /// is provided
        /// </para>
        /// </summary>
        public string RequestedRegion
        {
            get { return this._requestedRegion; }
            set { this._requestedRegion = value; }
        }

        // Check to see if RequestedRegion property is set
        internal bool IsSetRequestedRegion()
        {
            return this._requestedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SigninSourceVpce. 
        /// <para>
        /// SignIn VPC endpoint identifier
        /// </para>
        /// </summary>
        public string SigninSourceVpce
        {
            get { return this._signinSourceVpce; }
            set { this._signinSourceVpce = value; }
        }

        // Check to see if SigninSourceVpce property is set
        internal bool IsSetSigninSourceVpce()
        {
            return this._signinSourceVpce != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// Source IP address
        /// </para>
        /// </summary>
        public string SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVpc. 
        /// <para>
        /// VPC identifier to restrict console access
        /// </para>
        /// </summary>
        public string SourceVpc
        {
            get { return this._sourceVpc; }
            set { this._sourceVpc = value; }
        }

        // Check to see if SourceVpc property is set
        internal bool IsSetSourceVpc()
        {
            return this._sourceVpc != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSourceIp. 
        /// <para>
        /// Source IP address within VPC
        /// </para>
        /// </summary>
        public string VpcSourceIp
        {
            get { return this._vpcSourceIp; }
            set { this._vpcSourceIp = value; }
        }

        // Check to see if VpcSourceIp property is set
        internal bool IsSetVpcSourceIp()
        {
            return this._vpcSourceIp != null;
        }

    }
}
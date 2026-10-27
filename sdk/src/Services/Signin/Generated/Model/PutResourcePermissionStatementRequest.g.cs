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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePermissionStatement operation. Create
    /// a permission statement in the account's SignIn resource-based policy
    /// </summary>
    public partial class PutResourcePermissionStatementRequest : AmazonSigninRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token for the request
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConsoleSourceVpce. Console VPC endpoint identifier
        /// </summary>
        public string ConsoleSourceVpce { get; set; }

        /// <summary>
        /// Checks to see if the ConsoleSourceVpce property is set.
        /// </summary>
        internal bool IsSetConsoleSourceVpce() => this.ConsoleSourceVpce != null;

        /// <summary>
        /// Gets and sets the property ExcludedPrincipal. Principal to exclude from the permission
        /// statement
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExcludedPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ExcludedPrincipal property is set.
        /// </summary>
        internal bool IsSetExcludedPrincipal() => this.ExcludedPrincipal != null;

        /// <summary>
        /// Gets and sets the property RequestedRegion. AWS region where the VPC and VPC endpoint
        /// reside Required when sourceVpc or signinSourceVpce/consoleSourceVpce is provided
        /// </summary>
        public string RequestedRegion { get; set; }

        /// <summary>
        /// Checks to see if the RequestedRegion property is set.
        /// </summary>
        internal bool IsSetRequestedRegion() => this.RequestedRegion != null;

        /// <summary>
        /// Gets and sets the property SigninSourceVpce. SignIn VPC endpoint identifier
        /// </summary>
        public string SigninSourceVpce { get; set; }

        /// <summary>
        /// Checks to see if the SigninSourceVpce property is set.
        /// </summary>
        internal bool IsSetSigninSourceVpce() => this.SigninSourceVpce != null;

        /// <summary>
        /// Gets and sets the property SourceIp. Source IP address
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SourceIp property is set.
        /// </summary>
        internal bool IsSetSourceIp() => this.SourceIp != null;

        /// <summary>
        /// Gets and sets the property SourceVpc. VPC identifier to restrict console access
        /// </summary>
        public string SourceVpc { get; set; }

        /// <summary>
        /// Checks to see if the SourceVpc property is set.
        /// </summary>
        internal bool IsSetSourceVpc() => this.SourceVpc != null;

        /// <summary>
        /// Gets and sets the property VpcSourceIp. Source IP address within VPC
        /// </summary>
        public string VpcSourceIp { get; set; }

        /// <summary>
        /// Checks to see if the VpcSourceIp property is set.
        /// </summary>
        internal bool IsSetVpcSourceIp() => this.VpcSourceIp != null;
    }
}

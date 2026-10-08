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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Private network access to the resource inside a VPC, using a private connection.
    /// </summary>
    public partial class PrivateNetworkAccess
    {
        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// Name of the private connection that supplies the VPC configuration for this release
        /// management environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 30)]
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// Role ARN that AWS DevOps Agent assumes at runtime to connect to your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RuntimeRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeRoleArn property is set.
        /// </summary>
        internal bool IsSetRuntimeRoleArn() => this.RuntimeRoleArn != null;
    }
}

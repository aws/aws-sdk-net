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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Authentication method for calling a remote MCP server.
    /// </summary>
    public partial class HarnessRemoteMcpOutboundAuth
    {
        /// <summary>
        /// Gets and sets the property AwsIam. 
        /// <para>
        /// Sign requests to the remote MCP server with Signature Version 4 (SigV4) using the
        /// harness execution role. If you don't specify a Region, the harness Region is used.
        /// </para>
        /// </summary>
        public IamCredentialProvider AwsIam { get; set; }

        /// <summary>
        /// Checks to see if the AwsIam property is set.
        /// </summary>
        internal bool IsSetAwsIam() => this.AwsIam != null;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// No authentication.
        /// </para>
        /// </summary>
        public Unit None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;
    }
}

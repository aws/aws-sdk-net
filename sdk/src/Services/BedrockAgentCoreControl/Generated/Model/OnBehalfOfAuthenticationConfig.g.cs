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
    /// Specifies the client authentication method to use for the on-behalf-of token exchange.
    /// </summary>
    public partial class OnBehalfOfAuthenticationConfig
    {
        /// <summary>
        /// Gets and sets the property ClientAuthenticationMethod. 
        /// <para>
        /// The client authentication method to use during the on-behalf-of token exchange. The
        /// <c>NO_CLIENT</c> option omits the <c>clientId</c> and <c>clientSecret</c> during the
        /// on-behalf-of token exchange with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnBehalfOfClientAuthenticationMethod ClientAuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ClientAuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetClientAuthenticationMethod() => this.ClientAuthenticationMethod != null;
    }
}

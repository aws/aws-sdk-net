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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ExchangeCodeForToken operation. <note> <para>
    /// This is for internal use. </para> </note> <para> Amplify uses this action to exchange
    /// an access code for a token. </para>
    /// </summary>
    public partial class ExchangeCodeForTokenRequest : AmazonAmplifyUIBuilderRequest
    {
        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The third-party provider for the token. The only valid value is <c>figma</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenProviders Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// Describes the configuration of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExchangeCodeForTokenRequestBody Request { get; set; }

        /// <summary>
        /// Checks to see if the Request property is set.
        /// </summary>
        internal bool IsSetRequest() => this.Request != null;
    }
}

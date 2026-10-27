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
    /// An API key credential provider for gateway authentication. This structure contains
    /// the configuration for authenticating with the target endpoint using an API key.
    /// </summary>
    public partial class ApiKeyCredentialProvider
    {
        /// <summary>
        /// Gets and sets the property CredentialLocation. 
        /// <para>
        /// The location of the API key credential. This field specifies where in the request
        /// the API key should be placed.
        /// </para>
        /// </summary>
        public ApiKeyCredentialLocation CredentialLocation { get; set; }

        /// <summary>
        /// Checks to see if the CredentialLocation property is set.
        /// </summary>
        internal bool IsSetCredentialLocation() => this.CredentialLocation != null;

        /// <summary>
        /// Gets and sets the property CredentialParameterName. 
        /// <para>
        /// The name of the credential parameter for the API key. This parameter name is used
        /// when sending the API key to the target endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CredentialParameterName { get; set; }

        /// <summary>
        /// Checks to see if the CredentialParameterName property is set.
        /// </summary>
        internal bool IsSetCredentialParameterName() => this.CredentialParameterName != null;

        /// <summary>
        /// Gets and sets the property CredentialPrefix. 
        /// <para>
        /// The prefix for the API key credential. This prefix is added to the API key when sending
        /// it to the target endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CredentialPrefix { get; set; }

        /// <summary>
        /// Checks to see if the CredentialPrefix property is set.
        /// </summary>
        internal bool IsSetCredentialPrefix() => this.CredentialPrefix != null;

        /// <summary>
        /// Gets and sets the property ProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the API key credential provider. This ARN identifies
        /// the provider in Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderArn property is set.
        /// </summary>
        internal bool IsSetProviderArn() => this.ProviderArn != null;
    }
}

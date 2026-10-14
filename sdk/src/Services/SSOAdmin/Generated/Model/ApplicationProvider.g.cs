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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes a provider that can be used to connect an Amazon Web Services
    /// managed application or customer managed application to IAM Identity Center.
    /// </summary>
    public partial class ApplicationProvider
    {
        /// <summary>
        /// Gets and sets the property ApplicationProviderArn. 
        /// <para>
        /// The ARN of the application provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string ApplicationProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationProviderArn property is set.
        /// </summary>
        internal bool IsSetApplicationProviderArn() => this.ApplicationProviderArn != null;

        /// <summary>
        /// Gets and sets the property DisplayData. 
        /// <para>
        /// A structure that describes how IAM Identity Center represents the application provider
        /// in the portal.
        /// </para>
        /// </summary>
        public DisplayData DisplayData { get; set; }

        /// <summary>
        /// Checks to see if the DisplayData property is set.
        /// </summary>
        internal bool IsSetDisplayData() => this.DisplayData != null;

        /// <summary>
        /// Gets and sets the property FederationProtocol. 
        /// <para>
        /// The protocol that the application provider uses to perform federation.
        /// </para>
        /// </summary>
        public FederationProtocol FederationProtocol { get; set; }

        /// <summary>
        /// Checks to see if the FederationProtocol property is set.
        /// </summary>
        internal bool IsSetFederationProtocol() => this.FederationProtocol != null;

        /// <summary>
        /// Gets and sets the property ResourceServerConfig. 
        /// <para>
        /// A structure that describes the application provider's resource server.
        /// </para>
        /// </summary>
        public ResourceServerConfig ResourceServerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceServerConfig property is set.
        /// </summary>
        internal bool IsSetResourceServerConfig() => this.ResourceServerConfig != null;
    }
}

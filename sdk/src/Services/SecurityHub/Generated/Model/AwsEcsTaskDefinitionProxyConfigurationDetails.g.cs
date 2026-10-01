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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The configuration details for the App Mesh proxy.
    /// </summary>
    public partial class AwsEcsTaskDefinitionProxyConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that will serve as the App Mesh proxy.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property ProxyConfigurationProperties. 
        /// <para>
        /// The set of network configuration parameters to provide to the Container Network Interface
        /// (CNI) plugin, specified as key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionProxyConfigurationProxyConfigurationPropertiesDetails> ProxyConfigurationProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionProxyConfigurationProxyConfigurationPropertiesDetails>() : null;

        /// <summary>
        /// Checks to see if the ProxyConfigurationProperties property is set.
        /// </summary>
        internal bool IsSetProxyConfigurationProperties() => this.ProxyConfigurationProperties != null && (this.ProxyConfigurationProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The proxy type.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

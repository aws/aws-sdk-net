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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _containerName;
        private List<AwsEcsTaskDefinitionProxyConfigurationProxyConfigurationPropertiesDetails> _proxyConfigurationProperties = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionProxyConfigurationProxyConfigurationPropertiesDetails>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that will serve as the App Mesh proxy.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyConfigurationProperties. 
        /// <para>
        /// The set of network configuration parameters to provide to the Container Network Interface
        /// (CNI) plugin, specified as key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionProxyConfigurationProxyConfigurationPropertiesDetails> ProxyConfigurationProperties
        {
            get { return this._proxyConfigurationProperties; }
            set { this._proxyConfigurationProperties = value; }
        }

        // Check to see if ProxyConfigurationProperties property is set
        internal bool IsSetProxyConfigurationProperties()
        {
            return this._proxyConfigurationProperties != null && (this._proxyConfigurationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The proxy type.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProxy operation. Creates a proxy. A proxy
    /// is a fully managed, Envoy-based proxy that runs your Envoy configuration on Amazon
    /// EC2 instances inside your own virtual private cloud (VPC). AWS provisions and scales
    /// the proxy, upgrades the Envoy version, patches the operating system, and monitors
    /// its health.
    /// </summary>
    public partial class CreateProxyRequest : AmazonELBProxyRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. The attributes for the proxy. Attributes can
        /// be changed after creation. Attributes that you don't specify are set to their default
        /// values.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. A unique, case-sensitive identifier that you
        /// provide to ensure the idempotency of the request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. The configuration for the proxy.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CustomerKmsKeyArn. The Amazon Resource Name (ARN) of the
        /// customer managed KMS key used to encrypt the proxy's configuration content. If you
        /// don't specify a key, the default service-owned key is used.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerKmsKeyArn() => this.CustomerKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the proxy. The name must be unique within
        /// your account for the Region. The valid characters are a-z, 0-9, and hyphens (-). You
        /// can't use a hyphen as the first or last character.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. The network configuration for the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyNetworkUserConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProxyVersion. The version of the proxy software, in `major.minor`
        /// format.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProxyVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProxyVersion property is set.
        /// </summary>
        internal bool IsSetProxyVersion() => this.ProxyVersion != null;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the IAM role
        /// that provides permissions to the code that your Envoy configuration runs on the proxy,
        /// such as filters and extensions. These are the permissions that this code needs when
        /// it calls AWS services.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags for the proxy.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. The type of proxy.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

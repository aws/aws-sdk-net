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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContainerService operation. Updates the
    /// configuration of your Amazon Lightsail container service, such as its power, scale,
    /// and public domain names.
    /// </summary>
    public partial class UpdateContainerServiceRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// A Boolean value to indicate whether the container service is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Checks to see if the IsDisabled property is set.
        /// </summary>
        internal bool IsSetIsDisabled() => this.IsDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property Power. 
        /// <para>
        /// The power for the container service.
        /// </para>
        ///  
        /// <para>
        /// The power specifies the amount of memory, vCPUs, and base monthly cost of each node
        /// of the container service. The <c>power</c> and <c>scale</c> of a container service
        /// makes up its configured capacity. To determine the monthly price of your container
        /// service, multiply the base price of the <c>power</c> with the <c>scale</c> (the number
        /// of nodes) of the service.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetContainerServicePowers</c> action to view the specifications of each
        /// power option.
        /// </para>
        /// </summary>
        public ContainerServicePowerName Power { get; set; }

        /// <summary>
        /// Checks to see if the Power property is set.
        /// </summary>
        internal bool IsSetPower() => this.Power != null;

        /// <summary>
        /// Gets and sets the property PrivateRegistryAccess. 
        /// <para>
        /// An object to describe the configuration for the container service to access private
        /// container image repositories, such as Amazon Elastic Container Registry (Amazon ECR)
        /// private repositories.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-container-service-ecr-private-repo-access">Configuring
        /// access to an Amazon ECR private repository for an Amazon Lightsail container service</a>
        /// in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        public PrivateRegistryAccessRequest PrivateRegistryAccess { get; set; }

        /// <summary>
        /// Checks to see if the PrivateRegistryAccess property is set.
        /// </summary>
        internal bool IsSetPrivateRegistryAccess() => this.PrivateRegistryAccess != null;

        /// <summary>
        /// Gets and sets the property PublicDomainNames. 
        /// <para>
        /// The public domain names to use with the container service, such as <c>example.com</c>
        /// and <c>www.example.com</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to four public domain names for a container service. The domain
        /// names that you specify are used when you create a deployment with a container configured
        /// as the public endpoint of your container service.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify public domain names, then you can use the default domain of the
        /// container service.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must create and validate an SSL/TLS certificate before you can use public domain
        /// names with your container service. Use the <c>CreateCertificate</c> action to create
        /// a certificate for the public domain names you want to use with your container service.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can specify public domain names using a string to array map as shown in the example
        /// later on this page.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> PublicDomainNames { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the PublicDomainNames property is set.
        /// </summary>
        internal bool IsSetPublicDomainNames() => this.PublicDomainNames != null && (this.PublicDomainNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// The scale for the container service.
        /// </para>
        ///  
        /// <para>
        /// The scale specifies the allocated compute nodes of the container service. The <c>power</c>
        /// and <c>scale</c> of a container service makes up its configured capacity. To determine
        /// the monthly price of your container service, multiply the base price of the <c>power</c>
        /// with the <c>scale</c> (the number of nodes) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? Scale { get; set; }

        /// <summary>
        /// Checks to see if the Scale property is set.
        /// </summary>
        internal bool IsSetScale() => this.Scale.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the container service to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}

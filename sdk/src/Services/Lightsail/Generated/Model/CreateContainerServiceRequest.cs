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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
    /// Container for the parameters to the CreateContainerService operation.
    /// Creates an Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// A Lightsail container service is a compute resource to which you can deploy containers.
    /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-container-services">Container
    /// services in Amazon Lightsail</a> in the <i>Lightsail Dev Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateContainerServiceRequest : AmazonLightsailRequest
    {
        private ContainerServiceDeploymentRequest _deployment;
        private ContainerServicePowerName _power;
        private PrivateRegistryAccessRequest _privateRegistryAccess;
        private Dictionary<string, List<string>> _publicDomainNames = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _scale;
        private string _serviceName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Deployment. 
        /// <para>
        /// An object that describes a deployment for the container service.
        /// </para>
        ///  
        /// <para>
        /// A deployment specifies the containers that will be launched on the container service
        /// and their settings, such as the ports to open, the environment variables to apply,
        /// and the launch command to run. It also specifies the container that will serve as
        /// the public endpoint of the deployment and its settings, such as the HTTP or HTTPS
        /// port to use, and the health check configuration.
        /// </para>
        /// </summary>
        public ContainerServiceDeploymentRequest Deployment
        {
            get { return this._deployment; }
            set { this._deployment = value; }
        }

        // Check to see if Deployment property is set
        internal bool IsSetDeployment()
        {
            return this._deployment != null;
        }

        /// <summary>
        /// Gets and sets the property Power. 
        /// <para>
        /// The power specification for the container service.
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
        /// Use the <c>GetContainerServicePowers</c> action to get a list of power options that
        /// you can specify using this parameter, and their base monthly cost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerServicePowerName Power
        {
            get { return this._power; }
            set { this._power = value; }
        }

        // Check to see if Power property is set
        internal bool IsSetPower()
        {
            return this._power != null;
        }

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
        public PrivateRegistryAccessRequest PrivateRegistryAccess
        {
            get { return this._privateRegistryAccess; }
            set { this._privateRegistryAccess = value; }
        }

        // Check to see if PrivateRegistryAccess property is set
        internal bool IsSetPrivateRegistryAccess()
        {
            return this._privateRegistryAccess != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> PublicDomainNames
        {
            get { return this._publicDomainNames; }
            set { this._publicDomainNames = value; }
        }

        // Check to see if PublicDomainNames property is set
        internal bool IsSetPublicDomainNames()
        {
            return this._publicDomainNames != null && (this._publicDomainNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// The scale specification for the container service.
        /// </para>
        ///  
        /// <para>
        /// The scale specifies the allocated compute nodes of the container service. The <c>power</c>
        /// and <c>scale</c> of a container service makes up its configured capacity. To determine
        /// the monthly price of your container service, multiply the base price of the <c>power</c>
        /// with the <c>scale</c> (the number of nodes) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public int? Scale
        {
            get { return this._scale; }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name for the container service.
        /// </para>
        ///  
        /// <para>
        /// The name that you specify for your container service will make up part of its default
        /// domain. The default domain of a container service is typically <c>https://&lt;ServiceName&gt;.&lt;RandomGUID&gt;.&lt;AWSRegion&gt;.cs.amazonlightsail.com</c>.
        /// If the name of your container service is <c>container-service-1</c>, and it's located
        /// in the US East (Ohio) Amazon Web Services Region (<c>us-east-2</c>), then the domain
        /// for your container service will be like the following example: <c>https://container-service-1.ur4EXAMPLE2uq.us-east-2.cs.amazonlightsail.com</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following are the requirements for container service names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be unique within each Amazon Web Services Region in your Lightsail account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain 1 to 63 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain only alphanumeric characters and hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A hyphen (-) can separate words but cannot be at the start or end of the name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the container service during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
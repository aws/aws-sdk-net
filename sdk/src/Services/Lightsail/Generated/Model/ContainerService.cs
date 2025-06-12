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
    /// Describes an Amazon Lightsail container service.
    /// </summary>
    public partial class ContainerService
    {
        private string _arn;
        private string _containerServiceName;
        private DateTime? _createdAt;
        private ContainerServiceDeployment _currentDeployment;
        private bool? _isDisabled;
        private ResourceLocation _location;
        private ContainerServiceDeployment _nextDeployment;
        private ContainerServicePowerName _power;
        private string _powerId;
        private string _principalArn;
        private string _privateDomainName;
        private PrivateRegistryAccess _privateRegistryAccess;
        private Dictionary<string, List<string>> _publicDomainNames = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private ResourceType _resourceType;
        private int? _scale;
        private ContainerServiceState _state;
        private ContainerServiceStateDetail _stateDetail;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _url;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container service.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerServiceName. 
        /// <para>
        /// The name of the container service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ContainerServiceName
        {
            get { return this._containerServiceName; }
            set { this._containerServiceName = value; }
        }

        // Check to see if ContainerServiceName property is set
        internal bool IsSetContainerServiceName()
        {
            return this._containerServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the container service was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentDeployment. 
        /// <para>
        /// An object that describes the current container deployment of the container service.
        /// </para>
        /// </summary>
        public ContainerServiceDeployment CurrentDeployment
        {
            get { return this._currentDeployment; }
            set { this._currentDeployment = value; }
        }

        // Check to see if CurrentDeployment property is set
        internal bool IsSetCurrentDeployment()
        {
            return this._currentDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// A Boolean value indicating whether the container service is disabled.
        /// </para>
        /// </summary>
        public bool? IsDisabled
        {
            get { return this._isDisabled; }
            set { this._isDisabled = value; }
        }

        // Check to see if IsDisabled property is set
        internal bool IsSetIsDisabled()
        {
            return this._isDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the container service, such as the Amazon
        /// Web Services Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NextDeployment. 
        /// <para>
        /// An object that describes the next deployment of the container service.
        /// </para>
        ///  
        /// <para>
        /// This value is <c>null</c> when there is no deployment in a <c>pending</c> state.
        /// </para>
        /// </summary>
        public ContainerServiceDeployment NextDeployment
        {
            get { return this._nextDeployment; }
            set { this._nextDeployment = value; }
        }

        // Check to see if NextDeployment property is set
        internal bool IsSetNextDeployment()
        {
            return this._nextDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Power. 
        /// <para>
        /// The power specification of the container service.
        /// </para>
        ///  
        /// <para>
        /// The power specifies the amount of RAM, the number of vCPUs, and the base price of
        /// the container service.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PowerId. 
        /// <para>
        /// The ID of the power of the container service.
        /// </para>
        /// </summary>
        public string PowerId
        {
            get { return this._powerId; }
            set { this._powerId = value; }
        }

        // Check to see if PowerId property is set
        internal bool IsSetPowerId()
        {
            return this._powerId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The principal ARN of the container service.
        /// </para>
        ///  
        /// <para>
        /// The principal ARN can be used to create a trust relationship between your standard
        /// Amazon Web Services account and your Lightsail container service. This allows you
        /// to give your service permission to access resources in your standard Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDomainName. 
        /// <para>
        /// The private domain name of the container service.
        /// </para>
        ///  
        /// <para>
        /// The private domain name is accessible only by other resources within the default virtual
        /// private cloud (VPC) of your Lightsail account.
        /// </para>
        /// </summary>
        public string PrivateDomainName
        {
            get { return this._privateDomainName; }
            set { this._privateDomainName = value; }
        }

        // Check to see if PrivateDomainName property is set
        internal bool IsSetPrivateDomainName()
        {
            return this._privateDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateRegistryAccess. 
        /// <para>
        /// An object that describes the configuration for the container service to access private
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
        public PrivateRegistryAccess PrivateRegistryAccess
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
        /// The public domain name of the container service, such as <c>example.com</c> and <c>www.example.com</c>.
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
        /// See <c>CreateContainerService</c> or <c>UpdateContainerService</c> for information
        /// about how to specify public domain names for your Lightsail container service.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type of the container service.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// The scale specification of the container service.
        /// </para>
        ///  
        /// <para>
        /// The scale specifies the allocated compute nodes of the container service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the container service.
        /// </para>
        ///  
        /// <para>
        /// The following container service states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The container service is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> - The container service is running but it does not have an active container
        /// deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPLOYING</c> - The container service is launching a container deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> - The container service is running and it has an active container
        /// deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The container service capacity or its custom domains are being
        /// updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The container service is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - The container service is disabled, and its active deployment and
        /// containers, if any, are shut down.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerServiceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetail. 
        /// <para>
        /// An object that describes the current state of the container service.
        /// </para>
        ///  <note> 
        /// <para>
        /// The state detail is populated only when a container service is in a <c>PENDING</c>,
        /// <c>DEPLOYING</c>, or <c>UPDATING</c> state.
        /// </para>
        ///  </note>
        /// </summary>
        public ContainerServiceStateDetail StateDetail
        {
            get { return this._stateDetail; }
            set { this._stateDetail = value; }
        }

        // Check to see if StateDetail property is set
        internal bool IsSetStateDetail()
        {
            return this._stateDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
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

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The publicly accessible URL of the container service.
        /// </para>
        ///  
        /// <para>
        /// If no public endpoint is specified in the <c>currentDeployment</c>, this URL returns
        /// a 404 response.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetEnvironment operation.
    /// </summary>
    public partial class GetEnvironmentResponse : AmazonWebServiceResponse
    {
        private string _awsAccountId;
        private string _awsAccountRegion;
        private DateTime? _createdAt;
        private string _createdBy;
        private DeploymentProperties _deploymentProperties;
        private string _description;
        private string _domainId;
        private List<ConfigurableEnvironmentAction> _environmentActions = AWSConfigs.InitializeCollections ? new List<ConfigurableEnvironmentAction>() : null;
        private string _environmentBlueprintId;
        private string _environmentConfigurationId;
        private string _environmentProfileId;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private Deployment _lastDeployment;
        private string _name;
        private string _projectId;
        private string _provider;
        private List<Resource> _provisionedResources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private ProvisioningProperties _provisioningProperties;
        private EnvironmentStatus _status;
        private DateTime? _updatedAt;
        private List<CustomParameter> _userParameters = AWSConfigs.InitializeCollections ? new List<CustomParameter>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where the environment exists.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountRegion. 
        /// <para>
        /// The Amazon Web Services region where the environment exists.
        /// </para>
        /// </summary>
        public string AwsAccountRegion
        {
            get { return this._awsAccountRegion; }
            set { this._awsAccountRegion = value; }
        }

        // Check to see if AwsAccountRegion property is set
        internal bool IsSetAwsAccountRegion()
        {
            return this._awsAccountRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the environment was created.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentProperties. 
        /// <para>
        /// The deployment properties of the environment.
        /// </para>
        /// </summary>
        public DeploymentProperties DeploymentProperties
        {
            get { return this._deploymentProperties; }
            set { this._deploymentProperties = value; }
        }

        // Check to see if DeploymentProperties property is set
        internal bool IsSetDeploymentProperties()
        {
            return this._deploymentProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain where the environment exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentActions. 
        /// <para>
        /// The actions of the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurableEnvironmentAction> EnvironmentActions
        {
            get { return this._environmentActions; }
            set { this._environmentActions = value; }
        }

        // Check to see if EnvironmentActions property is set
        internal bool IsSetEnvironmentActions()
        {
            return this._environmentActions != null && (this._environmentActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The blueprint with which the environment is created.
        /// </para>
        /// </summary>
        public string EnvironmentBlueprintId
        {
            get { return this._environmentBlueprintId; }
            set { this._environmentBlueprintId = value; }
        }

        // Check to see if EnvironmentBlueprintId property is set
        internal bool IsSetEnvironmentBlueprintId()
        {
            return this._environmentBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationId. 
        /// <para>
        /// The configuration ID that is used to create the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string EnvironmentConfigurationId
        {
            get { return this._environmentConfigurationId; }
            set { this._environmentConfigurationId = value; }
        }

        // Check to see if EnvironmentConfigurationId property is set
        internal bool IsSetEnvironmentConfigurationId()
        {
            return this._environmentConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentProfileId. 
        /// <para>
        /// The ID of the environment profile with which the environment is created.
        /// </para>
        /// </summary>
        public string EnvironmentProfileId
        {
            get { return this._environmentProfileId; }
            set { this._environmentProfileId = value; }
        }

        // Check to see if EnvironmentProfileId property is set
        internal bool IsSetEnvironmentProfileId()
        {
            return this._environmentProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The business glossary terms that can be used in this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeployment. 
        /// <para>
        /// The details of the last deployment of the environment.
        /// </para>
        /// </summary>
        public Deployment LastDeployment
        {
            get { return this._lastDeployment; }
            set { this._lastDeployment = value; }
        }

        // Check to see if LastDeployment property is set
        internal bool IsSetLastDeployment()
        {
            return this._lastDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the Amazon DataZone project in which this environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of this Amazon DataZone environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedResources. 
        /// <para>
        /// The provisioned resources of this Amazon DataZone environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> ProvisionedResources
        {
            get { return this._provisionedResources; }
            set { this._provisionedResources = value; }
        }

        // Check to see if ProvisionedResources property is set
        internal bool IsSetProvisionedResources()
        {
            return this._provisionedResources != null && (this._provisionedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningProperties. 
        /// <para>
        /// The provisioning properties of this Amazon DataZone environment.
        /// </para>
        /// </summary>
        public ProvisioningProperties ProvisioningProperties
        {
            get { return this._provisioningProperties; }
            set { this._provisioningProperties = value; }
        }

        // Check to see if ProvisioningProperties property is set
        internal bool IsSetProvisioningProperties()
        {
            return this._provisioningProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this Amazon DataZone environment.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when this environment was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters of this Amazon DataZone environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomParameter> UserParameters
        {
            get { return this._userParameters; }
            set { this._userParameters = value; }
        }

        // Check to see if UserParameters property is set
        internal bool IsSetUserParameters()
        {
            return this._userParameters != null && (this._userParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
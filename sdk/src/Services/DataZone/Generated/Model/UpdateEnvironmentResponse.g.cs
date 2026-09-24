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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the UpdateEnvironment operation.
    /// </summary>
    public partial class UpdateEnvironmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account in which the environment is to be
        /// updated.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountRegion. 
        /// <para>
        /// The Amazon Web Services Region in which the environment is updated.
        /// </para>
        /// </summary>
        public string AwsAccountRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountRegion property is set.
        /// </summary>
        internal bool IsSetAwsAccountRegion() => this.AwsAccountRegion != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DeploymentProperties. 
        /// <para>
        /// The deployment properties to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// </summary>
        public DeploymentProperties DeploymentProperties { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentProperties property is set.
        /// </summary>
        internal bool IsSetDeploymentProperties() => this.DeploymentProperties != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain in which the environment is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentActions. 
        /// <para>
        /// The environment actions to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurableEnvironmentAction> EnvironmentActions { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurableEnvironmentAction>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentActions property is set.
        /// </summary>
        internal bool IsSetEnvironmentActions() => this.EnvironmentActions != null && (this.EnvironmentActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The blueprint identifier of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentBlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentBlueprintId property is set.
        /// </summary>
        internal bool IsSetEnvironmentBlueprintId() => this.EnvironmentBlueprintId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationId. 
        /// <para>
        /// The configuration ID of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EnvironmentConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfigurationId property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurationId() => this.EnvironmentConfigurationId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationName. 
        /// <para>
        /// The configuration name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string EnvironmentConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfigurationName property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurationName() => this.EnvironmentConfigurationName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentProfileId. 
        /// <para>
        /// The profile identifier of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentProfileId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentProfileId property is set.
        /// </summary>
        internal bool IsSetEnvironmentProfileId() => this.EnvironmentProfileId != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the environment that is to be updated.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastDeployment. 
        /// <para>
        /// The last deployment of the environment.
        /// </para>
        /// </summary>
        public Deployment LastDeployment { get; set; }

        /// <summary>
        /// Checks to see if the LastDeployment property is set.
        /// </summary>
        internal bool IsSetLastDeployment() => this.LastDeployment != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The project identifier of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider identifier of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property ProvisionedResources. 
        /// <para>
        /// The provisioned resources to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> ProvisionedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the ProvisionedResources property is set.
        /// </summary>
        internal bool IsSetProvisionedResources() => this.ProvisionedResources != null && (this.ProvisionedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningProperties. 
        /// <para>
        /// The provisioning properties to be updated as part of the <c>UpdateEnvironment</c>
        /// action.
        /// </para>
        /// </summary>
        public ProvisioningProperties ProvisioningProperties { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningProperties property is set.
        /// </summary>
        internal bool IsSetProvisioningProperties() => this.ProvisioningProperties != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the environment was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters to be updated as part of the <c>UpdateEnvironment</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomParameter> UserParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomParameter>() : null;

        /// <summary>
        /// Checks to see if the UserParameters property is set.
        /// </summary>
        internal bool IsSetUserParameters() => this.UserParameters != null && (this.UserParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

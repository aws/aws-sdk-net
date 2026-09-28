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
    /// Container for the parameters to the CreateEnvironment operation. Create an Amazon
    /// DataZone environment.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentOrder. 
        /// <para>
        /// The deployment order of the environment.
        /// </para>
        /// </summary>
        public int? DeploymentOrder { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentOrder property is set.
        /// </summary>
        internal bool IsSetDeploymentOrder() => this.DeploymentOrder.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon DataZone environment.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountIdentifier. 
        /// <para>
        /// The ID of the account in which the environment is being created.
        /// </para>
        /// </summary>
        public string EnvironmentAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountIdentifier() => this.EnvironmentAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountRegion. 
        /// <para>
        /// The region of the account in which the environment is being created.
        /// </para>
        /// </summary>
        public string EnvironmentAccountRegion { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentAccountRegion property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountRegion() => this.EnvironmentAccountRegion != null;

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintIdentifier. 
        /// <para>
        /// The ID of the blueprint with which the environment is being created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid for V1 domains. If provided for a V2 domain, the service
        /// returns a ValidationException.
        /// </para>
        ///  </note>
        /// </summary>
        public string EnvironmentBlueprintIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentBlueprintIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentBlueprintIdentifier() => this.EnvironmentBlueprintIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationId. 
        /// <para>
        /// The configuration ID of the environment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnvironmentProfileIdentifier. 
        /// <para>
        /// The identifier of the environment profile that is used to create this Amazon DataZone
        /// environment.
        /// </para>
        /// </summary>
        public string EnvironmentProfileIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentProfileIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentProfileIdentifier() => this.EnvironmentProfileIdentifier != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms that can be used in this Amazon DataZone environment.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project in which this environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters of this Amazon DataZone environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentParameter> UserParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;

        /// <summary>
        /// Checks to see if the UserParameters property is set.
        /// </summary>
        internal bool IsSetUserParameters() => this.UserParameters != null && (this.UserParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

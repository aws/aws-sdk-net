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
    /// Container for the parameters to the CreateProject operation. Creates an Amazon DataZone
    /// project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon DataZone project.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this project is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property DomainUnitId. 
        /// <para>
        /// The ID of the domain unit. This parameter is not required and if it is not specified,
        /// then the project is created at the root domain unit level.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DomainUnitId { get; set; }

        /// <summary>
        /// Checks to see if the DomainUnitId property is set.
        /// </summary>
        internal bool IsSetDomainUnitId() => this.DomainUnitId != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms that can be used in this Amazon DataZone project.
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
        /// Gets and sets the property MembershipAssignments. 
        /// <para>
        /// The members to be assigned to the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectMembershipAssignment> MembershipAssignments { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectMembershipAssignment>() : null;

        /// <summary>
        /// Checks to see if the MembershipAssignments property is set.
        /// </summary>
        internal bool IsSetMembershipAssignments() => this.MembershipAssignments != null && (this.MembershipAssignments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectCategory. 
        /// <para>
        /// The category of the project. Set to 'ADMIN' designates this as an administrative project
        /// for the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string ProjectCategory { get; set; }

        /// <summary>
        /// Checks to see if the ProjectCategory property is set.
        /// </summary>
        internal bool IsSetProjectCategory() => this.ProjectCategory != null;

        /// <summary>
        /// Gets and sets the property ProjectExecutionRole. 
        /// <para>
        /// The default project IAM role that is used to access project resources and run computes
        /// such as Glue and Sagemaker.
        /// </para>
        /// </summary>
        public string ProjectExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ProjectExecutionRole property is set.
        /// </summary>
        internal bool IsSetProjectExecutionRole() => this.ProjectExecutionRole != null;

        /// <summary>
        /// Gets and sets the property ProjectProfileId. 
        /// <para>
        /// The ID of the project profile.
        /// </para>
        /// </summary>
        public string ProjectProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectProfileId property is set.
        /// </summary>
        internal bool IsSetProjectProfileId() => this.ProjectProfileId != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The resource tags of the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public Dictionary<string, string> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters of the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfigurationUserParameter> UserParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentConfigurationUserParameter>() : null;

        /// <summary>
        /// Checks to see if the UserParameters property is set.
        /// </summary>
        internal bool IsSetUserParameters() => this.UserParameters != null && (this.UserParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

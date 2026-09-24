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
    /// The details of the policy grant.
    /// </summary>
    public partial class PolicyGrantDetail
    {
        /// <summary>
        /// Gets and sets the property AddToProjectMemberPool. 
        /// <para>
        /// Specifies that the policy grant is to be added to the members of the project.
        /// </para>
        /// </summary>
        public AddToProjectMemberPoolPolicyGrantDetail AddToProjectMemberPool { get; set; }

        /// <summary>
        /// Checks to see if the AddToProjectMemberPool property is set.
        /// </summary>
        internal bool IsSetAddToProjectMemberPool() => this.AddToProjectMemberPool != null;

        /// <summary>
        /// Gets and sets the property CreateAssetType. 
        /// <para>
        /// Specifies that this is a create asset type policy.
        /// </para>
        /// </summary>
        public CreateAssetTypePolicyGrantDetail CreateAssetType { get; set; }

        /// <summary>
        /// Checks to see if the CreateAssetType property is set.
        /// </summary>
        internal bool IsSetCreateAssetType() => this.CreateAssetType != null;

        /// <summary>
        /// Gets and sets the property CreateDomainUnit. 
        /// <para>
        /// Specifies that this is a create domain unit policy.
        /// </para>
        /// </summary>
        public CreateDomainUnitPolicyGrantDetail CreateDomainUnit { get; set; }

        /// <summary>
        /// Checks to see if the CreateDomainUnit property is set.
        /// </summary>
        internal bool IsSetCreateDomainUnit() => this.CreateDomainUnit != null;

        /// <summary>
        /// Gets and sets the property CreateEnvironment. 
        /// <para>
        /// Specifies that this is a create environment policy.
        /// </para>
        /// </summary>
        public Unit CreateEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the CreateEnvironment property is set.
        /// </summary>
        internal bool IsSetCreateEnvironment() => this.CreateEnvironment != null;

        /// <summary>
        /// Gets and sets the property CreateEnvironmentFromBlueprint.
        /// </summary>
        public Unit CreateEnvironmentFromBlueprint { get; set; }

        /// <summary>
        /// Checks to see if the CreateEnvironmentFromBlueprint property is set.
        /// </summary>
        internal bool IsSetCreateEnvironmentFromBlueprint() => this.CreateEnvironmentFromBlueprint != null;

        /// <summary>
        /// Gets and sets the property CreateEnvironmentProfile. 
        /// <para>
        /// Specifies that this is a create environment profile policy.
        /// </para>
        /// </summary>
        public CreateEnvironmentProfilePolicyGrantDetail CreateEnvironmentProfile { get; set; }

        /// <summary>
        /// Checks to see if the CreateEnvironmentProfile property is set.
        /// </summary>
        internal bool IsSetCreateEnvironmentProfile() => this.CreateEnvironmentProfile != null;

        /// <summary>
        /// Gets and sets the property CreateFormType. 
        /// <para>
        /// Specifies that this is a create form type policy.
        /// </para>
        /// </summary>
        public CreateFormTypePolicyGrantDetail CreateFormType { get; set; }

        /// <summary>
        /// Checks to see if the CreateFormType property is set.
        /// </summary>
        internal bool IsSetCreateFormType() => this.CreateFormType != null;

        /// <summary>
        /// Gets and sets the property CreateGlossary. 
        /// <para>
        ///  Specifies that this is a create glossary policy.
        /// </para>
        /// </summary>
        public CreateGlossaryPolicyGrantDetail CreateGlossary { get; set; }

        /// <summary>
        /// Checks to see if the CreateGlossary property is set.
        /// </summary>
        internal bool IsSetCreateGlossary() => this.CreateGlossary != null;

        /// <summary>
        /// Gets and sets the property CreateProject. 
        /// <para>
        /// Specifies that this is a create project policy.
        /// </para>
        /// </summary>
        public CreateProjectPolicyGrantDetail CreateProject { get; set; }

        /// <summary>
        /// Checks to see if the CreateProject property is set.
        /// </summary>
        internal bool IsSetCreateProject() => this.CreateProject != null;

        /// <summary>
        /// Gets and sets the property CreateProjectFromProjectProfile. 
        /// <para>
        /// Specifies whether to create a project from project profile.
        /// </para>
        /// </summary>
        public CreateProjectFromProjectProfilePolicyGrantDetail CreateProjectFromProjectProfile { get; set; }

        /// <summary>
        /// Checks to see if the CreateProjectFromProjectProfile property is set.
        /// </summary>
        internal bool IsSetCreateProjectFromProjectProfile() => this.CreateProjectFromProjectProfile != null;

        /// <summary>
        /// Gets and sets the property DelegateCreateEnvironmentProfile. 
        /// <para>
        /// Specifies that this is the delegation of the create environment profile policy.
        /// </para>
        /// </summary>
        public Unit DelegateCreateEnvironmentProfile { get; set; }

        /// <summary>
        /// Checks to see if the DelegateCreateEnvironmentProfile property is set.
        /// </summary>
        internal bool IsSetDelegateCreateEnvironmentProfile() => this.DelegateCreateEnvironmentProfile != null;

        /// <summary>
        /// Gets and sets the property OverrideDomainUnitOwners. 
        /// <para>
        /// Specifies whether to override domain unit owners.
        /// </para>
        /// </summary>
        public OverrideDomainUnitOwnersPolicyGrantDetail OverrideDomainUnitOwners { get; set; }

        /// <summary>
        /// Checks to see if the OverrideDomainUnitOwners property is set.
        /// </summary>
        internal bool IsSetOverrideDomainUnitOwners() => this.OverrideDomainUnitOwners != null;

        /// <summary>
        /// Gets and sets the property OverrideProjectOwners. 
        /// <para>
        /// Specifies whether to override project owners.
        /// </para>
        /// </summary>
        public OverrideProjectOwnersPolicyGrantDetail OverrideProjectOwners { get; set; }

        /// <summary>
        /// Checks to see if the OverrideProjectOwners property is set.
        /// </summary>
        internal bool IsSetOverrideProjectOwners() => this.OverrideProjectOwners != null;

        /// <summary>
        /// Gets and sets the property UseAssetType. 
        /// <para>
        ///  Specifies the domain unit(s) whose projects can use this asset type while creating
        /// asset or asset revisions.
        /// </para>
        /// </summary>
        public UseAssetTypePolicyGrantDetail UseAssetType { get; set; }

        /// <summary>
        /// Checks to see if the UseAssetType property is set.
        /// </summary>
        internal bool IsSetUseAssetType() => this.UseAssetType != null;
    }
}

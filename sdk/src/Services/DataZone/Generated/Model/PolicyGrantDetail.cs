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
    /// The details of the policy grant.
    /// </summary>
    public partial class PolicyGrantDetail
    {
        private AddToProjectMemberPoolPolicyGrantDetail _addToProjectMemberPool;
        private CreateAssetTypePolicyGrantDetail _createAssetType;
        private CreateDomainUnitPolicyGrantDetail _createDomainUnit;
        private Unit _createEnvironment;
        private Unit _createEnvironmentFromBlueprint;
        private CreateEnvironmentProfilePolicyGrantDetail _createEnvironmentProfile;
        private CreateFormTypePolicyGrantDetail _createFormType;
        private CreateGlossaryPolicyGrantDetail _createGlossary;
        private CreateProjectPolicyGrantDetail _createProject;
        private CreateProjectFromProjectProfilePolicyGrantDetail _createProjectFromProjectProfile;
        private Unit _delegateCreateEnvironmentProfile;
        private OverrideDomainUnitOwnersPolicyGrantDetail _overrideDomainUnitOwners;
        private OverrideProjectOwnersPolicyGrantDetail _overrideProjectOwners;
        private UseAssetTypePolicyGrantDetail _useAssetType;

        /// <summary>
        /// Gets and sets the property AddToProjectMemberPool. 
        /// <para>
        /// Specifies that the policy grant is to be added to the members of the project.
        /// </para>
        /// </summary>
        public AddToProjectMemberPoolPolicyGrantDetail AddToProjectMemberPool
        {
            get { return this._addToProjectMemberPool; }
            set { this._addToProjectMemberPool = value; }
        }

        // Check to see if AddToProjectMemberPool property is set
        internal bool IsSetAddToProjectMemberPool()
        {
            return this._addToProjectMemberPool != null;
        }

        /// <summary>
        /// Gets and sets the property CreateAssetType. 
        /// <para>
        /// Specifies that this is a create asset type policy.
        /// </para>
        /// </summary>
        public CreateAssetTypePolicyGrantDetail CreateAssetType
        {
            get { return this._createAssetType; }
            set { this._createAssetType = value; }
        }

        // Check to see if CreateAssetType property is set
        internal bool IsSetCreateAssetType()
        {
            return this._createAssetType != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDomainUnit. 
        /// <para>
        /// Specifies that this is a create domain unit policy.
        /// </para>
        /// </summary>
        public CreateDomainUnitPolicyGrantDetail CreateDomainUnit
        {
            get { return this._createDomainUnit; }
            set { this._createDomainUnit = value; }
        }

        // Check to see if CreateDomainUnit property is set
        internal bool IsSetCreateDomainUnit()
        {
            return this._createDomainUnit != null;
        }

        /// <summary>
        /// Gets and sets the property CreateEnvironment. 
        /// <para>
        /// Specifies that this is a create environment policy.
        /// </para>
        /// </summary>
        public Unit CreateEnvironment
        {
            get { return this._createEnvironment; }
            set { this._createEnvironment = value; }
        }

        // Check to see if CreateEnvironment property is set
        internal bool IsSetCreateEnvironment()
        {
            return this._createEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property CreateEnvironmentFromBlueprint.
        /// </summary>
        public Unit CreateEnvironmentFromBlueprint
        {
            get { return this._createEnvironmentFromBlueprint; }
            set { this._createEnvironmentFromBlueprint = value; }
        }

        // Check to see if CreateEnvironmentFromBlueprint property is set
        internal bool IsSetCreateEnvironmentFromBlueprint()
        {
            return this._createEnvironmentFromBlueprint != null;
        }

        /// <summary>
        /// Gets and sets the property CreateEnvironmentProfile. 
        /// <para>
        /// Specifies that this is a create environment profile policy.
        /// </para>
        /// </summary>
        public CreateEnvironmentProfilePolicyGrantDetail CreateEnvironmentProfile
        {
            get { return this._createEnvironmentProfile; }
            set { this._createEnvironmentProfile = value; }
        }

        // Check to see if CreateEnvironmentProfile property is set
        internal bool IsSetCreateEnvironmentProfile()
        {
            return this._createEnvironmentProfile != null;
        }

        /// <summary>
        /// Gets and sets the property CreateFormType. 
        /// <para>
        /// Specifies that this is a create form type policy.
        /// </para>
        /// </summary>
        public CreateFormTypePolicyGrantDetail CreateFormType
        {
            get { return this._createFormType; }
            set { this._createFormType = value; }
        }

        // Check to see if CreateFormType property is set
        internal bool IsSetCreateFormType()
        {
            return this._createFormType != null;
        }

        /// <summary>
        /// Gets and sets the property CreateGlossary. 
        /// <para>
        ///  Specifies that this is a create glossary policy.
        /// </para>
        /// </summary>
        public CreateGlossaryPolicyGrantDetail CreateGlossary
        {
            get { return this._createGlossary; }
            set { this._createGlossary = value; }
        }

        // Check to see if CreateGlossary property is set
        internal bool IsSetCreateGlossary()
        {
            return this._createGlossary != null;
        }

        /// <summary>
        /// Gets and sets the property CreateProject. 
        /// <para>
        /// Specifies that this is a create project policy.
        /// </para>
        /// </summary>
        public CreateProjectPolicyGrantDetail CreateProject
        {
            get { return this._createProject; }
            set { this._createProject = value; }
        }

        // Check to see if CreateProject property is set
        internal bool IsSetCreateProject()
        {
            return this._createProject != null;
        }

        /// <summary>
        /// Gets and sets the property CreateProjectFromProjectProfile. 
        /// <para>
        /// Specifies whether to create a project from project profile.
        /// </para>
        /// </summary>
        public CreateProjectFromProjectProfilePolicyGrantDetail CreateProjectFromProjectProfile
        {
            get { return this._createProjectFromProjectProfile; }
            set { this._createProjectFromProjectProfile = value; }
        }

        // Check to see if CreateProjectFromProjectProfile property is set
        internal bool IsSetCreateProjectFromProjectProfile()
        {
            return this._createProjectFromProjectProfile != null;
        }

        /// <summary>
        /// Gets and sets the property DelegateCreateEnvironmentProfile. 
        /// <para>
        /// Specifies that this is the delegation of the create environment profile policy.
        /// </para>
        /// </summary>
        public Unit DelegateCreateEnvironmentProfile
        {
            get { return this._delegateCreateEnvironmentProfile; }
            set { this._delegateCreateEnvironmentProfile = value; }
        }

        // Check to see if DelegateCreateEnvironmentProfile property is set
        internal bool IsSetDelegateCreateEnvironmentProfile()
        {
            return this._delegateCreateEnvironmentProfile != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideDomainUnitOwners. 
        /// <para>
        /// Specifies whether to override domain unit owners.
        /// </para>
        /// </summary>
        public OverrideDomainUnitOwnersPolicyGrantDetail OverrideDomainUnitOwners
        {
            get { return this._overrideDomainUnitOwners; }
            set { this._overrideDomainUnitOwners = value; }
        }

        // Check to see if OverrideDomainUnitOwners property is set
        internal bool IsSetOverrideDomainUnitOwners()
        {
            return this._overrideDomainUnitOwners != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideProjectOwners. 
        /// <para>
        /// Specifies whether to override project owners.
        /// </para>
        /// </summary>
        public OverrideProjectOwnersPolicyGrantDetail OverrideProjectOwners
        {
            get { return this._overrideProjectOwners; }
            set { this._overrideProjectOwners = value; }
        }

        // Check to see if OverrideProjectOwners property is set
        internal bool IsSetOverrideProjectOwners()
        {
            return this._overrideProjectOwners != null;
        }

        /// <summary>
        /// Gets and sets the property UseAssetType. 
        /// <para>
        ///  Specifies the domain unit(s) whose projects can use this asset type while creating
        /// asset or asset revisions.
        /// </para>
        /// </summary>
        public UseAssetTypePolicyGrantDetail UseAssetType
        {
            get { return this._useAssetType; }
            set { this._useAssetType = value; }
        }

        // Check to see if UseAssetType property is set
        internal bool IsSetUseAssetType()
        {
            return this._useAssetType != null;
        }

    }
}
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
    /// Container for the parameters to the CreateEnvironment operation.
    /// Create an Amazon DataZone environment.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonDataZoneRequest
    {
        private int? _deploymentOrder;
        private string _description;
        private string _domainIdentifier;
        private string _environmentAccountIdentifier;
        private string _environmentAccountRegion;
        private string _environmentBlueprintIdentifier;
        private string _environmentConfigurationId;
        private string _environmentProfileIdentifier;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _projectIdentifier;
        private List<EnvironmentParameter> _userParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentParameter>() : null;

        /// <summary>
        /// Gets and sets the property DeploymentOrder. 
        /// <para>
        /// The deployment order of the environment.
        /// </para>
        /// </summary>
        public int? DeploymentOrder
        {
            get { return this._deploymentOrder; }
            set { this._deploymentOrder = value; }
        }

        // Check to see if DeploymentOrder property is set
        internal bool IsSetDeploymentOrder()
        {
            return this._deploymentOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon DataZone environment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentAccountIdentifier. 
        /// <para>
        /// The ID of the account in which the environment is being created.
        /// </para>
        /// </summary>
        public string EnvironmentAccountIdentifier
        {
            get { return this._environmentAccountIdentifier; }
            set { this._environmentAccountIdentifier = value; }
        }

        // Check to see if EnvironmentAccountIdentifier property is set
        internal bool IsSetEnvironmentAccountIdentifier()
        {
            return this._environmentAccountIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentAccountRegion. 
        /// <para>
        /// The region of the account in which the environment is being created.
        /// </para>
        /// </summary>
        public string EnvironmentAccountRegion
        {
            get { return this._environmentAccountRegion; }
            set { this._environmentAccountRegion = value; }
        }

        // Check to see if EnvironmentAccountRegion property is set
        internal bool IsSetEnvironmentAccountRegion()
        {
            return this._environmentAccountRegion != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintIdentifier. 
        /// <para>
        /// The ID of the blueprint with which the environment is being created.
        /// </para>
        /// </summary>
        public string EnvironmentBlueprintIdentifier
        {
            get { return this._environmentBlueprintIdentifier; }
            set { this._environmentBlueprintIdentifier = value; }
        }

        // Check to see if EnvironmentBlueprintIdentifier property is set
        internal bool IsSetEnvironmentBlueprintIdentifier()
        {
            return this._environmentBlueprintIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationId. 
        /// <para>
        /// The configuration ID of the environment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnvironmentProfileIdentifier. 
        /// <para>
        /// The identifier of the environment profile that is used to create this Amazon DataZone
        /// environment.
        /// </para>
        /// </summary>
        public string EnvironmentProfileIdentifier
        {
            get { return this._environmentProfileIdentifier; }
            set { this._environmentProfileIdentifier = value; }
        }

        // Check to see if EnvironmentProfileIdentifier property is set
        internal bool IsSetEnvironmentProfileIdentifier()
        {
            return this._environmentProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms that can be used in this Amazon DataZone environment.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project in which this environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectIdentifier
        {
            get { return this._projectIdentifier; }
            set { this._projectIdentifier = value; }
        }

        // Check to see if ProjectIdentifier property is set
        internal bool IsSetProjectIdentifier()
        {
            return this._projectIdentifier != null;
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
        public List<EnvironmentParameter> UserParameters
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
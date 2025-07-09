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
    /// Container for the parameters to the UpdateProject operation.
    /// Updates the specified project in Amazon DataZone.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonDataZoneRequest
    {
        private string _description;
        private string _domainIdentifier;
        private string _domainUnitId;
        private EnvironmentDeploymentDetails _environmentDeploymentDetails;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;
        private string _name;
        private string _projectProfileVersion;
        private List<EnvironmentConfigurationUserParameter> _userParameters = AWSConfigs.InitializeCollections ? new List<EnvironmentConfigurationUserParameter>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateProject</c> action.
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain where a project is being updated.
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
        /// Gets and sets the property DomainUnitId. 
        /// <para>
        /// The ID of the domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DomainUnitId
        {
            get { return this._domainUnitId; }
            set { this._domainUnitId = value; }
        }

        // Check to see if DomainUnitId property is set
        internal bool IsSetDomainUnitId()
        {
            return this._domainUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentDeploymentDetails. 
        /// <para>
        /// The environment deployment details of the project.
        /// </para>
        /// </summary>
        public EnvironmentDeploymentDetails EnvironmentDeploymentDetails
        {
            get { return this._environmentDeploymentDetails; }
            set { this._environmentDeploymentDetails = value; }
        }

        // Check to see if EnvironmentDeploymentDetails property is set
        internal bool IsSetEnvironmentDeploymentDetails()
        {
            return this._environmentDeploymentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms to be updated as part of the <c>UpdateProject</c> action.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the project that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateProject</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property ProjectProfileVersion. 
        /// <para>
        /// The project profile version to which the project should be updated. You can only specify
        /// the following string for this parameter: <c>latest</c>.
        /// </para>
        /// </summary>
        public string ProjectProfileVersion
        {
            get { return this._projectProfileVersion; }
            set { this._projectProfileVersion = value; }
        }

        // Check to see if ProjectProfileVersion property is set
        internal bool IsSetProjectProfileVersion()
        {
            return this._projectProfileVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UserParameters. 
        /// <para>
        /// The user parameters of the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfigurationUserParameter> UserParameters
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
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
    /// Container for the parameters to the CreateProjectProfile operation.
    /// Creates a project profile.
    /// </summary>
    public partial class CreateProjectProfileRequest : AmazonDataZoneRequest
    {
        private bool? _allowCustomProjectResourceTags;
        private string _description;
        private string _domainIdentifier;
        private string _domainUnitIdentifier;
        private List<EnvironmentConfiguration> _environmentConfigurations = AWSConfigs.InitializeCollections ? new List<EnvironmentConfiguration>() : null;
        private string _name;
        private List<ResourceTagParameter> _projectResourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTagParameter>() : null;
        private string _projectResourceTagsDescription;
        private Status _status;

        /// <summary>
        /// Gets and sets the property AllowCustomProjectResourceTags. 
        /// <para>
        /// Specifies whether custom project resource tags are supported.
        /// </para>
        /// </summary>
        public bool AllowCustomProjectResourceTags
        {
            get { return this._allowCustomProjectResourceTags.GetValueOrDefault(); }
            set { this._allowCustomProjectResourceTags = value; }
        }

        // Check to see if AllowCustomProjectResourceTags property is set
        internal bool IsSetAllowCustomProjectResourceTags()
        {
            return this._allowCustomProjectResourceTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of a project profile.
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
        /// A domain ID of the project profile.
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
        /// Gets and sets the property DomainUnitIdentifier. 
        /// <para>
        /// A domain unit ID of the project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DomainUnitIdentifier
        {
            get { return this._domainUnitIdentifier; }
            set { this._domainUnitIdentifier = value; }
        }

        // Check to see if DomainUnitIdentifier property is set
        internal bool IsSetDomainUnitIdentifier()
        {
            return this._domainUnitIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurations. 
        /// <para>
        /// Environment configurations of the project profile.
        /// </para>
        /// </summary>
        public List<EnvironmentConfiguration> EnvironmentConfigurations
        {
            get { return this._environmentConfigurations; }
            set { this._environmentConfigurations = value; }
        }

        // Check to see if EnvironmentConfigurations property is set
        internal bool IsSetEnvironmentConfigurations()
        {
            return this._environmentConfigurations != null && (this._environmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Project profile name.
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
        /// Gets and sets the property ProjectResourceTags. 
        /// <para>
        /// The resource tags of the project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<ResourceTagParameter> ProjectResourceTags
        {
            get { return this._projectResourceTags; }
            set { this._projectResourceTags = value; }
        }

        // Check to see if ProjectResourceTags property is set
        internal bool IsSetProjectResourceTags()
        {
            return this._projectResourceTags != null && (this._projectResourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProjectResourceTagsDescription. 
        /// <para>
        /// Field viewable through the UI that provides a project user with the allowed resource
        /// tag specifications.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string ProjectResourceTagsDescription
        {
            get { return this._projectResourceTagsDescription; }
            set { this._projectResourceTagsDescription = value; }
        }

        // Check to see if ProjectResourceTagsDescription property is set
        internal bool IsSetProjectResourceTagsDescription()
        {
            return this._projectResourceTagsDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Project profile status.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
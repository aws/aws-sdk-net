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
    /// This is the response object from the CreateProjectProfile operation.
    /// </summary>
    public partial class CreateProjectProfileResponse : AmazonWebServiceResponse
    {
        private bool? _allowCustomProjectResourceTags;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _domainId;
        private string _domainUnitId;
        private List<EnvironmentConfiguration> _environmentConfigurations = AWSConfigs.InitializeCollections ? new List<EnvironmentConfiguration>() : null;
        private string _id;
        private DateTime? _lastUpdatedAt;
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
        public bool? AllowCustomProjectResourceTags
        {
            get { return this._allowCustomProjectResourceTags; }
            set { this._allowCustomProjectResourceTags = value; }
        }

        // Check to see if AllowCustomProjectResourceTags property is set
        internal bool IsSetAllowCustomProjectResourceTags()
        {
            return this._allowCustomProjectResourceTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp at which a project profile is created.
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
        /// A user who created a project profile.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A project profile description.
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
        /// The ID of the domain where a project profile is created.
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
        /// Gets and sets the property DomainUnitId. 
        /// <para>
        /// The ID of the domain unit where a project profile is created.
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
        /// Gets and sets the property EnvironmentConfigurations. 
        /// <para>
        /// Environment configurations of a project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Project profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp when a project profile was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
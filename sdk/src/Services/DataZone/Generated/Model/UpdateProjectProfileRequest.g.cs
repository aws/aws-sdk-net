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
    /// Container for the parameters to the UpdateProjectProfile operation. Updates a project
    /// profile.
    /// </summary>
    public partial class UpdateProjectProfileRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AllowCustomProjectResourceTags. 
        /// <para>
        /// Specifies whether custom project resource tags are supported.
        /// </para>
        /// </summary>
        public bool? AllowCustomProjectResourceTags { get; set; }

        /// <summary>
        /// Checks to see if the AllowCustomProjectResourceTags property is set.
        /// </summary>
        internal bool IsSetAllowCustomProjectResourceTags() => this.AllowCustomProjectResourceTags.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a project profile.
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
        /// The ID of the domain where a project profile is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property DomainUnitIdentifier. 
        /// <para>
        /// The ID of the domain unit where a project profile is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DomainUnitIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainUnitIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainUnitIdentifier() => this.DomainUnitIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurations. 
        /// <para>
        /// The environment configurations of a project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfiguration> EnvironmentConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentConfigurations property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurations() => this.EnvironmentConfigurations != null && (this.EnvironmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of a project profile that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectResourceTags. 
        /// <para>
        /// The resource tags of the project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<ResourceTagParameter> ProjectResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTagParameter>() : null;

        /// <summary>
        /// Checks to see if the ProjectResourceTags property is set.
        /// </summary>
        internal bool IsSetProjectResourceTags() => this.ProjectResourceTags != null && (this.ProjectResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProjectResourceTagsDescription. 
        /// <para>
        /// Field viewable through the UI that provides a project user with the allowed resource
        /// tag specifications.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string ProjectResourceTagsDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProjectResourceTagsDescription property is set.
        /// </summary>
        internal bool IsSetProjectResourceTagsDescription() => this.ProjectResourceTagsDescription != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a project profile.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

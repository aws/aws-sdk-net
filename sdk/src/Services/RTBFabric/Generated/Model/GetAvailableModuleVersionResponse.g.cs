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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// This is the response object from the GetAvailableModuleVersion operation.
    /// </summary>
    public partial class GetAvailableModuleVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurableActions. 
        /// <para>
        /// The capabilities that you can turn on when you attach the version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public List<string> ConfigurableActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConfigurableActions property is set.
        /// </summary>
        internal bool IsSetConfigurableActions() => this.ConfigurableActions != null && (this.ConfigurableActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConfigurationSchema. 
        /// <para>
        /// The JSON Schema for the parameters that you can set in <c>configurationValues</c>
        /// when you attach the version.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 32768)]
        public string ConfigurationSchema { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSchema property is set.
        /// </summary>
        internal bool IsSetConfigurationSchema() => this.ConfigurationSchema != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModuleId. 
        /// <para>
        /// The module's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Checks to see if the ModuleId property is set.
        /// </summary>
        internal bool IsSetModuleId() => this.ModuleId != null;

        /// <summary>
        /// Gets and sets the property ModuleVersionArn. 
        /// <para>
        /// The version's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string ModuleVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModuleVersionArn property is set.
        /// </summary>
        internal bool IsSetModuleVersionArn() => this.ModuleVersionArn != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The data-access grants the version holds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// The vendor's release notes.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 4096)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseNotes property is set.
        /// </summary>
        internal bool IsSetReleaseNotes() => this.ReleaseNotes != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// ACTIVE or DEPRECATED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModuleVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the version last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}

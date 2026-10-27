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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStack operation. Updates the specified fields
    /// for the specified stack.
    /// </summary>
    public partial class UpdateStackRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of interface VPC endpoint (interface endpoint) objects. Users of the stack
        /// can connect to WorkSpaces Applications only through the specified endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<AccessEndpoint> AccessEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;

        /// <summary>
        /// Checks to see if the AccessEndpoints property is set.
        /// </summary>
        internal bool IsSetAccessEndpoints() => this.AccessEndpoints != null && (this.AccessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentAccessConfig. 
        /// <para>
        /// The configuration for agent access on the stack. Specify this to update agent access
        /// settings. To remove agent access, use AttributesToDelete with the AGENT_ACCESS_CONFIG
        /// value.
        /// </para>
        /// </summary>
        public AgentAccessConfigForUpdate AgentAccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the AgentAccessConfig property is set.
        /// </summary>
        internal bool IsSetAgentAccessConfig() => this.AgentAccessConfig != null;

        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users of a stack. When these settings are
        /// enabled, changes that users make to applications and Windows settings are automatically
        /// saved after each session and applied to the next session.
        /// </para>
        /// </summary>
        public ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSettings property is set.
        /// </summary>
        internal bool IsSetApplicationSettings() => this.ApplicationSettings != null;

        /// <summary>
        /// Gets and sets the property AttributesToDelete. 
        /// <para>
        /// The stack attributes to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesToDelete property is set.
        /// </summary>
        internal bool IsSetAttributesToDelete() => this.AttributesToDelete != null && (this.AttributesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContentRedirection.
        /// </summary>
        public ContentRedirection ContentRedirection { get; set; }

        /// <summary>
        /// Checks to see if the ContentRedirection property is set.
        /// </summary>
        internal bool IsSetContentRedirection() => this.ContentRedirection != null;

        /// <summary>
        /// Gets and sets the property DeleteStorageConnectors. 
        /// <para>
        /// Deletes the storage connectors currently enabled for the stack.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated")]
        public bool? DeleteStorageConnectors { get; set; }

        /// <summary>
        /// Checks to see if the DeleteStorageConnectors property is set.
        /// </summary>
        internal bool IsSetDeleteStorageConnectors() => this.DeleteStorageConnectors.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The stack name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EmbedHostDomains. 
        /// <para>
        /// The domains where WorkSpaces Applications streaming sessions can be embedded in an
        /// iframe. You must approve the domains that you want to host embedded WorkSpaces Applications
        /// streaming sessions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> EmbedHostDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EmbedHostDomains property is set.
        /// </summary>
        internal bool IsSetEmbedHostDomains() => this.EmbedHostDomains != null && (this.EmbedHostDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeedbackURL. 
        /// <para>
        /// The URL that users are redirected to after they choose the Send Feedback link. If
        /// no URL is specified, no Send Feedback link is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string FeedbackURL { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackURL property is set.
        /// </summary>
        internal bool IsSetFeedbackURL() => this.FeedbackURL != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RedirectURL. 
        /// <para>
        /// The URL that users are redirected to after their streaming session ends.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string RedirectURL { get; set; }

        /// <summary>
        /// Checks to see if the RedirectURL property is set.
        /// </summary>
        internal bool IsSetRedirectURL() => this.RedirectURL != null;

        /// <summary>
        /// Gets and sets the property StorageConnectorAuthentication. 
        /// <para>
        /// Specifies whether users' cloud storage authentication persists across streaming sessions.
        /// When you specify FORCE_REAUTHENTICATION, WorkSpaces Applications removes the stored
        /// authentication for the stack's OneDrive and Google Drive connectors when a user's
        /// session ends. The user links their cloud storage again on their next session. To clear
        /// this attribute, add STORAGE_CONNECTOR_AUTHENTICATION to AttributesToDelete.
        /// </para>
        /// </summary>
        public StorageConnectorAuthentication StorageConnectorAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the StorageConnectorAuthentication property is set.
        /// </summary>
        internal bool IsSetStorageConnectorAuthentication() => this.StorageConnectorAuthentication != null;

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// The storage connectors to enable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageConnector> StorageConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<StorageConnector>() : null;

        /// <summary>
        /// Checks to see if the StorageConnectors property is set.
        /// </summary>
        internal bool IsSetStorageConnectors() => this.StorageConnectors != null && (this.StorageConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StreamingExperienceSettings. 
        /// <para>
        /// The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently,
        /// UDP is only supported in the Windows native client.
        /// </para>
        /// </summary>
        public StreamingExperienceSettings StreamingExperienceSettings { get; set; }

        /// <summary>
        /// Checks to see if the StreamingExperienceSettings property is set.
        /// </summary>
        internal bool IsSetStreamingExperienceSettings() => this.StreamingExperienceSettings != null;

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// The actions that are enabled or disabled for users during their streaming sessions.
        /// By default, these actions are enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<UserSetting> UserSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<UserSetting>() : null;

        /// <summary>
        /// Checks to see if the UserSettings property is set.
        /// </summary>
        internal bool IsSetUserSettings() => this.UserSettings != null && (this.UserSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

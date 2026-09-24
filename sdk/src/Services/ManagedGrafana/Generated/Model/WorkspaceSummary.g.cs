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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure that contains some information about one workspace in the account.
    /// </summary>
    public partial class WorkspaceSummary
    {
        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// A structure containing information about the authentication methods used in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationSummary Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date that the workspace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The customer-entered description of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The URL endpoint to use to access the Grafana console in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property GrafanaToken. 
        /// <para>
        /// The token that ties this workspace to a Grafana Labs account. For more information,
        /// see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html#AMG-workspace-register-enterprise">Link
        /// your account with Grafana Labs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string GrafanaToken { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaToken property is set.
        /// </summary>
        internal bool IsSetGrafanaToken() => this.GrafanaToken != null;

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// The Grafana version that the workspace is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaVersion property is set.
        /// </summary>
        internal bool IsSetGrafanaVersion() => this.GrafanaVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// Specifies whether this workspace has a full Grafana Enterprise license.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Managed Grafana workspaces no longer support Grafana Enterprise free trials.
        /// </para>
        ///  </note>
        /// </summary>
        public LicenseType LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The most recent date that the workspace was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Checks to see if the Modified property is set.
        /// </summary>
        internal bool IsSetModified() => this.Modified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationDestinations. 
        /// <para>
        /// The Amazon Web Services notification channels that Amazon Managed Grafana can automatically
        /// create IAM roles and permissions for, which allows Amazon Managed Grafana to use these
        /// channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationDestinations property is set.
        /// </summary>
        internal bool IsSetNotificationDestinations() => this.NotificationDestinations != null && (this.NotificationDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkspaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the workspace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

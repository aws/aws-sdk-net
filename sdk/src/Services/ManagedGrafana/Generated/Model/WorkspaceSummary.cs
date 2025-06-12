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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
        private AuthenticationSummary _authentication;
        private DateTime? _created;
        private string _description;
        private string _endpoint;
        private string _grafanaToken;
        private string _grafanaVersion;
        private string _id;
        private LicenseType _licenseType;
        private DateTime? _modified;
        private string _name;
        private List<string> _notificationDestinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private WorkspaceStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// A structure containing information about the authentication methods used in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationSummary Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date that the workspace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The customer-entered description of the workspace.
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
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The URL endpoint to use to access the Grafana console in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property GrafanaToken. 
        /// <para>
        /// The token that ties this workspace to a Grafana Labs account. For more information,
        /// see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html#AMG-workspace-register-enterprise">Link
        /// your account with Grafana Labs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string GrafanaToken
        {
            get { return this._grafanaToken; }
            set { this._grafanaToken = value; }
        }

        // Check to see if GrafanaToken property is set
        internal bool IsSetGrafanaToken()
        {
            return this._grafanaToken != null;
        }

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// The Grafana version that the workspace is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GrafanaVersion
        {
            get { return this._grafanaVersion; }
            set { this._grafanaVersion = value; }
        }

        // Check to see if GrafanaVersion property is set
        internal bool IsSetGrafanaVersion()
        {
            return this._grafanaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the workspace.
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
        public LicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The most recent date that the workspace was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Modified
        {
            get { return this._modified; }
            set { this._modified = value; }
        }

        // Check to see if Modified property is set
        internal bool IsSetModified()
        {
            return this._modified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property NotificationDestinations. 
        /// <para>
        /// The Amazon Web Services notification channels that Amazon Managed Grafana can automatically
        /// create IAM roles and permissions for, which allows Amazon Managed Grafana to use these
        /// channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationDestinations
        {
            get { return this._notificationDestinations; }
            set { this._notificationDestinations = value; }
        }

        // Check to see if NotificationDestinations property is set
        internal bool IsSetNotificationDestinations()
        {
            return this._notificationDestinations != null && (this._notificationDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the workspace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
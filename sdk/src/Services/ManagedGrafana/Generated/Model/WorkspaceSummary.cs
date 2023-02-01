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
        private string _grafanaVersion;
        private string _id;
        private DateTime? _modified;
        private string _name;
        private List<string> _notificationDestinations = new List<string>();
        private WorkspaceStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
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
        /// Gets and sets the property Modified. 
        /// <para>
        /// The most recent date that the workspace was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Modified
        {
            get { return this._modified.GetValueOrDefault(); }
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
        /// </summary>
        public List<string> NotificationDestinations
        {
            get { return this._notificationDestinations; }
            set { this._notificationDestinations = value; }
        }

        // Check to see if NotificationDestinations property is set
        internal bool IsSetNotificationDestinations()
        {
            return this._notificationDestinations != null && this._notificationDestinations.Count > 0; 
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
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
    /// Container for the parameters to the CreateWorkspaceApiKey operation.
    /// Creates a Grafana API key for the workspace. This key can be used to authenticate
    /// requests sent to the workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
    /// for available APIs and example requests.
    /// </summary>
    public partial class CreateWorkspaceApiKeyRequest : AmazonManagedGrafanaRequest
    {
        private string _keyName;
        private string _keyRole;
        private int? _secondsToLive;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// Specifies the name of the key. Keynames must be unique to the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRole. 
        /// <para>
        /// Specifies the permission level of the key.
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>VIEWER</code>|<code>EDITOR</code>|<code>ADMIN</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyRole
        {
            get { return this._keyRole; }
            set { this._keyRole = value; }
        }

        // Check to see if KeyRole property is set
        internal bool IsSetKeyRole()
        {
            return this._keyRole != null;
        }

        /// <summary>
        /// Gets and sets the property SecondsToLive. 
        /// <para>
        /// Specifies the time in seconds until the key expires. Keys can be valid for up to 30
        /// days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2592000)]
        public int SecondsToLive
        {
            get { return this._secondsToLive.GetValueOrDefault(); }
            set { this._secondsToLive = value; }
        }

        // Check to see if SecondsToLive property is set
        internal bool IsSetSecondsToLive()
        {
            return this._secondsToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to create an API key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}
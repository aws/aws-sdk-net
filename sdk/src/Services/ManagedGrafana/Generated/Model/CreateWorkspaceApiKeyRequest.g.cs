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
    /// Container for the parameters to the CreateWorkspaceApiKey operation. Creates a Grafana
    /// API key for the workspace. This key can be used to authenticate requests sent to the
    /// workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
    /// for available APIs and example requests. <note> <para> In workspaces compatible with
    /// Grafana version 9 or above, use workspace service accounts instead of API keys. API
    /// keys will be removed in a future release. </para> </note>
    /// </summary>
    public partial class CreateWorkspaceApiKeyRequest : AmazonManagedGrafanaRequest
    {
        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// Specifies the name of the key. Keynames must be unique to the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property KeyRole. 
        /// <para>
        /// Specifies the permission level of the key.
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <c>ADMIN</c>|<c>EDITOR</c>|<c>VIEWER</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyRole { get; set; }

        /// <summary>
        /// Checks to see if the KeyRole property is set.
        /// </summary>
        internal bool IsSetKeyRole() => this.KeyRole != null;

        /// <summary>
        /// Gets and sets the property SecondsToLive. 
        /// <para>
        /// Specifies the time in seconds until the key expires. Keys can be valid for up to 30
        /// days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2592000)]
        public int? SecondsToLive { get; set; }

        /// <summary>
        /// Checks to see if the SecondsToLive property is set.
        /// </summary>
        internal bool IsSetSecondsToLive() => this.SecondsToLive.HasValue;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to create an API key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}

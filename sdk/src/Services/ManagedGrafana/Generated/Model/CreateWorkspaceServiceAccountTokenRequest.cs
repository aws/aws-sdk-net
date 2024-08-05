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
    /// Container for the parameters to the CreateWorkspaceServiceAccountToken operation.
    /// Creates a token that can be used to authenticate and authorize Grafana HTTP API operations
    /// for the given <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">workspace
    /// service account</a>. The service account acts as a user for the API operations, and
    /// defines the permissions that are used by the API.
    /// 
    ///  <important> 
    /// <para>
    /// When you create the service account token, you will receive a key that is used when
    /// calling Grafana APIs. Do not lose this key, as it will not be retrievable again.
    /// </para>
    ///  
    /// <para>
    /// If you do lose the key, you can delete the token and recreate it to receive a new
    /// key. This will disable the initial key.
    /// </para>
    ///  </important> 
    /// <para>
    /// Service accounts are only available for workspaces that are compatible with Grafana
    /// version 9 and above.
    /// </para>
    /// </summary>
    public partial class CreateWorkspaceServiceAccountTokenRequest : AmazonManagedGrafanaRequest
    {
        private string _name;
        private int? _secondsToLive;
        private string _serviceAccountId;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the token to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property SecondsToLive. 
        /// <para>
        /// Sets how long the token will be valid, in seconds. You can set the time up to 30 days
        /// in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2592000)]
        public int? SecondsToLive
        {
            get { return this._secondsToLive; }
            set { this._secondsToLive = value; }
        }

        // Check to see if SecondsToLive property is set
        internal bool IsSetSecondsToLive()
        {
            return this._secondsToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountId. 
        /// <para>
        /// The ID of the service account for which to create a token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccountId
        {
            get { return this._serviceAccountId; }
            set { this._serviceAccountId = value; }
        }

        // Check to see if ServiceAccountId property is set
        internal bool IsSetServiceAccountId()
        {
            return this._serviceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace the service account resides within.
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
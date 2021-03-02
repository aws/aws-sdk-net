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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLocationObjectStorage operation.
    /// Updates some of the parameters of a previously created location for self-managed object
    /// storage server access. For information about creating a self-managed object storage
    /// location, see <a>create-object-location</a>.
    /// </summary>
    public partial class UpdateLocationObjectStorageRequest : AmazonDataSyncRequest
    {
        private string _accessKey;
        private List<string> _agentArns = new List<string>();
        private string _locationArn;
        private string _secretKey;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Optional. The access key is used if credentials are required to access the self-managed
        /// object storage server. If your object storage requires a user name and password to
        /// authenticate, use <code>AccessKey</code> and <code>SecretKey</code> to provide the
        /// user name and password, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=200)]
        public string AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agents associated with the self-managed object
        /// storage server location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && this._agentArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the self-managed object storage server location
        /// to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretKey. 
        /// <para>
        /// Optional. The secret key is used if credentials are required to access the self-managed
        /// object storage server. If your object storage requires a user name and password to
        /// authenticate, use <code>AccessKey</code> and <code>SecretKey</code> to provide the
        /// user name and password, respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=200)]
        public string SecretKey
        {
            get { return this._secretKey; }
            set { this._secretKey = value; }
        }

        // Check to see if SecretKey property is set
        internal bool IsSetSecretKey()
        {
            return this._secretKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The port that your self-managed object storage server accepts inbound network traffic
        /// on. The server port is set by default to TCP 80 (HTTP) or TCP 443 (HTTPS). You can
        /// specify a custom port if your self-managed object storage server requires one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public int ServerPort
        {
            get { return this._serverPort.GetValueOrDefault(); }
            set { this._serverPort = value; }
        }

        // Check to see if ServerPort property is set
        internal bool IsSetServerPort()
        {
            return this._serverPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerProtocol. 
        /// <para>
        /// The protocol that the object storage server uses to communicate. Valid values are
        /// <code>HTTP</code> or <code>HTTPS</code>.
        /// </para>
        /// </summary>
        public ObjectStorageServerProtocol ServerProtocol
        {
            get { return this._serverProtocol; }
            set { this._serverProtocol = value; }
        }

        // Check to see if ServerProtocol property is set
        internal bool IsSetServerProtocol()
        {
            return this._serverProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// The subdirectory in the self-managed object storage server that is used to read data
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

    }
}
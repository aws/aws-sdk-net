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
    /// Container for the parameters to the CreateLocationObjectStorage operation.
    /// Creates an endpoint for a self-managed object storage bucket. For more information
    /// about self-managed object storage locations, see <a>create-object-location</a>.
    /// </summary>
    public partial class CreateLocationObjectStorageRequest : AmazonDataSyncRequest
    {
        private string _accessKey;
        private List<string> _agentArns = new List<string>();
        private string _bucketName;
        private string _secretKey;
        private string _serverHostname;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

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
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket on the self-managed object storage server that is used to read data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
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
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// The name of the self-managed object storage server. This value is the IP address or
        /// Domain Name Service (DNS) name of the object storage server. An agent uses this host
        /// name to mount the object storage server in a network. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServerHostname
        {
            get { return this._serverHostname; }
            set { this._serverHostname = value; }
        }

        // Check to see if ServerHostname property is set
        internal bool IsSetServerHostname()
        {
            return this._serverHostname != null;
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
        /// HTTP or HTTPS.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag that you want to add to the location. The
        /// value can be an empty string. We recommend using tags to name your resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
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
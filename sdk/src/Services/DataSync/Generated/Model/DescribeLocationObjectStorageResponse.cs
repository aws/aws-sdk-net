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
    /// DescribeLocationObjectStorageResponse
    /// </summary>
    public partial class DescribeLocationObjectStorageResponse : AmazonWebServiceResponse
    {
        private string _accessKey;
        private List<string> _agentArns = new List<string>();
        private DateTime? _creationTime;
        private string _locationArn;
        private string _locationUri;
        private MemoryStream _serverCertificate;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// The access key (for example, a user name) required to authenticate with the object
        /// storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// The ARNs of the DataSync agents that can securely connect with your location.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the location was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificate. 
        /// <para>
        /// The self-signed certificate that DataSync uses to securely authenticate with your
        /// object storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public MemoryStream ServerCertificate
        {
            get { return this._serverCertificate; }
            set { this._serverCertificate = value; }
        }

        // Check to see if ServerCertificate property is set
        internal bool IsSetServerCertificate()
        {
            return this._serverCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The port that your object storage server accepts inbound network traffic on (for example,
        /// port 443).
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
        /// The protocol that your object storage system uses to communicate.
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

    }
}
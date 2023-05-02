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
    /// This is the response object from the DescribeStorageSystem operation.
    /// </summary>
    public partial class DescribeStorageSystemResponse : AmazonWebServiceResponse
    {
        private List<string> _agentArns = new List<string>();
        private string _cloudWatchLogGroupArn;
        private StorageSystemConnectivityStatus _connectivityStatus;
        private DateTime? _creationTime;
        private string _errorMessage;
        private string _name;
        private string _secretsManagerArn;
        private DiscoveryServerConfiguration _serverConfiguration;
        private string _storageSystemArn;
        private DiscoverySystemType _systemType;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARN of the DataSync agent that connects to and reads from your on-premises storage
        /// system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        /// The ARN of the Amazon CloudWatch log group that's used to monitor and log discovery
        /// job events.
        /// </para>
        /// </summary>
        [AWSProperty(Max=562)]
        public string CloudWatchLogGroupArn
        {
            get { return this._cloudWatchLogGroupArn; }
            set { this._cloudWatchLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogGroupArn property is set
        internal bool IsSetCloudWatchLogGroupArn()
        {
            return this._cloudWatchLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectivityStatus. 
        /// <para>
        /// Indicates whether your DataSync agent can connect to your on-premises storage system.
        /// </para>
        /// </summary>
        public StorageSystemConnectivityStatus ConnectivityStatus
        {
            get { return this._connectivityStatus; }
            set { this._connectivityStatus = value; }
        }

        // Check to see if ConnectivityStatus property is set
        internal bool IsSetConnectivityStatus()
        {
            return this._connectivityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when you added the on-premises storage system to DataSync Discovery.
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Describes the connectivity error that the DataSync agent is encountering with your
        /// on-premises storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you gave your on-premises storage system when adding it to DataSync
        /// Discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property SecretsManagerArn. 
        /// <para>
        /// The ARN of the secret that stores your on-premises storage system's credentials. DataSync
        /// Discovery stores these credentials in <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-configure-storage.html#discovery-add-storage">Secrets
        /// Manager</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string SecretsManagerArn
        {
            get { return this._secretsManagerArn; }
            set { this._secretsManagerArn = value; }
        }

        // Check to see if SecretsManagerArn property is set
        internal bool IsSetSecretsManagerArn()
        {
            return this._secretsManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServerConfiguration. 
        /// <para>
        /// The server name and network port required to connect with your on-premises storage
        /// system's management interface.
        /// </para>
        /// </summary>
        public DiscoveryServerConfiguration ServerConfiguration
        {
            get { return this._serverConfiguration; }
            set { this._serverConfiguration = value; }
        }

        // Check to see if ServerConfiguration property is set
        internal bool IsSetServerConfiguration()
        {
            return this._serverConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageSystemArn. 
        /// <para>
        /// The ARN of the on-premises storage system that the discovery job looked at.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string StorageSystemArn
        {
            get { return this._storageSystemArn; }
            set { this._storageSystemArn = value; }
        }

        // Check to see if StorageSystemArn property is set
        internal bool IsSetStorageSystemArn()
        {
            return this._storageSystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemType. 
        /// <para>
        /// The type of on-premises storage system.
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync Discovery currently only supports NetApp Fabric-Attached Storage (FAS) and
        /// All Flash FAS (AFF) systems running ONTAP 9.7 or later. 
        /// </para>
        ///  </note>
        /// </summary>
        public DiscoverySystemType SystemType
        {
            get { return this._systemType; }
            set { this._systemType = value; }
        }

        // Check to see if SystemType property is set
        internal bool IsSetSystemType()
        {
            return this._systemType != null;
        }

    }
}
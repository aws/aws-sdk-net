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
    /// Container for the parameters to the UpdateStorageSystem operation.
    /// Modifies some configurations of an on-premises storage system resource that you're
    /// using with DataSync Discovery.
    /// </summary>
    public partial class UpdateStorageSystemRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = new List<string>();
        private string _cloudWatchLogGroupArn;
        private Credentials _credentials;
        private string _name;
        private DiscoveryServerConfiguration _serverConfiguration;
        private string _storageSystemArn;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the DataSync agent that connects to and
        /// reads your on-premises storage system.
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
        /// Specifies the ARN of the Amazon CloudWatch log group for monitoring and logging discovery
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
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Specifies the user name and password for accessing your on-premises storage system's
        /// management interface.
        /// </para>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a familiar name for your on-premises storage system.
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
        /// Gets and sets the property ServerConfiguration. 
        /// <para>
        /// Specifies the server name and network port required to connect with your on-premises
        /// storage system's management interface.
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
        /// Specifies the ARN of the on-premises storage system that you want reconfigure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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

    }
}
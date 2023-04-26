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
    /// Container for the parameters to the AddStorageSystem operation.
    /// Creates an Amazon Web Services resource for an on-premises storage system that you
    /// want DataSync Discovery to collect information about.
    /// </summary>
    public partial class AddStorageSystemRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = new List<string>();
        private string _clientToken;
        private string _cloudWatchLogGroupArn;
        private Credentials _credentials;
        private string _name;
        private DiscoveryServerConfiguration _serverConfiguration;
        private DiscoverySystemType _systemType;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the DataSync agent that connects to and
        /// reads from your on-premises storage system's management interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a client token to make sure requests with this API operation are idempotent.
        /// If you don't specify a client token, DataSync generates one for you automatically.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        [AWSProperty(Required=true)]
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
        /// Specifies the server name and network port required to connect with the management
        /// interface of your on-premises storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SystemType. 
        /// <para>
        /// Specifies the type of on-premises storage system that you want DataSync Discovery
        /// to collect information about.
        /// </para>
        ///  <note> 
        /// <para>
        /// DataSync Discovery currently supports NetApp Fabric-Attached Storage (FAS) and All
        /// Flash FAS (AFF) systems running ONTAP 9.7 or later.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your on-premises
        /// storage system.
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
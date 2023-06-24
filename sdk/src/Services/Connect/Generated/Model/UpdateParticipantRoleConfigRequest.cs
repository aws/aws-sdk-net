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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateParticipantRoleConfig operation.
    /// Updates timeouts for when human chat participants are to be considered idle, and when
    /// agents are automatically disconnected from a chat due to idleness. You can set four
    /// timers:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Customer idle timeout
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Customer auto-disconnect timeout
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Agent idle timeout
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Agent auto-disconnect timeout
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
    /// up chat timeouts for human participants</a>. 
    /// </para>
    /// </summary>
    public partial class UpdateParticipantRoleConfigRequest : AmazonConnectRequest
    {
        private UpdateParticipantRoleConfigChannelInfo _channelConfiguration;
        private string _contactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ChannelConfiguration. 
        /// <para>
        /// The Amazon Connect channel you want to configure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateParticipantRoleConfigChannelInfo ChannelConfiguration
        {
            get { return this._channelConfiguration; }
            set { this._channelConfiguration = value; }
        }

        // Check to see if ChannelConfiguration property is set
        internal bool IsSetChannelConfiguration()
        {
            return this._channelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}
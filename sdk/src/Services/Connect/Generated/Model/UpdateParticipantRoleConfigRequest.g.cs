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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateParticipantRoleConfig operation. Updates
    /// timeouts for when human chat participants are to be considered idle, and when agents
    /// are automatically disconnected from a chat due to idleness. You can set four timers:
    /// <ul> <li> <para> Customer idle timeout </para> </li> <li> <para> Customer auto-disconnect
    /// timeout </para> </li> <li> <para> Agent idle timeout </para> </li> <li> <para> Agent
    /// auto-disconnect timeout </para> </li> </ul> <para> For more information about how
    /// chat timeouts work, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-chat-timeouts.html">Set
    /// up chat timeouts for human participants</a>. </para>
    /// </summary>
    public partial class UpdateParticipantRoleConfigRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelConfiguration. 
        /// <para>
        /// The Connect Customer channel you want to configure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateParticipantRoleConfigChannelInfo ChannelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChannelConfiguration property is set.
        /// </summary>
        internal bool IsSetChannelConfiguration() => this.ChannelConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}

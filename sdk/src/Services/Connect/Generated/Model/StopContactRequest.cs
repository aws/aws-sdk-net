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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StopContact operation.
    /// Ends the specified contact. Use this API to stop queued callbacks. It does not work
    /// for voice contacts that use the following initiation methods:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// DISCONNECT
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TRANSFER
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// QUEUE_TRANSFER
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EXTERNAL_OUTBOUND
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MONITOR
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Chat and task contacts can be terminated in any state, regardless of initiation method.
    /// </para>
    /// </summary>
    public partial class StopContactRequest : AmazonConnectRequest
    {
        private string _contactId;
        private DisconnectReason _disconnectReason;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The ID of the contact.
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
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The reason a contact can be disconnected. Only Amazon Connect outbound campaigns can
        /// provide this field.
        /// </para>
        /// </summary>
        public DisconnectReason DisconnectReason
        {
            get { return this._disconnectReason; }
            set { this._disconnectReason = value; }
        }

        // Check to see if DisconnectReason property is set
        internal bool IsSetDisconnectReason()
        {
            return this._disconnectReason != null;
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
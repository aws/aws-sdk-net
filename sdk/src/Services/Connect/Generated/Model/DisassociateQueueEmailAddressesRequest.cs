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
    /// Container for the parameters to the DisassociateQueueEmailAddresses operation.
    /// Removes the association between a set of email addresses and a queue. After disassociation,
    /// agents will no longer be able to select these email addresses as "From" addresses
    /// when replying to inbound email contacts or initiating outbound email contacts in this
    /// queue.
    /// 
    ///  
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Agents will no longer see these email addresses in their "From" address selection
    /// options for this queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The email addresses themselves are not deleted from the instance, only their availability
    /// for agent selection in this queue is removed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Changes take effect immediately and will affect the agent experience in the Contact
    /// Control Panel (CCP).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateQueueEmailAddressesRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private List<string> _emailAddressesId = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceId;
        private string _queueId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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
        /// Gets and sets the property EmailAddressesId. 
        /// <para>
        /// List of email address identifiers to disassociate from the queue. These are the unique
        /// identifiers of email addresses that should no longer be routed to this queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> EmailAddressesId
        {
            get { return this._emailAddressesId; }
            set { this._emailAddressesId = value; }
        }

        // Check to see if EmailAddressesId property is set
        internal bool IsSetEmailAddressesId()
        {
            return this._emailAddressesId != null && (this._emailAddressesId.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier for the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

    }
}
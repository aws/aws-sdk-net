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
    /// Container for the parameters to the AssociateQueueEmailAddresses operation.
    /// Associates a set of email addresses with a queue to enable agents to select different
    /// "From" (system) email addresses when replying to inbound email contacts or initiating
    /// outbound email contacts. This allows agents to handle email contacts across different
    /// brands and business units within the same queue.
    /// 
    ///  
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can associate up to 49 additional email addresses with a single queue, plus 1
    /// default outbound email address, for a total of 50.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The email addresses must already exist in the Amazon Connect instance before they
    /// can be associated with a queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Agents will be able to select from these associated email addresses when handling
    /// email contacts in the queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For inbound email contacts, agents can select from email addresses associated with
    /// the queue where the contact was accepted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For outbound email contacts, agents can select from email addresses associated with
    /// their default outbound queue configured in their routing profile.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssociateQueueEmailAddressesRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private List<EmailAddressConfig> _emailAddressesConfig = AWSConfigs.InitializeCollections ? new List<EmailAddressConfig>() : null;
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
        /// Gets and sets the property EmailAddressesConfig. 
        /// <para>
        /// Configuration list containing the email addresses to associate with the queue. Each
        /// configuration specifies an email address ID that should be linked to this queue for
        /// routing purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<EmailAddressConfig> EmailAddressesConfig
        {
            get { return this._emailAddressesConfig; }
            set { this._emailAddressesConfig = value; }
        }

        // Check to see if EmailAddressesConfig property is set
        internal bool IsSetEmailAddressesConfig()
        {
            return this._emailAddressesConfig != null && (this._emailAddressesConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
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
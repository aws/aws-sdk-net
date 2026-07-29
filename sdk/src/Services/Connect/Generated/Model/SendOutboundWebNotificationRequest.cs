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
    /// Container for the parameters to the SendOutboundWebNotification operation.
    /// Sends an outbound web notification to a customer's web browser for outbound campaigns.
    /// For more information about outbound campaigns, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-outbound-campaigns.html">Set
    /// up Connect Customer outbound campaigns</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Only the Connect Customer outbound campaigns service principal is allowed to assume
    /// a role in your account and call this API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SendOutboundWebNotificationRequest : AmazonConnectRequest
    {
        private string _browserId;
        private string _clientToken;
        private WebNotificationContent _content;
        private WidgetDestination _destination;
        private DateTime? _expiresAt;
        private string _instanceId;
        private string _sessionId;
        private WebNotificationSource _source;

        /// <summary>
        /// Gets and sets the property BrowserId. 
        /// <para>
        /// A unique identifier for the customer's web browser instance to which the notification
        /// is being sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string BrowserId
        {
            get { return this._browserId; }
            set { this._browserId = value; }
        }

        // Check to see if BrowserId property is set
        internal bool IsSetBrowserId()
        {
            return this._browserId != null;
        }

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
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the web notification, including the notification type, the view to
        /// render, and any optional attributes used to populate it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebNotificationContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination for the web notification, specifying the communication widget that
        /// delivers the notification and the customer profile of the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WidgetDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp, in Unix epoch time format, at which the web notification expires. After
        /// this time, the notification is no longer delivered to the customer's browser.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the customer's web session to which the notification is being
        /// sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the web notification. A <c>SourceCampaign</c> object identifies the
        /// campaign and outbound request that triggered this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebNotificationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}
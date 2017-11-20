/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNotificationSubscription operation.
    /// Configure WorkDocs to use Amazon SNS notifications.
    /// 
    ///  
    /// <para>
    /// The endpoint receives a confirmation message, and must confirm the subscription. For
    /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SendMessageToHttp.html#SendMessageToHttp.confirm">Confirm
    /// the Subscription</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateNotificationSubscriptionRequest : AmazonWorkDocsRequest
    {
        private string _endpoint;
        private string _organizationId;
        private SubscriptionProtocolType _protocol;
        private SubscriptionType _subscriptionType;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint to receive the notifications. If the protocol is HTTPS, the endpoint
        /// is a URL that begins with "https://".
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use. The supported value is https, which delivers JSON-encoded messages
        /// using HTTPS POST.
        /// </para>
        /// </summary>
        public SubscriptionProtocolType Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The notification type.
        /// </para>
        /// </summary>
        public SubscriptionType SubscriptionType
        {
            get { return this._subscriptionType; }
            set { this._subscriptionType = value; }
        }

        // Check to see if SubscriptionType property is set
        internal bool IsSetSubscriptionType()
        {
            return this._subscriptionType != null;
        }

    }
}
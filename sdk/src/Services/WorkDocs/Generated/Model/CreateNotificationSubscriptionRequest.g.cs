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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNotificationSubscription operation. Configure
    /// Amazon WorkDocs to use Amazon SNS notifications. The endpoint receives a confirmation
    /// message, and must confirm the subscription. <para> For more information, see <a href="https://docs.aws.amazon.com/workdocs/latest/developerguide/manage-notifications.html">Setting
    /// up notifications for an IAM user or role</a> in the <i>Amazon WorkDocs Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateNotificationSubscriptionRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint to receive the notifications. If the protocol is HTTPS, the endpoint
        /// is a URL that begins with <c>https</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to use. The supported value is https, which delivers JSON-encoded messages
        /// using HTTPS POST.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionProtocolType Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The notification type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionType property is set.
        /// </summary>
        internal bool IsSetSubscriptionType() => this.SubscriptionType != null;
    }
}

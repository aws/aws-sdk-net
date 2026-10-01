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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the SendDataSetNotification operation. The type of
    /// event associated with the data set.
    /// </summary>
    public partial class SendDataSetNotificationRequest : AmazonDataExchangeRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency key for the notification, this key allows us to deduplicate notifications
        /// that are sent in quick succession erroneously.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Free-form text field for providers to add information about their notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// Affected data set of the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Extra details specific to this notification type.
        /// </para>
        /// </summary>
        public NotificationDetails Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Affected scope of this notification such as the underlying resources affected by the
        /// notification event.
        /// </para>
        /// </summary>
        public ScopeDetails Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the notification. Describing the kind of event the notification is alerting
        /// you to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

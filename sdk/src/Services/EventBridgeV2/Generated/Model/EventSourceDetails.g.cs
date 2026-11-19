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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Values EventBridge generated for an EventSource that depend on its type. Only the
    /// member for the EventSource's type is set. Returned in responses only. You never supply
    /// these values.
    /// </summary>
    public partial class EventSourceDetails
    {
        /// <summary>
        /// Gets and sets the property WebhookDetails. 
        /// <para>
        /// Values generated for a webhook EventSource.
        /// </para>
        /// </summary>
        public WebhookDetails WebhookDetails { get; set; }

        /// <summary>
        /// Checks to see if the WebhookDetails property is set.
        /// </summary>
        internal bool IsSetWebhookDetails() => this.WebhookDetails != null;
    }
}

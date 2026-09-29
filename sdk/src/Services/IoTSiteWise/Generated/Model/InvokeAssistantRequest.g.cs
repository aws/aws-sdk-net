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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeAssistant operation. Invokes SiteWise Assistant
    /// to start or continue a conversation.
    /// </summary>
    public partial class InvokeAssistantRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The ID assigned to a conversation. IoT SiteWise automatically generates a unique ID
        /// for you, and this parameter is never required. However, if you prefer to have your
        /// own ID, you must specify it here in UUID format. If you specify your own ID, it must
        /// be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property EnableTrace. 
        /// <para>
        /// Specifies if to turn trace on or not. It is used to track the SiteWise Assistant's
        /// reasoning, and data access process.
        /// </para>
        /// </summary>
        public bool? EnableTrace { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrace property is set.
        /// </summary>
        internal bool IsSetEnableTrace() => this.EnableTrace.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A text message sent to the SiteWise Assistant by the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 10000)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}

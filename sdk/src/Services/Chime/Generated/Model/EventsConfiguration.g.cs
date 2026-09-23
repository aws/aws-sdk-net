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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The configuration that allows a bot to receive outgoing events. Can be either an HTTPS
    /// endpoint or a Lambda function ARN.
    /// </summary>
    public partial class EventsConfiguration
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The bot ID.
        /// </para>
        /// </summary>
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// Lambda function ARN that allows a bot to receive outgoing events.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LambdaFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionArn property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionArn() => this.LambdaFunctionArn != null;

        /// <summary>
        /// Gets and sets the property OutboundEventsHTTPSEndpoint. 
        /// <para>
        /// HTTPS endpoint that allows a bot to receive outgoing events.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string OutboundEventsHTTPSEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the OutboundEventsHTTPSEndpoint property is set.
        /// </summary>
        internal bool IsSetOutboundEventsHTTPSEndpoint() => this.OutboundEventsHTTPSEndpoint != null;
    }
}

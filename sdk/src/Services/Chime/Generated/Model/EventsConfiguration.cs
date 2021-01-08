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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The configuration that allows a bot to receive outgoing events. Can be either an HTTPS
    /// endpoint or a Lambda function ARN.
    /// </summary>
    public partial class EventsConfiguration
    {
        private string _botId;
        private string _lambdaFunctionArn;
        private string _outboundEventsHTTPSEndpoint;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The bot ID.
        /// </para>
        /// </summary>
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// Lambda function ARN that allows a bot to receive outgoing events.
        /// </para>
        /// </summary>
        public string LambdaFunctionArn
        {
            get { return this._lambdaFunctionArn; }
            set { this._lambdaFunctionArn = value; }
        }

        // Check to see if LambdaFunctionArn property is set
        internal bool IsSetLambdaFunctionArn()
        {
            return this._lambdaFunctionArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundEventsHTTPSEndpoint. 
        /// <para>
        /// HTTPS endpoint that allows a bot to receive outgoing events.
        /// </para>
        /// </summary>
        public string OutboundEventsHTTPSEndpoint
        {
            get { return this._outboundEventsHTTPSEndpoint; }
            set { this._outboundEventsHTTPSEndpoint = value; }
        }

        // Check to see if OutboundEventsHTTPSEndpoint property is set
        internal bool IsSetOutboundEventsHTTPSEndpoint()
        {
            return this._outboundEventsHTTPSEndpoint != null;
        }

    }
}
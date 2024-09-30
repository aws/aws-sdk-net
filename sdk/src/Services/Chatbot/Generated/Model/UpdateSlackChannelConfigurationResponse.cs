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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// This is the response object from the UpdateSlackChannelConfiguration operation.
    /// </summary>
    public partial class UpdateSlackChannelConfigurationResponse : AmazonWebServiceResponse
    {
        private SlackChannelConfiguration _channelConfiguration;

        /// <summary>
        /// Gets and sets the property ChannelConfiguration. 
        /// <para>
        /// The configuration for a Slack channel configured with AWS Chatbot.
        /// </para>
        /// </summary>
        public SlackChannelConfiguration ChannelConfiguration
        {
            get { return this._channelConfiguration; }
            set { this._channelConfiguration = value; }
        }

        // Check to see if ChannelConfiguration property is set
        internal bool IsSetChannelConfiguration()
        {
            return this._channelConfiguration != null;
        }

    }
}
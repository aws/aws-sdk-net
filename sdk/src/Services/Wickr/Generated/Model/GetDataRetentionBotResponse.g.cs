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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetDataRetentionBot operation.
    /// </summary>
    public partial class GetDataRetentionBotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotExists. 
        /// <para>
        /// Indicates whether a data retention bot exists in the network.
        /// </para>
        /// </summary>
        public bool? BotExists { get; set; }

        /// <summary>
        /// Checks to see if the BotExists property is set.
        /// </summary>
        internal bool IsSetBotExists() => this.BotExists.HasValue;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the data retention bot.
        /// </para>
        /// </summary>
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property IsBotActive. 
        /// <para>
        /// Indicates whether the data retention bot is active and operational.
        /// </para>
        /// </summary>
        public bool? IsBotActive { get; set; }

        /// <summary>
        /// Checks to see if the IsBotActive property is set.
        /// </summary>
        internal bool IsSetIsBotActive() => this.IsBotActive.HasValue;

        /// <summary>
        /// Gets and sets the property IsDataRetentionBotRegistered. 
        /// <para>
        /// Indicates whether the data retention bot has been registered with the network.
        /// </para>
        /// </summary>
        public bool? IsDataRetentionBotRegistered { get; set; }

        /// <summary>
        /// Checks to see if the IsDataRetentionBotRegistered property is set.
        /// </summary>
        internal bool IsSetIsDataRetentionBotRegistered() => this.IsDataRetentionBotRegistered.HasValue;

        /// <summary>
        /// Gets and sets the property IsDataRetentionServiceEnabled. 
        /// <para>
        /// Indicates whether the data retention service is enabled for the network.
        /// </para>
        /// </summary>
        public bool? IsDataRetentionServiceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsDataRetentionServiceEnabled property is set.
        /// </summary>
        internal bool IsSetIsDataRetentionServiceEnabled() => this.IsDataRetentionServiceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property IsPubkeyMsgAcked. 
        /// <para>
        /// Indicates whether the public key message has been acknowledged by the bot.
        /// </para>
        /// </summary>
        public bool? IsPubkeyMsgAcked { get; set; }

        /// <summary>
        /// Checks to see if the IsPubkeyMsgAcked property is set.
        /// </summary>
        internal bool IsSetIsPubkeyMsgAcked() => this.IsPubkeyMsgAcked.HasValue;
    }
}

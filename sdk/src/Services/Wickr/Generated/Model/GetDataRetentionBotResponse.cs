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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private bool? _botExists;
        private string _botName;
        private bool? _isBotActive;
        private bool? _isDataRetentionBotRegistered;
        private bool? _isDataRetentionServiceEnabled;
        private bool? _isPubkeyMsgAcked;

        /// <summary>
        /// Gets and sets the property BotExists. 
        /// <para>
        /// Indicates whether a data retention bot exists in the network.
        /// </para>
        /// </summary>
        public bool? BotExists
        {
            get { return this._botExists; }
            set { this._botExists = value; }
        }

        // Check to see if BotExists property is set
        internal bool IsSetBotExists()
        {
            return this._botExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the data retention bot.
        /// </para>
        /// </summary>
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property IsBotActive. 
        /// <para>
        /// Indicates whether the data retention bot is active and operational.
        /// </para>
        /// </summary>
        public bool? IsBotActive
        {
            get { return this._isBotActive; }
            set { this._isBotActive = value; }
        }

        // Check to see if IsBotActive property is set
        internal bool IsSetIsBotActive()
        {
            return this._isBotActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDataRetentionBotRegistered. 
        /// <para>
        /// Indicates whether the data retention bot has been registered with the network.
        /// </para>
        /// </summary>
        public bool? IsDataRetentionBotRegistered
        {
            get { return this._isDataRetentionBotRegistered; }
            set { this._isDataRetentionBotRegistered = value; }
        }

        // Check to see if IsDataRetentionBotRegistered property is set
        internal bool IsSetIsDataRetentionBotRegistered()
        {
            return this._isDataRetentionBotRegistered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDataRetentionServiceEnabled. 
        /// <para>
        /// Indicates whether the data retention service is enabled for the network.
        /// </para>
        /// </summary>
        public bool? IsDataRetentionServiceEnabled
        {
            get { return this._isDataRetentionServiceEnabled; }
            set { this._isDataRetentionServiceEnabled = value; }
        }

        // Check to see if IsDataRetentionServiceEnabled property is set
        internal bool IsSetIsDataRetentionServiceEnabled()
        {
            return this._isDataRetentionServiceEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPubkeyMsgAcked. 
        /// <para>
        /// Indicates whether the public key message has been acknowledged by the bot.
        /// </para>
        /// </summary>
        public bool? IsPubkeyMsgAcked
        {
            get { return this._isPubkeyMsgAcked; }
            set { this._isPubkeyMsgAcked = value; }
        }

        // Check to see if IsPubkeyMsgAcked property is set
        internal bool IsSetIsPubkeyMsgAcked()
        {
            return this._isPubkeyMsgAcked.HasValue; 
        }

    }
}
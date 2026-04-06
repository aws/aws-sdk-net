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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies the location of an identified issue within the bot configuration.
    /// </summary>
    public partial class IssueLocation
    {
        private string _botLocale;
        private string _intentId;
        private string _slotId;

        /// <summary>
        /// Gets and sets the property BotLocale. 
        /// <para>
        /// The locale identifier where the issue was found.
        /// </para>
        /// </summary>
        public string BotLocale
        {
            get { return this._botLocale; }
            set { this._botLocale = value; }
        }

        // Check to see if BotLocale property is set
        internal bool IsSetBotLocale()
        {
            return this._botLocale != null;
        }

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The intent identifier where the issue was found, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string IntentId
        {
            get { return this._intentId; }
            set { this._intentId = value; }
        }

        // Check to see if IntentId property is set
        internal bool IsSetIntentId()
        {
            return this._intentId != null;
        }

        /// <summary>
        /// Gets and sets the property SlotId. 
        /// <para>
        /// The slot identifier where the issue was found, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string SlotId
        {
            get { return this._slotId; }
            set { this._slotId = value; }
        }

        // Check to see if SlotId property is set
        internal bool IsSetSlotId()
        {
            return this._slotId != null;
        }

    }
}
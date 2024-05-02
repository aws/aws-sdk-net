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
    /// A statistical summary of the bot recommendation results.
    /// </summary>
    public partial class BotRecommendationResultStatistics
    {
        private IntentStatistics _intents;
        private SlotTypeStatistics _slotTypes;

        /// <summary>
        /// Gets and sets the property Intents. 
        /// <para>
        /// Statistical information about about the intents associated with the bot recommendation
        /// results.
        /// </para>
        /// </summary>
        public IntentStatistics Intents
        {
            get { return this._intents; }
            set { this._intents = value; }
        }

        // Check to see if Intents property is set
        internal bool IsSetIntents()
        {
            return this._intents != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypes. 
        /// <para>
        /// Statistical information about the slot types associated with the bot recommendation
        /// results.
        /// </para>
        /// </summary>
        public SlotTypeStatistics SlotTypes
        {
            get { return this._slotTypes; }
            set { this._slotTypes = value; }
        }

        // Check to see if SlotTypes property is set
        internal bool IsSetSlotTypes()
        {
            return this._slotTypes != null;
        }

    }
}
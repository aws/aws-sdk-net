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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains fields describing a condition by which to filter the intent stages. The expression
    /// may be understood as <code>name</code> <code>operator</code> <code>values</code>.
    /// For example:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>IntentName CO Book</code> – The intent name contains the string "Book."
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BotVersion EQ 2</code> – The bot version is equal to two.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The operators that each filter supports are listed below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BotAlias</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BotVersion</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LocaleId</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Modality</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Channel</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SessionId</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OriginatingRequestId</code> – <code>EQ</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>IntentName</code> – <code>EQ</code>, <code>CO</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>IntentStageName</code> – <code>EQ</code>, <code>CO</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AnalyticsIntentStageFilter
    {
        private AnalyticsIntentStageFilterName _name;
        private AnalyticsFilterOperator _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The category by which to filter the intent stages. The descriptions for each option
        /// are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BotAlias</code> – The name of the bot alias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BotVersion</code> – The version of the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LocaleId</code> – The locale of the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Modality</code> – The modality of the session with the bot (audio, DTMF, or
        /// text).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Channel</code> – The channel that the bot is integrated with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SessionId</code> – The identifier of the session with the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OriginatingRequestId</code> – The identifier of the first request in a session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IntentName</code> – The name of the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IntentStageName</code> – The stage in the intent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsIntentStageFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operation by which to filter the category. The following operations are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CO</code> – Contains
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EQ</code> – Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GT</code> – Greater than
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LT</code> – Less than
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The operators that each filter supports are listed below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BotAlias</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BotVersion</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LocaleId</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Modality</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Channel</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SessionId</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OriginatingRequestId</code> – <code>EQ</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IntentName</code> – <code>EQ</code>, <code>CO</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IntentStageName</code> – <code>EQ</code>, <code>CO</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsFilterOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array containing the values of the category by which to apply the operator to filter
        /// the results. You can provide multiple values if the operator is <code>EQ</code> or
        /// <code>CO</code>. If you provide multiple values, you filter for results that equal/contain
        /// any of the values. For example, if the <code>name</code>, <code>operator</code>, and
        /// <code>values</code> fields are <code>Modality</code>, <code>EQ</code>, and <code>[Speech,
        /// Text]</code>, the operation filters for results where the modality was either <code>Speech</code>
        /// or <code>Text</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
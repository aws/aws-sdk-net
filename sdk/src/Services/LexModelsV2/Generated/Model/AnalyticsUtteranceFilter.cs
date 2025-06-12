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
    /// Contains fields describing a condition by which to filter the utterances. The expression
    /// may be understood as <c>name</c> <c>operator</c> <c>values</c>. For example:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>LocaleId EQ Book</c> – The locale is the string "en".
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UtteranceText CO help</c> – The text of the utterance contains the string "help".
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The operators that each filter supports are listed below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>BotAlias</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>BotVersion</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LocaleId</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Modality</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Channel</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SessionId</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OriginatingRequestId</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UtteranceState</c> – <c>EQ</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UtteranceText</c> – <c>EQ</c>, <c>CO</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AnalyticsUtteranceFilter
    {
        private AnalyticsUtteranceFilterName _name;
        private AnalyticsFilterOperator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The category by which to filter the utterances. The descriptions for each option are
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BotAlias</c> – The name of the bot alias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BotVersion</c> – The version of the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LocaleId</c> – The locale of the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Modality</c> – The modality of the session with the bot (audio, DTMF, or text).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Channel</c> – The channel that the bot is integrated with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SessionId</c> – The identifier of the session with the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OriginatingRequestId</c> – The identifier of the first request in a session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtteranceState</c> – The state of the utterance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtteranceText</c> – The text in the utterance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsUtteranceFilterName Name
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
        ///  <c>CO</c> – Contains
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EQ</c> – Equals
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GT</c> – Greater than
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LT</c> – Less than
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The operators that each filter supports are listed below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BotAlias</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BotVersion</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LocaleId</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Modality</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Channel</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SessionId</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OriginatingRequestId</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtteranceState</c> – <c>EQ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtteranceText</c> – <c>EQ</c>, <c>CO</c>.
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
        /// the results. You can provide multiple values if the operator is <c>EQ</c> or <c>CO</c>.
        /// If you provide multiple values, you filter for results that equal/contain any of the
        /// values. For example, if the <c>name</c>, <c>operator</c>, and <c>values</c> fields
        /// are <c>Modality</c>, <c>EQ</c>, and <c>[Speech, Text]</c>, the operation filters for
        /// results where the modality was either <c>Speech</c> or <c>Text</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
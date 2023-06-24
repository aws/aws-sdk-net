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
    /// Container for the parameters to the BatchUpdateCustomVocabularyItem operation.
    /// Update a batch of custom vocabulary items for a given bot locale's custom vocabulary.
    /// </summary>
    public partial class BatchUpdateCustomVocabularyItemRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private List<CustomVocabularyItem> _customVocabularyItemList = new List<CustomVocabularyItem>();
        private string _localeId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with this custom vocabulary
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The identifier of the version of the bot associated with this custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CustomVocabularyItemList. 
        /// <para>
        /// A list of custom vocabulary items with updated fields. Each entry must contain a phrase
        /// and can optionally contain a displayAs and/or a weight.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<CustomVocabularyItem> CustomVocabularyItemList
        {
            get { return this._customVocabularyItemList; }
            set { this._customVocabularyItemList = value; }
        }

        // Check to see if CustomVocabularyItemList property is set
        internal bool IsSetCustomVocabularyItemList()
        {
            return this._customVocabularyItemList != null && this._customVocabularyItemList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale where this custom vocabulary is used. The
        /// string must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">
        /// Supported Languages </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

    }
}
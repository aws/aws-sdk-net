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
    /// Provides information about the bot or bot locale that you want to import. You can
    /// specify the <c>botImportSpecification</c> or the <c>botLocaleImportSpecification</c>,
    /// but not both.
    /// </summary>
    public partial class ImportResourceSpecification
    {
        private BotImportSpecification _botImportSpecification;
        private BotLocaleImportSpecification _botLocaleImportSpecification;
        private CustomVocabularyImportSpecification _customVocabularyImportSpecification;
        private TestSetImportResourceSpecification _testSetImportResourceSpecification;

        /// <summary>
        /// Gets and sets the property BotImportSpecification. 
        /// <para>
        /// Parameters for importing a bot.
        /// </para>
        /// </summary>
        public BotImportSpecification BotImportSpecification
        {
            get { return this._botImportSpecification; }
            set { this._botImportSpecification = value; }
        }

        // Check to see if BotImportSpecification property is set
        internal bool IsSetBotImportSpecification()
        {
            return this._botImportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property BotLocaleImportSpecification. 
        /// <para>
        /// Parameters for importing a bot locale.
        /// </para>
        /// </summary>
        public BotLocaleImportSpecification BotLocaleImportSpecification
        {
            get { return this._botLocaleImportSpecification; }
            set { this._botLocaleImportSpecification = value; }
        }

        // Check to see if BotLocaleImportSpecification property is set
        internal bool IsSetBotLocaleImportSpecification()
        {
            return this._botLocaleImportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CustomVocabularyImportSpecification.
        /// </summary>
        public CustomVocabularyImportSpecification CustomVocabularyImportSpecification
        {
            get { return this._customVocabularyImportSpecification; }
            set { this._customVocabularyImportSpecification = value; }
        }

        // Check to see if CustomVocabularyImportSpecification property is set
        internal bool IsSetCustomVocabularyImportSpecification()
        {
            return this._customVocabularyImportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetImportResourceSpecification. 
        /// <para>
        /// Specifications for the test set that is imported.
        /// </para>
        /// </summary>
        public TestSetImportResourceSpecification TestSetImportResourceSpecification
        {
            get { return this._testSetImportResourceSpecification; }
            set { this._testSetImportResourceSpecification = value; }
        }

        // Check to see if TestSetImportResourceSpecification property is set
        internal bool IsSetTestSetImportResourceSpecification()
        {
            return this._testSetImportResourceSpecification != null;
        }

    }
}
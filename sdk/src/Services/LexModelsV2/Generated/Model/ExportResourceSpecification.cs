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
    /// Provides information about the bot or bot locale that you want to export. You can
    /// specify the <c>botExportSpecification</c> or the <c>botLocaleExportSpecification</c>,
    /// but not both.
    /// </summary>
    public partial class ExportResourceSpecification
    {
        private BotExportSpecification _botExportSpecification;
        private BotLocaleExportSpecification _botLocaleExportSpecification;
        private CustomVocabularyExportSpecification _customVocabularyExportSpecification;
        private TestSetExportSpecification _testSetExportSpecification;

        /// <summary>
        /// Gets and sets the property BotExportSpecification. 
        /// <para>
        /// Parameters for exporting a bot.
        /// </para>
        /// </summary>
        public BotExportSpecification BotExportSpecification
        {
            get { return this._botExportSpecification; }
            set { this._botExportSpecification = value; }
        }

        // Check to see if BotExportSpecification property is set
        internal bool IsSetBotExportSpecification()
        {
            return this._botExportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property BotLocaleExportSpecification. 
        /// <para>
        /// Parameters for exporting a bot locale.
        /// </para>
        /// </summary>
        public BotLocaleExportSpecification BotLocaleExportSpecification
        {
            get { return this._botLocaleExportSpecification; }
            set { this._botLocaleExportSpecification = value; }
        }

        // Check to see if BotLocaleExportSpecification property is set
        internal bool IsSetBotLocaleExportSpecification()
        {
            return this._botLocaleExportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CustomVocabularyExportSpecification. 
        /// <para>
        /// The parameters required to export a custom vocabulary.
        /// </para>
        /// </summary>
        public CustomVocabularyExportSpecification CustomVocabularyExportSpecification
        {
            get { return this._customVocabularyExportSpecification; }
            set { this._customVocabularyExportSpecification = value; }
        }

        // Check to see if CustomVocabularyExportSpecification property is set
        internal bool IsSetCustomVocabularyExportSpecification()
        {
            return this._customVocabularyExportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TestSetExportSpecification. 
        /// <para>
        /// Specifications for the test set that is exported as a resource.
        /// </para>
        /// </summary>
        public TestSetExportSpecification TestSetExportSpecification
        {
            get { return this._testSetExportSpecification; }
            set { this._testSetExportSpecification = value; }
        }

        // Check to see if TestSetExportSpecification property is set
        internal bool IsSetTestSetExportSpecification()
        {
            return this._testSetExportSpecification != null;
        }

    }
}
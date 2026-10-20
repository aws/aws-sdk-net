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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides information about the bot or bot locale that you want to import. You can
    /// specify the <c>botImportSpecification</c> or the <c>botLocaleImportSpecification</c>,
    /// but not both.
    /// </summary>
    public partial class ImportResourceSpecification
    {
        /// <summary>
        /// Gets and sets the property BotImportSpecification. 
        /// <para>
        /// Parameters for importing a bot.
        /// </para>
        /// </summary>
        public BotImportSpecification BotImportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the BotImportSpecification property is set.
        /// </summary>
        internal bool IsSetBotImportSpecification() => this.BotImportSpecification != null;

        /// <summary>
        /// Gets and sets the property BotLocaleImportSpecification. 
        /// <para>
        /// Parameters for importing a bot locale.
        /// </para>
        /// </summary>
        public BotLocaleImportSpecification BotLocaleImportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the BotLocaleImportSpecification property is set.
        /// </summary>
        internal bool IsSetBotLocaleImportSpecification() => this.BotLocaleImportSpecification != null;

        /// <summary>
        /// Gets and sets the property CustomVocabularyImportSpecification.
        /// </summary>
        public CustomVocabularyImportSpecification CustomVocabularyImportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomVocabularyImportSpecification property is set.
        /// </summary>
        internal bool IsSetCustomVocabularyImportSpecification() => this.CustomVocabularyImportSpecification != null;

        /// <summary>
        /// Gets and sets the property TestSetImportResourceSpecification. 
        /// <para>
        /// Specifications for the test set that is imported.
        /// </para>
        /// </summary>
        public TestSetImportResourceSpecification TestSetImportResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the TestSetImportResourceSpecification property is set.
        /// </summary>
        internal bool IsSetTestSetImportResourceSpecification() => this.TestSetImportResourceSpecification != null;
    }
}

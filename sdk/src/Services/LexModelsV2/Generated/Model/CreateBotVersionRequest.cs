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
    /// Container for the parameters to the CreateBotVersion operation.
    /// Creates an immutable version of the bot. When you create the first version of a bot,
    /// Amazon Lex sets the version number to 1. Subsequent bot versions increase in an increment
    /// of 1. The version number will always represent the total number of versions created
    /// of the bot, not the current number of versions. If a bot version is deleted, that
    /// bot version number will not be reused.
    /// </summary>
    public partial class CreateBotVersionRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private Dictionary<string, BotVersionLocaleDetails> _botVersionLocaleSpecification = AWSConfigs.InitializeCollections ? new Dictionary<string, BotVersionLocaleDetails>() : null;
        private string _description;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot to create the version for.
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
        /// Gets and sets the property BotVersionLocaleSpecification. 
        /// <para>
        /// Specifies the locales that Amazon Lex adds to this version. You can choose the <c>Draft</c>
        /// version or any other previously published version for each locale. When you specify
        /// a source version, the locale data is copied from the source version to the new version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public Dictionary<string, BotVersionLocaleDetails> BotVersionLocaleSpecification
        {
            get { return this._botVersionLocaleSpecification; }
            set { this._botVersionLocaleSpecification = value; }
        }

        // Check to see if BotVersionLocaleSpecification property is set
        internal bool IsSetBotVersionLocaleSpecification()
        {
            return this._botVersionLocaleSpecification != null && (this._botVersionLocaleSpecification.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the version. Use the description to help identify the version in
        /// lists.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}
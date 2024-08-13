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
    /// This is the response object from the StartBotResourceGeneration operation.
    /// </summary>
    public partial class StartBotResourceGenerationResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private string _generationId;
        private string _generationInputPrompt;
        private GenerationStatus _generationStatus;
        private string _localeId;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot for which the generation request was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
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
        /// The version of the bot for which the generation request was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time at which the generation request was made.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The unique identifier of the generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string GenerationId
        {
            get { return this._generationId; }
            set { this._generationId = value; }
        }

        // Check to see if GenerationId property is set
        internal bool IsSetGenerationId()
        {
            return this._generationId != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationInputPrompt. 
        /// <para>
        /// The prompt that was used generate intents and slot types for the bot locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=2000)]
        public string GenerationInputPrompt
        {
            get { return this._generationInputPrompt; }
            set { this._generationInputPrompt = value; }
        }

        // Check to see if GenerationInputPrompt property is set
        internal bool IsSetGenerationInputPrompt()
        {
            return this._generationInputPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// The status of the generation request.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus
        {
            get { return this._generationStatus; }
            set { this._generationStatus = value; }
        }

        // Check to see if GenerationStatus property is set
        internal bool IsSetGenerationStatus()
        {
            return this._generationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot for which the generation request was made.
        /// </para>
        /// </summary>
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
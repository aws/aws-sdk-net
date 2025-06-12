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
    /// This is the response object from the DescribeBotResourceGeneration operation.
    /// </summary>
    public partial class DescribeBotResourceGenerationResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _generatedBotLocaleUrl;
        private string _generationId;
        private string _generationInputPrompt;
        private GenerationStatus _generationStatus;
        private DateTime? _lastUpdatedDateTime;
        private string _localeId;
        private string _modelArn;

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
        /// The date and time at which the item was generated.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons why the generation of bot resources through natural language description
        /// failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GeneratedBotLocaleUrl. 
        /// <para>
        /// The Amazon S3 location of the generated bot locale configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GeneratedBotLocaleUrl
        {
            get { return this._generatedBotLocaleUrl; }
            set { this._generatedBotLocaleUrl = value; }
        }

        // Check to see if GeneratedBotLocaleUrl property is set
        internal bool IsSetGeneratedBotLocaleUrl()
        {
            return this._generatedBotLocaleUrl != null;
        }

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The generation ID for which to return the generation details.
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
        /// The prompt used in the generation request.
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
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time at which the generated item was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the model used to generate the bot resources.
        /// </para>
        /// </summary>
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

    }
}
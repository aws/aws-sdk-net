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
    /// This is the response object from the DescribeBotResourceGeneration operation.
    /// </summary>
    public partial class DescribeBotResourceGenerationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot for which the generation request was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot for which the generation request was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time at which the item was generated.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons why the generation of bot resources through natural language description
        /// failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GeneratedBotLocaleUrl. 
        /// <para>
        /// The Amazon S3 location of the generated bot locale configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string GeneratedBotLocaleUrl { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedBotLocaleUrl property is set.
        /// </summary>
        internal bool IsSetGeneratedBotLocaleUrl() => this.GeneratedBotLocaleUrl != null;

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The generation ID for which to return the generation details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string GenerationId { get; set; }

        /// <summary>
        /// Checks to see if the GenerationId property is set.
        /// </summary>
        internal bool IsSetGenerationId() => this.GenerationId != null;

        /// <summary>
        /// Gets and sets the property GenerationInputPrompt. 
        /// <para>
        /// The prompt used in the generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 2000)]
        public string GenerationInputPrompt { get; set; }

        /// <summary>
        /// Checks to see if the GenerationInputPrompt property is set.
        /// </summary>
        internal bool IsSetGenerationInputPrompt() => this.GenerationInputPrompt != null;

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// The status of the generation request.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the GenerationStatus property is set.
        /// </summary>
        internal bool IsSetGenerationStatus() => this.GenerationStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time at which the generated item was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale of the bot for which the generation request was made.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the model used to generate the bot resources.
        /// </para>
        /// </summary>
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;
    }
}

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
    /// This is the response object from the CreateBotVersion operation.
    /// </summary>
    public partial class CreateBotVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The bot identifier specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotStatus. 
        /// <para>
        /// When you send a request to create or update a bot, Amazon Lex sets the status response
        /// element to <c>Creating</c>. After Amazon Lex builds the bot, it sets status to <c>Available</c>.
        /// If Amazon Lex can't build the bot, it sets status to <c>Failed</c>.
        /// </para>
        /// </summary>
        public BotStatus BotStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotStatus property is set.
        /// </summary>
        internal bool IsSetBotStatus() => this.BotStatus != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version number assigned to the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property BotVersionLocaleSpecification. 
        /// <para>
        /// The source versions used for each locale in the new version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, BotVersionLocaleDetails> BotVersionLocaleSpecification { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, BotVersionLocaleDetails>() : null;

        /// <summary>
        /// Checks to see if the BotVersionLocaleSpecification property is set.
        /// </summary>
        internal bool IsSetBotVersionLocaleSpecification() => this.BotVersionLocaleSpecification != null && (this.BotVersionLocaleSpecification.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the version specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}

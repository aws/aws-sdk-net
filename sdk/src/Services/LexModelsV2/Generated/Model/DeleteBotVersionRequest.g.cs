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
    /// Container for the parameters to the DeleteBotVersion operation. Deletes a specific
    /// version of a bot. To delete all versions of a bot, use the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DeleteBot.html">DeleteBot</a>
    /// operation.
    /// </summary>
    public partial class DeleteBotVersionRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// By default, Amazon Lex checks if any other resource, such as an alias or bot network,
        /// is using the bot version before it is deleted and throws a <c>ResourceInUseException</c>
        /// exception if the version is being used by another resource. Set this parameter to
        /// <c>true</c> to skip this check and remove the version even if it is being used by
        /// another resource.
        /// </para>
        /// </summary>
        public bool? SkipResourceInUseCheck { get; set; }

        /// <summary>
        /// Checks to see if the SkipResourceInUseCheck property is set.
        /// </summary>
        internal bool IsSetSkipResourceInUseCheck() => this.SkipResourceInUseCheck.HasValue;
    }
}

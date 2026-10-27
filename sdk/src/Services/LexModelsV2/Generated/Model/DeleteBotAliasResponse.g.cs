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
    /// This is the response object from the DeleteBotAlias operation.
    /// </summary>
    public partial class DeleteBotAliasResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The unique identifier of the bot alias to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotAliasStatus. 
        /// <para>
        /// The current status of the alias. The status is <c>Deleting</c> while the alias is
        /// in the process of being deleted. Once the alias is deleted, it will no longer appear
        /// in the list of aliases returned by the <c>ListBotAliases</c> operation.
        /// </para>
        /// </summary>
        public BotAliasStatus BotAliasStatus { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasStatus property is set.
        /// </summary>
        internal bool IsSetBotAliasStatus() => this.BotAliasStatus != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot that contains the alias to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;
    }
}

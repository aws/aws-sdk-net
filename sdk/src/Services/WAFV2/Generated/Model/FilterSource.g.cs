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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Information about the bot filter that was applied to the request. This structure is
    /// populated in the response when you filter by bot category, organization, or name.
    /// </summary>
    public partial class FilterSource
    {
        /// <summary>
        /// Gets and sets the property BotCategory. 
        /// <para>
        /// The bot category that was used to filter the results. For example, <c>ai</c> or <c>search_engine</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotCategory { get; set; }

        /// <summary>
        /// Checks to see if the BotCategory property is set.
        /// </summary>
        internal bool IsSetBotCategory() => this.BotCategory != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The bot name that was used to filter the results. For example, <c>gptbot</c> or <c>googlebot</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property BotOrganization. 
        /// <para>
        /// The bot organization that was used to filter the results. For example, <c>OpenAI</c>
        /// or <c>Google</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotOrganization { get; set; }

        /// <summary>
        /// Checks to see if the BotOrganization property is set.
        /// </summary>
        internal bool IsSetBotOrganization() => this.BotOrganization != null;
    }
}

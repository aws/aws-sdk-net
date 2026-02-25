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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
        private string _botCategory;
        private string _botName;
        private string _botOrganization;

        /// <summary>
        /// Gets and sets the property BotCategory. 
        /// <para>
        /// The bot category that was used to filter the results. For example, <c>ai</c> or <c>search_engine</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string BotCategory
        {
            get { return this._botCategory; }
            set { this._botCategory = value; }
        }

        // Check to see if BotCategory property is set
        internal bool IsSetBotCategory()
        {
            return this._botCategory != null;
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The bot name that was used to filter the results. For example, <c>gptbot</c> or <c>googlebot</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property BotOrganization. 
        /// <para>
        /// The bot organization that was used to filter the results. For example, <c>OpenAI</c>
        /// or <c>Google</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string BotOrganization
        {
            get { return this._botOrganization; }
            set { this._botOrganization = value; }
        }

        // Check to see if BotOrganization property is set
        internal bool IsSetBotOrganization()
        {
            return this._botOrganization != null;
        }

    }
}
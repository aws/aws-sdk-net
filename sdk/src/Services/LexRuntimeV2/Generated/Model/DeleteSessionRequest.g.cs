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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSession operation. Removes session information
    /// for a specified bot, alias, and user ID. <para> You can use this operation to restart
    /// a conversation with a bot. When you remove a session, the entire history of the session
    /// is removed so that you can start again. </para> <para> You don't need to delete a
    /// session. Sessions have a time limit and will expire. Set the session time limit when
    /// you create the bot. The default is 5 minutes, but you can specify anything between
    /// 1 minute and 24 hours. </para> <para> If you specify a bot or alias ID that doesn't
    /// exist, you receive a <c>BadRequestException.</c> </para> <para> If the locale doesn't
    /// exist in the bot, or if the locale hasn't been enables for the alias, you receive
    /// a <c>BadRequestException</c>. </para>
    /// </summary>
    public partial class DeleteSessionRequest : AmazonLexRuntimeV2Request
    {
        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotAliasId { get; set; }

        /// <summary>
        /// Checks to see if the BotAliasId property is set.
        /// </summary>
        internal bool IsSetBotAliasId() => this.BotAliasId != null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale where the session is in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}

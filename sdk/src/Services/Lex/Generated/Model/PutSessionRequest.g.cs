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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PutSession operation. Creates a new session or
    /// modifies an existing session with an Amazon Lex bot. Use this operation to enable
    /// your application to set the state of the bot. <para> For more information, see <a
    /// href="https://docs.aws.amazon.com/lex/latest/dg/how-session-api.html">Managing Sessions</a>.
    /// </para>
    /// </summary>
    public partial class PutSessionRequest : AmazonLexRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The message that Amazon Lex returns in the response can be either text or speech based
        /// depending on the value of this field.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>text/plain; charset=utf-8</c>, Amazon Lex returns text in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value begins with <c>audio/</c>, Amazon Lex returns speech in the response.
        /// Amazon Lex uses Amazon Polly to generate the speech in the configuration that you
        /// specify. For example, if you specify <c>audio/mpeg</c> as the value, Amazon Lex returns
        /// speech in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>audio/pcm</c>, the speech is returned as <c>audio/pcm</c> in 16-bit,
        /// little endian format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following are the accepted values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>audio/mpeg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/ogg</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/pcm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audio/*</c> (defaults to mpeg)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>text/plain; charset=utf-8</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of contexts active for the request. A context can be activated when a previous
        /// intent is fulfilled, or by including the context in the request,
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a list of contexts, Amazon Lex will use the current list of contexts
        /// for the session. If you specify an empty list, all contexts for the session are cleared.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 20)]
        public List<ActiveContext> ActiveContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<ActiveContext>() : null;

        /// <summary>
        /// Checks to see if the ActiveContexts property is set.
        /// </summary>
        internal bool IsSetActiveContexts() => this.ActiveContexts != null && (this.ActiveContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias in use for the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotAlias { get; set; }

        /// <summary>
        /// Checks to see if the BotAlias property is set.
        /// </summary>
        internal bool IsSetBotAlias() => this.BotAlias != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the bot that contains the session data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property DialogAction. 
        /// <para>
        /// Sets the next action that the bot should take to fulfill the conversation.
        /// </para>
        /// </summary>
        public DialogAction DialogAction { get; set; }

        /// <summary>
        /// Checks to see if the DialogAction property is set.
        /// </summary>
        internal bool IsSetDialogAction() => this.DialogAction != null;

        /// <summary>
        /// Gets and sets the property RecentIntentSummaryView. 
        /// <para>
        /// A summary of the recent intents for the bot. You can use the intent summary view to
        /// set a checkpoint label on an intent and modify attributes of intents. You can also
        /// use it to remove or add intent summary objects to the list.
        /// </para>
        ///  
        /// <para>
        /// An intent that you modify or add to the list must make sense for the bot. For example,
        /// the intent name must be valid for the bot. You must provide valid values for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>intentName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// slot names
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>slotToElict</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you send the <c>recentIntentSummaryView</c> parameter in a <c>PutSession</c> request,
        /// the contents of the new summary view replaces the old summary view. For example, if
        /// a <c>GetSession</c> request returns three intents in the summary view and you call
        /// <c>PutSession</c> with one intent in the summary view, the next call to <c>GetSession</c>
        /// will only return one intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<IntentSummary> RecentIntentSummaryView { get; set; } = AWSConfigs.InitializeCollections ? new List<IntentSummary>() : null;

        /// <summary>
        /// Checks to see if the RecentIntentSummaryView property is set.
        /// </summary>
        internal bool IsSetRecentIntentSummaryView() => this.RecentIntentSummaryView != null && (this.RecentIntentSummaryView.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing the session-specific context information. It contains
        /// application information passed between Amazon Lex and a client application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> SessionAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SessionAttributes property is set.
        /// </summary>
        internal bool IsSetSessionAttributes() => this.SessionAttributes != null && (this.SessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}

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
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of active contexts for the session. A context can be set when an intent is
        /// fulfilled or by calling the <c>PostContent</c>, <c>PostText</c>, or <c>PutSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You can use a context to control the intents that can follow up an intent, or to modify
        /// the operation of your application.
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
        /// Gets and sets the property DialogAction. 
        /// <para>
        /// Describes the current state of the bot.
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
        /// An array of information about the intents used in the session. The array can contain
        /// a maximum of three summaries. If more than three intents are used in the session,
        /// the <c>recentIntentSummaryView</c> operation contains information about the last three
        /// intents used.
        /// </para>
        ///  
        /// <para>
        /// If you set the <c>checkpointLabelFilter</c> parameter in the request, the array contains
        /// only the intents with the specified label.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}

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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        private List<ActiveContext> _activeContexts = new List<ActiveContext>();
        private DialogAction _dialogAction;
        private List<IntentSummary> _recentIntentSummaryView = new List<IntentSummary>();
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of active contexts for the session. A context can be set when an intent is
        /// fulfilled or by calling the <code>PostContent</code>, <code>PostText</code>, or <code>PutSession</code>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You can use a context to control the intents that can follow up an intent, or to modify
        /// the operation of your application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public List<ActiveContext> ActiveContexts
        {
            get { return this._activeContexts; }
            set { this._activeContexts = value; }
        }

        // Check to see if ActiveContexts property is set
        internal bool IsSetActiveContexts()
        {
            return this._activeContexts != null && this._activeContexts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DialogAction. 
        /// <para>
        /// Describes the current state of the bot.
        /// </para>
        /// </summary>
        public DialogAction DialogAction
        {
            get { return this._dialogAction; }
            set { this._dialogAction = value; }
        }

        // Check to see if DialogAction property is set
        internal bool IsSetDialogAction()
        {
            return this._dialogAction != null;
        }

        /// <summary>
        /// Gets and sets the property RecentIntentSummaryView. 
        /// <para>
        /// An array of information about the intents used in the session. The array can contain
        /// a maximum of three summaries. If more than three intents are used in the session,
        /// the <code>recentIntentSummaryView</code> operation contains information about the
        /// last three intents used.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>checkpointLabelFilter</code> parameter in the request, the array
        /// contains only the intents with the specified label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<IntentSummary> RecentIntentSummaryView
        {
            get { return this._recentIntentSummaryView; }
            set { this._recentIntentSummaryView = value; }
        }

        // Check to see if RecentIntentSummaryView property is set
        internal bool IsSetRecentIntentSummaryView()
        {
            return this._recentIntentSummaryView != null && this._recentIntentSummaryView.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing the session-specific context information. It contains
        /// application information passed between Amazon Lex and a client application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && this._sessionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the session.
        /// </para>
        /// </summary>
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}
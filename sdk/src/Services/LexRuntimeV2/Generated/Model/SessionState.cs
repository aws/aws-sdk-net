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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The state of the user's session with Amazon Lex.
    /// </summary>
    public partial class SessionState
    {
        private List<ActiveContext> _activeContexts = new List<ActiveContext>();
        private DialogAction _dialogAction;
        private Intent _intent;
        private string _originatingRequestId;
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// One or more contexts that indicate to Amazon Lex the context of a request. When a
        /// context is active, Amazon Lex considers intents with the matching context as a trigger
        /// as the next intent in a session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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
        /// The next step that Amazon Lex should take in the conversation with a user.
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
        /// Gets and sets the property Intent. 
        /// <para>
        /// The active intent that Amazon Lex is processing.
        /// </para>
        /// </summary>
        public Intent Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

        /// <summary>
        /// Gets and sets the property OriginatingRequestId.
        /// </summary>
        [AWSProperty(Min=1)]
        public string OriginatingRequestId
        {
            get { return this._originatingRequestId; }
            set { this._originatingRequestId = value; }
        }

        // Check to see if OriginatingRequestId property is set
        internal bool IsSetOriginatingRequestId()
        {
            return this._originatingRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing session-specific context information. It contains
        /// application information passed between Amazon Lex and a client application.
        /// </para>
        /// </summary>
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

    }
}
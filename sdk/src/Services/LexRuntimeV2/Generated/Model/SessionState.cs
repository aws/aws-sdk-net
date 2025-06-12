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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The state of the user's session with Amazon Lex V2.
    /// </summary>
    public partial class SessionState
    {
        private List<ActiveContext> _activeContexts = AWSConfigs.InitializeCollections ? new List<ActiveContext>() : null;
        private DialogAction _dialogAction;
        private Intent _intent;
        private string _originatingRequestId;
        private RuntimeHints _runtimeHints;
        private Dictionary<string, string> _sessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// One or more contexts that indicate to Amazon Lex V2 the context of a request. When
        /// a context is active, Amazon Lex V2 considers intents with the matching context as
        /// a trigger as the next intent in a session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._activeContexts != null && (this._activeContexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DialogAction. 
        /// <para>
        /// The next step that Amazon Lex V2 should take in the conversation with a user.
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
        /// The active intent that Amazon Lex V2 is processing.
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
        /// <para>
        /// A unique identifier for a specific request.
        /// </para>
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
        /// Gets and sets the property RuntimeHints. 
        /// <para>
        /// Hints for phrases that a customer is likely to use for a slot. Amazon Lex V2 uses
        /// the hints to help determine the correct value of a slot.
        /// </para>
        /// </summary>
        public RuntimeHints RuntimeHints
        {
            get { return this._runtimeHints; }
            set { this._runtimeHints = value; }
        }

        // Check to see if RuntimeHints property is set
        internal bool IsSetRuntimeHints()
        {
            return this._runtimeHints != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing session-specific context information. It contains
        /// application information passed between Amazon Lex V2 and a client application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && (this._sessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
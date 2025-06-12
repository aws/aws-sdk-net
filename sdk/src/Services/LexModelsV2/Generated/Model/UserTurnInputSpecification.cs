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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// Contains information about the user messages in the turn in the input.
    /// </summary>
    public partial class UserTurnInputSpecification
    {
        private Dictionary<string, string> _requestAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private InputSessionStateSpecification _sessionState;
        private UtteranceInputSpecification _utteranceInput;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request attributes of the user turn.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && (this._requestAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionState. 
        /// <para>
        /// Contains information about the session state in the input.
        /// </para>
        /// </summary>
        public InputSessionStateSpecification SessionState
        {
            get { return this._sessionState; }
            set { this._sessionState = value; }
        }

        // Check to see if SessionState property is set
        internal bool IsSetSessionState()
        {
            return this._sessionState != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceInput. 
        /// <para>
        /// The utterance input in the user turn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UtteranceInputSpecification UtteranceInput
        {
            get { return this._utteranceInput; }
            set { this._utteranceInput = value; }
        }

        // Check to see if UtteranceInput property is set
        internal bool IsSetUtteranceInput()
        {
            return this._utteranceInput != null;
        }

    }
}
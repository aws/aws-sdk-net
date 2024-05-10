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
    /// Specifies the prompts that Amazon Lex uses while a bot is waiting for customer input.
    /// </summary>
    public partial class WaitAndContinueSpecification
    {
        private bool? _active;
        private ResponseSpecification _continueResponse;
        private StillWaitingResponseSpecification _stillWaitingResponse;
        private ResponseSpecification _waitingResponse;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether the bot will wait for a user to respond. When this field is false,
        /// wait and continue responses for a slot aren't used. If the <c>active</c> field isn't
        /// specified, the default is true.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContinueResponse. 
        /// <para>
        /// The response that Amazon Lex sends to indicate that the bot is ready to continue the
        /// conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseSpecification ContinueResponse
        {
            get { return this._continueResponse; }
            set { this._continueResponse = value; }
        }

        // Check to see if ContinueResponse property is set
        internal bool IsSetContinueResponse()
        {
            return this._continueResponse != null;
        }

        /// <summary>
        /// Gets and sets the property StillWaitingResponse. 
        /// <para>
        /// A response that Amazon Lex sends periodically to the user to indicate that the bot
        /// is still waiting for input from the user.
        /// </para>
        /// </summary>
        public StillWaitingResponseSpecification StillWaitingResponse
        {
            get { return this._stillWaitingResponse; }
            set { this._stillWaitingResponse = value; }
        }

        // Check to see if StillWaitingResponse property is set
        internal bool IsSetStillWaitingResponse()
        {
            return this._stillWaitingResponse != null;
        }

        /// <summary>
        /// Gets and sets the property WaitingResponse. 
        /// <para>
        /// The response that Amazon Lex sends to indicate that the bot is waiting for the conversation
        /// to continue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseSpecification WaitingResponse
        {
            get { return this._waitingResponse; }
            set { this._waitingResponse = value; }
        }

        // Check to see if WaitingResponse property is set
        internal bool IsSetWaitingResponse()
        {
            return this._waitingResponse != null;
        }

    }
}
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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides a prompt for making sure that the user is ready for the intent to be fulfilled.
    /// </summary>
    public partial class IntentConfirmationSetting
    {
        private bool? _active;
        private ResponseSpecification _declinationResponse;
        private PromptSpecification _promptSpecification;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether the intent's confirmation is sent to the user. When this field is
        /// false, confirmation and declination responses aren't sent. If the <code>active</code>
        /// field isn't specified, the default is true.
        /// </para>
        /// </summary>
        public bool Active
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeclinationResponse. 
        /// <para>
        /// When the user answers "no" to the question defined in <code>promptSpecification</code>,
        /// Amazon Lex responds with this response to acknowledge that the intent was canceled.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseSpecification DeclinationResponse
        {
            get { return this._declinationResponse; }
            set { this._declinationResponse = value; }
        }

        // Check to see if DeclinationResponse property is set
        internal bool IsSetDeclinationResponse()
        {
            return this._declinationResponse != null;
        }

        /// <summary>
        /// Gets and sets the property PromptSpecification. 
        /// <para>
        /// Prompts the user to confirm the intent. This question should have a yes or no answer.
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex uses this prompt to ensure that the user acknowledges that the intent is
        /// ready for fulfillment. For example, with the <code>OrderPizza</code> intent, you might
        /// want to confirm that the order is correct before placing it. For other intents, such
        /// as intents that simply respond to user questions, you might not need to ask the user
        /// for confirmation before providing the information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PromptSpecification PromptSpecification
        {
            get { return this._promptSpecification; }
            set { this._promptSpecification = value; }
        }

        // Check to see if PromptSpecification property is set
        internal bool IsSetPromptSpecification()
        {
            return this._promptSpecification != null;
        }

    }
}
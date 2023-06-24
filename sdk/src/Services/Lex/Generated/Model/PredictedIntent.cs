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
    /// An intent that Amazon Lex suggests satisfies the user's intent. Includes the name
    /// of the intent, the confidence that Amazon Lex has that the user's intent is satisfied,
    /// and the slots defined for the intent.
    /// </summary>
    public partial class PredictedIntent
    {
        private string _intentName;
        private IntentConfidence _nluIntentConfidence;
        private Dictionary<string, string> _slots = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent that Amazon Lex suggests satisfies the user's intent.
        /// </para>
        /// </summary>
        public string IntentName
        {
            get { return this._intentName; }
            set { this._intentName = value; }
        }

        // Check to see if IntentName property is set
        internal bool IsSetIntentName()
        {
            return this._intentName != null;
        }

        /// <summary>
        /// Gets and sets the property NluIntentConfidence. 
        /// <para>
        /// Indicates how confident Amazon Lex is that an intent satisfies the user's intent.
        /// </para>
        /// </summary>
        public IntentConfidence NluIntentConfidence
        {
            get { return this._nluIntentConfidence; }
            set { this._nluIntentConfidence = value; }
        }

        // Check to see if NluIntentConfidence property is set
        internal bool IsSetNluIntentConfidence()
        {
            return this._nluIntentConfidence != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// The slot and slot values associated with the predicted intent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null && this._slots.Count > 0; 
        }

    }
}
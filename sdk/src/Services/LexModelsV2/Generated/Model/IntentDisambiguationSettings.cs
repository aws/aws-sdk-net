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
    /// Configures the Intent Disambiguation feature that helps resolve ambiguous user inputs
    /// when multiple intents could match. When enabled, the system presents clarifying questions
    /// to users, helping them specify their exact intent for improved conversation accuracy.
    /// </summary>
    public partial class IntentDisambiguationSettings
    {
        private string _customDisambiguationMessage;
        private bool? _enabled;
        private int? _maxDisambiguationIntents;

        /// <summary>
        /// Gets and sets the property CustomDisambiguationMessage. 
        /// <para>
        /// Provides a custom message that will be displayed before presenting the disambiguation
        /// options to users. This message helps set the context for users and can be customized
        /// to match your bot's tone and brand. If not specified, a default message will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string CustomDisambiguationMessage
        {
            get { return this._customDisambiguationMessage; }
            set { this._customDisambiguationMessage = value; }
        }

        // Check to see if CustomDisambiguationMessage property is set
        internal bool IsSetCustomDisambiguationMessage()
        {
            return this._customDisambiguationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Determines whether the Intent Disambiguation feature is enabled. When set to <c>true</c>,
        /// Amazon Lex will present disambiguation options to users when multiple intents could
        /// match their input, with the default being <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDisambiguationIntents. 
        /// <para>
        /// Specifies the maximum number of intent options (2-5) to present to users when disambiguation
        /// is needed. This setting determines how many intent options will be shown to users
        /// when the system detects ambiguous input. The default value is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public int? MaxDisambiguationIntents
        {
            get { return this._maxDisambiguationIntents; }
            set { this._maxDisambiguationIntents = value; }
        }

        // Check to see if MaxDisambiguationIntents property is set
        internal bool IsSetMaxDisambiguationIntents()
        {
            return this._maxDisambiguationIntents.HasValue; 
        }

    }
}
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
    /// Provides summary information about a built-in intent for the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBuiltInIntents.html">
    /// ListBuiltInIntents </a> operation.
    /// </summary>
    public partial class BuiltInIntentSummary
    {
        private string _description;
        private string _intentSignature;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IntentSignature. 
        /// <para>
        /// The signature of the built-in intent. Use this to specify the parent intent of a derived
        /// intent.
        /// </para>
        /// </summary>
        public string IntentSignature
        {
            get { return this._intentSignature; }
            set { this._intentSignature = value; }
        }

        // Check to see if IntentSignature property is set
        internal bool IsSetIntentSignature()
        {
            return this._intentSignature != null;
        }

    }
}
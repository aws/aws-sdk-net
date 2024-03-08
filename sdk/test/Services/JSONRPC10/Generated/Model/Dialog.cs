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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.JSONRPC10.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Dialog
    {
        private Farewell _farewell;
        private string _greeting;
        private string _language;

        /// <summary>
        /// Gets and sets the property Farewell.
        /// </summary>
        public Farewell Farewell
        {
            get { return this._farewell; }
            set { this._farewell = value; }
        }

        // Check to see if Farewell property is set
        internal bool IsSetFarewell()
        {
            return this._farewell != null;
        }

        /// <summary>
        /// Gets and sets the property Greeting.
        /// </summary>
        public string Greeting
        {
            get { return this._greeting; }
            set { this._greeting = value; }
        }

        // Check to see if Greeting property is set
        internal bool IsSetGreeting()
        {
            return this._greeting != null;
        }

        /// <summary>
        /// Gets and sets the property Language.
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}
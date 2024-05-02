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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Specifies a Lambda function that verifies requests to a bot or fulfills the user's
    /// request to a bot..
    /// </summary>
    public partial class CodeHook
    {
        private string _messageVersion;
        private string _uri;

        /// <summary>
        /// Gets and sets the property MessageVersion. 
        /// <para>
        /// The version of the request-response that you want Amazon Lex to use to invoke your
        /// Lambda function. For more information, see <a>using-lambda</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string MessageVersion
        {
            get { return this._messageVersion; }
            set { this._messageVersion = value; }
        }

        // Check to see if MessageVersion property is set
        internal bool IsSetMessageVersion()
        {
            return this._messageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about a proactive recommendation, including the token used to retrieve its
    /// chunked response with <c>GetNextMessage</c>.
    /// </summary>
    public partial class ProactiveRecommendationDataDetails
    {
        private string _nextMessageToken;

        /// <summary>
        /// Gets and sets the property NextMessageToken. 
        /// <para>
        /// The token used to retrieve the next message in the proactive recommendation. Pass
        /// this token in a <c>GetNextMessage</c> request to continue receiving the chunked proactive
        /// response. Each response returns the next token to use until the chunked response is
        /// complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string NextMessageToken
        {
            get { return this._nextMessageToken; }
            set { this._nextMessageToken = value; }
        }

        // Check to see if NextMessageToken property is set
        internal bool IsSetNextMessageToken()
        {
            return this._nextMessageToken != null;
        }

    }
}
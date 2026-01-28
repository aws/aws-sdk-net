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
    /// Details about case summarization chunk data.
    /// </summary>
    public partial class CaseSummarizationChunkDataDetails
    {
        private string _completion;
        private string _nextChunkToken;

        /// <summary>
        /// Gets and sets the property Completion. 
        /// <para>
        /// A chunk of the case summarization completion.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Completion
        {
            get { return this._completion; }
            set { this._completion = value; }
        }

        // Check to see if Completion property is set
        internal bool IsSetCompletion()
        {
            return this._completion != null;
        }

        /// <summary>
        /// Gets and sets the property NextChunkToken. 
        /// <para>
        /// Token for retrieving the next chunk of streaming summarization data, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextChunkToken
        {
            get { return this._nextChunkToken; }
            set { this._nextChunkToken = value; }
        }

        // Check to see if NextChunkToken property is set
        internal bool IsSetNextChunkToken()
        {
            return this._nextChunkToken != null;
        }

    }
}
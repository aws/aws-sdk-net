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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Details of streaming chunk data for email responses including completion text and
    /// pagination tokens.
    /// </summary>
    public partial class EmailResponseChunkDataDetails
    {
        /// <summary>
        /// Gets and sets the property Completion. 
        /// <para>
        /// The partial or complete professional email response text with appropriate greetings
        /// and closings.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Completion { get; set; }

        /// <summary>
        /// Checks to see if the Completion property is set.
        /// </summary>
        internal bool IsSetCompletion() => this.Completion != null;

        /// <summary>
        /// Gets and sets the property NextChunkToken. 
        /// <para>
        /// Token for retrieving the next chunk of streaming response data, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextChunkToken { get; set; }

        /// <summary>
        /// Checks to see if the NextChunkToken property is set.
        /// </summary>
        internal bool IsSetNextChunkToken() => this.NextChunkToken != null;
    }
}

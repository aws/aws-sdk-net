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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
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
namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the GetSpeechSynthesisTask operation.
    /// </summary>
    public partial class GetSpeechSynthesisTaskResponse : AmazonWebServiceResponse
    {
        private SynthesisTask _synthesisTask;

        /// <summary>
        /// Gets and sets the property SynthesisTask. 
        /// <para>
        /// SynthesisTask object that provides information from the requested task, including
        /// output format, creation time, task status, and so on.
        /// </para>
        /// </summary>
        public SynthesisTask SynthesisTask
        {
            get { return this._synthesisTask; }
            set { this._synthesisTask = value; }
        }

        // Check to see if SynthesisTask property is set
        internal bool IsSetSynthesisTask()
        {
            return this._synthesisTask != null;
        }

    }
}
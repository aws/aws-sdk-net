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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the GetActivityTask operation.
    /// </summary>
    public partial class GetActivityTaskResponse : AmazonWebServiceResponse
    {
        private string _input;
        private string _taskToken;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The string that contains the JSON input data for the task. Length constraints apply
        /// to the payload size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=262144)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// A token that identifies the scheduled task. This token must be copied and included
        /// in subsequent calls to <a>SendTaskHeartbeat</a>, <a>SendTaskSuccess</a> or <a>SendTaskFailure</a>
        /// in order to report the progress or completion of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TaskToken
        {
            get { return this._taskToken; }
            set { this._taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this._taskToken != null;
        }

    }
}
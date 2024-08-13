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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Provides details in the event of a failed flow, including the failure count and the
    /// related error messages.
    /// </summary>
    public partial class ErrorInfo
    {
        private string _executionMessage;
        private long? _putFailuresCount;

        /// <summary>
        /// Gets and sets the property ExecutionMessage. 
        /// <para>
        ///  Specifies the error message that appears if a flow fails. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ExecutionMessage
        {
            get { return this._executionMessage; }
            set { this._executionMessage = value; }
        }

        // Check to see if ExecutionMessage property is set
        internal bool IsSetExecutionMessage()
        {
            return this._executionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property PutFailuresCount. 
        /// <para>
        ///  Specifies the failure count for the attempted flow. 
        /// </para>
        /// </summary>
        public long? PutFailuresCount
        {
            get { return this._putFailuresCount; }
            set { this._putFailuresCount = value; }
        }

        // Check to see if PutFailuresCount property is set
        internal bool IsSetPutFailuresCount()
        {
            return this._putFailuresCount.HasValue; 
        }

    }
}
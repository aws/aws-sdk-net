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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Provides details in the event of a failed flow, including the failure count and the
    /// related error messages.
    /// </summary>
    public partial class ErrorInfo
    {
        /// <summary>
        /// Gets and sets the property ExecutionMessage. 
        /// <para>
        ///  Specifies the error message that appears if a flow fails. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ExecutionMessage { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionMessage property is set.
        /// </summary>
        internal bool IsSetExecutionMessage() => this.ExecutionMessage != null;

        /// <summary>
        /// Gets and sets the property PutFailuresCount. 
        /// <para>
        ///  Specifies the failure count for the attempted flow. 
        /// </para>
        /// </summary>
        public long? PutFailuresCount { get; set; }

        /// <summary>
        /// Checks to see if the PutFailuresCount property is set.
        /// </summary>
        internal bool IsSetPutFailuresCount() => this.PutFailuresCount.HasValue;
    }
}

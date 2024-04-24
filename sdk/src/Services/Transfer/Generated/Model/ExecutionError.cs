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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the error message and type, for an error that occurs during the execution
    /// of the workflow.
    /// </summary>
    public partial class ExecutionError
    {
        private string _message;
        private ExecutionErrorType _type;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies the descriptive message that corresponds to the <c>ErrorType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the error type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALREADY_EXISTS</c>: occurs for a copy step, if the overwrite option is not selected
        /// and a file with the same name already exists in the target location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BAD_REQUEST</c>: a general bad request: for example, a step that attempts to tag
        /// an EFS file returns <c>BAD_REQUEST</c>, as only S3 files can be tagged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_STEP_FAILED</c>: occurs when the custom step provided a callback that indicates
        /// failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_SERVER_ERROR</c>: a catch-all error that can occur for a variety of reasons.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_FOUND</c>: occurs when a requested entity, for example a source file for a
        /// copy step, does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERMISSION_DENIED</c>: occurs if your policy does not contain the correct permissions
        /// to complete one or more of the steps in the workflow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMEOUT</c>: occurs when the execution times out.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can set the <c>TimeoutSeconds</c> for a custom step, anywhere from 1 second to
        /// 1800 seconds (30 minutes). 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>THROTTLED</c>: occurs if you exceed the new execution refill rate of one workflow
        /// per second.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionErrorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
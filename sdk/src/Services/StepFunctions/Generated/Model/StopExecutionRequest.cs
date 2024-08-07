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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Container for the parameters to the StopExecution operation.
    /// Stops an execution.
    /// 
    ///  
    /// <para>
    /// This API action is not supported by <c>EXPRESS</c> state machines.
    /// </para>
    ///  
    /// <para>
    /// For an execution with encryption enabled, Step Functions will encrypt the error and
    /// cause fields using the KMS key for the execution role.
    /// </para>
    ///  
    /// <para>
    /// A caller can stop an execution without using any KMS permissions in the execution
    /// role if the caller provides a null value for both <c>error</c> and <c>cause</c> fields
    /// because no data needs to be encrypted.
    /// </para>
    /// </summary>
    public partial class StopExecutionRequest : AmazonStepFunctionsRequest
    {
        private string _cause;
        private string _error;
        private string _executionArn;

        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// A more detailed explanation of the cause of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=32768)]
        public string Cause
        {
            get { return this._cause; }
            set { this._cause = value; }
        }

        // Check to see if Cause property is set
        internal bool IsSetCause()
        {
            return this._cause != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error code of the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

    }
}
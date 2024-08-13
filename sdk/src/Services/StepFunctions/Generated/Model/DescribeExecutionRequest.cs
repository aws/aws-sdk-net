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
    /// Container for the parameters to the DescribeExecution operation.
    /// Provides information about a state machine execution, such as the state machine associated
    /// with the execution, the execution input and output, and relevant execution metadata.
    /// If you've <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-executions.html">redriven</a>
    /// an execution, you can use this API action to return information about the redrives
    /// of that execution. In addition, you can use this API action to return the Map Run
    /// Amazon Resource Name (ARN) if the execution was dispatched by a Map Run.
    /// 
    ///  
    /// <para>
    /// If you specify a version or alias ARN when you call the <a>StartExecution</a> API
    /// action, <c>DescribeExecution</c> returns that ARN.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is eventually consistent. The results are best effort and may not reflect
    /// very recent updates and changes.
    /// </para>
    ///  </note> 
    /// <para>
    /// Executions of an <c>EXPRESS</c> state machine aren't supported by <c>DescribeExecution</c>
    /// unless a Map Run dispatched them.
    /// </para>
    /// </summary>
    public partial class DescribeExecutionRequest : AmazonStepFunctionsRequest
    {
        private string _executionArn;
        private IncludedData _includedData;

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution to describe.
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

        /// <summary>
        /// Gets and sets the property IncludedData. 
        /// <para>
        /// If your state machine definition is encrypted with a KMS key, callers must have <c>kms:Decrypt</c>
        /// permission to decrypt the definition. Alternatively, you can call DescribeStateMachine
        /// API with <c>includedData = METADATA_ONLY</c> to get a successful response without
        /// the encrypted definition.
        /// </para>
        /// </summary>
        public IncludedData IncludedData
        {
            get { return this._includedData; }
            set { this._includedData = value; }
        }

        // Check to see if IncludedData property is set
        internal bool IsSetIncludedData()
        {
            return this._includedData != null;
        }

    }
}
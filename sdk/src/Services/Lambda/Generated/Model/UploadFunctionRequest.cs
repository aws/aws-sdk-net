/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the UploadFunction operation.
    /// Creates a new Lambda function or updates an existing function. The function metadata
    /// is created from the request parameters, and the code for the function is provided
    /// by a .zip file in the request body. If the function name already exists, the existing
    /// Lambda function is updated with the new code and metadata. 
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:UploadFunction</code> action.
    /// </para>
    /// </summary>
    public partial class UploadFunctionRequest : AmazonLambdaRequest
    {
        private string _description;
        private string _functionName;
        private Stream _functionZip;
        private string _handler;
        private int? _memorySize;
        private Mode _mode;
        private string _role;
        private Runtime _runtime;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short, user-defined function description. Lambda does not use this value. Assign
        /// a meaningful description as you see fit.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name you want to assign to the function you are uploading. The function names
        /// appear in the console and are returned in the <a>ListFunctions</a> API. Function names
        /// are used to specify functions to other AWS Lambda APIs, such as <a>InvokeAsync</a>.
        /// 
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionZip. 
        /// <para>
        /// A .zip file containing your packaged source code. For more information about creating
        /// a .zip file, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/walkthrough-custom-events.html">AWS
        /// LambdaL How it Works</a> in the AWS Lambda Developer Guide. 
        /// </para>
        /// </summary>
        public Stream FunctionZip
        {
            get { return this._functionZip; }
            set { this._functionZip = value; }
        }

        // Check to see if FunctionZip property is set
        internal bool IsSetFunctionZip()
        {
            return this._functionZip != null;
        }

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The function that Lambda calls to begin execution. For Node.js, it is the <i>module-name</i>.<i>export</i>
        /// value in your function. 
        /// </para>
        /// </summary>
        public string Handler
        {
            get { return this._handler; }
            set { this._handler = value; }
        }

        // Check to see if Handler property is set
        internal bool IsSetHandler()
        {
            return this._handler != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySize. 
        /// <para>
        /// The amount of memory, in MB, your Lambda function is given. Lambda uses this memory
        /// size to infer the amount of CPU allocated to your function. Your function use-case
        /// determines your CPU and memory requirements. For example, database operation might
        /// need less memory compared to image processing function. The default value is 128 MB.
        /// The value must be a multiple of 64 MB.
        /// </para>
        /// </summary>
        public int MemorySize
        {
            get { return this._memorySize.GetValueOrDefault(); }
            set { this._memorySize = value; }
        }

        // Check to see if MemorySize property is set
        internal bool IsSetMemorySize()
        {
            return this._memorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// How the Lambda function will be invoked. Lambda supports only the "event" mode. 
        /// </para>
        /// </summary>
        public Mode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Lambda assumes when it executes
        /// your function to access any other Amazon Web Services (AWS) resources. 
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime environment for the Lambda function you are uploading. Currently, Lambda
        /// supports only "nodejs" as the runtime.
        /// </para>
        /// </summary>
        public Runtime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The function execution time at which Lambda should terminate the function. Because
        /// the execution time has cost implications, we recommend you set this value based on
        /// your expected execution time. The default is 3 seconds. 
        /// </para>
        /// </summary>
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}
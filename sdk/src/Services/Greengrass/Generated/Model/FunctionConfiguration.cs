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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// The configuration of the Lambda function.
    /// </summary>
    public partial class FunctionConfiguration
    {
        private EncodingType _encodingType;
        private FunctionConfigurationEnvironment _environment;
        private string _execArgs;
        private string _executable;
        private string _functionRuntimeOverride;
        private int? _memorySize;
        private bool? _pinned;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property EncodingType. The expected encoding type of the input payload
        /// for the function. The default is ''json''.
        /// </summary>
        public EncodingType EncodingType
        {
            get { return this._encodingType; }
            set { this._encodingType = value; }
        }

        // Check to see if EncodingType property is set
        internal bool IsSetEncodingType()
        {
            return this._encodingType != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. The environment configuration of the function.
        /// </summary>
        public FunctionConfigurationEnvironment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property ExecArgs. The execution arguments.
        /// </summary>
        public string ExecArgs
        {
            get { return this._execArgs; }
            set { this._execArgs = value; }
        }

        // Check to see if ExecArgs property is set
        internal bool IsSetExecArgs()
        {
            return this._execArgs != null;
        }

        /// <summary>
        /// Gets and sets the property Executable. The name of the function executable.
        /// </summary>
        public string Executable
        {
            get { return this._executable; }
            set { this._executable = value; }
        }

        // Check to see if Executable property is set
        internal bool IsSetExecutable()
        {
            return this._executable != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionRuntimeOverride. The Lambda runtime supported by
        /// Greengrass which is to be used instead of the one specified in the Lambda function.
        /// </summary>
        public string FunctionRuntimeOverride
        {
            get { return this._functionRuntimeOverride; }
            set { this._functionRuntimeOverride = value; }
        }

        // Check to see if FunctionRuntimeOverride property is set
        internal bool IsSetFunctionRuntimeOverride()
        {
            return this._functionRuntimeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property MemorySize. The memory size, in KB, which the function
        /// requires. This setting is not applicable and should be cleared when you run the Lambda
        /// function without containerization.
        /// </summary>
        public int? MemorySize
        {
            get { return this._memorySize; }
            set { this._memorySize = value; }
        }

        // Check to see if MemorySize property is set
        internal bool IsSetMemorySize()
        {
            return this._memorySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pinned. True if the function is pinned. Pinned means the
        /// function is long-lived and starts when the core starts.
        /// </summary>
        public bool? Pinned
        {
            get { return this._pinned; }
            set { this._pinned = value; }
        }

        // Check to see if Pinned property is set
        internal bool IsSetPinned()
        {
            return this._pinned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. The allowed function execution time, after which
        /// Lambda should terminate the function. This timeout still applies to pinned Lambda
        /// functions for each request.
        /// </summary>
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}
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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// The configuration of the Lambda function.
    /// </summary>
    public partial class FunctionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncodingType. The expected encoding type of the input payload
        /// for the function. The default is ''json''.
        /// </summary>
        public EncodingType EncodingType { get; set; }

        /// <summary>
        /// Checks to see if the EncodingType property is set.
        /// </summary>
        internal bool IsSetEncodingType() => this.EncodingType != null;

        /// <summary>
        /// Gets and sets the property Environment. The environment configuration of the function.
        /// </summary>
        public FunctionConfigurationEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property ExecArgs. The execution arguments.
        /// </summary>
        public string ExecArgs { get; set; }

        /// <summary>
        /// Checks to see if the ExecArgs property is set.
        /// </summary>
        internal bool IsSetExecArgs() => this.ExecArgs != null;

        /// <summary>
        /// Gets and sets the property Executable. The name of the function executable.
        /// </summary>
        public string Executable { get; set; }

        /// <summary>
        /// Checks to see if the Executable property is set.
        /// </summary>
        internal bool IsSetExecutable() => this.Executable != null;

        /// <summary>
        /// Gets and sets the property FunctionRuntimeOverride. The Lambda runtime supported by
        /// Greengrass which is to be used instead of the one specified in the Lambda function.
        /// </summary>
        public string FunctionRuntimeOverride { get; set; }

        /// <summary>
        /// Checks to see if the FunctionRuntimeOverride property is set.
        /// </summary>
        internal bool IsSetFunctionRuntimeOverride() => this.FunctionRuntimeOverride != null;

        /// <summary>
        /// Gets and sets the property MemorySize. The memory size, in KB, which the function
        /// requires. This setting is not applicable and should be cleared when you run the Lambda
        /// function without containerization.
        /// </summary>
        public int? MemorySize { get; set; }

        /// <summary>
        /// Checks to see if the MemorySize property is set.
        /// </summary>
        internal bool IsSetMemorySize() => this.MemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property Pinned. True if the function is pinned. Pinned means the
        /// function is long-lived and starts when the core starts.
        /// </summary>
        public bool? Pinned { get; set; }

        /// <summary>
        /// Checks to see if the Pinned property is set.
        /// </summary>
        internal bool IsSetPinned() => this.Pinned.HasValue;

        /// <summary>
        /// Gets and sets the property Timeout. The allowed function execution time, after which
        /// Lambda should terminate the function. This timeout still applies to pinned Lambda
        /// functions for each request.
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;
    }
}

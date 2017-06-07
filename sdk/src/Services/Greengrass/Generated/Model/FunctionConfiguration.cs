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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Configuration of the function
    /// </summary>
    public partial class FunctionConfiguration
    {
        private FunctionConfigurationEnvironment _environment;
        private string _execArgs;
        private string _executable;
        private int? _memorySize;
        private bool? _pinned;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property Environment. Environment of the function configuration
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
        /// Gets and sets the property ExecArgs. Execution Arguments
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
        /// Gets and sets the property Executable. Executable
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
        /// Gets and sets the property MemorySize. The memory size, in KB, you configured for
        /// the function.
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
        /// Gets and sets the property Pinned. Whether the function is pinned or not. Pinned means
        /// the function is long-lived and starts when the core starts.
        /// </summary>
        public bool Pinned
        {
            get { return this._pinned.GetValueOrDefault(); }
            set { this._pinned = value; }
        }

        // Check to see if Pinned property is set
        internal bool IsSetPinned()
        {
            return this._pinned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. The function execution time at which Lambda should
        /// terminate the function. This timeout still applies to pinned lambdas for each request.
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
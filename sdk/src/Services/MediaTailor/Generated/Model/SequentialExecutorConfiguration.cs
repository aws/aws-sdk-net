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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for a <c>SEQUENTIAL_EXECUTOR</c> function. A <c>SEQUENTIAL_EXECUTOR</c>
    /// runs a sequence of child functions in order, passing data between steps through temporary
    /// data. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-types-sequential-executor.html">SEQUENTIAL_EXECUTOR</a>
    /// in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class SequentialExecutorConfiguration
    {
        private List<FunctionRef> _functionList = AWSConfigs.InitializeCollections ? new List<FunctionRef>() : null;
        private Dictionary<string, string> _output = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RuntimeType _runtime;
        private int? _timeoutMilliseconds;

        /// <summary>
        /// Gets and sets the property FunctionList. 
        /// <para>
        /// An ordered list of 1 to 10 steps. Each step specifies a child function to execute
        /// and an optional run condition expression that controls whether the step runs. MediaTailor
        /// executes steps in order, passing data between steps through temporary data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FunctionRef> FunctionList
        {
            get { return this._functionList; }
            set { this._functionList = value; }
        }

        // Check to see if FunctionList property is set
        internal bool IsSetFunctionList()
        {
            return this._functionList != null && (this._functionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// An optional map of output bindings that controls which bindings the sequence commits
        /// to the session state after all steps complete. If omitted, MediaTailor commits all
        /// accumulated output bindings from all child steps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null && (this._output.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// Set this to <c>JSONata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeType Runtime
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
        /// Gets and sets the property TimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, for the entire sequence to complete. This timeout
        /// covers all steps, including any HTTP calls made by child functions. If the sequence
        /// exceeds this timeout, MediaTailor discards all output from the sequence and proceeds
        /// with default behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TimeoutMilliseconds
        {
            get { return this._timeoutMilliseconds; }
            set { this._timeoutMilliseconds = value; }
        }

        // Check to see if TimeoutMilliseconds property is set
        internal bool IsSetTimeoutMilliseconds()
        {
            return this._timeoutMilliseconds.HasValue; 
        }

    }
}
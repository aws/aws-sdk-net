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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
    /// Container for the parameters to the PutFunctionConcurrency operation.
    /// Sets a limit on the number of concurrent executions available to this function. It
    /// is a subset of your account's total concurrent execution limit per region. Note that
    /// Lambda automatically reserves a buffer of 100 concurrent executions for functions
    /// without any reserved concurrency limit. This means if your account limit is 1000,
    /// you have a total of 900 available to allocate to individual functions. For more information,
    /// see <a>concurrent-executions</a>.
    /// </summary>
    public partial class PutFunctionConcurrencyRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private int? _reservedConcurrentExecutions;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the function you are setting concurrent execution limits on. For more
        /// information, see <a>concurrent-executions</a>.
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
        /// Gets and sets the property ReservedConcurrentExecutions. 
        /// <para>
        /// The concurrent execution limit reserved for this function. For more information, see
        /// <a>concurrent-executions</a>.
        /// </para>
        /// </summary>
        public int ReservedConcurrentExecutions
        {
            get { return this._reservedConcurrentExecutions.GetValueOrDefault(); }
            set { this._reservedConcurrentExecutions = value; }
        }

        // Check to see if ReservedConcurrentExecutions property is set
        internal bool IsSetReservedConcurrentExecutions()
        {
            return this._reservedConcurrentExecutions.HasValue; 
        }

    }
}
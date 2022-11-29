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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the PutFunctionConcurrency operation.
    /// </summary>
    public partial class PutFunctionConcurrencyResponse : AmazonWebServiceResponse
    {
        private int? _reservedConcurrentExecutions;

        /// <summary>
        /// Gets and sets the property ReservedConcurrentExecutions. 
        /// <para>
        /// The number of concurrent executions that are reserved for this function. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-concurrency.html">Managing
        /// Lambda reserved concurrency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
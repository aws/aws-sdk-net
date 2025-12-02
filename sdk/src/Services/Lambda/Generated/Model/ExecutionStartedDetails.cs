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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about a durable execution that started.
    /// </summary>
    public partial class ExecutionStartedDetails
    {
        private int? _executionTimeout;
        private EventInput _input;

        /// <summary>
        /// Gets and sets the property ExecutionTimeout. 
        /// <para>
        /// The maximum amount of time that the durable execution is allowed to run, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int ExecutionTimeout
        {
            get { return this._executionTimeout.GetValueOrDefault(); }
            set { this._executionTimeout = value; }
        }

        // Check to see if ExecutionTimeout property is set
        internal bool IsSetExecutionTimeout()
        {
            return this._executionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input payload provided for the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}
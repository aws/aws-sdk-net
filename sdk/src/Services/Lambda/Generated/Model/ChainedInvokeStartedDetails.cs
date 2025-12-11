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
    /// Contains details about a chained function invocation that has started execution, including
    /// start time and execution context.
    /// </summary>
    public partial class ChainedInvokeStartedDetails
    {
        private string _durableExecutionArn;
        private string _executedVersion;
        private string _functionName;
        private EventInput _input;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property DurableExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the durable execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DurableExecutionArn
        {
            get { return this._durableExecutionArn; }
            set { this._durableExecutionArn = value; }
        }

        // Check to see if DurableExecutionArn property is set
        internal bool IsSetDurableExecutionArn()
        {
            return this._durableExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutedVersion. 
        /// <para>
        /// The version of the function that was executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExecutedVersion
        {
            get { return this._executedVersion; }
            set { this._executedVersion = value; }
        }

        // Check to see if ExecutedVersion property is set
        internal bool IsSetExecutedVersion()
        {
            return this._executedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function being invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Input. 
        /// <para>
        /// The JSON input payload provided to the chained invocation.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The tenant identifier for the chained invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}
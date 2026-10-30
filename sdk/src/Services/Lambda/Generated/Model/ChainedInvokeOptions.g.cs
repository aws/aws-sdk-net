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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration options for chained function invocations in durable executions, including
    /// retry settings and timeout configuration.
    /// </summary>
    public partial class ChainedInvokeOptions
    {
        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The tenant identifier for the chained invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;

        /// <summary>
        /// Gets and sets the property XAmznTraceId. 
        /// <para>
        /// The X-Ray trace header to use when starting the chained invocation. This parameter
        /// is optional. If you omit this value, the child invocation inherits the parent durable
        /// execution's trace header.
        /// </para>
        ///  
        /// <para>
        /// Specify this value on the <c>START</c> update for the chained invocation operation.
        /// For more information about the header format, see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-concepts.html#xray-concepts-tracingheader">Tracing
        /// header</a> in the <i>X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string XAmznTraceId { get; set; }

        /// <summary>
        /// Checks to see if the XAmznTraceId property is set.
        /// </summary>
        internal bool IsSetXAmznTraceId() => this.XAmznTraceId != null;
    }
}

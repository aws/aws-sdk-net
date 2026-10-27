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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Lambda invocation parameters for subscribers. Values are forwarded to the Lambda Invoke
    /// API. Every string member accepts a literal or a JSONata expression (e.g. "{% $events.Data.qualifier
    /// %}").
    /// </summary>
    public partial class LambdaParameters
    {
        /// <summary>
        /// Gets and sets the property DurableExecutionName. Durable execution name. Accepts a
        /// JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string DurableExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionName property is set.
        /// </summary>
        internal bool IsSetDurableExecutionName() => this.DurableExecutionName != null;

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. Timeout in seconds for each invocation
        /// of the target. String-typed so the value may be a JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string InvocationTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetInvocationTimeoutSeconds() => this.InvocationTimeoutSeconds != null;

        /// <summary>
        /// Gets and sets the property InvocationType. Lambda invocation type. EVENT invokes the
        /// function asynchronously; REQUEST_RESPONSE waits for its result.
        /// </summary>
        public InvocationType InvocationType { get; set; }

        /// <summary>
        /// Checks to see if the InvocationType property is set.
        /// </summary>
        internal bool IsSetInvocationType() => this.InvocationType != null;

        /// <summary>
        /// Gets and sets the property Qualifier. Lambda qualifier: $LATEST, $LATEST.PUBLISHED,
        /// a numeric version, or an alias. Accepts a JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property TenantId. Tenant identifier. Accepts a JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;
    }
}

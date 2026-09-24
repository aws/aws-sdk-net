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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
    /// API. Every string member accepts a literal or a JSONata expression (e.g. &quot;{%
    /// $events.Data.qualifier %}&quot;).
    /// </summary>
    public partial class LambdaParameters
    {
        private string _durableExecutionName;
        private string _invocationTimeoutSeconds;
        private InvocationType _invocationType;
        private string _qualifier;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property DurableExecutionName. 
        /// <para>
        /// Durable execution name. Accepts a JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string DurableExecutionName
        {
            get { return this._durableExecutionName; }
            set { this._durableExecutionName = value; }
        }

        // Check to see if DurableExecutionName property is set
        internal bool IsSetDurableExecutionName()
        {
            return this._durableExecutionName != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// Timeout in seconds for each invocation of the target. String-typed so the value may
        /// be a JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string InvocationTimeoutSeconds
        {
            get { return this._invocationTimeoutSeconds; }
            set { this._invocationTimeoutSeconds = value; }
        }

        // Check to see if InvocationTimeoutSeconds property is set
        internal bool IsSetInvocationTimeoutSeconds()
        {
            return this._invocationTimeoutSeconds != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Lambda invocation type. EVENT invokes the function asynchronously; REQUEST_RESPONSE
        /// waits for its result.
        /// </para>
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Lambda qualifier: $LATEST, $LATEST.PUBLISHED, a numeric version, or an alias. Accepts
        /// a JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// Tenant identifier. Accepts a JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
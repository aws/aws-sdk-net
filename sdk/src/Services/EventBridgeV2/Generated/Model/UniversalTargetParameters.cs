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
    /// Parameters for USI (Universal Service Integration) targets. Used when TargetArn is
    /// in the format arn:aws:events:::aws-sdk:{service}:{apiAction}
    /// </summary>
    public partial class UniversalTargetParameters
    {
        private string _input;
        private string _invocationTimeoutSeconds;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// JSON string or JSONata expression that produces the API request. Supports {% ... %}
        /// JSONata expressions for dynamic values from the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=262144)]
        public string Input
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
        /// Gets and sets the property InvocationTimeoutSeconds. 
        /// <para>
        /// Timeout in seconds for each invocation of the target (1-30, default 30). Accepts a
        /// literal integer or a {% ... %} JSONata expression evaluated against the event at invocation
        /// time. A JSONata expression is syntax-checked at create time. Resolved values outside
        /// of the range [1, 30] will be constrained to the nearest bound at delivery time. Defaults
        /// to 30 seconds when unset.
        /// </para>
        /// </summary>
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

    }
}
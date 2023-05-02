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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the StartFlow operation.
    /// Activates an existing flow. For on-demand flows, this operation runs the flow immediately.
    /// For schedule and event-triggered flows, this operation activates the flow.
    /// </summary>
    public partial class StartFlowRequest : AmazonAppflowRequest
    {
        private string _clientToken;
        private string _flowName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <code>clientToken</code> parameter is an idempotency token. It ensures that your
        /// <code>StartFlow</code> request completes only once. You choose the value to pass.
        /// For example, if you don't receive a response from your request, you can safely retry
        /// the request with the same <code>clientToken</code> parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you omit a <code>clientToken</code> value, the Amazon Web Services SDK that you
        /// are using inserts a value for you. This way, the SDK can safely retry requests multiple
        /// times after a network error. You must provide your own value for other use cases.
        /// </para>
        ///  
        /// <para>
        /// If you specify input parameters that differ from your first request, an error occurs
        /// for flows that run on a schedule or based on an event. However, the error doesn't
        /// occur for flows that run on demand. You set the conditions that initiate your flow
        /// for the <code>triggerConfig</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you use a different value for <code>clientToken</code>, Amazon AppFlow considers
        /// it a new call to <code>StartFlow</code>. The token is active for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlowName
        {
            get { return this._flowName; }
            set { this._flowName = value; }
        }

        // Check to see if FlowName property is set
        internal bool IsSetFlowName()
        {
            return this._flowName != null;
        }

    }
}
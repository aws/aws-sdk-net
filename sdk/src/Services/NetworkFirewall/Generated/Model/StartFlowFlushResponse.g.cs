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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the StartFlowFlush operation.
    /// </summary>
    public partial class StartFlowFlushResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FlowOperationId. 
        /// <para>
        /// A unique identifier for the flow operation. This ID is returned in the responses to
        /// start and list commands. You provide to describe commands.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FlowOperationId { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationId property is set.
        /// </summary>
        internal bool IsSetFlowOperationId() => this.FlowOperationId != null;

        /// <summary>
        /// Gets and sets the property FlowOperationStatus. 
        /// <para>
        /// Returns the status of the flow operation. This string is returned in the responses
        /// to start, list, and describe commands.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED_WITH_ERRORS</c>, results may be returned with any number
        /// of <c>Flows</c> missing from the response. If the status is <c>FAILED</c>, <c>Flows</c>
        /// returned will be empty.
        /// </para>
        /// </summary>
        public FlowOperationStatus FlowOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowOperationStatus property is set.
        /// </summary>
        internal bool IsSetFlowOperationStatus() => this.FlowOperationStatus != null;
    }
}

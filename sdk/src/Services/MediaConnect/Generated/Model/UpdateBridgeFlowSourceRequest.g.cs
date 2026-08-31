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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Update the flow source of the bridge.
    /// </summary>
    public partial class UpdateBridgeFlowSourceRequest
    {
        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that identifies the MediaConnect resource from which
        /// to delete tags.
        /// </para>
        /// </summary>
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowVpcInterfaceAttachment. 
        /// <para>
        /// The name of the VPC interface attachment to use for this source. 
        /// </para>
        /// </summary>
        public VpcInterfaceAttachment FlowVpcInterfaceAttachment { get; set; }

        /// <summary>
        /// Checks to see if the FlowVpcInterfaceAttachment property is set.
        /// </summary>
        internal bool IsSetFlowVpcInterfaceAttachment() => this.FlowVpcInterfaceAttachment != null;
    }
}

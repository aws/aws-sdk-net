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
    /// Container for the parameters to the RemoveFlowVpcInterface operation. Removes a VPC
    /// Interface from an existing flow. This request can be made only on a VPC interface
    /// that does not have a Source or Output associated with it. If the VPC interface is
    /// referenced by a Source or Output, you must first delete or update the Source or Output
    /// to no longer reference the VPC interface.
    /// </summary>
    public partial class RemoveFlowVpcInterfaceRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that you want to remove a VPC interface
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. 
        /// <para>
        ///  The name of the VPC interface that you want to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VpcInterfaceName property is set.
        /// </summary>
        internal bool IsSetVpcInterfaceName() => this.VpcInterfaceName != null;
    }
}

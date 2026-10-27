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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// The list of endpoint objects. For custom routing, this is a list of virtual private
    /// cloud (VPC) subnet IDs.
    /// </summary>
    public partial class CustomRoutingEndpointConfiguration
    {
        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cross-account attachment that specifies the
        /// endpoints (resources) that can be added to accelerators and principals that have permission
        /// to add the endpoints.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string AttachmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentArn property is set.
        /// </summary>
        internal bool IsSetAttachmentArn() => this.AttachmentArn != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// An ID for the endpoint. For custom routing accelerators, this is the virtual private
        /// cloud (VPC) subnet ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;
    }
}

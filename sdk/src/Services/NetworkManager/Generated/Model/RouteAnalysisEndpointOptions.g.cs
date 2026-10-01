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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a source or a destination.
    /// </summary>
    public partial class RouteAnalysisEndpointOptions
    {
        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayArn. 
        /// <para>
        /// The ARN of the transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TransitGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayArn property is set.
        /// </summary>
        internal bool IsSetTransitGatewayArn() => this.TransitGatewayArn != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentArn. 
        /// <para>
        /// The ARN of the transit gateway attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TransitGatewayAttachmentArn { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentArn property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentArn() => this.TransitGatewayAttachmentArn != null;
    }
}

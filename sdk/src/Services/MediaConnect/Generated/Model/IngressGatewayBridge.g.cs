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
    /// Create a bridge with the ingress bridge type. An ingress bridge is a ground-to-cloud
    /// bridge. The content originates at your premises and is delivered to the cloud.
    /// </summary>
    public partial class IngressGatewayBridge
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance running this bridge. 
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxBitrate. 
        /// <para>
        /// The maximum expected bitrate (in bps) of the ingress bridge. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxOutputs. 
        /// <para>
        /// The maximum number of outputs on the ingress bridge. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxOutputs { get; set; }

        /// <summary>
        /// Checks to see if the MaxOutputs property is set.
        /// </summary>
        internal bool IsSetMaxOutputs() => this.MaxOutputs.HasValue;
    }
}

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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the AttachClusterNodeVolume operation.
    /// </summary>
    public partial class AttachClusterNodeVolumeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        ///  The timestamp when the volume attachment operation was initiated by the SageMaker
        /// HyperPod service. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AttachTime { get; set; }

        /// <summary>
        /// Checks to see if the AttachTime property is set.
        /// </summary>
        internal bool IsSetAttachTime() => this.AttachTime.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of your SageMaker HyperPod cluster where the volume
        /// attachment operation was performed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        ///  The device name assigned to your attached volume on the target instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        ///  The unique identifier of the cluster node where your volume was attached. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of your volume attachment operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VolumeAttachmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        ///  The unique identifier of your EBS volume that was attached. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}

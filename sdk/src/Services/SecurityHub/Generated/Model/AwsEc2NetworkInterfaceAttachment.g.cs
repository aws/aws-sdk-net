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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the network interface attachment.
    /// </summary>
    public partial class AwsEc2NetworkInterfaceAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// Indicates when the attachment initiated.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string AttachTime { get; set; }

        /// <summary>
        /// Checks to see if the AttachTime property is set.
        /// </summary>
        internal bool IsSetAttachTime() => this.AttachTime != null;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The identifier of the network interface attachment
        /// </para>
        /// </summary>
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the network interface is deleted when the instance is terminated.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceIndex. 
        /// <para>
        /// The device index of the network interface attachment on the instance.
        /// </para>
        /// </summary>
        public int? DeviceIndex { get; set; }

        /// <summary>
        /// Checks to see if the DeviceIndex property is set.
        /// </summary>
        internal bool IsSetDeviceIndex() => this.DeviceIndex.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the instance.
        /// </para>
        /// </summary>
        public string InstanceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceOwnerId property is set.
        /// </summary>
        internal bool IsSetInstanceOwnerId() => this.InstanceOwnerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The attachment state.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>attaching</c> | <c>attached</c> | <c>detaching</c> | <c>detached</c>
        /// 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

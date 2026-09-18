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
    /// An attachment to an Amazon EC2 volume.
    /// </summary>
    public partial class AwsEc2VolumeAttachment
    {
        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// The datetime when the attachment initiated.
        /// </para>
        /// </summary>
        public string AttachTime { get; set; }

        /// <summary>
        /// Checks to see if the AttachTime property is set.
        /// </summary>
        internal bool IsSetAttachTime() => this.AttachTime != null;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Whether the EBS volume is deleted when the EC2 instance is terminated.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the EC2 instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The attachment state of the volume. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>attaching</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attached</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>busy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>detaching</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>detached</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

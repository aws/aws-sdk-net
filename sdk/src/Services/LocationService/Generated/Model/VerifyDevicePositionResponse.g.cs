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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the VerifyDevicePosition operation.
    /// </summary>
    public partial class VerifyDevicePositionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit for the verification response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistanceUnit DistanceUnit { get; set; }

        /// <summary>
        /// Checks to see if the DistanceUnit property is set.
        /// </summary>
        internal bool IsSetDistanceUnit() => this.DistanceUnit != null;

        /// <summary>
        /// Gets and sets the property InferredState. 
        /// <para>
        /// The inferred state of the device, given the provided position, IP address, cellular
        /// signals, and Wi-Fi- access points.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferredState InferredState { get; set; }

        /// <summary>
        /// Checks to see if the InferredState property is set.
        /// </summary>
        internal bool IsSetInferredState() => this.InferredState != null;

        /// <summary>
        /// Gets and sets the property ReceivedTime. 
        /// <para>
        /// The timestamp for when the tracker resource received the device position in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? ReceivedTime { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedTime property is set.
        /// </summary>
        internal bool IsSetReceivedTime() => this.ReceivedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The timestamp at which the device's position was determined. Uses <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? SampleTime { get; set; }

        /// <summary>
        /// Checks to see if the SampleTime property is set.
        /// </summary>
        internal bool IsSetSampleTime() => this.SampleTime.HasValue;
    }
}

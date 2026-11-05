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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInputDeviceThumbnail operation. Get the
    /// latest thumbnail data for the input device.
    /// </summary>
    public partial class DescribeInputDeviceThumbnailRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. The HTTP Accept header. Indicates the requested
        /// type for the thumbnail.
        /// </summary>
        [AWSProperty(Required = true)]
        public AcceptHeader Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property InputDeviceId. The unique ID of this input device. For
        /// example, hd-123456789abcdef.
        /// </summary>
        [AWSProperty(Required = true)]
        public string InputDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the InputDeviceId property is set.
        /// </summary>
        internal bool IsSetInputDeviceId() => this.InputDeviceId != null;
    }
}

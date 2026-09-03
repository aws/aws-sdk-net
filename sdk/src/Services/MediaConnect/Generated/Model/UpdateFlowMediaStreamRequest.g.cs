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
    /// Container for the parameters to the UpdateFlowMediaStream operation. Updates an existing
    /// media stream.
    /// </summary>
    public partial class UpdateFlowMediaStreamRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The attributes that you want to assign to the media stream.
        /// </para>
        /// </summary>
        public MediaStreamAttributesRequest Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property ClockRate. 
        /// <para>
        /// The sample rate for the stream. This value in measured in kHz. 
        /// </para>
        /// </summary>
        public int? ClockRate { get; set; }

        /// <summary>
        /// Checks to see if the ClockRate property is set.
        /// </summary>
        internal bool IsSetClockRate() => this.ClockRate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that can help you quickly identify what your media stream is used for.
        /// 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that is associated with the media stream
        /// that you updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property MediaStreamName. 
        /// <para>
        ///  The media stream that you updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MediaStreamName { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamName property is set.
        /// </summary>
        internal bool IsSetMediaStreamName() => this.MediaStreamName != null;

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// The type of media stream. 
        /// </para>
        /// </summary>
        public MediaStreamType MediaStreamType { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamType property is set.
        /// </summary>
        internal bool IsSetMediaStreamType() => this.MediaStreamType != null;

        /// <summary>
        /// Gets and sets the property VideoFormat. 
        /// <para>
        /// The resolution of the video. 
        /// </para>
        /// </summary>
        public string VideoFormat { get; set; }

        /// <summary>
        /// Checks to see if the VideoFormat property is set.
        /// </summary>
        internal bool IsSetVideoFormat() => this.VideoFormat != null;
    }
}

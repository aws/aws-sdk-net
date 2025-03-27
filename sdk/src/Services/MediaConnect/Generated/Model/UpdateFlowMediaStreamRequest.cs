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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Container for the parameters to the UpdateFlowMediaStream operation.
    /// Updates an existing media stream.
    /// </summary>
    public partial class UpdateFlowMediaStreamRequest : AmazonMediaConnectRequest
    {
        private MediaStreamAttributesRequest _attributes;
        private int? _clockRate;
        private string _description;
        private string _flowArn;
        private string _mediaStreamName;
        private MediaStreamType _mediaStreamType;
        private string _videoFormat;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The attributes that you want to assign to the media stream.
        /// </para>
        /// </summary>
        public MediaStreamAttributesRequest Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property ClockRate. 
        /// <para>
        /// The sample rate for the stream. This value in measured in kHz. 
        /// </para>
        /// </summary>
        public int? ClockRate
        {
            get { return this._clockRate; }
            set { this._clockRate = value; }
        }

        // Check to see if ClockRate property is set
        internal bool IsSetClockRate()
        {
            return this._clockRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that can help you quickly identify what your media stream is used for.
        /// 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that is associated with the media stream
        /// that you updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStreamName. 
        /// <para>
        ///  The media stream that you updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MediaStreamName
        {
            get { return this._mediaStreamName; }
            set { this._mediaStreamName = value; }
        }

        // Check to see if MediaStreamName property is set
        internal bool IsSetMediaStreamName()
        {
            return this._mediaStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        /// The type of media stream. 
        /// </para>
        /// </summary>
        public MediaStreamType MediaStreamType
        {
            get { return this._mediaStreamType; }
            set { this._mediaStreamType = value; }
        }

        // Check to see if MediaStreamType property is set
        internal bool IsSetMediaStreamType()
        {
            return this._mediaStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property VideoFormat. 
        /// <para>
        /// The resolution of the video. 
        /// </para>
        /// </summary>
        public string VideoFormat
        {
            get { return this._videoFormat; }
            set { this._videoFormat = value; }
        }

        // Check to see if VideoFormat property is set
        internal bool IsSetVideoFormat()
        {
            return this._videoFormat != null;
        }

    }
}
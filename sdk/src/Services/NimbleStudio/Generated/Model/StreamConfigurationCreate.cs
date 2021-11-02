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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Configuration for streaming workstations created using this launch profile.
    /// </summary>
    public partial class StreamConfigurationCreate
    {
        private StreamingClipboardMode _clipboardMode;
        private List<string> _ec2InstanceTypes = new List<string>();
        private int? _maxSessionLengthInMinutes;
        private int? _maxStoppedSessionLengthInMinutes;
        private List<string> _streamingImageIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ClipboardMode. 
        /// <para>
        /// Enable or disable the use of the system clipboard to copy and paste between the streaming
        /// session and streaming client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamingClipboardMode ClipboardMode
        {
            get { return this._clipboardMode; }
            set { this._clipboardMode = value; }
        }

        // Check to see if ClipboardMode property is set
        internal bool IsSetClipboardMode()
        {
            return this._clipboardMode != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceTypes. 
        /// <para>
        /// The EC2 instance types that users can select from when launching a streaming session
        /// with this launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> Ec2InstanceTypes
        {
            get { return this._ec2InstanceTypes; }
            set { this._ec2InstanceTypes = value; }
        }

        // Check to see if Ec2InstanceTypes property is set
        internal bool IsSetEc2InstanceTypes()
        {
            return this._ec2InstanceTypes != null && this._ec2InstanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionLengthInMinutes. 
        /// <para>
        /// The length of time, in minutes, that a streaming session can be active before it is
        /// stopped or terminated. After this point, Nimble Studio automatically terminates or
        /// stops the session. The default length of time is 690 minutes, and the maximum length
        /// of time is 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=43200)]
        public int MaxSessionLengthInMinutes
        {
            get { return this._maxSessionLengthInMinutes.GetValueOrDefault(); }
            set { this._maxSessionLengthInMinutes = value; }
        }

        // Check to see if MaxSessionLengthInMinutes property is set
        internal bool IsSetMaxSessionLengthInMinutes()
        {
            return this._maxSessionLengthInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxStoppedSessionLengthInMinutes. 
        /// <para>
        /// The length of time, in minutes, that a streaming session can be active before it is
        /// stopped or terminated. After this point, Nimble Studio automatically terminates or
        /// stops the session. The default length of time is 690 minutes, and the maximum length
        /// of time is 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5760)]
        public int MaxStoppedSessionLengthInMinutes
        {
            get { return this._maxStoppedSessionLengthInMinutes.GetValueOrDefault(); }
            set { this._maxStoppedSessionLengthInMinutes = value; }
        }

        // Check to see if MaxStoppedSessionLengthInMinutes property is set
        internal bool IsSetMaxStoppedSessionLengthInMinutes()
        {
            return this._maxStoppedSessionLengthInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamingImageIds. 
        /// <para>
        /// The streaming images that users can select from when launching a streaming session
        /// with this launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> StreamingImageIds
        {
            get { return this._streamingImageIds; }
            set { this._streamingImageIds = value; }
        }

        // Check to see if StreamingImageIds property is set
        internal bool IsSetStreamingImageIds()
        {
            return this._streamingImageIds != null && this._streamingImageIds.Count > 0; 
        }

    }
}
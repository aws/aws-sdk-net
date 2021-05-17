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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the AddFlowMediaStreams operation.
    /// </summary>
    public partial class AddFlowMediaStreamsResponse : AmazonWebServiceResponse
    {
        private string _flowArn;
        private List<MediaStream> _mediaStreams = new List<MediaStream>();

        /// <summary>
        /// Gets and sets the property FlowArn. The ARN of the flow that you added media streams
        /// to.
        /// </summary>
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
        /// Gets and sets the property MediaStreams. The media streams that you added to the flow.
        /// </summary>
        public List<MediaStream> MediaStreams
        {
            get { return this._mediaStreams; }
            set { this._mediaStreams = value; }
        }

        // Check to see if MediaStreams property is set
        internal bool IsSetMediaStreams()
        {
            return this._mediaStreams != null && this._mediaStreams.Count > 0; 
        }

    }
}
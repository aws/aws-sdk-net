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
    /// This is the response object from the UpdateFlowMediaStream operation.
    /// </summary>
    public partial class UpdateFlowMediaStreamResponse : AmazonWebServiceResponse
    {
        private string _flowArn;
        private MediaStream _mediaStream;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        /// The ARN of the flow that is associated with the media stream that you updated. 
        /// </para>
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
        /// Gets and sets the property MediaStream. 
        /// <para>
        /// The media stream that you updated. 
        /// </para>
        /// </summary>
        public MediaStream MediaStream
        {
            get { return this._mediaStream; }
            set { this._mediaStream = value; }
        }

        // Check to see if MediaStream property is set
        internal bool IsSetMediaStream()
        {
            return this._mediaStream != null;
        }

    }
}
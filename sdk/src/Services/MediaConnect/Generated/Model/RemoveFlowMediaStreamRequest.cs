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
    /// Container for the parameters to the RemoveFlowMediaStream operation.
    /// Removes a media stream from a flow. This action is only available if the media stream
    /// is not associated with a source or output.
    /// </summary>
    public partial class RemoveFlowMediaStreamRequest : AmazonMediaConnectRequest
    {
        private string _flowArn;
        private string _mediaStreamName;

        /// <summary>
        /// Gets and sets the property FlowArn. The Amazon Resource Name (ARN) of the flow.
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
        /// Gets and sets the property MediaStreamName. The name of the media stream that you
        /// want to remove.
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

    }
}
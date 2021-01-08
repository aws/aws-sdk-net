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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideoSignalingChannels.Model
{
    /// <summary>
    /// This is the response object from the GetIceServerConfig operation.
    /// </summary>
    public partial class GetIceServerConfigResponse : AmazonWebServiceResponse
    {
        private List<IceServer> _iceServerList = new List<IceServer>();

        /// <summary>
        /// Gets and sets the property IceServerList. 
        /// <para>
        /// The list of ICE server information objects.
        /// </para>
        /// </summary>
        public List<IceServer> IceServerList
        {
            get { return this._iceServerList; }
            set { this._iceServerList = value; }
        }

        // Check to see if IceServerList property is set
        internal bool IsSetIceServerList()
        {
            return this._iceServerList != null && this._iceServerList.Count > 0; 
        }

    }
}
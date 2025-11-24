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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// This is the response object from the CancelChannelHandshake operation.
    /// </summary>
    public partial class CancelChannelHandshakeResponse : AmazonWebServiceResponse
    {
        private CancelChannelHandshakeDetail _channelHandshakeDetail;

        /// <summary>
        /// Gets and sets the property ChannelHandshakeDetail. 
        /// <para>
        /// Details of the canceled channel handshake.
        /// </para>
        /// </summary>
        public CancelChannelHandshakeDetail ChannelHandshakeDetail
        {
            get { return this._channelHandshakeDetail; }
            set { this._channelHandshakeDetail = value; }
        }

        // Check to see if ChannelHandshakeDetail property is set
        internal bool IsSetChannelHandshakeDetail()
        {
            return this._channelHandshakeDetail != null;
        }

    }
}
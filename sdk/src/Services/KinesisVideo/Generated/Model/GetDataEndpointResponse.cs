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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the GetDataEndpoint operation.
    /// </summary>
    public partial class GetDataEndpointResponse : AmazonWebServiceResponse
    {
        private string _dataEndpoint;

        /// <summary>
        /// Gets and sets the property DataEndpoint. 
        /// <para>
        /// The endpoint value. To read data from the stream or to write data to it, specify this
        /// endpoint in your application.
        /// </para>
        /// </summary>
        public string DataEndpoint
        {
            get { return this._dataEndpoint; }
            set { this._dataEndpoint = value; }
        }

        // Check to see if DataEndpoint property is set
        internal bool IsSetDataEndpoint()
        {
            return this._dataEndpoint != null;
        }

    }
}
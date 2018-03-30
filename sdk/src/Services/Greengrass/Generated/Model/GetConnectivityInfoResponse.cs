/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the GetConnectivityInfo operation.
    /// </summary>
    public partial class GetConnectivityInfoResponse : AmazonWebServiceResponse
    {
        private List<ConnectivityInfo> _connectivityInfo = new List<ConnectivityInfo>();
        private string _message;

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. Connectivity info list.
        /// </summary>
        public List<ConnectivityInfo> ConnectivityInfo
        {
            get { return this._connectivityInfo; }
            set { this._connectivityInfo = value; }
        }

        // Check to see if ConnectivityInfo property is set
        internal bool IsSetConnectivityInfo()
        {
            return this._connectivityInfo != null && this._connectivityInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Message. A message about the connectivity info request.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}
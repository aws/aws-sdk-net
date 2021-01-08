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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// This is the response object from the UpdateGlobalNetwork operation.
    /// </summary>
    public partial class UpdateGlobalNetworkResponse : AmazonWebServiceResponse
    {
        private GlobalNetwork _globalNetwork;

        /// <summary>
        /// Gets and sets the property GlobalNetwork. 
        /// <para>
        /// Information about the global network object.
        /// </para>
        /// </summary>
        public GlobalNetwork GlobalNetwork
        {
            get { return this._globalNetwork; }
            set { this._globalNetwork = value; }
        }

        // Check to see if GlobalNetwork property is set
        internal bool IsSetGlobalNetwork()
        {
            return this._globalNetwork != null;
        }

    }
}
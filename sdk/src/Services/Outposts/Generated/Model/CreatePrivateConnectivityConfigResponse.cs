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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the CreatePrivateConnectivityConfig operation.
    /// </summary>
    public partial class CreatePrivateConnectivityConfigResponse : AmazonWebServiceResponse
    {
        private string _outpostId;
        private PrivateConnectivityConfig _privateConnectivityConfig;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateConnectivityConfig. 
        /// <para>
        /// The private connectivity configuration for the Outpost.
        /// </para>
        /// </summary>
        public PrivateConnectivityConfig PrivateConnectivityConfig
        {
            get { return this._privateConnectivityConfig; }
            set { this._privateConnectivityConfig = value; }
        }

        // Check to see if PrivateConnectivityConfig property is set
        internal bool IsSetPrivateConnectivityConfig()
        {
            return this._privateConnectivityConfig != null;
        }

    }
}
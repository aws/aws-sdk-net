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
    /// The configuration settings for a router network interface.
    /// </summary>
    public partial class RouterNetworkInterfaceConfiguration
    {
        private PublicRouterNetworkInterfaceConfiguration _public;
        private VpcRouterNetworkInterfaceConfiguration _vpc;

        /// <summary>
        /// Gets and sets the property Public.
        /// </summary>
        public PublicRouterNetworkInterfaceConfiguration Public
        {
            get { return this._public; }
            set { this._public = value; }
        }

        // Check to see if Public property is set
        internal bool IsSetPublic()
        {
            return this._public != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc.
        /// </summary>
        public VpcRouterNetworkInterfaceConfiguration Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents logging information.
    /// </summary>
    public partial class VirtualGatewayLogging
    {
        private VirtualGatewayAccessLog _accessLog;

        /// <summary>
        /// Gets and sets the property AccessLog. 
        /// <para>
        /// The access log configuration.
        /// </para>
        /// </summary>
        public VirtualGatewayAccessLog AccessLog
        {
            get { return this._accessLog; }
            set { this._accessLog = value; }
        }

        // Check to see if AccessLog property is set
        internal bool IsSetAccessLog()
        {
            return this._accessLog != null;
        }

    }
}
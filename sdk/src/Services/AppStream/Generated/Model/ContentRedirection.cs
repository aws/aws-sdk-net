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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Configuration for bidirectional URL redirection between the streaming session and
    /// the local client. Use HostToClient to redirect URLs from the remote desktop to the
    /// local browser.
    /// </summary>
    public partial class ContentRedirection
    {
        private UrlRedirectionConfig _hostToClient;

        /// <summary>
        /// Gets and sets the property HostToClient. 
        /// <para>
        /// Configuration for redirecting URLs from the remote desktop to the local client browser.
        /// </para>
        /// </summary>
        public UrlRedirectionConfig HostToClient
        {
            get { return this._hostToClient; }
            set { this._hostToClient = value; }
        }

        // Check to see if HostToClient property is set
        internal bool IsSetHostToClient()
        {
            return this._hostToClient != null;
        }

    }
}
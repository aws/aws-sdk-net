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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The optional configuration for a server that serves segments. Use this if you want
    /// the segment delivery server to be different from the source location server. For example,
    /// you can configure your source location server to be an origination server, such as
    /// MediaPackage, and the segment delivery server to be a content delivery network (CDN),
    /// such as CloudFront. If you don't specify a segment delivery server, then the source
    /// location server is used.
    /// </summary>
    public partial class DefaultSegmentDeliveryConfiguration
    {
        private string _baseUrl;

        /// <summary>
        /// Gets and sets the property BaseUrl. 
        /// <para>
        /// The hostname of the server that will be used to serve segments. This string must include
        /// the protocol, such as <b>https://</b>.
        /// </para>
        /// </summary>
        public string BaseUrl
        {
            get { return this._baseUrl; }
            set { this._baseUrl = value; }
        }

        // Check to see if BaseUrl property is set
        internal bool IsSetBaseUrl()
        {
            return this._baseUrl != null;
        }

    }
}
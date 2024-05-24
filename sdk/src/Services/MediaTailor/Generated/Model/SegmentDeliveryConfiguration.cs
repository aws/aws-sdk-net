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
    /// The segment delivery configuration settings.
    /// </summary>
    public partial class SegmentDeliveryConfiguration
    {
        private string _baseUrl;
        private string _name;

        /// <summary>
        /// Gets and sets the property BaseUrl. 
        /// <para>
        /// The base URL of the host or path of the segment delivery server that you're using
        /// to serve segments. This is typically a content delivery network (CDN). The URL can
        /// be absolute or relative. To use an absolute URL include the protocol, such as <c>https://example.com/some/path</c>.
        /// To use a relative URL specify the relative path, such as <c>/some/path*</c>.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier used to distinguish between multiple segment delivery configurations
        /// in a source location.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the CreateImageBuilderStreamingURL operation.
    /// </summary>
    public partial class CreateImageBuilderStreamingURLResponse : AmazonWebServiceResponse
    {
        private DateTime? _expires;
        private string _streamingURL;

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// The elapsed time, in seconds after the Unix epoch, when this URL expires.
        /// </para>
        /// </summary>
        public DateTime Expires
        {
            get { return this._expires.GetValueOrDefault(); }
            set { this._expires = value; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this._expires.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamingURL. 
        /// <para>
        /// The URL to start the AppStream 2.0 streaming session.
        /// </para>
        /// </summary>
        public string StreamingURL
        {
            get { return this._streamingURL; }
            set { this._streamingURL = value; }
        }

        // Check to see if StreamingURL property is set
        internal bool IsSetStreamingURL()
        {
            return this._streamingURL != null;
        }

    }
}
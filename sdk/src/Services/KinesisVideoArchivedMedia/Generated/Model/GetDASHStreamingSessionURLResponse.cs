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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// This is the response object from the GetDASHStreamingSessionURL operation.
    /// </summary>
    public partial class GetDASHStreamingSessionURLResponse : AmazonWebServiceResponse
    {
        private string _dashStreamingSessionURL;

        /// <summary>
        /// Gets and sets the property DASHStreamingSessionURL. 
        /// <para>
        /// The URL (containing the session token) that a media player can use to retrieve the
        /// MPEG-DASH manifest.
        /// </para>
        /// </summary>
        public string DASHStreamingSessionURL
        {
            get { return this._dashStreamingSessionURL; }
            set { this._dashStreamingSessionURL = value; }
        }

        // Check to see if DASHStreamingSessionURL property is set
        internal bool IsSetDASHStreamingSessionURL()
        {
            return this._dashStreamingSessionURL != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the GetSessionEmbedUrl operation.
    /// </summary>
    public partial class GetSessionEmbedUrlResponse : AmazonWebServiceResponse
    {
        private string _embedUrl;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property EmbedUrl. 
        /// <para>
        /// A single-use URL that you can put into your server-side web page to embed your Amazon
        /// QuickSight session. This URL is valid for 5 minutes. The API operation provides the
        /// URL with an <code>auth_code</code> value that enables one (and only one) sign-on to
        /// a user session that is valid for 10 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string EmbedUrl
        {
            get { return this._embedUrl; }
            set { this._embedUrl = value; }
        }

        // Check to see if EmbedUrl property is set
        internal bool IsSetEmbedUrl()
        {
            return this._embedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the GetSessionEmbedUrl operation.
    /// </summary>
    public partial class GetSessionEmbedUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EmbedUrl. 
        /// <para>
        /// A single-use URL that you can put into your server-side web page to embed your Quick
        /// session. This URL is valid for 5 minutes. The API operation provides the URL with
        /// an <c>auth_code</c> value that enables one (and only one) sign-on to a user session
        /// that is valid for 10 hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// Checks to see if the EmbedUrl property is set.
        /// </summary>
        internal bool IsSetEmbedUrl() => this.EmbedUrl != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}

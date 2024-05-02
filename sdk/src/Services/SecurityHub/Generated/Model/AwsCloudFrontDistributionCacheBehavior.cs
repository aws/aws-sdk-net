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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a cache behavior for the distribution.
    /// </summary>
    public partial class AwsCloudFrontDistributionCacheBehavior
    {
        private string _viewerProtocolPolicy;

        /// <summary>
        /// Gets and sets the property ViewerProtocolPolicy. 
        /// <para>
        /// The protocol that viewers can use to access the files in an origin. You can specify
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>allow-all</c> - Viewers can use HTTP or HTTPS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>redirect-to-https</c> - CloudFront responds to HTTP requests with an HTTP status
        /// code of 301 (Moved Permanently) and the HTTPS URL. The viewer then uses the new URL
        /// to resubmit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>https-only</c> - CloudFront responds to HTTP request with an HTTP status code
        /// of 403 (Forbidden).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ViewerProtocolPolicy
        {
            get { return this._viewerProtocolPolicy; }
            set { this._viewerProtocolPolicy = value; }
        }

        // Check to see if ViewerProtocolPolicy property is set
        internal bool IsSetViewerProtocolPolicy()
        {
            return this._viewerProtocolPolicy != null;
        }

    }
}
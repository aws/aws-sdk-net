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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class GetCloudFrontOriginAccessIdentityResponse : AmazonWebServiceResponse
    {
        private CloudFrontOriginAccessIdentity _cloudFrontOriginAccessIdentity;
        private string _eTag;

        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentity. 
        /// <para>
        /// The origin access identity's information.
        /// </para>
        /// </summary>
        public CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentity
        {
            get { return this._cloudFrontOriginAccessIdentity; }
            set { this._cloudFrontOriginAccessIdentity = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentity property is set
        internal bool IsSetCloudFrontOriginAccessIdentity()
        {
            return this._cloudFrontOriginAccessIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the origin access identity's information. For example: <c>E2QWRUHAPOMQZL</c>.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

    }
}
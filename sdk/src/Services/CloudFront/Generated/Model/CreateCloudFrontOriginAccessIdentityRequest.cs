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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFrontOriginAccessIdentity operation.
    /// Creates a new origin access identity. If you're using Amazon S3 for your origin, you
    /// can use an origin access identity to require users to access your content using a
    /// CloudFront URL instead of the Amazon S3 URL. For more information about how to use
    /// origin access identities, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
    /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </summary>
    public partial class CreateCloudFrontOriginAccessIdentityRequest : AmazonCloudFrontRequest
    {
        private CloudFrontOriginAccessIdentityConfig _cloudFrontOriginAccessIdentityConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCloudFrontOriginAccessIdentityRequest() { }

        /// <summary>
        /// Instantiates CreateCloudFrontOriginAccessIdentityRequest with the parameterized properties
        /// </summary>
        /// <param name="cloudFrontOriginAccessIdentityConfig">The current configuration information for the identity.</param>
        public CreateCloudFrontOriginAccessIdentityRequest(CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            _cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
        }

        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentityConfig. 
        /// <para>
        /// The current configuration information for the identity.
        /// </para>
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this._cloudFrontOriginAccessIdentityConfig; }
            set { this._cloudFrontOriginAccessIdentityConfig = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this._cloudFrontOriginAccessIdentityConfig != null;
        }

    }
}
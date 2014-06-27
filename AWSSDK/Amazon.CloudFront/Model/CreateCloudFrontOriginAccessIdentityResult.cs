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
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class CreateCloudFrontOriginAccessIdentityResult
    {
        private CloudFrontOriginAccessIdentity _cloudFrontOriginAccessIdentity;
        private string _eTag;
        private string _location;


        /// <summary>
        /// Gets and sets the property CloudFrontOriginAccessIdentity. The origin access identity's
        /// information.
        /// </summary>
        public CloudFrontOriginAccessIdentity CloudFrontOriginAccessIdentity
        {
            get { return this._cloudFrontOriginAccessIdentity; }
            set { this._cloudFrontOriginAccessIdentity = value; }
        }


        /// <summary>
        /// Sets the CloudFrontOriginAccessIdentity property
        /// </summary>
        /// <param name="cloudFrontOriginAccessIdentity">The value to set for the CloudFrontOriginAccessIdentity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCloudFrontOriginAccessIdentityResult WithCloudFrontOriginAccessIdentity(CloudFrontOriginAccessIdentity cloudFrontOriginAccessIdentity)
        {
            this._cloudFrontOriginAccessIdentity = cloudFrontOriginAccessIdentity;
            return this;
        }

        // Check to see if CloudFrontOriginAccessIdentity property is set
        internal bool IsSetCloudFrontOriginAccessIdentity()
        {
            return this._cloudFrontOriginAccessIdentity != null;
        }


        /// <summary>
        /// Gets and sets the property ETag. The current version of the origin access identity
        /// created.
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }


        /// <summary>
        /// Sets the ETag property
        /// </summary>
        /// <param name="eTag">The value to set for the ETag property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCloudFrontOriginAccessIdentityResult WithETag(string eTag)
        {
            this._eTag = eTag;
            return this;
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }


        /// <summary>
        /// Gets and sets the property Location. The fully qualified URI of the new origin access
        /// identity just created.    For example: https://cloudfront.amazonaws.com/2010-11-01/origin-access-identity/cloudfront/E74FTE3AJFJ256A.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }


        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCloudFrontOriginAccessIdentityResult WithLocation(string location)
        {
            this._location = location;
            return this;
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}
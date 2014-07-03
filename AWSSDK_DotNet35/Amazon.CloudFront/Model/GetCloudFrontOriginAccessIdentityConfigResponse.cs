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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Configuration for accessing Amazon GetCloudFrontOriginAccessIdentityConfig service
    /// </summary>
    public partial class GetCloudFrontOriginAccessIdentityConfigResponse : GetCloudFrontOriginAccessIdentityConfigResult
    {
        /// <summary>
        /// Gets and sets the GetCloudFrontOriginAccessIdentityConfigResult property.
        /// Represents the output of a GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the GetCloudFrontOriginAccessIdentityConfigResult class are now available on the GetCloudFrontOriginAccessIdentityConfigResponse class. You should use the properties on GetCloudFrontOriginAccessIdentityConfigResponse instead of accessing them through GetCloudFrontOriginAccessIdentityConfigResult.")]
        public GetCloudFrontOriginAccessIdentityConfigResult GetCloudFrontOriginAccessIdentityConfigResult
        {
            get
            {
                return this;
            }
        }
    }
}
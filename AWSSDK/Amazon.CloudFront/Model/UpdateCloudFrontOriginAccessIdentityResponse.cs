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
using Amazon.Runtime;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Returns information about the UpdateCloudFrontOriginAccessIdentityResult response and response metadata.
    /// </summary>
    public class UpdateCloudFrontOriginAccessIdentityResponse : AmazonWebServiceResponse
    {
        private UpdateCloudFrontOriginAccessIdentityResult _updateCloudFrontOriginAccessIdentityResult;

        /// <summary>
        /// Gets and sets the UpdateCloudFrontOriginAccessIdentityResult property.
        /// Represents the output of a UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        public UpdateCloudFrontOriginAccessIdentityResult UpdateCloudFrontOriginAccessIdentityResult
        {
            get
            {
                if(this._updateCloudFrontOriginAccessIdentityResult == null)
                {
                    this._updateCloudFrontOriginAccessIdentityResult = new UpdateCloudFrontOriginAccessIdentityResult();
                }
                return this._updateCloudFrontOriginAccessIdentityResult;
            }
            set { this._updateCloudFrontOriginAccessIdentityResult = value; }
        }
    }
}
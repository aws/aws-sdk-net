/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetBucketWebsiteResponse contains the properties for S3 website configuration and
    /// any headers returned by S3.
    /// </summary>
    public class GetBucketWebsiteResponse : S3Response
    {
        WebsiteConfiguration _websiteConfiguration;

        #region WebsiteConfiguration


        /// <summary>
        /// Gets and sets the WebsiteConfiguration property.
        /// 
        /// This is where the index document suffix and custom error page are defined.
        /// </summary>
        public WebsiteConfiguration WebsiteConfiguration
        {
            get
            {
                if (this._websiteConfiguration == null)
                {
                    this._websiteConfiguration = new WebsiteConfiguration();
                }
                return this._websiteConfiguration;
            }
            set
            {
                this._websiteConfiguration = value;
            }
        }

        /// <summary>
        /// Sets the WithWebsiteConfiguration property for this request.
        /// </summary>
        /// <param name="config">The value that WithWebsiteConfiguration is set to</param>
        /// <returns>the request with the WebsiteConfiguration set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetBucketWebsiteResponse WithWebsiteConfiguration(WebsiteConfiguration config)
        {
            this.WebsiteConfiguration = config;
            return this;
        }

        #endregion
     }
}

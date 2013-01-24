/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> The returned result of the corresponding request. </para>
    /// </summary>
    public class GetCloudFrontOriginAccessIdentityConfigResult  
    {
        
        private CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig;
        private string eTag;

        /// <summary>
        /// The origin access identity's configuration information.
        ///  
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this.cloudFrontOriginAccessIdentityConfig; }
            set { this.cloudFrontOriginAccessIdentityConfig = value; }
        }

        /// <summary>
        /// Sets the CloudFrontOriginAccessIdentityConfig property
        /// </summary>
        /// <param name="cloudFrontOriginAccessIdentityConfig">The value to set for the CloudFrontOriginAccessIdentityConfig property </param>
        /// <returns>this instance</returns>
        public GetCloudFrontOriginAccessIdentityConfigResult WithCloudFrontOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            this.cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
            return this;
        }
            

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this.cloudFrontOriginAccessIdentityConfig != null;       
        }

        /// <summary>
        /// The current version of the configuration. For example: E2QWRUHAPOMQZL.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Sets the ETag property
        /// </summary>
        /// <param name="eTag">The value to set for the ETag property </param>
        /// <returns>this instance</returns>
        public GetCloudFrontOriginAccessIdentityConfigResult WithETag(string eTag)
        {
            this.eTag = eTag;
            return this;
        }
            

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;       
        }
    }
}

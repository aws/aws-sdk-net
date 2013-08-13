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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudFrontOriginAccessIdentity operation.
    /// <para> Create a new origin access identity. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateCloudFrontOriginAccessIdentity"/>
    public class CreateCloudFrontOriginAccessIdentityRequest : AmazonWebServiceRequest
    {
        private CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateCloudFrontOriginAccessIdentityRequest WithCloudFrontOriginAccessIdentityConfig(CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig)
        {
            this.cloudFrontOriginAccessIdentityConfig = cloudFrontOriginAccessIdentityConfig;
            return this;
        }
            

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this.cloudFrontOriginAccessIdentityConfig != null;
        }
    }
}
    

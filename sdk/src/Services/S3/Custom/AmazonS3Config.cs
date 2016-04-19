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

using Amazon.Runtime;
using Amazon.Util.Internal;

namespace Amazon.S3
{

    /// <summary>
    /// Configuration for accessing AmazonS3 service
    /// </summary>
    public partial class AmazonS3Config : ClientConfig
    {
        internal const string AccelerateEndpoint ="s3-accelerate.amazonaws.com";

        private bool forcePathStyle = false;
        private bool useAccelerateEndpoint = false;

        /// <summary>
        /// When true, requests will always use path style addressing.
        /// </summary>
        public bool ForcePathStyle
        {
            get { return forcePathStyle; }
            set { forcePathStyle = value; }
        }

        /// <summary>
        /// Enables S3 accelerate by sending requests to the accelerate endpoint instead of the regular region endpoint. 
        /// To use this feature, the bucket name should be DNS compliant names and should not contain periods (.). 
        /// The following APIs are not supported and are sent to the regular region endpoint, even if this option is enabled:
        /// <ol> 
        /// <li>PutBucket</li>
        /// <li>ListBuckets</li>
        /// <li>DeleteBucket</li>
        /// </ol>
        /// </summary>
        public bool UseAccelerateEndpoint
        {
            get { return useAccelerateEndpoint; }
            set { useAccelerateEndpoint = value; }
        }

        /// <summary>
        /// Validate that the config object is properly configured.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.ForcePathStyle && this.UseAccelerateEndpoint)
            {
                throw new AmazonClientException(
                        @"S3 accelerate is not compatible with Path style requests. Disable Path style requests" +
                         " using AmazonS3Config.ForcePathStyle property to use S3 accelerate.");
            }

            var isExplicitAccelerateEndpoint = !string.IsNullOrEmpty(this.ServiceURL) &&
                this.ServiceURL.IndexOf(AccelerateEndpoint,StringComparison.OrdinalIgnoreCase) >= 0;

            if (isExplicitAccelerateEndpoint)
            {

                if (this.RegionEndpoint == null && string.IsNullOrEmpty(this.AuthenticationRegion))
                {
                    throw new AmazonClientException(
                            @"Specify a region using AmazonS3Config.RegionEndpoint or AmazonS3Config.AuthenticationRegion" +
                            " to use S3 accelerate.");
                }
                else
                {
                    if (this.RegionEndpoint == null && !string.IsNullOrEmpty(this.AuthenticationRegion))
                    {
                        this.RegionEndpoint = RegionEndpoint.GetBySystemName(this.AuthenticationRegion);
                    }

                    this.UseAccelerateEndpoint = true;
                }
            }          
        }
        
        /// <summary>
        /// This method contains custom initializations for the config object.
        /// </summary>
        protected override void Initialize()
        {           
            this.AllowAutoRedirect = false;
#if BCL45
            // Set Timeout and ReadWriteTimeout for S3 to max timeout as per-request
            // timeouts are not supported.
            this.Timeout = ClientConfig.MaxTimeout;
            this.ReadWriteTimeout = ClientConfig.MaxTimeout;
#elif PCL
            // Only Timeout property is supported for WinRT and Windows Phone.
            // Set Timeout for S3 to max timeout as per-request
            // timeouts are not supported.
            this.Timeout = ClientConfig.MaxTimeout;
#endif
        }
    }
}

    

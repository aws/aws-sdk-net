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
    /// <para> A complex type that contains information about the Amazon S3 origin. If the origin is a custom origin, use the CustomOriginConfig
    /// element instead. </para>
    /// </summary>
    public class S3OriginConfig
    {
        
        private string originAccessIdentity;

        /// <summary>
        /// The CloudFront origin access identity to associate with the origin. Use an origin access identity to configure the origin so that end users
        /// can only access objects in an Amazon S3 bucket through CloudFront. If you want end users to be able to access objects using either the
        /// CloudFront URL or the Amazon S3 URL, specify an empty OriginAccessIdentity element. To delete the origin access identity from an existing
        /// distribution, update the distribution configuration and include an empty OriginAccessIdentity element. To replace the origin access
        /// identity, update the distribution configuration and specify the new origin access identity.
        ///  
        /// </summary>
        public string OriginAccessIdentity
        {
            get { return this.originAccessIdentity; }
            set { this.originAccessIdentity = value; }
        }

        /// <summary>
        /// Sets the OriginAccessIdentity property
        /// </summary>
        /// <param name="originAccessIdentity">The value to set for the OriginAccessIdentity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3OriginConfig WithOriginAccessIdentity(string originAccessIdentity)
        {
            this.originAccessIdentity = originAccessIdentity;
            return this;
        }
            

        // Check to see if OriginAccessIdentity property is set
        internal bool IsSetOriginAccessIdentity()
        {
            return this.originAccessIdentity != null;
        }
    }
}

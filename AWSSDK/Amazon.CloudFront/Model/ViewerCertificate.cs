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
    /// <para> A complex type that contains information about viewer certificates for this distribution. </para>
    /// </summary>
    public class ViewerCertificate
    {
        
        private string iAMCertificateId;
        private bool? cloudFrontDefaultCertificate;

        /// <summary>
        /// The IAM certificate identifier of the custom viewer certificate for this distribution.
        ///  
        /// </summary>
        public string IAMCertificateId
        {
            get { return this.iAMCertificateId; }
            set { this.iAMCertificateId = value; }
        }

        /// <summary>
        /// Sets the IAMCertificateId property
        /// </summary>
        /// <param name="iAMCertificateId">The value to set for the IAMCertificateId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ViewerCertificate WithIAMCertificateId(string iAMCertificateId)
        {
            this.iAMCertificateId = iAMCertificateId;
            return this;
        }
            

        // Check to see if IAMCertificateId property is set
        internal bool IsSetIAMCertificateId()
        {
            return this.iAMCertificateId != null;
        }

        /// <summary>
        /// Set to true if you want to use the default *.cloudfront.net viewer certificate for this distribution. Omit this value if you are setting an
        /// IAMCertificateId.
        ///  
        /// </summary>
        public bool CloudFrontDefaultCertificate
        {
            get { return this.cloudFrontDefaultCertificate ?? default(bool); }
            set { this.cloudFrontDefaultCertificate = value; }
        }

        /// <summary>
        /// Sets the CloudFrontDefaultCertificate property
        /// </summary>
        /// <param name="cloudFrontDefaultCertificate">The value to set for the CloudFrontDefaultCertificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ViewerCertificate WithCloudFrontDefaultCertificate(bool cloudFrontDefaultCertificate)
        {
            this.cloudFrontDefaultCertificate = cloudFrontDefaultCertificate;
            return this;
        }
            

        // Check to see if CloudFrontDefaultCertificate property is set
        internal bool IsSetCloudFrontDefaultCertificate()
        {
            return this.cloudFrontDefaultCertificate.HasValue;
        }
    }
}

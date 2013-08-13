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
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

using Amazon.S3.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// S3 origin information to associate with the distribution.
    /// </summary>
    public class S3Origin
    {
        string _dnsName;
        CloudFrontOriginAccessIdentity _originAccessIdentity;

        /// <summary>
        /// Initializes a new instance of the S3Origin class.
        /// </summary>
        public S3Origin()
        {
        }


        /// <summary>
        /// Initializes a new instance of the S3Origin class.
        /// </summary>
        /// <param name="dnsName">The DNS name of your Amazon S3 bucket.</param>
        /// <param name="originAccessIdentity">The origin access identity.</param>
        public S3Origin(string dnsName, CloudFrontOriginAccessIdentity originAccessIdentity)
        {
            this.DNSName = dnsName;
            this.OriginAccessIdentity = originAccessIdentity;
        }

        /// <summary>
        /// Gets or sets the DNS name of your Amazon S3 bucket to associate with the distribution.
        /// For example: mybucket.s3.amazonaws.com.
        /// </summary>
        /// <value>The DNS name of your Amazon S3 bucket.</value>
        public string DNSName
        {
            get { return this._dnsName; }
            set 
            {
                if (AmazonS3Util.ValidateV2Bucket(value))
                {
                    this._dnsName = value;
                }
                else
                {
                    throw new AmazonCloudFrontException(
                        "Only Amazon S3 V2 style buckets are acceptable as Origin values"
                        );
                }
            }
        }


        /// <summary>
        /// Sets the DNS name of your Amazon S3 bucket to associate with the distribution and 
        /// returns back this instance for method chaining.
        /// </summary>
        /// <param name="dnsName">The DNS name of your Amazon S3 bucket.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Origin WithDNSName(string dnsName)
        {
            this.DNSName = dnsName;
            return this;
        }

        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets or sets the CloudFront origin access identity to associate with
        /// the distribution. When the distribution is serving private
        /// content this property must be set.
        /// </summary>
        /// <value>The origin access identity.</value>
        public CloudFrontOriginAccessIdentity OriginAccessIdentity
        {
            get { return this._originAccessIdentity; }
            set { this._originAccessIdentity = value; }
        }

        /// <summary>
        /// Sets the CloudFront origin access identity to associate with
        /// the distribution. When the distribution is serving private
        /// content this property must be set.
        /// This instance is returned back for method chaining.
        /// </summary>
        /// <param name="originAccessIdentity">The origin access identity.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Origin WithOriginAccessIdentity(CloudFrontOriginAccessIdentity originAccessIdentity)
        {
            this.OriginAccessIdentity = originAccessIdentity;
            return this;
        }

        internal bool IsSetOriginAccessIdentity()
        {
            return this._originAccessIdentity != null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<S3Origin>");

            sb.Append("<DNSName>");
            sb.Append((this.DNSName.EndsWith(".s3.amazonaws.com")) ? this.DNSName : String.Concat(this.DNSName, ".s3.amazonaws.com"));
            sb.Append("</DNSName>");

            if (this.OriginAccessIdentity != null)
            {
                sb.Append("<OriginAccessIdentity>");
                sb.Append(this.OriginAccessIdentity);
                sb.Append("</OriginAccessIdentity>");
            }

            sb.Append("</S3Origin>");

            return sb.ToString();
        }
    }
}

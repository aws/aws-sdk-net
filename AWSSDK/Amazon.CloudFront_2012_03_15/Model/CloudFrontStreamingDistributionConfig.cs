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
using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Describes a streaming distribution's configuration.
    /// It is used as a request element in Create a Distribution and Set a Distribution's Configuration.
    /// It is used as a response element in Get a Distribution's Information and Get a Distribution's
    /// Configuration.
    /// <para>A streaming distribution configuration objects consists of the following items:
    /// <list type="number">
    /// <item>Caller Reference</item>
    /// <item>Origin S3 Bucket</item>
    /// <item>Comment</item>
    /// <item>A list of CNAMEs for the distribution</item>
    /// <item>Enabled flag</item>
    /// <item>Bucket Logging details</item>
    /// <item>CloudFront Origin Access Identity associated with the distribution.
    /// This is a virtual identity you use to let CloudFront fetch private content 
    /// from your bucket.</item>
    /// <item>The AWS Accounts that have URL signing privileges for Private Content.</item>
    /// </list></para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    public class CloudFrontStreamingDistributionConfig : CloudFrontDistributionConfigBase
    {
        #region Public Methods

        /// <summary>
        /// Creates an XML representation of the CloudFront
        /// distribution configuration. The resulting XML
        /// can be sent to CloudFront when creating or updating
        /// a distribution.
        /// </summary>
        /// <returns>
        /// XML representation of the distribution's configuration
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?><StreamingDistributionConfig ");
            sb.Append("xmlns=\"http://cloudfront.amazonaws.com/doc/2010-11-01/\">");
            sb.Append(base.ToString());
            sb.Append("</StreamingDistributionConfig>");
            return sb.ToString();
        }

        /// <summary>
        /// Sets the Origin property.
        /// </summary>
        /// <param name="origin">Origin property</param>
        /// <returns>this instance</returns>
        [Obsolete("This property has been obsoleted in favor of the WithS3Origin method.")]
        public CloudFrontStreamingDistributionConfig WithOrigin(string origin)
        {
#pragma warning disable 0618
            Origin = origin;
#pragma warning restore 0618
            return this;
        }

        /// <summary>
        /// Sets the Comment property.
        /// </summary>
        /// <param name="comment">Comment property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithComment(string comment)
        {
            this.Comment = comment;
            return this;
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">CallerReference property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithCallerReference(string callerReference)
        {
            this.CallerReference = callerReference;
            return this;
        }

        /// <summary>
        /// Sets the CNAME property. If you set more than 10 CNAME aliases for a distribution,
        /// a <code>TooManyDistributionCNAMEs</code> exception will be returned by CloudFront.
        /// </summary>
        /// <param name="cnames">CNAME property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithCNames(params string[] cnames)
        {
            foreach (string cname in cnames)
            {
                CNAME.Add(cname);
            }
            return this;
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">Enabled property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithEnabled(bool enabled)
        {
            this.Enabled = enabled;
            return this;
        }


        /// <summary>
        /// Sets the OriginAccessIdentity property.
        /// </summary>
        /// <param name="identity">OriginAccessIdentity property</param>
        /// <returns>this instance</returns>
        [Obsolete("This property has been obsoleted in favor of the WithS3Origin method.")]
        public CloudFrontStreamingDistributionConfig WithOriginAccessIdentity(CloudFrontOriginAccessIdentity identity)
        {
#pragma warning disable 0618
            OriginAccessIdentity = identity;
#pragma warning restore 0618
            return this;
        }

        /// <summary>
        /// Sets the TrustedSigners property.
        /// This specifies any AWS accounts you want to permit to create signed URLs for private content.
        /// </summary>
        /// <param name="signers">TrustedSigners property is set to this value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithTrustedSigners(UrlTrustedSigners signers)
        {
            this.TrustedSigners = signers;
            return this;
        }

        #endregion

        #region Logging

        /// <summary>
        /// Sets the Logging property.
        /// </summary>
        /// <param name="bucket">The bucket into which logs will be put</param>
        /// <param name="prefix">The prefix for the log files</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontStreamingDistributionConfig WithLogging(string bucket, string prefix)
        {
            if (String.IsNullOrEmpty(bucket))
            {
                throw new ArgumentNullException(
                    "bucket",
                    "The bucket specified as part of the Logging Config is null or the empty string"
                    );
            }

            Logging = new Tuple<string, string>(bucket, prefix);
            return this;
        }

        #endregion
    }
}

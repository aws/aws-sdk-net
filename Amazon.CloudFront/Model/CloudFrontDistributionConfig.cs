/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-12-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The CloudFrontDistributionConfig complex type describes a distribution's configuration information.
    /// It is used as a request element in Create a Distribution and Set a Distribution's Configuration.
    /// It is used as a response element in Get a Distribution's Information and Get a Distribution's
    /// Configuration.
    /// <para>
    /// A distribution configuration objects consists of the following items:
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
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    public class CloudFrontDistributionConfig : CloudFrontDistributionConfigBase
    {
        #region Private Members

        [field:NonSerializedAttribute()]
        private Tuple<string, string> logging;
        private CloudFrontOriginAccessIdentity identity;
        private UrlTrustedSigners trustedSigners;

        #endregion

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
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?><DistributionConfig ");
            sb.Append("xmlns=\"http://cloudfront.amazonaws.com/doc/2009-12-01/\">");

            if (IsSetOrigin())
            {
                sb.Append("<Origin>");
                sb.Append((Origin.EndsWith(".s3.amazonaws.com")) ? Origin : String.Concat(Origin, ".s3.amazonaws.com"));
                sb.Append("</Origin>");
            }

            if (IsSetCallerReference())
            {
                sb.Append(String.Concat("<CallerReference>", CallerReference, "</CallerReference>"));
            }

            if (IsSetCNames())
            {
                foreach (string cname in CNAME)
                {
                    if (!String.IsNullOrEmpty(cname))
                    {
                        sb.Append(String.Concat("<CNAME>", cname, "</CNAME>"));
                    }
                }
            }

            if (IsSetComment())
            {
                sb.Append(String.Concat("<Comment>", Comment, "</Comment>"));
            }

            sb.Append(String.Concat("<Enabled>", (this.Enabled) ? "true" : "false", "</Enabled>"));

            if (IsSetLogging())
            {
                sb.Append("<Logging>");
                if (!String.IsNullOrEmpty(Logging.First))
                {
                    sb.Append(String.Concat("<Bucket>", Logging.First, "</Bucket>"));
                }

                if (!String.IsNullOrEmpty(Logging.Second))
                {
                    sb.Append(String.Concat("<Prefix>", Logging.Second, "</Prefix>"));
                }
                else
                {
                    sb.Append("<Prefix/>");
                }

                sb.Append("</Logging>");
            }

            if (IsSetOriginAccessIdentity())
            {
                sb.Append(String.Concat("<OriginAccessIdentity>", OriginAccessIdentity, "</OriginAccessIdentity>"));
            }

            if (IsSetTrustedSigners())
            {
                sb.Append(String.Concat("<TrustedSigners>", TrustedSigners, "</TrustedSigners>"));
            }

            sb.Append("</DistributionConfig>");
            return sb.ToString();
        }

        #endregion

        /// <summary>
        /// Sets the Origin property.
        /// </summary>
        /// <param name="origin">Origin property</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithOrigin(string origin)
        {
            Origin = origin;
            return this;
        }

        /// <summary>
        /// Sets the Comment property.
        /// </summary>
        /// <param name="comment">Comment property</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithComment(string comment)
        {
            this.Comment = comment;
            return this;
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">CallerReference property</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithCallerReference(string callerReference)
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
        public CloudFrontDistributionConfig WithCNames(params string[] cnames)
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
        public CloudFrontDistributionConfig WithEnabled(bool enabled)
        {
            this.Enabled = enabled;
            return this;
        }

        #region Logging
        /// <summary>
        /// Gets and Sets the Logging property.
        /// A complex type that controls whether access logs are written for the
        /// distribution. For more information, refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html"/>
        /// </summary>
        /// <remarks>
        /// The Bucket specifies where the CloudFront access logs will be stored. Maximum length is 128
        /// characters and it must conform to Amazon S3 V2 bucket criteria.
        /// <para>The Prefix is an optional string of your choice to prefix to the access log
        /// filenames for this distribution. Maximum length is 256 characters and it can't
        /// start with a '/'</para>
        /// </remarks>
        [XmlIgnore]
        public Tuple<string, string> Logging
        {
            get
            {
                if (this.logging == null)
                {
                    this.logging = new Tuple<string, string>();
                }
                return this.logging;
            }
            set { this.logging = value; }
        }

        /// <summary>
        /// Sets the Logging property.
        /// </summary>
        /// <param name="bucket">The bucket into which logs will be put</param>
        /// <param name="prefix">The prefix for the log files</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithLogging(string bucket, string prefix)
        {
            if (String.IsNullOrEmpty(bucket))
            {
                throw new ArgumentNullException(
                    "bucket",
                    "The bucket specified as part of the Logging Config is null or the empty string"
                    );
            }

            logging = new Tuple<string, string>(bucket, prefix);
            return this;
        }

        /// <summary>
        /// Checks if the Logging property is set.
        /// </summary>
        /// <returns>true if the Logging property is set.</returns>
        internal bool IsSetLogging()
        {
            return (this.logging != null) &&
                (!System.String.IsNullOrEmpty(Logging.First)) &&
                (!System.String.IsNullOrEmpty(Logging.Second));
        }

        #endregion

        #region OriginAccessIdentity

        /// <summary>
        /// Gets and sets the OriginAccessIdentity property.
        /// The CloudFront origin access identity to associate with the distribution. 
        /// If you want the distribution to serve private content, include this element; 
        /// if you want the distribution to serve public content, remove this element.        
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginAccessIdentity")]
        public CloudFrontOriginAccessIdentity OriginAccessIdentity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        /// <summary>
        /// Sets the OriginAccessIdentity property.
        /// </summary>
        /// <param name="identity">OriginAccessIdentity property</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithOriginAccessIdentity(CloudFrontOriginAccessIdentity identity)
        {
            this.identity = identity;
            return this;
        }

        /// <summary>
        /// Checks if OriginAccessIdentity property is set.
        /// </summary>
        /// <returns>true if OriginAccessIdentity property is set.</returns>
        internal bool IsSetOriginAccessIdentity()
        {
            return this.identity != null;
        }

        #endregion

        #region TrustedSigners

        /// <summary>
        /// Gets and sets the TrustedSigners property.
        /// This specifies any AWS accounts you want to permit to create signed URLs for private content.
        /// </summary>
        [XmlElementAttribute(ElementName = "TrustedSigners")]
        public UrlTrustedSigners TrustedSigners
        {
            get { return this.trustedSigners; }
            set { this.trustedSigners = value; }
        }

        /// <summary>
        /// Sets the TrustedSigners property.
        /// This specifies any AWS accounts you want to permit to create signed URLs for private content.
        /// </summary>
        /// <param name="signers">TrustedSigners property is set to this value</param>
        /// <returns>this instance</returns>
        public CloudFrontDistributionConfig WithTrustedSigners(UrlTrustedSigners signers)
        {
            this.trustedSigners = signers;
            return this;
        }

        /// <summary>
        /// Checks if TrustedSigners property is set.
        /// </summary>
        /// <returns>true if TrustedSigners property is set.</returns>
        internal bool IsSetTrustedSigners()
        {
            return this.trustedSigners != null;
        }

        #endregion
    }
}
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
 *  API Version: 2010-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Util;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Describes the elements shared by the various distribution configurations.
    /// <para>The elements shared between configuration objects are:
    /// <list type="number">
    /// <item>Caller Reference</item>
    /// <item>Origin S3 Bucket</item>
    /// <item>Comment</item>
    /// <item>A list of CNAMEs for the distribution</item>
    /// <item>Enabled flag</item>
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/><br />
    /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    public class CloudFrontDistributionConfigBase
    {
        #region Private Members

        private string origin;
        private string callerReference = System.DateTime.UtcNow.ToString();
        private List<string> cnames = new List<string>();
        private string comment;
        private bool enabled;
        private string eTag;
        private CloudFrontOriginAccessIdentity identity;
        private UrlTrustedSigners trustedSigners;

        #endregion

        #region Origin

        /// <summary>
        /// Gets and sets the Origin property.
        /// The Amazon S3 bucket to associate with the distribution.
        /// For example: mybucket.s3.amazonaws.com.
        /// </summary>
        [XmlElementAttribute(ElementName = "Origin")]
        public virtual string Origin
        {
            get { return this.origin; }
            set
            {
                if (AmazonS3Util.ValidateV2Bucket(value))
                {
                    this.origin = value;
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
        /// Checks if Origin property is set.
        /// </summary>
        /// <returns>true if Origin property is set.</returns>
        internal virtual bool IsSetOrigin()
        {
            return !String.IsNullOrEmpty(this.origin);
        }

        #endregion

        #region Comment

        /// <summary>
        /// Gets and sets the Comment property.
        /// Any comments you want to include about the distribution.
        /// The maximum length of the comment is 128 characters
        /// </summary>
        [XmlElementAttribute(ElementName = "Comment")]
        public virtual string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Checks if Comment property is set.
        /// </summary>
        /// <returns>true if Comment property is set.</returns>
        internal virtual bool IsSetComment()
        {
            return !String.IsNullOrEmpty(this.comment);
        }

        #endregion

        #region CallerReference

        /// <summary>
        /// Gets and sets the CallerReference property.
        /// A unique number that ensures the request can't be replayed.
        /// If the CallerReference is new (no matter the content of the CloudFrontDistributionConfig object),
        /// a new distribution is created.
        /// </summary>
        /// <remarks>
        /// <para>If the CallerReference is a value you already sent in a previous request to
        /// create a distribution, and the content of the CloudFrontDistributionConfig is identical to the
        /// original request (ignoring white space), the response includes the same information
        /// returned to the original request.</para>
        /// <para>If the CallerReference is a value you already sent in a previous request to
        /// create a distribution but the content of the CloudFrontDistributionConfig is different from the
        /// original request, CloudFront returns a DistributionAlreadyExists error.</para>
        /// </remarks>
        [XmlElementAttribute(ElementName = "CallerReference")]
        public virtual string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Checks if CallerReference property is set
        /// </summary>
        /// <returns>true if CallerReference property is set</returns>
        internal virtual bool IsSetCallerReference()
        {
            return !String.IsNullOrEmpty(this.callerReference);
        }

        #endregion

        #region CNAME
        /// <summary>
        /// Gets the CNAME property.
        /// A CNAME alias you want to associate with this distribution. You can have up to
        /// 10 CNAME aliases per distribution. For more information, refer:
        /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html"/>
        /// </summary>
        /// <remarks>
        /// Only include a CNAME element if you have a CNAME to associate with the distribution.
        /// Don't include an empty CNAME element in the CloudFrontDistributionConfig object. If you do, CloudFront
        /// returns a MalformedXML error. Only 10 CNAME aliases can be specified for a distribution.
        /// </remarks>
        [XmlElementAttribute(ElementName = "CNAME")]
        public virtual List<string> CNAME
        {
            get
            {
                if (this.cnames == null)
                {
                    this.cnames = new List<string>();
                }
                return this.cnames;
            }
        }

        /// <summary>
        /// Checks if CNAME property is set
        /// </summary>
        /// <returns>true if CNAME property is set</returns>
        internal virtual bool IsSetCNames()
        {
            return (CNAME != null &&
                CNAME.Count > 0);
        }

        #endregion

        #region Enabled

        /// <summary>
        /// Gets and sets the Enabled property.
        /// Whether the distribution is enabled to accept
        /// end user requests for content.
        /// </summary>
        [XmlElementAttribute(ElementName = "Enabled")]
        public virtual bool Enabled
        {
            get { return this.enabled; }
            set { this.enabled = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property of the Distribution Config.
        /// The ETag is the current version of the Distribution's 
        /// Configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public virtual string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Checks if ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !System.String.IsNullOrEmpty(this.eTag);
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
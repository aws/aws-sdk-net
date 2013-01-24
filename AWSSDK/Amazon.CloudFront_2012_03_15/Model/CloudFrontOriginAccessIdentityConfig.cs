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
    /// The CloudFrontOriginAccessIdentityConfig complex type describes an origin access identity's configuration information.
    /// <para>An origin access identity configuration objects consists of the following items:
    /// <list type="number">
    /// <item>Caller Reference</item>
    /// <item>Comment</item>
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    public class CloudFrontOriginAccessIdentityConfig
    {
        #region Private Members

        // Default to UtcNow
        private string callerReference = System.DateTime.UtcNow.ToString();
        private string comment;
        private string eTag;

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
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?><CloudFrontOriginAccessIdentityConfig ");
            sb.Append("xmlns=\"http://cloudfront.amazonaws.com/doc/2010-11-01/\">");

            if (IsSetCallerReference())
            {
                sb.Append(String.Concat("<CallerReference>", CallerReference, "</CallerReference>"));
            }

            if (IsSetComment())
            {
                sb.Append(String.Concat("<Comment>", Comment, "</Comment>"));
            }

            sb.Append("</CloudFrontOriginAccessIdentityConfig>");
            return sb.ToString();
        }

        #endregion

        #region Comment

        /// <summary>
        /// Gets and sets the Comment property.
        /// Any comments you want to include about the distribution.
        /// The maximum length of the comment is 128 characters
        /// </summary>
        [XmlElementAttribute(ElementName = "Comment")]
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Sets the Comment property.
        /// </summary>
        /// <param name="comment">Comment property</param>
        /// <returns>this instance</returns>
        public CloudFrontOriginAccessIdentityConfig WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }

        /// <summary>
        /// Checks if Comment property is set.
        /// </summary>
        /// <returns>true if Comment property is set.</returns>
        internal bool IsSetComment()
        {
            return !String.IsNullOrEmpty(this.comment);
        }

        #endregion

        #region CallerReference

        /// <summary>
        /// Gets and sets the CallerReference property.
        /// A unique number that ensures the request can't be replayed.
        /// If the CallerReference is new (no matter the content of the 
        /// CloudFrontOriginAccessIdentityConfig object), a new distribution 
        /// is created. The default value set by the AWS SDK for NET is the 
        /// UtcNow timestamp.
        /// </summary>
        /// <remarks>
        /// <para>If the CallerReference is a value you already sent in a previous request to
        /// create an identity, and the content of the CloudFrontOriginAccessIdentityConfig is 
        /// identical to the original request (ignoring white space), the response includes 
        /// the same information returned to the original request.</para>
        /// <para>If the CallerReference is a value you already sent in a previous request to
        /// create an identity but the content of the CloudFrontOriginAccessIdentityConfig is different from the
        /// original request, CloudFront returns a CloudFrontOriginAccessIdentityAlreadyExists error.</para>
        /// </remarks>
        [XmlElementAttribute(ElementName = "CallerReference")]
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">CallerReference property</param>
        /// <returns>this instance</returns>
        public CloudFrontOriginAccessIdentityConfig WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }

        /// <summary>
        /// Checks if CallerReference property is set
        /// </summary>
        /// <returns>true if CallerReference property is set</returns>
        internal bool IsSetCallerReference()
        {
            return !String.IsNullOrEmpty(this.callerReference);
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property of this 
        /// Origin Access Identity Configuration. 
        /// The ETag is the current version of the 
        /// configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        /// <summary>
        /// Checks if the ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !System.String.IsNullOrEmpty(this.eTag);
        }

        #endregion
    }
}
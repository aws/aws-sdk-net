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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// A CloudFrontOriginAccessIdentity describes the information about a CloudFront Origin
    /// Access Identity. It is used as a response element when Creating a new CloudFront Origin Access
    /// Identity and when an Origin Access Identity's details are retrieved.
    /// <para>An origin access identity consists of the following items:
    /// <list type="number">
    /// <item>Id</item>
    /// <item>S3 Canonical User Id</item>
    /// <item>The Configuration for the Origin Access Identity</item>
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/OAIConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class CloudFrontOriginAccessIdentity
    {
        #region Private Members

        private string id;
        private string canonicalUserId;
        private CloudFrontOriginAccessIdentityConfig config;
        private string eTag;

        #endregion

        #region Id

        /// <summary>
        /// Gets and sets the Id property. This is the Id returned by CloudFront
        /// when the distribution is created and is unique to the Distribution.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public string Id
        {
            get { return this.id; }
            set {
                this.id = value;
                // When an origin access identity is returned as part of a 
                // distribution's configuration, the value looks like:
                // origin-access-identity/cloudfront/E74FTE3AJFJ256A
                if (id.Contains("/"))
                {
                    string[] parts = id.Split('/');
                    id = parts[parts.Length - 1];
                }
            }
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return !String.IsNullOrEmpty(this.id);
        }

        #endregion

        #region S3CanonicalUserId

        /// <summary>
        /// Gets and sets the Status property.
        /// The current status of the Distribution can either be Deployed or In Progres
        /// </summary>
        [XmlElementAttribute(ElementName = "S3CanonicalUserId")]
        public string S3CanonicalUserId
        {
            get { return this.canonicalUserId; }
            set { this.canonicalUserId = value; }
        }

        /// <summary>
        /// Checks if S3CanonicalUserId property is set.
        /// </summary>
        /// <returns>true if S3CanonicalUserId property is set.</returns>
        internal bool IsSetS3CanonicalUserId()
        {
            return !String.IsNullOrEmpty(this.canonicalUserId);
        }

        #endregion

        #region OriginAccessIdentityConfig

        /// <summary>
        /// Gets and sets the current Origin Access Identity Configuration.
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginAccessIdentityConfig")]
        public CloudFrontOriginAccessIdentityConfig OriginAccessIdentityConfig
        {
            get
            {
                if (null == this.config)
                {
                    this.config = new CloudFrontOriginAccessIdentityConfig();
                }
                return this.config;
            }
            set { this.config = value; }
        }

        /// <summary>
        /// Checks if OriginAccessIdentityConfig property is set
        /// </summary>
        /// <returns>true if OriginAccessIdentityConfig property is set</returns>
        internal bool IsSetConfig()
        {
            return this.config != null;
        }

        #endregion

        /// <summary>
        /// Creates an XML representation of this CloudFront
        /// Origin Access Identity.
        /// </summary>
        /// <returns>
        /// XML representation of the Origin Access Identity
        /// </returns>
        public override string ToString()
        {
            if (IsSetId())
            {
                return String.Concat(
                    "origin-access-identity/cloudfront/",
                    Id);
            }
            else
            {
                throw new AmazonCloudFrontException("A CloudFront Origin Access Identity object has no ID!");
            }
        }

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property of this 
        /// Origin Access Identity's Information.
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
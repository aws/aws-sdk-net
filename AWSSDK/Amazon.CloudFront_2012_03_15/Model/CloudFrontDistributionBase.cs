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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Util;
using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The DistributionBase contains the common elements of a CloudFront distribution.
    /// <para>The shared elements are:
    /// <list type="number">
    /// <item>Id</item>
    /// <item>Status</item>
    /// <item>Last Modified Timestamp</item>
    /// <item>Domain Name</item>
    /// <item>The Configuration for the Distribution</item>
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionDatatype.html"/><br />
    /// - <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/StreamingDistributionDatatype.html"/>
    /// </summary>
    [Serializable()]
    [XmlRootAttribute(Namespace = "http://cloudfront.amazonaws.com/doc/2010-11-01/", IsNullable = false)]
    public class CloudFrontDistributionBase
    {
        #region Private Members

        private string id;
        private string status;
        private DateTime? lastModifiedTime;
        private string domainName;
        private string eTag;
        private List<Signer> activeTrustedSigners;

        #endregion

        #region Id

        /// <summary>
        /// Gets and sets the Id property. This is the Id returned by CloudFront
        /// when the distribution is created and is unique to the Distribution.
        /// </summary>
        [XmlElementAttribute(ElementName = "Id")]
        public virtual string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal virtual bool IsSetId()
        {
            return !String.IsNullOrEmpty(this.id);
        }

        #endregion

        #region Status

        /// <summary>
        /// Gets and sets the Status property.
        /// The current status of the Distribution can either be Deployed or In Progres
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public virtual string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Checks if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        internal virtual bool IsSetStatus()
        {
            return !String.IsNullOrEmpty(this.status);
        }

        #endregion

        #region LastModifiedTime

        /// <summary>
        /// Gets and sets the LastModifiedTime property.
        /// The date and time the distribution was last modified. The 
        /// string returned is the GMT representation of DateTime.
        /// The date is in the format YYYY-MM-DDThh:mm:ssZ, as specified in the 
        /// ISO 8601 standard (e.g., 2008-07-24T19:37:58Z) 
        /// </summary>
        [XmlElementAttribute(ElementName = "LastModifiedTime")]
        public virtual string LastModifiedTime
        {
            get
            {
                return this.lastModifiedTime.GetValueOrDefault().ToString(
                    AWSSDKUtils.GMTDateFormat
                    );
            }
            set
            {
                try
                {
                    this.lastModifiedTime = DateTime.ParseExact(
                        value,
                        AWSSDKUtils.ISO8601DateFormat,
                        CultureInfo.InvariantCulture
                        );
                }
                catch (FormatException)
                {
                   this.lastModifiedTime = DateTime.ParseExact(
                        value,
                        AWSSDKUtils.ISO8601DateFormatNoMS,
                        CultureInfo.InvariantCulture
                        );
                }
            }
        }

        /// <summary>
        /// Checks if LastModifiedTime property is set.
        /// </summary>
        /// <returns>true if LastModifiedTime property is set.</returns>
        internal virtual bool IsSetLastModifiedTime()
        {
            return lastModifiedTime.HasValue;
        }

        #endregion

        #region DomainName

        /// <summary>
        /// Gets and sets the DomainName property.
        /// The domain name corresponding to the distribution. For example, 
        /// e604721fxaaqy9.cloudfront.net.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainName")]
        public virtual string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        /// <summary>
        /// Checks if DomainName property is set
        /// </summary>
        /// <returns>true if DomainName property is set</returns>
        internal virtual bool IsSetDomainName()
        {
            return !String.IsNullOrEmpty(this.domainName);
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property of this 
        /// Distribution's information.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public virtual string ETag
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

        #region ActiveTrustedSigners

        /// <summary>
        /// Gets and sets the ActiveTrustedSigners property.
        /// This specifies any AWS accounts you want to permit to create signed URLs for private content.
        /// </summary>
        [XmlElementAttribute(ElementName = "Signer")]
        public List<Signer> ActiveTrustedSigners
        {
            get
            {
                if (this.activeTrustedSigners == null)
                {
                    this.activeTrustedSigners = new List<Signer>();
                }
                return this.activeTrustedSigners;
            }
            set { this.activeTrustedSigners = value; }
        }

        /// <summary>
        /// Checks if ActiveTrustedSigners property is set.
        /// </summary>
        /// <returns>true if ActiveTrustedSigners property is set.</returns>
        internal bool IsSetActiveTrustedSigners()
        {
            return this.ActiveTrustedSigners.Count > 0;
        }

        #endregion

        /// <summary>
        /// Returns the string representation of the distribution.
        /// </summary>
        /// <returns>
        /// A string representing the distribution
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            XmlSerializer ser = new XmlSerializer(this.GetType());
            using (System.IO.StringWriter sr = new System.IO.StringWriter(sb))
            {
                ser.Serialize(sr, this);
            }
            return sb.ToString();
        }
    }
}
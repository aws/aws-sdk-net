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

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The UrlTrustedSigners complex type specifies any AWS accounts you want to permit to create signed URLs for private content.
    /// To specify who can sign URLs
    /// <list type="number">
    /// <item>Enable yourself to be a trusted signer (you must explicitly give yourself permission).
    /// <see cref="P:Amazon.CloudFront.Model.UrlTrustedSigners.EnableSelf"/>
    /// </item>
    /// <item>Add an AwsAccountNumber for each AWS account (other than your own) that you want to give signing 
    /// authority (limit of five). Remove the dashes from the account number.
    /// <see cref="P:Amazon.CloudFront.Model.UrlTrustedSigners.AwsAccountNumbers"/>
    /// </item>
    /// </list>
    /// If you want the distribution to use signed URLs, include this element in the DistributionConfig for your CloudFront 
    /// distribution either while creating the distribution or by updating the distribution's config.
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
    /// </summary>
    /// <seealso cref="M:Amazon.CloudFront.AmazonCloudFrontClient.SetDistributionConfig" />
    /// <seealso cref="M:Amazon.CloudFront.AmazonCloudFrontClient.CreateDistribution"/>
    /// <seealso cref="T:Amazon.CloudFront.Model.CloudFrontDistributionConfig"/>
    [Serializable()]
    public class UrlTrustedSigners
    {
        #region Private Members
        
        private bool enableSelf;
        private List<string> awsAccounts;

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates an string representation of the UrlTrustedSigners object
        /// by overriding the default Object ToString method. This string
        /// can be concatenated to the distribution config xml that is sent 
        /// to CloudFront while creating a distribution or updating a distribution's
        /// configuration.
        /// </summary>
        /// <returns>
        /// String representation of the UrlTrustedSigners type.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            if (EnableSelf)
            {
                sb.Append("<Self/>");
            }

            if (IsSetAwsAccounts())
            {
                foreach (string account in AwsAccountNumbers)
                {
                    sb.Append(String.Concat("<AwsAccountNumber>", account, "</AwsAccountNumber>"));
                }
            }
            return sb.ToString();
        }

        #endregion

        #region AwsAccountNumbers
        /// <summary>
        /// Gets and sets the AwsAccountNumbers property.
        /// A list of the AwsAccountNumbers for each AWS account (other than your own) 
        /// that you want to give URL signing authority to (limit of five).
        /// </summary>
        [XmlElementAttribute(ElementName = "AwsAccountNumber")]
        public List<string> AwsAccountNumbers
        {
            get
            {
                if (this.awsAccounts == null)
                {
                    this.awsAccounts = new List<string>();
                }
                return this.awsAccounts;
            }
            set { this.awsAccounts = value; }
        }

        /// <summary>
        /// Sets the AwsAccountNumbers property. Please provide the AWS account number without dashes.
        /// If you set more than 5 trusted signers for URLs,
        /// a <code>TooManyTrustedSigners</code> exception will be returned by CloudFront.
        /// </summary>
        /// <param name="awsAccounts">Value that the AwsAccountNumbers property will be set to</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UrlTrustedSigners WithAwsAccountNumbers(params string[] awsAccounts)
        {
            foreach (string account in awsAccounts)
            {
                AwsAccountNumbers.Add(account);
            }
            return this;
        }

        /// <summary>
        /// Checks if AwsAccountNumbers property is set
        /// </summary>
        /// <returns>true if AwsAccountNumbers property is set</returns>
        internal bool IsSetAwsAccounts()
        {
            return AwsAccountNumbers.Count > 0;
        }

        #endregion

        #region EnableSelf

        /// <summary>
        /// Gets and sets the EnableSelf property.
        /// Whether your own AWS account is authorized to sign URLs.
        /// Default - your AWS account is not authorized to sign URLs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Self")]
        public bool EnableSelf
        {
            get { return this.enableSelf; }
            set { this.enableSelf = value; }
        }

        /// <summary>
        /// Sets the EnableSelf property
        /// </summary>
        /// <param name="enableSelf">EnableSelf property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UrlTrustedSigners WithEnableSelf(bool enableSelf)
        {
            this.enableSelf = enableSelf;
            return this;
        }

        #endregion
    }
}

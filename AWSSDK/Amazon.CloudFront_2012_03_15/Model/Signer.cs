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
    /// The Signer complex type specifies an AWS accounts that has permission to create signed URLs 
    /// for private content. The Accounts that have signing privileges are specified in the 
    /// DistributionConfig complex type and can be set using the SetDistributionConfig CloudFront
    /// operation. A signer can be:
    /// <list type="number">
    /// <item>Yourself (you must explicitly give yourself permission).
    /// <see cref="P:Amazon.CloudFront.Model.UrlTrustedSigners.EnableSelf"/>
    /// </item>
    /// <item>An AwsAccountNumber for each AWS account (other than your own) that you is given signing 
    /// authority. The account number has no dashes.
    /// <see cref="P:Amazon.CloudFront.Model.UrlTrustedSigners.AwsAccountNumbers"/>
    /// </item>
    /// </list>
    /// The Signer element also includes the IDs of any active key pairs associated with the trusted signer's 
    /// AWS account. If no KeyPairId  element appears for a Signer, that signer can't create working signed URLs. 
    /// </summary>
    /// <seealso cref="M:Amazon.CloudFront.AmazonCloudFrontClient.SetDistributionConfig" />
    /// <seealso cref="T:Amazon.CloudFront.Model.CloudFrontDistributionConfig"/>
    /// <seealso href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
    [Serializable()]
    public class Signer
    {
        #region Private Members

        private bool self;
        private List<string> keypairId;
        private string awsAccountNumber;

        #endregion

        #region KeyPairId
        /// <summary>
        /// Gets and Sets the KeyPairId property.
        /// A list of the KeyPairId for the AWS account
        /// that has URL signing authority.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyPairId")]
        public List<string> KeyPairId
        {
            get
            {
                if (this.keypairId == null)
                {
                    this.keypairId = new List<string>();
                }
                return this.keypairId;
            }
            set { this.keypairId = value; }
        }

        /// <summary>
        /// Checks if KeyPairId property is set
        /// </summary>
        /// <returns>true if KeyPairId property is set</returns>
        internal bool IsSetKeypairId()
        {
            return KeyPairId.Count > 0;
        }

        #endregion

        #region Self

        /// <summary>
        /// Gets and sets the Self property.
        /// Whether this Signer specifies "your" account.
        /// </summary>
        [XmlElementAttribute(ElementName = "Self")]
        public bool Self
        {
            get { return this.self; }
            set { this.self = value; }
        }

        #endregion

        #region AwsAccountNumber

        /// <summary>
        /// Gets and sets the AwsAccountNumber property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AwsAccountNumber")]
        public string AwsAccountNumber
        {
            get { return this.awsAccountNumber; }
            set { this.awsAccountNumber = value; }
        }

        /// <summary>
        /// Checks if AwsAccountNumber property is set
        /// </summary>
        /// <returns>true if AwsAccountNumber property is set</returns>
        internal bool IsSetAwsAccountNumber()
        {
            return !String.IsNullOrEmpty(this.AwsAccountNumber);
        }

        #endregion
    }
}
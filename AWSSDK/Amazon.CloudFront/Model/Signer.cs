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
    /// <para> A complex type that lists the AWS accounts that were included in the TrustedSigners complex type, as well as their active CloudFront
    /// key pair IDs, if any. </para>
    /// </summary>
    public class Signer
    {
        
        private string awsAccountNumber;
        private KeyPairIds keyPairIds;

        /// <summary>
        /// Specifies an AWS account that can create signed URLs. Values: self, which indicates that the AWS account that was used to create the
        /// distribution can created signed URLs, or an AWS account number. Omit the dashes in the account number.
        ///  
        /// </summary>
        public string AwsAccountNumber
        {
            get { return this.awsAccountNumber; }
            set { this.awsAccountNumber = value; }
        }

        /// <summary>
        /// Sets the AwsAccountNumber property
        /// </summary>
        /// <param name="awsAccountNumber">The value to set for the AwsAccountNumber property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Signer WithAwsAccountNumber(string awsAccountNumber)
        {
            this.awsAccountNumber = awsAccountNumber;
            return this;
        }
            

        // Check to see if AwsAccountNumber property is set
        internal bool IsSetAwsAccountNumber()
        {
            return this.awsAccountNumber != null;
        }

        /// <summary>
        /// A complex type that lists the active CloudFront key pairs, if any, that are associated with AwsAccountNumber.
        ///  
        /// </summary>
        public KeyPairIds KeyPairIds
        {
            get { return this.keyPairIds; }
            set { this.keyPairIds = value; }
        }

        /// <summary>
        /// Sets the KeyPairIds property
        /// </summary>
        /// <param name="keyPairIds">The value to set for the KeyPairIds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Signer WithKeyPairIds(KeyPairIds keyPairIds)
        {
            this.keyPairIds = keyPairIds;
            return this;
        }
            

        // Check to see if KeyPairIds property is set
        internal bool IsSetKeyPairIds()
        {
            return this.keyPairIds != null;
        }
    }
}

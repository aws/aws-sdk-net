/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that lists the AWS accounts that were included in the TrustedSigners
    /// complex type, as well as their active CloudFront key pair IDs, if any.
    /// </summary>
    public partial class Signer
    {
        private string _awsAccountNumber;
        private KeyPairIds _keyPairIds;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Signer() { }

        /// <summary>
        /// Gets and sets the property AwsAccountNumber. Specifies an AWS account that can create
        /// signed URLs. Values: self, which indicates that the AWS account that was used to create
        /// the distribution can created signed URLs, or an AWS account number. Omit the dashes
        /// in the account number.
        /// </summary>
        public string AwsAccountNumber
        {
            get { return this._awsAccountNumber; }
            set { this._awsAccountNumber = value; }
        }

        // Check to see if AwsAccountNumber property is set
        internal bool IsSetAwsAccountNumber()
        {
            return this._awsAccountNumber != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairIds. A complex type that lists the active CloudFront
        /// key pairs, if any, that are associated with AwsAccountNumber.
        /// </summary>
        public KeyPairIds KeyPairIds
        {
            get { return this._keyPairIds; }
            set { this._keyPairIds = value; }
        }

        // Check to see if KeyPairIds property is set
        internal bool IsSetKeyPairIds()
        {
            return this._keyPairIds != null;
        }

    }
}
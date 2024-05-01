/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A list of Amazon Web Services accounts and the active CloudFront key pairs in each
    /// account that CloudFront can use to verify the signatures of signed URLs and signed
    /// cookies.
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
        /// Gets and sets the property AwsAccountNumber. 
        /// <para>
        /// An Amazon Web Services account number that contains active CloudFront key pairs that
        /// CloudFront can use to verify the signatures of signed URLs and signed cookies. If
        /// the Amazon Web Services account that owns the key pairs is the same account that owns
        /// the CloudFront distribution, the value of this field is <c>self</c>.
        /// </para>
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
        /// Gets and sets the property KeyPairIds. 
        /// <para>
        /// A list of CloudFront key pair identifiers.
        /// </para>
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
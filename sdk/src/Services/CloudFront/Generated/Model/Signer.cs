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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// A complex type that lists the AWS accounts that were included in the <code>TrustedSigners</code>
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
        /// Gets and sets the property AwsAccountNumber. 
        /// <para>
        /// An AWS account that is included in the <code>TrustedSigners</code> complex type for
        /// this RTMP distribution. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>self</code>, which is the AWS account used to create the distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An AWS account number.
        /// </para>
        ///  </li> </ul>
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
        /// A complex type that lists the active CloudFront key pairs, if any, that are associated
        /// with <code>AwsAccountNumber</code>.
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
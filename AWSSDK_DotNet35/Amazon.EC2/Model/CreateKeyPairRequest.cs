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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyPair operation.
    /// Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public
    /// key and displays the private key for you to save to a file. The private key is returned
    /// as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name
    /// already exists, Amazon EC2 returns an error.
    /// 
    ///  
    /// <para>
    /// You can have up to five thousand key pairs per region.
    /// </para>
    ///  
    /// <para>
    /// The key pair returned to you is available only in the region in which you create it.
    /// To create a key pair that is available in all regions, use <a>ImportKeyPair</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class CreateKeyPairRequest : AmazonEC2Request
    {
        private string _keyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateKeyPairRequest() { }

        /// <summary>
        /// Instantiates CreateKeyPairRequest with the parameterized properties
        /// </summary>
        /// <param name="keyName">A unique name for the key pair. Constraints: Up to 255 ASCII characters</param>
        public CreateKeyPairRequest(string keyName)
        {
            _keyName = keyName;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A unique name for the key pair.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 ASCII characters
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

    }
}
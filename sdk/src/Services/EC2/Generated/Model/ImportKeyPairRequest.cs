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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportKeyPair operation.
    /// Imports the public key from an RSA key pair that you created with a third-party tool.
    /// Compare this with <a>CreateKeyPair</a>, in which AWS creates the key pair and gives
    /// the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create
    /// the key pair and give AWS just the public key. The private key is never transferred
    /// between you and AWS.
    /// 
    ///  
    /// <para>
    /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImportKeyPairRequest : AmazonEC2Request
    {
        private string _keyName;
        private string _publicKeyMaterial;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ImportKeyPairRequest() { }

        /// <summary>
        /// Instantiates ImportKeyPairRequest with the parameterized properties
        /// </summary>
        /// <param name="keyName">A unique name for the key pair.</param>
        /// <param name="publicKeyMaterial">The public key. For API calls, the text must be base64-encoded. For command line tools, base64 encoding is performed for you.</param>
        public ImportKeyPairRequest(string keyName, string publicKeyMaterial)
        {
            _keyName = keyName;
            _publicKeyMaterial = publicKeyMaterial;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A unique name for the key pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PublicKeyMaterial. 
        /// <para>
        /// The public key. For API calls, the text must be base64-encoded. For command line tools,
        /// base64 encoding is performed for you.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublicKeyMaterial
        {
            get { return this._publicKeyMaterial; }
            set { this._publicKeyMaterial = value; }
        }

        // Check to see if PublicKeyMaterial property is set
        internal bool IsSetPublicKeyMaterial()
        {
            return this._publicKeyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the imported key pair.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}
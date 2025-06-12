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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyPair operation.
    /// Creates an ED25519 or 2048-bit RSA key pair with the specified name and in the specified
    /// format. Amazon EC2 stores the public key and displays the private key for you to save
    /// to a file. The private key is returned as an unencrypted PEM encoded PKCS#1 private
    /// key or an unencrypted PPK formatted private key for use with PuTTY. If a key with
    /// the specified name already exists, Amazon EC2 returns an error.
    /// 
    ///  
    /// <para>
    /// The key pair returned to you is available only in the Amazon Web Services Region in
    /// which you create it. If you prefer, you can create your own key pair using a third-party
    /// tool and upload it to any Region using <a>ImportKeyPair</a>.
    /// </para>
    ///  
    /// <para>
    /// You can have up to 5,000 key pairs per Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
    /// EC2 key pairs</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateKeyPairRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private KeyFormat _keyFormat;
        private string _keyName;
        private KeyType _keyType;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyFormat. 
        /// <para>
        /// The format of the key pair.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>pem</c> 
        /// </para>
        /// </summary>
        public KeyFormat KeyFormat
        {
            get { return this._keyFormat; }
            set { this._keyFormat = value; }
        }

        // Check to see if KeyFormat property is set
        internal bool IsSetKeyFormat()
        {
            return this._keyFormat != null;
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
        /// Gets and sets the property KeyType. 
        /// <para>
        /// The type of key pair. Note that ED25519 keys are not supported for Windows instances.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>rsa</c> 
        /// </para>
        /// </summary>
        public KeyType KeyType
        {
            get { return this._keyType; }
            set { this._keyType = value; }
        }

        // Check to see if KeyType property is set
        internal bool IsSetKeyType()
        {
            return this._keyType != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new key pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
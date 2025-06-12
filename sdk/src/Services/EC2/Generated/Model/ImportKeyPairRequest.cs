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
    /// Container for the parameters to the ImportKeyPair operation.
    /// Imports the public key from an RSA or ED25519 key pair that you created using a third-party
    /// tool. You give Amazon Web Services only the public key. The private key is never transferred
    /// between you and Amazon Web Services.
    /// 
    ///  
    /// <para>
    /// For more information about the requirements for importing a key pair, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-key-pairs.html#how-to-generate-your-own-key-and-import-it-to-aws">Create
    /// a key pair and import the public key to Amazon EC2</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImportKeyPairRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _keyName;
        private string _publicKeyMaterial;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ImportKeyPairRequest() { }

        /// <summary>
        /// Instantiates ImportKeyPairRequest with the parameterized properties
        /// </summary>
        /// <param name="keyName">A unique name for the key pair.</param>
        /// <param name="publicKeyMaterial">The public key.</param>
        public ImportKeyPairRequest(string keyName, string publicKeyMaterial)
        {
            _keyName = keyName;
            _publicKeyMaterial = publicKeyMaterial;
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
        /// The public key.
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
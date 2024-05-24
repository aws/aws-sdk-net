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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// The password data for the Windows Server-based instance, including the ciphertext
    /// and the key pair name.
    /// </summary>
    public partial class PasswordData
    {
        private string _ciphertext;
        private string _keyPairName;

        /// <summary>
        /// Gets and sets the property Ciphertext. 
        /// <para>
        /// The encrypted password. Ciphertext will be an empty string if access to your new instance
        /// is not ready yet. When you create an instance, it can take up to 15 minutes for the
        /// instance to be ready.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the default key pair (<c>LightsailDefaultKeyPair</c>), the decrypted password
        /// will be available in the password field.
        /// </para>
        ///  
        /// <para>
        /// If you are using a custom key pair, you need to use your own means of decryption.
        /// </para>
        ///  
        /// <para>
        /// If you change the Administrator password on the instance, Lightsail will continue
        /// to return the original ciphertext value. When accessing the instance using RDP, you
        /// need to manually enter the Administrator password after changing it from the default.
        /// </para>
        ///  </note>
        /// </summary>
        public string Ciphertext
        {
            get { return this._ciphertext; }
            set { this._ciphertext = value; }
        }

        // Check to see if Ciphertext property is set
        internal bool IsSetCiphertext()
        {
            return this._ciphertext != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairName. 
        /// <para>
        /// The name of the key pair that you used when creating your instance. If no key pair
        /// name was specified when creating the instance, Lightsail uses the default key pair
        /// (<c>LightsailDefaultKeyPair</c>).
        /// </para>
        ///  
        /// <para>
        /// If you are using a custom key pair, you need to use your own means of decrypting your
        /// password using the <c>ciphertext</c>. Lightsail creates the ciphertext by encrypting
        /// your password with the public key part of this key pair.
        /// </para>
        /// </summary>
        public string KeyPairName
        {
            get { return this._keyPairName; }
            set { this._keyPairName = value; }
        }

        // Check to see if KeyPairName property is set
        internal bool IsSetKeyPairName()
        {
            return this._keyPairName != null;
        }

    }
}
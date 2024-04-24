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
    /// This is the response object from the CreateKeyPair operation.
    /// </summary>
    public partial class CreateKeyPairResponse : AmazonWebServiceResponse
    {
        private KeyPair _keyPair;
        private Operation _operation;
        private string _privateKeyBase64;
        private string _publicKeyBase64;

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// An array of key-value pairs containing information about the new key pair you just
        /// created.
        /// </para>
        /// </summary>
        public KeyPair KeyPair
        {
            get { return this._keyPair; }
            set { this._keyPair = value; }
        }

        // Check to see if KeyPair property is set
        internal bool IsSetKeyPair()
        {
            return this._keyPair != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// An array of objects that describe the result of the action, such as the status of
        /// the request, the timestamp of the request, and the resources affected by the request.
        /// </para>
        /// </summary>
        public Operation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyBase64. 
        /// <para>
        /// A base64-encoded RSA private key.
        /// </para>
        /// </summary>
        public string PrivateKeyBase64
        {
            get { return this._privateKeyBase64; }
            set { this._privateKeyBase64 = value; }
        }

        // Check to see if PrivateKeyBase64 property is set
        internal bool IsSetPrivateKeyBase64()
        {
            return this._privateKeyBase64 != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyBase64. 
        /// <para>
        /// A base64-encoded public key of the <c>ssh-rsa</c> type.
        /// </para>
        /// </summary>
        public string PublicKeyBase64
        {
            get { return this._publicKeyBase64; }
            set { this._publicKeyBase64 = value; }
        }

        // Check to see if PublicKeyBase64 property is set
        internal bool IsSetPublicKeyBase64()
        {
            return this._publicKeyBase64 != null;
        }

    }
}
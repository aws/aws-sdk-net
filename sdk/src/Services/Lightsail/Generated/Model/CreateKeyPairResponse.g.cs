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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// An array of key-value pairs containing information about the new key pair you just
        /// created.
        /// </para>
        /// </summary>
        public KeyPair KeyPair { get; set; }

        /// <summary>
        /// Checks to see if the KeyPair property is set.
        /// </summary>
        internal bool IsSetKeyPair() => this.KeyPair != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// An array of objects that describe the result of the action, such as the status of
        /// the request, the timestamp of the request, and the resources affected by the request.
        /// </para>
        /// </summary>
        public Operation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyBase64. 
        /// <para>
        /// A base64-encoded RSA private key.
        /// </para>
        /// </summary>
        public string PrivateKeyBase64 { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyBase64 property is set.
        /// </summary>
        internal bool IsSetPrivateKeyBase64() => this.PrivateKeyBase64 != null;

        /// <summary>
        /// Gets and sets the property PublicKeyBase64. 
        /// <para>
        /// A base64-encoded public key of the <c>ssh-rsa</c> type.
        /// </para>
        /// </summary>
        public string PublicKeyBase64 { get; set; }

        /// <summary>
        /// Checks to see if the PublicKeyBase64 property is set.
        /// </summary>
        internal bool IsSetPublicKeyBase64() => this.PublicKeyBase64 != null;
    }
}

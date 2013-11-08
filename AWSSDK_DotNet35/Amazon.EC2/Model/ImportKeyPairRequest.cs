/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ImportKeyPair operation.
    /// <para> Imports the public key from an RSA key pair created with a third-party tool. This operation differs from CreateKeyPair as the private
    /// key is never transferred between the caller and AWS servers. </para> <para> RSA key pairs are easily created on Microsoft Windows and Linux
    /// OS systems using the <c>ssh-keygen</c> command line tool provided with the standard OpenSSH installation. Standard library support for RSA
    /// key pair creation is also available for Java, Ruby, Python, and many other programming languages. </para> <para>The following formats are
    /// supported:</para>
    /// <ul>
    /// <li> OpenSSH public key format, </li>
    /// <li> Base64 encoded DER format. </li>
    /// <li> SSH public key file format as specified in <a href="http://tools.ietf.org/html/rfc4716" > RFC4716 </a> .
    /// </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class ImportKeyPairRequest : AmazonEC2Request
    {
        private string keyName;
        private string publicKeyMaterial;


        /// <summary>
        /// The unique name for the key pair.
        ///  
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;
        }

        /// <summary>
        /// The public key portion of the key pair being imported.
        ///  
        /// </summary>
        public string PublicKeyMaterial
        {
            get { return this.publicKeyMaterial; }
            set { this.publicKeyMaterial = value; }
        }

        // Check to see if PublicKeyMaterial property is set
        internal bool IsSetPublicKeyMaterial()
        {
            return this.publicKeyMaterial != null;
        }

    }
}
    

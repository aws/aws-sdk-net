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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Describes an Amazon EC2 key pair. This is a summary of the key pair data, and will not contain the actual private key material.
    /// </para> <para> The private key material is only available when initially creating the key pair. </para>
    /// </summary>
    public class KeyPairInfo
    {
        
        private string keyName;
        private string keyFingerprint;


        /// <summary>
        /// The name of the key pair.
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
        /// The SHA-1 digest of the DER encoded private key.
        ///  
        /// </summary>
        public string KeyFingerprint
        {
            get { return this.keyFingerprint; }
            set { this.keyFingerprint = value; }
        }

        // Check to see if KeyFingerprint property is set
        internal bool IsSetKeyFingerprint()
        {
            return this.keyFingerprint != null;
        }
    }
}

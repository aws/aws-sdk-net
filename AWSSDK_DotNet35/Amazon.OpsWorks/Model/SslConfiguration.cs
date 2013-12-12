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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes an app's SSL configuration.</para>
    /// </summary>
    public class SslConfiguration
    {
        
        private string certificate;
        private string privateKey;
        private string chain;


        /// <summary>
        /// The contents of the certificate's domain.crt file.
        ///  
        /// </summary>
        public string Certificate
        {
            get { return this.certificate; }
            set { this.certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this.certificate != null;
        }

        /// <summary>
        /// The private key; the contents of the certificate's domain.kex file.
        ///  
        /// </summary>
        public string PrivateKey
        {
            get { return this.privateKey; }
            set { this.privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this.privateKey != null;
        }

        /// <summary>
        /// Optional. Can be used to specify an intermediate certificate authority key or client authentication.
        ///  
        /// </summary>
        public string Chain
        {
            get { return this.chain; }
            set { this.chain = value; }
        }

        // Check to see if Chain property is set
        internal bool IsSetChain()
        {
            return this.chain != null;
        }
    }
}

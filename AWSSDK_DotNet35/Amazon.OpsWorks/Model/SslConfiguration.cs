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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes an app's SSL configuration.
    /// </summary>
    public partial class SslConfiguration
    {
        private string _certificate;
        private string _chain;
        private string _privateKey;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The contents of the certificate's domain.crt file.
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property Chain. 
        /// <para>
        /// Optional. Can be used to specify an intermediate certificate authority key or client
        /// authentication.
        /// </para>
        /// </summary>
        public string Chain
        {
            get { return this._chain; }
            set { this._chain = value; }
        }

        // Check to see if Chain property is set
        internal bool IsSetChain()
        {
            return this._chain != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key; the contents of the certificate's domain.kex file.
        /// </para>
        /// </summary>
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

    }
}
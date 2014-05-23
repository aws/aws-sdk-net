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


        /// <summary>
        /// Sets the Certificate property
        /// </summary>
        /// <param name="certificate">The value to set for the Certificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SslConfiguration WithCertificate(string certificate)
        {
            this._certificate = certificate;
            return this;
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


        /// <summary>
        /// Sets the Chain property
        /// </summary>
        /// <param name="chain">The value to set for the Chain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SslConfiguration WithChain(string chain)
        {
            this._chain = chain;
            return this;
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


        /// <summary>
        /// Sets the PrivateKey property
        /// </summary>
        /// <param name="privateKey">The value to set for the PrivateKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SslConfiguration WithPrivateKey(string privateKey)
        {
            this._privateKey = privateKey;
            return this;
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

    }
}
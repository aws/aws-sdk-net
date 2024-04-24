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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This structure can be used in the <a>ListCertificates</a> action to filter the output
    /// of the certificate list.
    /// </summary>
    public partial class Filters
    {
        private List<string> _extendedKeyUsage = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _keyTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _keyUsage = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Specify one or more <a>ExtendedKeyUsage</a> extension values.
        /// </para>
        /// </summary>
        public List<string> ExtendedKeyUsage
        {
            get { return this._extendedKeyUsage; }
            set { this._extendedKeyUsage = value; }
        }

        // Check to see if ExtendedKeyUsage property is set
        internal bool IsSetExtendedKeyUsage()
        {
            return this._extendedKeyUsage != null && (this._extendedKeyUsage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyTypes. 
        /// <para>
        /// Specify one or more algorithms that can be used to generate key pairs.
        /// </para>
        ///  
        /// <para>
        /// Default filtering returns only <c>RSA_1024</c> and <c>RSA_2048</c> certificates that
        /// have at least one domain. To return other certificate types, provide the desired type
        /// signatures in a comma-separated list. For example, <c>"keyTypes": ["RSA_2048","RSA_4096"]</c>
        /// returns both <c>RSA_2048</c> and <c>RSA_4096</c> certificates.
        /// </para>
        /// </summary>
        public List<string> KeyTypes
        {
            get { return this._keyTypes; }
            set { this._keyTypes = value; }
        }

        // Check to see if KeyTypes property is set
        internal bool IsSetKeyTypes()
        {
            return this._keyTypes != null && (this._keyTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Specify one or more <a>KeyUsage</a> extension values.
        /// </para>
        /// </summary>
        public List<string> KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null && (this._keyUsage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
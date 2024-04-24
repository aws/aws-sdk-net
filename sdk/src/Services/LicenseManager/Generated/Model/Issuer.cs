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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details about the issuer of a license.
    /// </summary>
    public partial class Issuer
    {
        private string _name;
        private string _signKey;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Issuer name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SignKey. 
        /// <para>
        /// Asymmetric KMS key from Key Management Service. The KMS key must have a key usage
        /// of sign and verify, and support the RSASSA-PSS SHA-256 signing algorithm.
        /// </para>
        /// </summary>
        public string SignKey
        {
            get { return this._signKey; }
            set { this._signKey = value; }
        }

        // Check to see if SignKey property is set
        internal bool IsSetSignKey()
        {
            return this._signKey != null;
        }

    }
}
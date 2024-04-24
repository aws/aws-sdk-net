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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Certificate extensions for v4 template schema
    /// </summary>
    public partial class ExtensionsV4
    {
        private ApplicationPolicies _applicationPolicies;
        private KeyUsage _keyUsage;

        /// <summary>
        /// Gets and sets the property ApplicationPolicies. 
        /// <para>
        /// Application policies specify what the certificate is used for and its purpose.
        /// </para>
        /// </summary>
        public ApplicationPolicies ApplicationPolicies
        {
            get { return this._applicationPolicies; }
            set { this._applicationPolicies = value; }
        }

        // Check to see if ApplicationPolicies property is set
        internal bool IsSetApplicationPolicies()
        {
            return this._applicationPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The key usage extension defines the purpose (e.g., encipherment, signature) of the
        /// key contained in the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyUsage KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

    }
}
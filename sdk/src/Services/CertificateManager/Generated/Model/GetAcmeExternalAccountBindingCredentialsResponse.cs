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
    /// This is the response object from the GetAcmeExternalAccountBindingCredentials operation.
    /// </summary>
    public partial class GetAcmeExternalAccountBindingCredentialsResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private string _macKey;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The key identifier for the external account binding credentials.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property MacKey. 
        /// <para>
        /// The MAC key for the external account binding credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string MacKey
        {
            get { return this._macKey; }
            set { this._macKey = value; }
        }

        // Check to see if MacKey property is set
        internal bool IsSetMacKey()
        {
            return this._macKey != null;
        }

    }
}
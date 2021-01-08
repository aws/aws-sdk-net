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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about an extended key usage X.509 v3 extension object.
    /// </summary>
    public partial class AwsCertificateManagerCertificateExtendedKeyUsage
    {
        private string _name;
        private string _oId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an extension value. Indicates the purpose for which the certificate public
        /// key can be used.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OId. 
        /// <para>
        /// An object identifier (OID) for the extension value.
        /// </para>
        ///  
        /// <para>
        /// The format is numbers separated by periods.
        /// </para>
        /// </summary>
        public string OId
        {
            get { return this._oId; }
            set { this._oId = value; }
        }

        // Check to see if OId property is set
        internal bool IsSetOId()
        {
            return this._oId != null;
        }

    }
}
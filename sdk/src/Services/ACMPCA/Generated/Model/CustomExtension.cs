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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Specifies the X.509 extension information for a certificate.
    /// 
    ///  
    /// <para>
    /// Extensions present in <code>CustomExtensions</code> follow the <code>ApiPassthrough</code>
    /// <a href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations">template
    /// rules</a>. 
    /// </para>
    /// </summary>
    public partial class CustomExtension
    {
        private bool? _critical;
        private string _objectIdentifier;
        private string _value;

        /// <summary>
        /// Gets and sets the property Critical.  
        /// <para>
        /// Specifies the critical flag of the X.509 extension.
        /// </para>
        /// </summary>
        public bool Critical
        {
            get { return this._critical.GetValueOrDefault(); }
            set { this._critical = value; }
        }

        // Check to see if Critical property is set
        internal bool IsSetCritical()
        {
            return this._critical.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectIdentifier.  
        /// <para>
        /// Specifies the object identifier (OID) of the X.509 extension. For more information,
        /// see the <a href="https://oidref.com/2.5.29">Global OID reference database.</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string ObjectIdentifier
        {
            get { return this._objectIdentifier; }
            set { this._objectIdentifier = value; }
        }

        // Check to see if ObjectIdentifier property is set
        internal bool IsSetObjectIdentifier()
        {
            return this._objectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Value.  
        /// <para>
        /// Specifies the base64-encoded value of the X.509 extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Specifies the X.509 extension information for a certificate.
    /// 
    ///  
    /// <para>
    /// Extensions present in <c>CustomExtensions</c> follow the <c>ApiPassthrough</c> <a
    /// href="https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations">template
    /// rules</a>. 
    /// </para>
    /// </summary>
    public partial class CustomExtension
    {
        /// <summary>
        /// Gets and sets the property Critical.  
        /// <para>
        /// Specifies the critical flag of the X.509 extension.
        /// </para>
        /// </summary>
        public bool? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectIdentifier.  
        /// <para>
        /// Specifies the object identifier (OID) of the X.509 extension. For more information,
        /// see the <a href="https://oidref.com/2.5.29">Global OID reference database.</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ObjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ObjectIdentifier property is set.
        /// </summary>
        internal bool IsSetObjectIdentifier() => this.ObjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property Value.  
        /// <para>
        /// Specifies the base64-encoded value of the X.509 extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

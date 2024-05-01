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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Specifies additional purposes for which the certified public key may be used other
    /// than basic purposes indicated in the <c>KeyUsage</c> extension.
    /// </summary>
    public partial class ExtendedKeyUsage
    {
        private string _extendedKeyUsageObjectIdentifier;
        private ExtendedKeyUsageType _extendedKeyUsageType;

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsageObjectIdentifier. 
        /// <para>
        /// Specifies a custom <c>ExtendedKeyUsage</c> with an object identifier (OID).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ExtendedKeyUsageObjectIdentifier
        {
            get { return this._extendedKeyUsageObjectIdentifier; }
            set { this._extendedKeyUsageObjectIdentifier = value; }
        }

        // Check to see if ExtendedKeyUsageObjectIdentifier property is set
        internal bool IsSetExtendedKeyUsageObjectIdentifier()
        {
            return this._extendedKeyUsageObjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsageType. 
        /// <para>
        /// Specifies a standard <c>ExtendedKeyUsage</c> as defined as in <a href="https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.12">RFC
        /// 5280</a>.
        /// </para>
        /// </summary>
        public ExtendedKeyUsageType ExtendedKeyUsageType
        {
            get { return this._extendedKeyUsageType; }
            set { this._extendedKeyUsageType = value; }
        }

        // Check to see if ExtendedKeyUsageType property is set
        internal bool IsSetExtendedKeyUsageType()
        {
            return this._extendedKeyUsageType != null;
        }

    }
}
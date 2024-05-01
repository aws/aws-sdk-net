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
    /// The key usage property defines the purpose of the private key contained in the certificate.
    /// You can specify specific purposes using property flags or all by using property type
    /// ALL.
    /// </summary>
    public partial class KeyUsageProperty
    {
        private KeyUsagePropertyFlags _propertyFlags;
        private KeyUsagePropertyType _propertyType;

        /// <summary>
        /// Gets and sets the property PropertyFlags. 
        /// <para>
        /// You can specify key usage for encryption, key agreement, and signature. You can use
        /// property flags or property type but not both. 
        /// </para>
        /// </summary>
        public KeyUsagePropertyFlags PropertyFlags
        {
            get { return this._propertyFlags; }
            set { this._propertyFlags = value; }
        }

        // Check to see if PropertyFlags property is set
        internal bool IsSetPropertyFlags()
        {
            return this._propertyFlags != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyType. 
        /// <para>
        /// You can specify all key usages using property type ALL. You can use property type
        /// or property flags but not both. 
        /// </para>
        /// </summary>
        public KeyUsagePropertyType PropertyType
        {
            get { return this._propertyType; }
            set { this._propertyType = value; }
        }

        // Check to see if PropertyType property is set
        internal bool IsSetPropertyType()
        {
            return this._propertyType != null;
        }

    }
}
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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Parameter information for key material import using asymmetric RSA wrap and unwrap
    /// key exchange method.
    /// </summary>
    public partial class ImportKeyCryptogram
    {
        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable from the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Exportable { get; set; }

        /// <summary>
        /// Checks to see if the Exportable property is set.
        /// </summary>
        internal bool IsSetExportable() => this.Exportable.HasValue;

        /// <summary>
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token that initiates key import using the asymmetric RSA wrap and unwrap
        /// key exchange method into AWS Payment Cryptography. It expires after 30 days. You can
        /// use the same import token to import multiple keys to the same service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImportToken { get; set; }

        /// <summary>
        /// Checks to see if the ImportToken property is set.
        /// </summary>
        internal bool IsSetImportToken() => this.ImportToken != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes.
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyCryptogram. 
        /// <para>
        /// The RSA wrapped key cryptogram under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 4096)]
        public string WrappedKeyCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyCryptogram property is set.
        /// </summary>
        internal bool IsSetWrappedKeyCryptogram() => this.WrappedKeyCryptogram != null;

        /// <summary>
        /// Gets and sets the property WrappingSpec. 
        /// <para>
        /// The wrapping spec for the wrapped key cryptogram.
        /// </para>
        /// </summary>
        public WrappingKeySpec WrappingSpec { get; set; }

        /// <summary>
        /// Checks to see if the WrappingSpec property is set.
        /// </summary>
        internal bool IsSetWrappingSpec() => this.WrappingSpec != null;
    }
}

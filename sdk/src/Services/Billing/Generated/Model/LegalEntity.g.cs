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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// A legal entity on a private pricing contract. It can be found on your contract's signature
    /// page.
    /// </summary>
    public partial class LegalEntity
    {
        /// <summary>
        /// Gets and sets the property LegalEntityName. 
        /// <para>
        /// The name of the legal entity as it appears on the contract document. This value can
        /// be up to 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// Checks to see if the LegalEntityName property is set.
        /// </summary>
        internal bool IsSetLegalEntityName() => this.LegalEntityName != null;
    }
}

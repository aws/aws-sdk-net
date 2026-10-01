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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The metadata for your tax document.
    /// </summary>
    public partial class TaxDocumentMetadata
    {
        /// <summary>
        /// Gets and sets the property TaxDocumentAccessToken. 
        /// <para>
        /// The tax document access token, which contains information that the Tax Settings API
        /// uses to locate the tax document.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you update your tax registration, the existing <c>taxDocumentAccessToken</c> won't
        /// be valid. To get the latest token, call the <c>GetTaxRegistration</c> or <c>ListTaxRegistrations</c>
        /// API operation. This token is valid for 24 hours.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaxDocumentAccessToken { get; set; }

        /// <summary>
        /// Checks to see if the TaxDocumentAccessToken property is set.
        /// </summary>
        internal bool IsSetTaxDocumentAccessToken() => this.TaxDocumentAccessToken != null;

        /// <summary>
        /// Gets and sets the property TaxDocumentName. 
        /// <para>
        /// The name of your tax document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaxDocumentName { get; set; }

        /// <summary>
        /// Checks to see if the TaxDocumentName property is set.
        /// </summary>
        internal bool IsSetTaxDocumentName() => this.TaxDocumentName != null;
    }
}

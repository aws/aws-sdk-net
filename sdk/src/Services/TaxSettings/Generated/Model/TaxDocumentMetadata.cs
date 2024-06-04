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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
        private string _taxDocumentAccessToken;
        private string _taxDocumentName;

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
        [AWSProperty(Required=true)]
        public string TaxDocumentAccessToken
        {
            get { return this._taxDocumentAccessToken; }
            set { this._taxDocumentAccessToken = value; }
        }

        // Check to see if TaxDocumentAccessToken property is set
        internal bool IsSetTaxDocumentAccessToken()
        {
            return this._taxDocumentAccessToken != null;
        }

        /// <summary>
        /// Gets and sets the property TaxDocumentName. 
        /// <para>
        /// The name of your tax document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaxDocumentName
        {
            get { return this._taxDocumentName; }
            set { this._taxDocumentName = value; }
        }

        // Check to see if TaxDocumentName property is set
        internal bool IsSetTaxDocumentName()
        {
            return this._taxDocumentName != null;
        }

    }
}
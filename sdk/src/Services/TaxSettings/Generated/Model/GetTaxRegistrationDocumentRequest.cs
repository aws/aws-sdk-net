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
    /// Container for the parameters to the GetTaxRegistrationDocument operation.
    /// Downloads your tax documents to the Amazon S3 bucket that you specify in your request.
    /// </summary>
    public partial class GetTaxRegistrationDocumentRequest : AmazonTaxSettingsRequest
    {
        private DestinationS3Location _destinations3Location;
        private TaxDocumentMetadata _taxDocumentMetadata;

        /// <summary>
        /// Gets and sets the property DestinationS3Location. 
        /// <para>
        /// The Amazon S3 bucket that you specify to download your tax documents to.
        /// </para>
        /// </summary>
        public DestinationS3Location DestinationS3Location
        {
            get { return this._destinations3Location; }
            set { this._destinations3Location = value; }
        }

        // Check to see if DestinationS3Location property is set
        internal bool IsSetDestinationS3Location()
        {
            return this._destinations3Location != null;
        }

        /// <summary>
        /// Gets and sets the property TaxDocumentMetadata. 
        /// <para>
        /// The metadata for your tax document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaxDocumentMetadata TaxDocumentMetadata
        {
            get { return this._taxDocumentMetadata; }
            set { this._taxDocumentMetadata = value; }
        }

        // Check to see if TaxDocumentMetadata property is set
        internal bool IsSetTaxDocumentMetadata()
        {
            return this._taxDocumentMetadata != null;
        }

    }
}
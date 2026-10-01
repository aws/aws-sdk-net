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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Specifies the supported document types and attachment types for invoice delivery to
    /// a procurement portal.
    /// </summary>
    public partial class InvoiceConfiguration
    {
        private List<string> _attachmentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _documentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentTypes. 
        /// <para>
        /// The attachment types supported by the procurement portal for e-invoice delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttachmentTypes
        {
            get { return this._attachmentTypes; }
            set { this._attachmentTypes = value; }
        }

        // Check to see if AttachmentTypes property is set
        internal bool IsSetAttachmentTypes()
        {
            return this._attachmentTypes != null && (this._attachmentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentTypes. 
        /// <para>
        /// The e-invoice document types supported by the procurement portal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> DocumentTypes
        {
            get { return this._documentTypes; }
            set { this._documentTypes = value; }
        }

        // Check to see if DocumentTypes property is set
        internal bool IsSetDocumentTypes()
        {
            return this._documentTypes != null && (this._documentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
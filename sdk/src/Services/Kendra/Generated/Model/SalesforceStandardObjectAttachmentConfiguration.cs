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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for processing attachments to Salesforce standard
    /// objects.
    /// </summary>
    public partial class SalesforceStandardObjectAttachmentConfiguration
    {
        private string _documentTitleFieldName;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the field used for the document title.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleFieldName
        {
            get { return this._documentTitleFieldName; }
            set { this._documentTitleFieldName = value; }
        }

        // Check to see if DocumentTitleFieldName property is set
        internal bool IsSetDocumentTitleFieldName()
        {
            return this._documentTitleFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// One or more objects that map fields in attachments to Amazon Kendra index fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && (this._fieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
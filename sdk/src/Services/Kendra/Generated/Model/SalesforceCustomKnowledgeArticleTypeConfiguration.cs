/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides configuration information for indexing Salesforce custom articles.
    /// </summary>
    public partial class SalesforceCustomKnowledgeArticleTypeConfiguration
    {
        private string _documentDataFieldName;
        private string _documentTitleFieldName;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private string _name;

        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the field in the custom knowledge article that contains the document data
        /// to index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DocumentDataFieldName
        {
            get { return this._documentDataFieldName; }
            set { this._documentDataFieldName = value; }
        }

        // Check to see if DocumentDataFieldName property is set
        internal bool IsSetDocumentDataFieldName()
        {
            return this._documentDataFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the field in the custom knowledge article that contains the document title.
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
        /// One or more objects that map fields in the custom knowledge article to fields in the
        /// Amazon Kendra index.
        /// </para>
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
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
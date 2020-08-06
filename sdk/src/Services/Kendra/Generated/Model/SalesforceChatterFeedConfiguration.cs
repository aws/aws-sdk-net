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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Defines configuration for syncing a Salesforce chatter feed. The contents of the object
    /// comes from the Salesforce FeedItem table.
    /// </summary>
    public partial class SalesforceChatterFeedConfiguration
    {
        private string _documentDataFieldName;
        private string _documentTitleFieldName;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _includeFilterTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the column in the Salesforce FeedItem table that contains the content
        /// to index. Typically this is the <code>Body</code> column.
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
        /// The name of the column in the Salesforce FeedItem table that contains the title of
        /// the document. This is typically the <code>Title</code> collumn.
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
        /// Maps fields from a Salesforce chatter feed into Amazon Kendra index fields.
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
        /// Gets and sets the property IncludeFilterTypes. 
        /// <para>
        /// Filters the documents in the feed based on status of the user. When you specify <code>ACTIVE_USERS</code>
        /// only documents from users who have an active account are indexed. When you specify
        /// <code>STANDARD_USER</code> only documents for Salesforce standard users are documented.
        /// You can specify both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> IncludeFilterTypes
        {
            get { return this._includeFilterTypes; }
            set { this._includeFilterTypes = value; }
        }

        // Check to see if IncludeFilterTypes property is set
        internal bool IsSetIncludeFilterTypes()
        {
            return this._includeFilterTypes != null && this._includeFilterTypes.Count > 0; 
        }

    }
}
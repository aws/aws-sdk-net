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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// The configuration information for syncing a Salesforce chatter feed. The contents
    /// of the object comes from the Salesforce FeedItem table.
    /// </summary>
    public partial class SalesforceChatterFeedConfiguration
    {
        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the column in the Salesforce FeedItem table that contains the content
        /// to index. Typically this is the <c>Body</c> column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DocumentDataFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDataFieldName property is set.
        /// </summary>
        internal bool IsSetDocumentDataFieldName() => this.DocumentDataFieldName != null;

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the column in the Salesforce FeedItem table that contains the title of
        /// the document. This is typically the <c>Title</c> column.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DocumentTitleFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitleFieldName property is set.
        /// </summary>
        internal bool IsSetDocumentTitleFieldName() => this.DocumentTitleFieldName != null;

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Maps fields from a Salesforce chatter feed into Amazon Kendra index fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the FieldMappings property is set.
        /// </summary>
        internal bool IsSetFieldMappings() => this.FieldMappings != null && (this.FieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeFilterTypes. 
        /// <para>
        /// Filters the documents in the feed based on status of the user. When you specify <c>ACTIVE_USERS</c>
        /// only documents from users who have an active account are indexed. When you specify
        /// <c>STANDARD_USER</c> only documents for Salesforce standard users are documented.
        /// You can specify both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> IncludeFilterTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeFilterTypes property is set.
        /// </summary>
        internal bool IsSetIncludeFilterTypes() => this.IncludeFilterTypes != null && (this.IncludeFilterTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

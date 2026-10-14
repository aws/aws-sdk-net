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
    /// Provides information about how Amazon Kendra should use the columns of a database
    /// in an index.
    /// </summary>
    public partial class ColumnConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChangeDetectingColumns. 
        /// <para>
        /// One to five columns that indicate when a document in the database has changed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> ChangeDetectingColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChangeDetectingColumns property is set.
        /// </summary>
        internal bool IsSetChangeDetectingColumns() => this.ChangeDetectingColumns != null && (this.ChangeDetectingColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentDataColumnName. 
        /// <para>
        /// The column that contains the contents of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DocumentDataColumnName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDataColumnName property is set.
        /// </summary>
        internal bool IsSetDocumentDataColumnName() => this.DocumentDataColumnName != null;

        /// <summary>
        /// Gets and sets the property DocumentIdColumnName. 
        /// <para>
        /// The column that provides the document's identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DocumentIdColumnName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentIdColumnName property is set.
        /// </summary>
        internal bool IsSetDocumentIdColumnName() => this.DocumentIdColumnName != null;

        /// <summary>
        /// Gets and sets the property DocumentTitleColumnName. 
        /// <para>
        /// The column that contains the title of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DocumentTitleColumnName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitleColumnName property is set.
        /// </summary>
        internal bool IsSetDocumentTitleColumnName() => this.DocumentTitleColumnName != null;

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// An array of objects that map database column names to the corresponding fields in
        /// an index. You must first create the fields in the index using the <c>UpdateIndex</c>
        /// API.
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
    }
}

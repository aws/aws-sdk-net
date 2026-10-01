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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIndex operation. Updates an existing OpenSearch
    /// index schema and semantic enrichment configuration. This operation allows modification
    /// of field mappings and semantic search settings for text fields. Changes to semantic
    /// enrichment configuration will apply to newly ingested documents.
    /// </summary>
    public partial class UpdateIndexRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexSchema. 
        /// <para>
        /// The updated JSON schema for the index including any changes to mappings, settings,
        /// and semantic enrichment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document IndexSchema { get; set; }

        /// <summary>
        /// Checks to see if the IndexSchema property is set.
        /// </summary>
        internal bool IsSetIndexSchema() => !this.IndexSchema.IsNull();
    }
}

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
    /// Provides the count of documents that match a particular document attribute or field
    /// when doing a faceted search.
    /// </summary>
    public partial class DocumentAttributeValueCountPair
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of documents in the response that have the attribute/field value for the
        /// key.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentAttributeValue. 
        /// <para>
        /// The value of the attribute/field. For example, "HR".
        /// </para>
        /// </summary>
        public DocumentAttributeValue DocumentAttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the DocumentAttributeValue property is set.
        /// </summary>
        internal bool IsSetDocumentAttributeValue() => this.DocumentAttributeValue != null;

        /// <summary>
        /// Gets and sets the property FacetResults. 
        /// <para>
        /// Contains the results of a document attribute/field that is a nested facet. A <c>FacetResult</c>
        /// contains the counts for each facet nested within a facet.
        /// </para>
        ///  
        /// <para>
        /// For example, the document attribute or facet "Department" includes a value called
        /// "Engineering". In addition, the document attribute or facet "SubDepartment" includes
        /// the values "Frontend" and "Backend" for documents assigned to "Engineering". You can
        /// display nested facets in the search results so that documents can be searched not
        /// only by department but also by a sub department within a department. The counts for
        /// documents that belong to "Frontend" and "Backend" within "Engineering" are returned
        /// for a query.
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FacetResult> FacetResults { get; set; } = AWSConfigs.InitializeCollections ? new List<FacetResult>() : null;

        /// <summary>
        /// Checks to see if the FacetResults property is set.
        /// </summary>
        internal bool IsSetFacetResults() => this.FacetResults != null && (this.FacetResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

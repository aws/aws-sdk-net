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
    /// Information about a document attribute or field. You can use document attributes as
    /// facets.
    /// 
    ///  
    /// <para>
    /// For example, the document attribute or facet "Department" includes the values "HR",
    /// "Engineering", and "Accounting". You can display these values in the search results
    /// so that documents can be searched by department.
    /// </para>
    ///  
    /// <para>
    /// You can display up to 10 facet values per facet for a query. If you want to increase
    /// this limit, contact <a href="http://aws.amazon.com/contact-us/">Support</a>.
    /// </para>
    /// </summary>
    public partial class Facet
    {
        private string _documentAttributeKey;
        private List<Facet> _facets = AWSConfigs.InitializeCollections ? new List<Facet>() : null;
        private int? _maxResults;

        /// <summary>
        /// Gets and sets the property DocumentAttributeKey. 
        /// <para>
        /// The unique key for the document attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DocumentAttributeKey
        {
            get { return this._documentAttributeKey; }
            set { this._documentAttributeKey = value; }
        }

        // Check to see if DocumentAttributeKey property is set
        internal bool IsSetDocumentAttributeKey()
        {
            return this._documentAttributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property Facets. 
        /// <para>
        /// An array of document attributes that are nested facets within a facet.
        /// </para>
        ///  
        /// <para>
        /// For example, the document attribute or facet "Department" includes a value called
        /// "Engineering". In addition, the document attribute or facet "SubDepartment" includes
        /// the values "Frontend" and "Backend" for documents assigned to "Engineering". You can
        /// display nested facets in the search results so that documents can be searched not
        /// only by department but also by a sub department within a department. This helps your
        /// users further narrow their search.
        /// </para>
        ///  
        /// <para>
        /// You can only have one nested facet within a facet. If you want to increase this limit,
        /// contact <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Facet> Facets
        {
            get { return this._facets; }
            set { this._facets = value; }
        }

        // Check to see if Facets property is set
        internal bool IsSetFacets()
        {
            return this._facets != null && (this._facets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of facet values per facet. The default is 10. You can use this to limit
        /// the number of facet values to less than 10. If you want to increase the default, contact
        /// <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

    }
}
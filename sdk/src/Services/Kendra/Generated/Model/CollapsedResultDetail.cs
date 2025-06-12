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
    /// Provides details about a collapsed group of search results.
    /// </summary>
    public partial class CollapsedResultDetail
    {
        private DocumentAttribute _documentAttribute;
        private List<ExpandedResultItem> _expandedResults = AWSConfigs.InitializeCollections ? new List<ExpandedResultItem>() : null;

        /// <summary>
        /// Gets and sets the property DocumentAttribute. 
        /// <para>
        /// The value of the document attribute that results are collapsed on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentAttribute DocumentAttribute
        {
            get { return this._documentAttribute; }
            set { this._documentAttribute = value; }
        }

        // Check to see if DocumentAttribute property is set
        internal bool IsSetDocumentAttribute()
        {
            return this._documentAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property ExpandedResults. 
        /// <para>
        /// A list of results in the collapsed group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpandedResultItem> ExpandedResults
        {
            get { return this._expandedResults; }
            set { this._expandedResults = value; }
        }

        // Check to see if ExpandedResults property is set
        internal bool IsSetExpandedResults()
        {
            return this._expandedResults != null && (this._expandedResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
    /// Specifies the properties, such as relevance tuning and searchability, of an index
    /// field.
    /// </summary>
    public partial class DocumentMetadataConfiguration
    {
        private string _name;
        private Relevance _relevance;
        private Search _search;
        private DocumentAttributeValueType _type;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
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

        /// <summary>
        /// Gets and sets the property Relevance. 
        /// <para>
        /// Provides tuning parameters to determine how the field affects the search results.
        /// </para>
        /// </summary>
        public Relevance Relevance
        {
            get { return this._relevance; }
            set { this._relevance = value; }
        }

        // Check to see if Relevance property is set
        internal bool IsSetRelevance()
        {
            return this._relevance != null;
        }

        /// <summary>
        /// Gets and sets the property Search. 
        /// <para>
        /// Provides information about how the field is used during a search.
        /// </para>
        /// </summary>
        public Search Search
        {
            get { return this._search; }
            set { this._search = value; }
        }

        // Check to see if Search property is set
        internal bool IsSetSearch()
        {
            return this._search != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the index field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentAttributeValueType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
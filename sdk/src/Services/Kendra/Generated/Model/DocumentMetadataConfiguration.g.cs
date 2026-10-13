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
    /// Specifies the properties, such as relevance tuning and searchability, of an index
    /// field.
    /// </summary>
    public partial class DocumentMetadataConfiguration
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Relevance. 
        /// <para>
        /// Provides tuning parameters to determine how the field affects the search results.
        /// </para>
        /// </summary>
        public Relevance Relevance { get; set; }

        /// <summary>
        /// Checks to see if the Relevance property is set.
        /// </summary>
        internal bool IsSetRelevance() => this.Relevance != null;

        /// <summary>
        /// Gets and sets the property Search. 
        /// <para>
        /// Provides information about how the field is used during a search.
        /// </para>
        /// </summary>
        public Search Search { get; set; }

        /// <summary>
        /// Checks to see if the Search property is set.
        /// </summary>
        internal bool IsSetSearch() => this.Search != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the index field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentAttributeValueType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

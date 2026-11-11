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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Options for literal field. Present if <c>IndexFieldType</c> specifies the field is
    /// of type <c>literal</c>. All options are enabled by default.
    /// </summary>
    public partial class LiteralOptions
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. A value to use for the field if the field
        /// isn't specified for a document.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property FacetEnabled. 
        /// <para>
        /// Whether facet information can be returned for the field.
        /// </para>
        /// </summary>
        public bool? FacetEnabled { get; set; }

        /// <summary>
        /// Checks to see if the FacetEnabled property is set.
        /// </summary>
        internal bool IsSetFacetEnabled() => this.FacetEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ReturnEnabled. 
        /// <para>
        /// Whether the contents of the field can be returned in the search results.
        /// </para>
        /// </summary>
        public bool? ReturnEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ReturnEnabled property is set.
        /// </summary>
        internal bool IsSetReturnEnabled() => this.ReturnEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SearchEnabled. 
        /// <para>
        /// Whether the contents of the field are searchable.
        /// </para>
        /// </summary>
        public bool? SearchEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SearchEnabled property is set.
        /// </summary>
        internal bool IsSetSearchEnabled() => this.SearchEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SortEnabled. 
        /// <para>
        /// Whether the field can be used to sort the search results.
        /// </para>
        /// </summary>
        public bool? SortEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SortEnabled property is set.
        /// </summary>
        internal bool IsSetSortEnabled() => this.SortEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SourceField.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceField { get; set; }

        /// <summary>
        /// Checks to see if the SourceField property is set.
        /// </summary>
        internal bool IsSetSourceField() => this.SourceField != null;
    }
}

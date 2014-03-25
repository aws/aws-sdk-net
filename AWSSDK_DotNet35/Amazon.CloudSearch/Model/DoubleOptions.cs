/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Options for a double-precision 64-bit floating point field. Present if <c>IndexFieldType</c> specifies the field is of type
    /// <c>double</c> . All options are enabled by default.</para>
    /// </summary>
    public partial class DoubleOptions
    {
        
        private double? defaultValue;
        private string sourceField;
        private bool? facetEnabled;
        private bool? searchEnabled;
        private bool? returnEnabled;
        private bool? sortEnabled;


        /// <summary>
        /// A value to use for the field if the field isn't specified for a document. This can be important if you are using the field in an expression
        /// and that field is not present in every document.
        ///  
        /// </summary>
        public double DefaultValue
        {
            get { return this.defaultValue ?? default(double); }
            set { this.defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue.HasValue;
        }

        /// <summary>
        /// The name of the source field to map to the field.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9_]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceField
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        // Check to see if SourceField property is set
        internal bool IsSetSourceField()
        {
            return this.sourceField != null;
        }

        /// <summary>
        /// Whether facet information can be returned for the field.
        ///  
        /// </summary>
        public bool FacetEnabled
        {
            get { return this.facetEnabled ?? default(bool); }
            set { this.facetEnabled = value; }
        }

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this.facetEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field are searchable.
        ///  
        /// </summary>
        public bool SearchEnabled
        {
            get { return this.searchEnabled ?? default(bool); }
            set { this.searchEnabled = value; }
        }

        // Check to see if SearchEnabled property is set
        internal bool IsSetSearchEnabled()
        {
            return this.searchEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field can be returned in the search results.
        ///  
        /// </summary>
        public bool ReturnEnabled
        {
            get { return this.returnEnabled ?? default(bool); }
            set { this.returnEnabled = value; }
        }

        // Check to see if ReturnEnabled property is set
        internal bool IsSetReturnEnabled()
        {
            return this.returnEnabled.HasValue;
        }

        /// <summary>
        /// Whether the field can be used to sort the search results.
        ///  
        /// </summary>
        public bool SortEnabled
        {
            get { return this.sortEnabled ?? default(bool); }
            set { this.sortEnabled = value; }
        }

        // Check to see if SortEnabled property is set
        internal bool IsSetSortEnabled()
        {
            return this.sortEnabled.HasValue;
        }
    }
}

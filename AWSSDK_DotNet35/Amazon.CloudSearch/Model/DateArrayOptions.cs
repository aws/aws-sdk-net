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
    /// <para>Options for a field that contains an array of dates. Present if <c>IndexFieldType</c> specifies the field is of type
    /// <c>date-array</c> . All options are enabled by default.</para>
    /// </summary>
    public partial class DateArrayOptions
    {
        
        private string defaultValue;
        private string sourceFields;
        private bool? facetEnabled;
        private bool? searchEnabled;
        private bool? returnEnabled;


        /// <summary>
        /// A value to use for the field if the field isn't specified for a document.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this.defaultValue; }
            set { this.defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;
        }

        /// <summary>
        /// A list of source fields to map to the field.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\s*[a-z][a-z0-9_]*\s*(,\s*[a-z][a-z0-9_]*\s*)*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceFields
        {
            get { return this.sourceFields; }
            set { this.sourceFields = value; }
        }

        // Check to see if SourceFields property is set
        internal bool IsSetSourceFields()
        {
            return this.sourceFields != null;
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
    }
}

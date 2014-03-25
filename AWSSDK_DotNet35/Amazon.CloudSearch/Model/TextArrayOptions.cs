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
    /// <para>Options for a field that contains an array of text strings. Present if <c>IndexFieldType</c> specifies the field is of type
    /// <c>text-array</c> . A <c>text-array</c> field is always searchable. All options are enabled by default.</para>
    /// </summary>
    public partial class TextArrayOptions
    {
        
        private string defaultValue;
        private string sourceFields;
        private bool? returnEnabled;
        private bool? highlightEnabled;
        private string analysisScheme;


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
        /// Whether highlights can be returned for the field.
        ///  
        /// </summary>
        public bool HighlightEnabled
        {
            get { return this.highlightEnabled ?? default(bool); }
            set { this.highlightEnabled = value; }
        }

        // Check to see if HighlightEnabled property is set
        internal bool IsSetHighlightEnabled()
        {
            return this.highlightEnabled.HasValue;
        }

        /// <summary>
        /// The name of an analysis scheme for a <c>text-array</c> field.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\S]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AnalysisScheme
        {
            get { return this.analysisScheme; }
            set { this.analysisScheme = value; }
        }

        // Check to see if AnalysisScheme property is set
        internal bool IsSetAnalysisScheme()
        {
            return this.analysisScheme != null;
        }
    }
}

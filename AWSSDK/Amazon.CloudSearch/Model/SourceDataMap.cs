/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Specifies how to map source attribute values to custom values when populating an <c>IndexField</c> .</para>
    /// </summary>
    public class SourceDataMap  
    {
        
        private string sourceName;
        private string defaultValue;
        private Dictionary<string,string> cases = new Dictionary<string,string>();

        /// <summary>
        /// The name of the document source field to add to this <c>IndexField</c>.
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
        public string SourceName
        {
            get { return this.sourceName; }
            set { this.sourceName = value; }
        }

        /// <summary>
        /// Sets the SourceName property
        /// </summary>
        /// <param name="sourceName">The value to set for the SourceName property </param>
        /// <returns>this instance</returns>
        public SourceDataMap WithSourceName(string sourceName)
        {
            this.sourceName = sourceName;
            return this;
        }
            

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this.sourceName != null;       
        }

        /// <summary>
        /// The value of a field or source document attribute.
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

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        public SourceDataMap WithDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue != null;       
        }

        /// <summary>
        /// A map that translates source field values to custom values.
        ///  
        /// </summary>
        public Dictionary<string,string> Cases
        {
            get { return this.cases; }
            set { this.cases = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Cases dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Cases dictionary.</param>
        /// <returns>this instance</returns>
        public SourceDataMap WithCases(params KeyValuePair<string, string>[] pairs)
        {
            foreach (KeyValuePair<string, string> pair in pairs)
            {
                this.Cases[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this.cases != null;       
        }
    }
}

/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>The value of the <c>DefaultSearchField</c> configured for this search domain and its current status.</para>
    /// </summary>
    public class DefaultSearchFieldStatus  
    {
        
        private string options;
        private OptionStatus status;

        /// <summary>
        /// The name of the <c>IndexField</c> to use as the default search field. The default is an empty string, which automatically searches all text
        /// fields.
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
        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        /// <summary>
        /// Sets the Options property
        /// </summary>
        /// <param name="options">The value to set for the Options property </param>
        /// <returns>this instance</returns>
        public DefaultSearchFieldStatus WithOptions(string options)
        {
            this.options = options;
            return this;
        }
            

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;       
        }

        /// <summary>
        /// The status of an option, including when it was last updated and whether it is actively in use for searches.
        ///  
        /// </summary>
        public OptionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public DefaultSearchFieldStatus WithStatus(OptionStatus status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }
    }
}

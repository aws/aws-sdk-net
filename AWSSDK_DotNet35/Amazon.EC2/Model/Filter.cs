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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> A filter used to limit results when describing tags. Multiple values can be specified per filter. A tag must match at least one of
    /// the specified values for it to be returned from an operation. </para> <para> Wildcards can be included in filter values; <c>*</c> specifies
    /// that zero or more characters must match, and <c>?</c> specifies that exactly one character must match. Use a backslash to escape special
    /// characters. For example, a filter value of <c>\*amazon\?\\</c> specifies the literal string <c>*amazon?\</c> .
    /// </para>
    /// </summary>
    public class Filter
    {
        
        private string name;
        private List<string> values = new List<string>();


        /// <summary>
        /// Specifies the name of the filter.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Contains one or more values for the filter.
        ///  
        /// </summary>
        public List<string> Values
        {
            get { return this.values; }
            set { this.values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this.values.Count > 0;
        }
    }
}

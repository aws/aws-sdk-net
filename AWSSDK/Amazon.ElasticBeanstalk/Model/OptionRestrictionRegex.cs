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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> A regular expression representing a restriction on a string configuration option value. </para>
    /// </summary>
    public class OptionRestrictionRegex  
    {
        
        private string pattern;
        private string label;

        /// <summary>
        /// The regular expression pattern that a string configuration option value with this restriction must match.
        ///  
        /// </summary>
        public string Pattern
        {
            get { return this.pattern; }
            set { this.pattern = value; }
        }

        /// <summary>
        /// Sets the Pattern property
        /// </summary>
        /// <param name="pattern">The value to set for the Pattern property </param>
        /// <returns>this instance</returns>
        public OptionRestrictionRegex WithPattern(string pattern)
        {
            this.pattern = pattern;
            return this;
        }
            

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this.pattern != null;       
        }

        /// <summary>
        /// A unique name representing this regular expression.
        ///  
        /// </summary>
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        /// <summary>
        /// Sets the Label property
        /// </summary>
        /// <param name="label">The value to set for the Label property </param>
        /// <returns>this instance</returns>
        public OptionRestrictionRegex WithLabel(string label)
        {
            this.label = label;
            return this;
        }
            

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this.label != null;       
        }
    }
}

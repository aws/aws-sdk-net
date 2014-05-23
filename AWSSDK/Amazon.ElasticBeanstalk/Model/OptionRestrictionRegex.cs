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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A regular expression representing a restriction on a string configuration
    ///         option value.
    /// </summary>
    public partial class OptionRestrictionRegex
    {
        private string _label;
        private string _pattern;


        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///          A unique name representing this regular expression.        
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }


        /// <summary>
        /// Sets the Label property
        /// </summary>
        /// <param name="label">The value to set for the Label property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionRestrictionRegex WithLabel(string label)
        {
            this._label = label;
            return this;
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }


        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        ///          The regular expression pattern that a string configuration option value with
        ///         this restriction must match.        
        /// </para>
        /// </summary>
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }


        /// <summary>
        /// Sets the Pattern property
        /// </summary>
        /// <param name="pattern">The value to set for the Pattern property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OptionRestrictionRegex WithPattern(string pattern)
        {
            this._pattern = pattern;
            return this;
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}
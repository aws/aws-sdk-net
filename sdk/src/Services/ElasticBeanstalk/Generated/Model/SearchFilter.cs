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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes criteria to restrict a list of results.
    /// 
    ///  
    /// <para>
    /// For operators that apply a single value to the attribute, the filter is evaluated
    /// as follows: <code>Attribute Operator Values[1]</code> 
    /// </para>
    ///  
    /// <para>
    /// Some operators, e.g. <code>in</code>, can apply multiple values. In this case, the
    /// filter is evaluated as a logical union (OR) of applications of the operator to the
    /// attribute with each one of the values: <code>(Attribute Operator Values[1]) OR (Attribute
    /// Operator Values[2]) OR ...</code> 
    /// </para>
    ///  
    /// <para>
    /// The valid values for attributes of <code>SearchFilter</code> depend on the API action.
    /// For valid values, see the reference page for the API action you're calling that takes
    /// a <code>SearchFilter</code> parameter.
    /// </para>
    /// </summary>
    public partial class SearchFilter
    {
        private string _attribute;
        private string _operator;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The result attribute to which the filter values are applied. Valid values vary by
        /// API action.
        /// </para>
        /// </summary>
        public string Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to apply to the <code>Attribute</code> with each of the <code>Values</code>.
        /// Valid values vary by <code>Attribute</code>.
        /// </para>
        /// </summary>
        public string Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The list of values applied to the <code>Attribute</code> and <code>Operator</code>
        /// attributes. Number of values and valid values vary by <code>Attribute</code>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
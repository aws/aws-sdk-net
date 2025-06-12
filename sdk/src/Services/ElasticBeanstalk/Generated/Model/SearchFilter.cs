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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes criteria to restrict a list of results.
    /// 
    ///  
    /// <para>
    /// For operators that apply a single value to the attribute, the filter is evaluated
    /// as follows: <c>Attribute Operator Values[1]</c> 
    /// </para>
    ///  
    /// <para>
    /// Some operators, e.g. <c>in</c>, can apply multiple values. In this case, the filter
    /// is evaluated as a logical union (OR) of applications of the operator to the attribute
    /// with each one of the values: <c>(Attribute Operator Values[1]) OR (Attribute Operator
    /// Values[2]) OR ...</c> 
    /// </para>
    ///  
    /// <para>
    /// The valid values for attributes of <c>SearchFilter</c> depend on the API action. For
    /// valid values, see the reference page for the API action you're calling that takes
    /// a <c>SearchFilter</c> parameter.
    /// </para>
    /// </summary>
    public partial class SearchFilter
    {
        private string _attribute;
        private string _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The operator to apply to the <c>Attribute</c> with each of the <c>Values</c>. Valid
        /// values vary by <c>Attribute</c>.
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
        /// The list of values applied to the <c>Attribute</c> and <c>Operator</c> attributes.
        /// Number of values and valid values vary by <c>Attribute</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
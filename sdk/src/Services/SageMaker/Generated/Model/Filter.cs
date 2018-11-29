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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A conditional statement for a search expression that includes a Boolean operator,
    /// a resource property, and a value.
    /// 
    ///  
    /// <para>
    /// If you don't specify an <code>Operator</code> and a <code>Value</code>, the filter
    /// searches for only the specified property. For example, defining a <code>Filter</code>
    /// for the <code>FailureReason</code> for the <code>TrainingJob</code> <code>Resource</code>
    /// searches for training job objects that have a value in the <code>FailureReason</code>
    /// field.
    /// </para>
    ///  
    /// <para>
    /// If you specify a <code>Value</code>, but not an <code>Operator</code>, Amazon SageMaker
    /// uses the equals operator as a default.
    /// </para>
    ///  
    /// <para>
    /// In search, there are several property types:
    /// </para>
    ///  <dl> <dt>Metrics</dt> <dd> 
    /// <para>
    /// To define a metric filter, enter a value using the form <code>"Metrics.&lt;name&gt;"</code>,
    /// where <code>&lt;name&gt;</code> is a metric name. For example, the following filter
    /// searches for training jobs with an <code>"accuracy"</code> metric greater than <code>"0.9"</code>:
    /// </para>
    ///  
    /// <para>
    ///  <code>{</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Name": "Metrics.accuracy",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Operator": "GREATER_THAN",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"Value": "0.9"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>}</code> 
    /// </para>
    ///  </dd> <dt>HyperParameters</dt> <dd> 
    /// <para>
    /// To define a hyperparameter filter, enter a value with the form <code>"HyperParamters.&lt;name&gt;"</code>.
    /// Decimal hyperparameter values are treated as a decimal in a comparison if the specified
    /// <code>Value</code> is also a decimal value. If the specified <code>Value</code> is
    /// an integer, the decimal hyperparameter values are treated as integers. For example,
    /// the following filter is satisfied by training jobs with a <code>"learning_rate"</code>
    /// hyperparameter that is less than <code>"0.5"</code>:
    /// </para>
    ///  
    /// <para>
    ///  <code> {</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Name": "HyperParameters.learning_rate",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Operator": "LESS_THAN",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Value": "0.5"</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> }</code> 
    /// </para>
    ///  </dd> <dt>Tags</dt> <dd> 
    /// <para>
    /// To define a tag filter, enter a value with the form <code>"Tags.&lt;key&gt;"</code>.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private Operator _operator;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A property name. For example, <code>TrainingJobName</code>. See <a>TrainingJob</a>
        /// properties for the list of valid property names for each supported resource.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// A Boolean binary operator that is used to evaluate the filter. The operator field
        /// contains one of the following values:
        /// </para>
        ///  <dl> <dt>Equals</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> equals the specified <code>Value</code>.
        /// </para>
        ///  </dd> <dt>NotEquals</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> does not equal the specified <code>Value</code>.
        /// </para>
        ///  </dd> <dt>GreaterThan</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> is greater than the specified <code>Value</code>.
        /// Not supported for text-based properties.
        /// </para>
        ///  </dd> <dt>GreaterThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> is greater than or equal to the specified
        /// <code>Value</code>. Not supported for text-based properties.
        /// </para>
        ///  </dd> <dt>LessThan</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> is less than the specified <code>Value</code>.
        /// Not supported for text-based properties.
        /// </para>
        ///  </dd> <dt>LessThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The specified resource in <code>Name</code> is less than or equal to the specified
        /// <code>Value</code>. Not supported for text-based properties.
        /// </para>
        ///  </dd> <dt>Contains</dt> <dd> 
        /// <para>
        /// Only supported for text-based properties. The word-list of the property contains the
        /// specified <code>Value</code>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public Operator Operator
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
        /// Gets and sets the property Value. 
        /// <para>
        /// A value used with <code>Resource</code> and <code>Operator</code> to determin if objects
        /// statisfy the filter's condition. For numerical properties, <code>Value</code> must
        /// be an integer or floating-point decimal. For timestamp properties, <code>Value</code>
        /// must be an ISO 8601 date-time string of the following format: <code>YYYY-mm-dd'T'HH:MM:SS</code>.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
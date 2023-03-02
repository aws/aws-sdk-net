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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A conditional statement for a search expression that includes a resource property,
    /// a Boolean operator, and a value. Resources that match the statement are returned in
    /// the results from the <a>Search</a> API.
    /// 
    ///  
    /// <para>
    /// If you specify a <code>Value</code>, but not an <code>Operator</code>, SageMaker uses
    /// the equals operator.
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
    ///  <code>"Operator": "GreaterThan",</code> 
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
    /// To define a hyperparameter filter, enter a value with the form <code>"HyperParameters.&lt;name&gt;"</code>.
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
    ///  <code> "Operator": "LessThan",</code> 
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
    /// To define a tag filter, enter a value with the form <code>Tags.&lt;key&gt;</code>.
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
        /// A resource property name. For example, <code>TrainingJobName</code>. For valid property
        /// names, see <a>SearchRecord</a>. You must specify a valid property for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The value of <code>Name</code> equals <code>Value</code>.
        /// </para>
        ///  </dd> <dt>NotEquals</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> doesn't equal <code>Value</code>.
        /// </para>
        ///  </dd> <dt>Exists</dt> <dd> 
        /// <para>
        /// The <code>Name</code> property exists.
        /// </para>
        ///  </dd> <dt>NotExists</dt> <dd> 
        /// <para>
        /// The <code>Name</code> property does not exist.
        /// </para>
        ///  </dd> <dt>GreaterThan</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> is greater than <code>Value</code>. Not supported for
        /// text properties.
        /// </para>
        ///  </dd> <dt>GreaterThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> is greater than or equal to <code>Value</code>. Not
        /// supported for text properties.
        /// </para>
        ///  </dd> <dt>LessThan</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> is less than <code>Value</code>. Not supported for
        /// text properties.
        /// </para>
        ///  </dd> <dt>LessThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> is less than or equal to <code>Value</code>. Not supported
        /// for text properties.
        /// </para>
        ///  </dd> <dt>In</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> is one of the comma delimited strings in <code>Value</code>.
        /// Only supported for text properties.
        /// </para>
        ///  </dd> <dt>Contains</dt> <dd> 
        /// <para>
        /// The value of <code>Name</code> contains the string <code>Value</code>. Only supported
        /// for text properties.
        /// </para>
        ///  
        /// <para>
        /// A <code>SearchExpression</code> can include the <code>Contains</code> operator multiple
        /// times when the value of <code>Name</code> is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Experiment.DisplayName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Experiment.ExperimentName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Experiment.Tags</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Trial.DisplayName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Trial.TrialName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Trial.Tags</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialComponent.DisplayName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialComponent.TrialComponentName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialComponent.Tags</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialComponent.InputArtifacts</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrialComponent.OutputArtifacts</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <code>SearchExpression</code> can include only one <code>Contains</code> operator
        /// for all other values of <code>Name</code>. In these cases, if you include multiple
        /// <code>Contains</code> operators in the <code>SearchExpression</code>, the result is
        /// the following error message: "<code>'CONTAINS' operator usage limit of 1 exceeded.</code>"
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
        /// A value used with <code>Name</code> and <code>Operator</code> to determine which resources
        /// satisfy the filter's condition. For numerical properties, <code>Value</code> must
        /// be an integer or floating-point decimal. For timestamp properties, <code>Value</code>
        /// must be an ISO 8601 date-time string of the following format: <code>YYYY-mm-dd'T'HH:MM:SS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
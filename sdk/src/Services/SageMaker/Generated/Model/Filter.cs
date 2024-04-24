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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A conditional statement for a search expression that includes a resource property,
    /// a Boolean operator, and a value. Resources that match the statement are returned in
    /// the results from the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API.
    /// 
    ///  
    /// <para>
    /// If you specify a <c>Value</c>, but not an <c>Operator</c>, SageMaker uses the equals
    /// operator.
    /// </para>
    ///  
    /// <para>
    /// In search, there are several property types:
    /// </para>
    ///  <dl> <dt>Metrics</dt> <dd> 
    /// <para>
    /// To define a metric filter, enter a value using the form <c>"Metrics.&lt;name&gt;"</c>,
    /// where <c>&lt;name&gt;</c> is a metric name. For example, the following filter searches
    /// for training jobs with an <c>"accuracy"</c> metric greater than <c>"0.9"</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c>{</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"Name": "Metrics.accuracy",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"Operator": "GreaterThan",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"Value": "0.9"</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>}</c> 
    /// </para>
    ///  </dd> <dt>HyperParameters</dt> <dd> 
    /// <para>
    /// To define a hyperparameter filter, enter a value with the form <c>"HyperParameters.&lt;name&gt;"</c>.
    /// Decimal hyperparameter values are treated as a decimal in a comparison if the specified
    /// <c>Value</c> is also a decimal value. If the specified <c>Value</c> is an integer,
    /// the decimal hyperparameter values are treated as integers. For example, the following
    /// filter is satisfied by training jobs with a <c>"learning_rate"</c> hyperparameter
    /// that is less than <c>"0.5"</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c> {</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c> "Name": "HyperParameters.learning_rate",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c> "Operator": "LessThan",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c> "Value": "0.5"</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c> }</c> 
    /// </para>
    ///  </dd> <dt>Tags</dt> <dd> 
    /// <para>
    /// To define a tag filter, enter a value with the form <c>Tags.&lt;key&gt;</c>.
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
        /// A resource property name. For example, <c>TrainingJobName</c>. For valid property
        /// names, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchRecord.html">SearchRecord</a>.
        /// You must specify a valid property for the resource.
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
        /// The value of <c>Name</c> equals <c>Value</c>.
        /// </para>
        ///  </dd> <dt>NotEquals</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> doesn't equal <c>Value</c>.
        /// </para>
        ///  </dd> <dt>Exists</dt> <dd> 
        /// <para>
        /// The <c>Name</c> property exists.
        /// </para>
        ///  </dd> <dt>NotExists</dt> <dd> 
        /// <para>
        /// The <c>Name</c> property does not exist.
        /// </para>
        ///  </dd> <dt>GreaterThan</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> is greater than <c>Value</c>. Not supported for text properties.
        /// </para>
        ///  </dd> <dt>GreaterThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> is greater than or equal to <c>Value</c>. Not supported for
        /// text properties.
        /// </para>
        ///  </dd> <dt>LessThan</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> is less than <c>Value</c>. Not supported for text properties.
        /// </para>
        ///  </dd> <dt>LessThanOrEqualTo</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> is less than or equal to <c>Value</c>. Not supported for
        /// text properties.
        /// </para>
        ///  </dd> <dt>In</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> is one of the comma delimited strings in <c>Value</c>. Only
        /// supported for text properties.
        /// </para>
        ///  </dd> <dt>Contains</dt> <dd> 
        /// <para>
        /// The value of <c>Name</c> contains the string <c>Value</c>. Only supported for text
        /// properties.
        /// </para>
        ///  
        /// <para>
        /// A <c>SearchExpression</c> can include the <c>Contains</c> operator multiple times
        /// when the value of <c>Name</c> is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Experiment.DisplayName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Experiment.ExperimentName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Experiment.Tags</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Trial.DisplayName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Trial.TrialName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Trial.Tags</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialComponent.DisplayName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialComponent.TrialComponentName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialComponent.Tags</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialComponent.InputArtifacts</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialComponent.OutputArtifacts</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <c>SearchExpression</c> can include only one <c>Contains</c> operator for all other
        /// values of <c>Name</c>. In these cases, if you include multiple <c>Contains</c> operators
        /// in the <c>SearchExpression</c>, the result is the following error message: "<c>'CONTAINS'
        /// operator usage limit of 1 exceeded.</c>"
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
        /// A value used with <c>Name</c> and <c>Operator</c> to determine which resources satisfy
        /// the filter's condition. For numerical properties, <c>Value</c> must be an integer
        /// or floating-point decimal. For timestamp properties, <c>Value</c> must be an ISO 8601
        /// date-time string of the following format: <c>YYYY-mm-dd'T'HH:MM:SS</c>.
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
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The value of a hyperparameter. Only one of <c>NumberValue</c> or <c>StringValue</c>
    /// can be specified.
    /// 
    ///  
    /// <para>
    /// This object is specified in the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrialComponent.html">CreateTrialComponent</a>
    /// request.
    /// </para>
    /// </summary>
    public partial class TrialComponentParameterValue
    {
        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// The numeric value of a numeric hyperparameter. If you specify a value for this parameter,
        /// you can't specify the <c>StringValue</c> parameter.
        /// </para>
        /// </summary>
        public double? NumberValue { get; set; }

        /// <summary>
        /// Checks to see if the NumberValue property is set.
        /// </summary>
        internal bool IsSetNumberValue() => this.NumberValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The string value of a categorical hyperparameter. If you specify a value for this
        /// parameter, you can't specify the <c>NumberValue</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}

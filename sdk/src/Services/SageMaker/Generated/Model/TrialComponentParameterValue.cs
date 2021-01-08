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
    /// The value of a hyperparameter. Only one of <code>NumberValue</code> or <code>StringValue</code>
    /// can be specified.
    /// 
    ///  
    /// <para>
    /// This object is specified in the <a>CreateTrialComponent</a> request.
    /// </para>
    /// </summary>
    public partial class TrialComponentParameterValue
    {
        private double? _numberValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// The numeric value of a numeric hyperparameter. If you specify a value for this parameter,
        /// you can't specify the <code>StringValue</code> parameter.
        /// </para>
        /// </summary>
        public double NumberValue
        {
            get { return this._numberValue.GetValueOrDefault(); }
            set { this._numberValue = value; }
        }

        // Check to see if NumberValue property is set
        internal bool IsSetNumberValue()
        {
            return this._numberValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The string value of a categorical hyperparameter. If you specify a value for this
        /// parameter, you can't specify the <code>NumberValue</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}
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
    /// Contains input values for a task.
    /// </summary>
    public partial class RenderableTask
    {
        private string _input;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// A JSON object that contains values for the variables defined in the template. It is
        /// made available to the template under the substitution variable <c>task.input</c>.
        /// For example, if you define a variable <c>task.input.text</c> in your template, you
        /// can supply the variable in the JSON object as <c>"text": "sample text"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=128000)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}
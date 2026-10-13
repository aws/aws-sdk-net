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
    /// The name and an example value of the hyperparameter that you want to use in Autotune.
    /// If Automatic model tuning (AMT) determines that your hyperparameter is eligible for
    /// Autotune, an optimal hyperparameter range is selected for you.
    /// </summary>
    public partial class AutoParameter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hyperparameter to optimize using Autotune.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ValueHint. 
        /// <para>
        /// An example value of the hyperparameter to optimize using Autotune.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ValueHint { get; set; }

        /// <summary>
        /// Checks to see if the ValueHint property is set.
        /// </summary>
        internal bool IsSetValueHint() => this.ValueHint != null;
    }
}

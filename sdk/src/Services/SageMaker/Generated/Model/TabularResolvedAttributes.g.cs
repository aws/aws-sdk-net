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
    /// The resolved attributes specific to the tabular problem type.
    /// </summary>
    public partial class TabularResolvedAttributes
    {
        /// <summary>
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// The type of supervised learning problem available for the model candidates of the
        /// AutoML job V2 (Binary Classification, Multiclass Classification, Regression). For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-datasets-problem-types.html#autopilot-problem-types">
        /// SageMaker Autopilot problem types</a>.
        /// </para>
        /// </summary>
        public ProblemType ProblemType { get; set; }

        /// <summary>
        /// Checks to see if the ProblemType property is set.
        /// </summary>
        internal bool IsSetProblemType() => this.ProblemType != null;
    }
}

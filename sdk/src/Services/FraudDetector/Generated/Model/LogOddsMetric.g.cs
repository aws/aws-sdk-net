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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The log odds metric details.
    /// </summary>
    public partial class LogOddsMetric
    {
        /// <summary>
        /// Gets and sets the property VariableImportance. 
        /// <para>
        /// The relative importance of the variable. For more information, see <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/model-variable-importance.html">Model
        /// variable importance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? VariableImportance { get; set; }

        /// <summary>
        /// Checks to see if the VariableImportance property is set.
        /// </summary>
        internal bool IsSetVariableImportance() => this.VariableImportance.HasValue;

        /// <summary>
        /// Gets and sets the property VariableName. 
        /// <para>
        /// The name of the variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VariableName { get; set; }

        /// <summary>
        /// Checks to see if the VariableName property is set.
        /// </summary>
        internal bool IsSetVariableName() => this.VariableName != null;

        /// <summary>
        /// Gets and sets the property VariableType. 
        /// <para>
        /// The type of variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VariableType { get; set; }

        /// <summary>
        /// Checks to see if the VariableType property is set.
        /// </summary>
        internal bool IsSetVariableType() => this.VariableType != null;
    }
}

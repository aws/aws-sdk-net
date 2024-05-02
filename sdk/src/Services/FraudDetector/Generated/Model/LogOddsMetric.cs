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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
        private float? _variableImportance;
        private string _variableName;
        private string _variableType;

        /// <summary>
        /// Gets and sets the property VariableImportance. 
        /// <para>
        /// The relative importance of the variable. For more information, see <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/model-variable-importance.html">Model
        /// variable importance</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? VariableImportance
        {
            get { return this._variableImportance; }
            set { this._variableImportance = value; }
        }

        // Check to see if VariableImportance property is set
        internal bool IsSetVariableImportance()
        {
            return this._variableImportance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VariableName. 
        /// <para>
        /// The name of the variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VariableName
        {
            get { return this._variableName; }
            set { this._variableName = value; }
        }

        // Check to see if VariableName property is set
        internal bool IsSetVariableName()
        {
            return this._variableName != null;
        }

        /// <summary>
        /// Gets and sets the property VariableType. 
        /// <para>
        /// The type of variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VariableType
        {
            get { return this._variableType; }
            set { this._variableType = value; }
        }

        // Check to see if VariableType property is set
        internal bool IsSetVariableType()
        {
            return this._variableType != null;
        }

    }
}
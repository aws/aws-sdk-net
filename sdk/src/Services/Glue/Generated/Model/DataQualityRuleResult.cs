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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the result of the evaluation of a data quality rule.
    /// </summary>
    public partial class DataQualityRuleResult
    {
        private string _description;
        private string _evaluationMessage;
        private string _name;
        private DataQualityRuleResultStatus _result;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMessage. 
        /// <para>
        /// An evaluation message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string EvaluationMessage
        {
            get { return this._evaluationMessage; }
            set { this._evaluationMessage = value; }
        }

        // Check to see if EvaluationMessage property is set
        internal bool IsSetEvaluationMessage()
        {
            return this._evaluationMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Result. 
        /// <para>
        /// A pass or fail status for the rule.
        /// </para>
        /// </summary>
        public DataQualityRuleResultStatus Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}
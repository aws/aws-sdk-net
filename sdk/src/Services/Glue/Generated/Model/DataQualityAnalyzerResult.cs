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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the result of the evaluation of a data quality analyzer.
    /// </summary>
    public partial class DataQualityAnalyzerResult
    {
        private string _description;
        private Dictionary<string, double> _evaluatedMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private string _evaluationMessage;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data quality analyzer.
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
        /// Gets and sets the property EvaluatedMetrics. 
        /// <para>
        /// A map of metrics associated with the evaluation of the analyzer.
        /// </para>
        /// </summary>
        public Dictionary<string, double> EvaluatedMetrics
        {
            get { return this._evaluatedMetrics; }
            set { this._evaluatedMetrics = value; }
        }

        // Check to see if EvaluatedMetrics property is set
        internal bool IsSetEvaluatedMetrics()
        {
            return this._evaluatedMetrics != null && (this._evaluatedMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The name of the data quality analyzer.
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

    }
}
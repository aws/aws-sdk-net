/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a metric that the training algorithm writes to <code>stderr</code> or <code>stdout</code>.
    /// Amazon SageMakerHyperparamter tuning captures all defined metrics. You specify one
    /// metric that a hyperparameter tuning job uses as its objective metric to choose the
    /// best training job.
    /// </summary>
    public partial class MetricDefinition
    {
        private string _name;
        private string _regex;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Regex. 
        /// <para>
        /// A regular expression that searches the output of a training job and gets the value
        /// of the metric. For more information about using regular expressions to define metrics,
        /// see <a>hpo-define-metrics</a>.
        /// </para>
        /// </summary>
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

    }
}
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
    /// Specifies your data quality evaluation criteria.
    /// </summary>
    public partial class EvaluateDataQuality
    {
        private List<string> _inputs = new List<string>();
        private string _name;
        private DQTransformOutput _output;
        private DQResultsPublishingOptions _publishingOptions;
        private string _ruleset;
        private DQStopJobOnFailureOptions _stopJobOnFailureOptions;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The inputs of your data quality evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Output. 
        /// <para>
        /// The output of your data quality evaluation.
        /// </para>
        /// </summary>
        public DQTransformOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property PublishingOptions. 
        /// <para>
        /// Options to configure how your results are published.
        /// </para>
        /// </summary>
        public DQResultsPublishingOptions PublishingOptions
        {
            get { return this._publishingOptions; }
            set { this._publishingOptions = value; }
        }

        // Check to see if PublishingOptions property is set
        internal bool IsSetPublishingOptions()
        {
            return this._publishingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// The ruleset for your data quality evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string Ruleset
        {
            get { return this._ruleset; }
            set { this._ruleset = value; }
        }

        // Check to see if Ruleset property is set
        internal bool IsSetRuleset()
        {
            return this._ruleset != null;
        }

        /// <summary>
        /// Gets and sets the property StopJobOnFailureOptions. 
        /// <para>
        /// Options to configure how your job will stop if your data quality evaluation fails.
        /// </para>
        /// </summary>
        public DQStopJobOnFailureOptions StopJobOnFailureOptions
        {
            get { return this._stopJobOnFailureOptions; }
            set { this._stopJobOnFailureOptions = value; }
        }

        // Check to see if StopJobOnFailureOptions property is set
        internal bool IsSetStopJobOnFailureOptions()
        {
            return this._stopJobOnFailureOptions != null;
        }

    }
}
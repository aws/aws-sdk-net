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
    /// Associates a SageMaker job as a trial component with an experiment and trial. Specified
    /// when you call the following APIs:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateProcessingJob</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateTrainingJob</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateTransformJob</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ExperimentConfig
    {
        private string _experimentName;
        private string _runName;
        private string _trialComponentDisplayName;
        private string _trialName;

        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of an existing experiment to associate with the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string ExperimentName
        {
            get { return this._experimentName; }
            set { this._experimentName = value; }
        }

        // Check to see if ExperimentName property is set
        internal bool IsSetExperimentName()
        {
            return this._experimentName != null;
        }

        /// <summary>
        /// Gets and sets the property RunName. 
        /// <para>
        /// The name of the experiment run to associate with the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string RunName
        {
            get { return this._runName; }
            set { this._runName = value; }
        }

        // Check to see if RunName property is set
        internal bool IsSetRunName()
        {
            return this._runName != null;
        }

        /// <summary>
        /// Gets and sets the property TrialComponentDisplayName. 
        /// <para>
        /// The display name for the trial component. If this key isn't specified, the display
        /// name is the trial component name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string TrialComponentDisplayName
        {
            get { return this._trialComponentDisplayName; }
            set { this._trialComponentDisplayName = value; }
        }

        // Check to see if TrialComponentDisplayName property is set
        internal bool IsSetTrialComponentDisplayName()
        {
            return this._trialComponentDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of an existing trial to associate the trial component with. If not specified,
        /// a new trial is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string TrialName
        {
            get { return this._trialName; }
            set { this._trialName = value; }
        }

        // Check to see if TrialName property is set
        internal bool IsSetTrialName()
        {
            return this._trialName != null;
        }

    }
}
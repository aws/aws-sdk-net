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
    /// Associates a SageMaker job as a trial component with an experiment and trial. Specified
    /// when you call the following APIs:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateProcessingJob.html">CreateProcessingJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTransformJob.html">CreateTransformJob</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ExperimentConfig
    {
        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of an existing experiment to associate with the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string ExperimentName { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentName property is set.
        /// </summary>
        internal bool IsSetExperimentName() => this.ExperimentName != null;

        /// <summary>
        /// Gets and sets the property RunName. 
        /// <para>
        /// The name of the experiment run to associate with the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string RunName { get; set; }

        /// <summary>
        /// Checks to see if the RunName property is set.
        /// </summary>
        internal bool IsSetRunName() => this.RunName != null;

        /// <summary>
        /// Gets and sets the property TrialComponentDisplayName. 
        /// <para>
        /// The display name for the trial component. If this key isn't specified, the display
        /// name is the trial component name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string TrialComponentDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentDisplayName property is set.
        /// </summary>
        internal bool IsSetTrialComponentDisplayName() => this.TrialComponentDisplayName != null;

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of an existing trial to associate the trial component with. If not specified,
        /// a new trial is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string TrialName { get; set; }

        /// <summary>
        /// Checks to see if the TrialName property is set.
        /// </summary>
        internal bool IsSetTrialName() => this.TrialName != null;
    }
}

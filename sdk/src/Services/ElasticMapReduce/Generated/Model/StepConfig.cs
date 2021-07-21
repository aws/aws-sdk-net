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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Specification for a cluster (job flow) step.
    /// </summary>
    public partial class StepConfig
    {
        private ActionOnFailure _actionOnFailure;
        private HadoopJarStepConfig _hadoopJarStep;
        private string _name;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StepConfig() { }

        /// <summary>
        /// Instantiates StepConfig with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the step.</param>
        /// <param name="hadoopJarStep">The JAR file used for the step.</param>
        public StepConfig(string name, HadoopJarStepConfig hadoopJarStep)
        {
            _name = name;
            _hadoopJarStep = hadoopJarStep;
        }

        /// <summary>
        /// Gets and sets the property ActionOnFailure. 
        /// <para>
        /// The action to take when the step fails. Use one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TERMINATE_CLUSTER</code> - Shuts down the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCEL_AND_WAIT</code> - Cancels any pending steps and returns the cluster
        /// to the <code>WAITING</code> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONTINUE</code> - Continues to the next step in the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TERMINATE_JOB_FLOW</code> - Shuts down the cluster. <code>TERMINATE_JOB_FLOW</code>
        /// is provided for backward compatibility. We recommend using <code>TERMINATE_CLUSTER</code>
        /// instead.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a cluster's <code>StepConcurrencyLevel</code> is greater than <code>1</code>, do
        /// not use <code>AddJobFlowSteps</code> to submit a step with this parameter set to <code>CANCEL_AND_WAIT</code>
        /// or <code>TERMINATE_CLUSTER</code>. The step is not submitted and the action fails
        /// with a message that the <code>ActionOnFailure</code> setting is not valid.
        /// </para>
        ///  
        /// <para>
        /// If you change a cluster's <code>StepConcurrencyLevel</code> to be greater than 1 while
        /// a step is running, the <code>ActionOnFailure</code> parameter may not behave as you
        /// expect. In this case, for a step that fails with this parameter set to <code>CANCEL_AND_WAIT</code>,
        /// pending steps and the running step are not canceled; for a step that fails with this
        /// parameter set to <code>TERMINATE_CLUSTER</code>, the cluster does not terminate.
        /// </para>
        /// </summary>
        public ActionOnFailure ActionOnFailure
        {
            get { return this._actionOnFailure; }
            set { this._actionOnFailure = value; }
        }

        // Check to see if ActionOnFailure property is set
        internal bool IsSetActionOnFailure()
        {
            return this._actionOnFailure != null;
        }

        /// <summary>
        /// Gets and sets the property HadoopJarStep. 
        /// <para>
        /// The JAR file used for the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HadoopJarStepConfig HadoopJarStep
        {
            get { return this._hadoopJarStep; }
            set { this._hadoopJarStep = value; }
        }

        // Check to see if HadoopJarStep property is set
        internal bool IsSetHadoopJarStep()
        {
            return this._hadoopJarStep != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
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
    /// This represents a step in a cluster.
    /// </summary>
    public partial class Step
    {
        private ActionOnFailure _actionOnFailure;
        private HadoopStepConfig _config;
        private string _executionRoleArn;
        private string _id;
        private string _name;
        private StepStatus _status;

        /// <summary>
        /// Gets and sets the property ActionOnFailure. 
        /// <para>
        /// The action to take when the cluster step fails. Possible values are <code>TERMINATE_CLUSTER</code>,
        /// <code>CANCEL_AND_WAIT</code>, and <code>CONTINUE</code>. <code>TERMINATE_JOB_FLOW</code>
        /// is provided for backward compatibility. We recommend using <code>TERMINATE_CLUSTER</code>
        /// instead.
        /// </para>
        ///  
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
        /// Gets and sets the property Config. 
        /// <para>
        /// The Hadoop job configuration of the cluster step.
        /// </para>
        /// </summary>
        public HadoopStepConfig Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the runtime role for a step on the cluster. The
        /// runtime role can be a cross-account IAM role. The runtime role ARN is a combination
        /// of account ID, role name, and role type using the following format: <code>arn:partition:service:region:account:resource</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, <code>arn:aws:IAM::1234567890:role/ReadOnly</code> is a correctly formatted
        /// runtime role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the cluster step.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster step.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status details of the cluster step.
        /// </para>
        /// </summary>
        public StepStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
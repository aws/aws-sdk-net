/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>This represents a step in a cluster.</para>
    /// </summary>
    public class Step
    {
        
        private string id;
        private string name;
        private HadoopStepConfig config;
        private ActionOnFailure actionOnFailure;
        private StepStatus status;


        /// <summary>
        /// The identifier of the cluster step.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name of the cluster step.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The Hadoop job configuration of the cluster step.
        ///  
        /// </summary>
        public HadoopStepConfig Config
        {
            get { return this.config; }
            set { this.config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this.config != null;
        }

        /// <summary>
        /// This specifies what action to take when the cluster step fails. TERMINATE_JOB_FLOW is deprecated, use TERMINATE_CLUSTER instead.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TERMINATE_JOB_FLOW, TERMINATE_CLUSTER, CANCEL_AND_WAIT, CONTINUE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ActionOnFailure ActionOnFailure
        {
            get { return this.actionOnFailure; }
            set { this.actionOnFailure = value; }
        }

        // Check to see if ActionOnFailure property is set
        internal bool IsSetActionOnFailure()
        {
            return this.actionOnFailure != null;
        }

        /// <summary>
        /// The current execution status details of the cluster step.
        ///  
        /// </summary>
        public StepStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}

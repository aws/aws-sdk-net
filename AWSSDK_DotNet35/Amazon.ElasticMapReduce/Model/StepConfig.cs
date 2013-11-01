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
    /// <para>Specification of a job flow step.</para>
    /// </summary>
    public class StepConfig
    {
        
        private string name;
        private ActionOnFailure actionOnFailure;
        private HadoopJarStepConfig hadoopJarStep;


        /// <summary>
        /// The name of the job flow step.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// The action to take if the job flow step fails.
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
        /// The JAR file used for the job flow step.
        ///  
        /// </summary>
        public HadoopJarStepConfig HadoopJarStep
        {
            get { return this.hadoopJarStep; }
            set { this.hadoopJarStep = value; }
        }

        // Check to see if HadoopJarStep property is set
        internal bool IsSetHadoopJarStep()
        {
            return this.hadoopJarStep != null;
        }
    }
}

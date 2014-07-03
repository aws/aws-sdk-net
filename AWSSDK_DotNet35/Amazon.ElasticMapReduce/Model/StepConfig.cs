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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Specification of a job flow step.
    /// </summary>
    public partial class StepConfig
    {
        private ActionOnFailure _actionOnFailure;
        private HadoopJarStepConfig _hadoopJarStep;
        private string _name;


        /// <summary>
        /// Gets and sets the property ActionOnFailure. 
        /// <para>
        /// The action to take if the job flow step fails.
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
        /// The JAR file used for the job flow step.
        /// </para>
        /// </summary>
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
        /// The name of the job flow step.
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

    }
}